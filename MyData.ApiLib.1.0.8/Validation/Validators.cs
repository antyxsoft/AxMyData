using System.Collections;

namespace MyData.ApiLib
{
    /// <summary>
    /// Helper for validating MyData models just before an API call
    /// </summary>
    public static partial class Validators
    {
        static List<Validator> ValidatorList = new List<Validator>();

        static void RegisterValidators()
        {
            List<Type> ValidatorClasses = new List<Type>();
            Lib.FindDerivedClasses(typeof(Validator), typeof(Validators).Assembly, ValidatorClasses);

            Validator Instance;
            Validator Instance2;
            foreach (Type ValidatorClass in ValidatorClasses)
            {
                Instance = Activator.CreateInstance(ValidatorClass) as Validator;
                Instance2 = ValidatorList.FirstOrDefault(item => item.Type == Instance.Type);
                if (Instance2 == null)
                    ValidatorList.Add(Instance);
            }
        }


        /* construction */
        /// <summary>
        /// Static constructor
        /// </summary>
        static Validators()
        {
            RegisterValidators();
        }

        /* validation helpers */
        /// <summary>
        /// Returns true if a specified value represents a MyData currency
        /// </summary>
        static public bool IsValidCurrency(string Value)
        {
            return Enum.GetNames(typeof(CurrencyType)).Contains(Value);
        }

        /* property validation */
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="RequiredAttribute"/>. </para>
        /// </summary>
        static public bool ValidateRequired(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage, string PropDescription)
        {
            ErrorMessage = "";
            RequiredAttribute Attr = GetPropertyAttribute<RequiredAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = $"{PropDescription} - Απαιτείται τιμή για το πεδίο.";
                return false;
            }

            return true;
        }
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="MaxLengthAttribute"/>. </para>
        /// </summary>
        static public bool ValidateMaxLength(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage, string PropDescription)
        {
            ErrorMessage = "";
            if (Prop.PropertyType != typeof(string))
                return true;

            MaxLengthAttribute Attr = GetPropertyAttribute<MaxLengthAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = $"{PropDescription} - {Attr.FormatErrorMessage(Prop.Name)}";
                return false; 
            }

            return true;
        }
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="MinLengthAttribute"/>. </para>
        /// </summary>
        static public bool ValidateMinLength(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage, string PropDescription)
        {
            ErrorMessage = "";
            if (Prop.PropertyType != typeof(string))
                return true;

            MinLengthAttribute Attr = GetPropertyAttribute<MinLengthAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = $"{PropDescription} - {Attr.FormatErrorMessage(Prop.Name)}";
                return false;
            }

            return true;
        }
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="RangeAttribute"/>. </para>
        /// </summary>
        static public bool ValidateRange(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage, string PropDescription)
        {
            ErrorMessage = "";
            if (!Lib.IsNumericType(Prop.PropertyType))
                return true;

            RangeAttribute Attr = GetPropertyAttribute<RangeAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = $"{PropDescription} - {Attr.FormatErrorMessage(Prop.Name)}";
                return false;
            }

            return true;
        }
        /// <summary>
        /// Validates a property of type generic List. Returns true if the List is not null but contains no elements.
        /// </summary>
        static public bool ValidateListCount(PropertyInfo Prop, object List, out string ErrorMessage, string PropDescription)
        {
            ErrorMessage = "";

            if (List != null && Prop.PropertyType.Name == typeof(List<>).Name)
            {
                int V = (List as IList).Count;

                if (V == 0)
                {
                    ErrorMessage = $"{PropDescription} - Η λίστα είναι κενή.";
                    return false;
                }

            }

            return true;
        }

        /// <summary>
        /// Validates a specified model based on <see cref="Attribute"/> decoration of its properties.
        /// <para>It uses the following attributes: <see cref="RequiredAttribute"/>, <see cref="MaxLengthAttribute"/>, <see cref="MinLengthAttribute"/>, <see cref="RangeAttribute"/> and <see cref="DescriptionAttribute"/>.</para>
        /// </summary>
        static public void ValidatePropertiesByAttributes(object Model, List<string> ErrorList)
        {
            CheckModel(Model);

            object PropValue;
            
            string ErrorMessage;
            string PropDescription;
            
            PropertyInfo[] PropList = GetProperties(Model);
            object[] AttrList;

            object ChildModel;
            System.Collections.IEnumerable List;

            string PropertyName;

            // check properties
            foreach (PropertyInfo Prop in PropList)
            {
                PropertyName = Prop.Name;

                AttrList = Prop.GetCustomAttributes(true);
                PropValue = Prop.GetValue(Model);
                PropDescription = GetPropertyDescription(Prop, AttrList);

                if (!ValidateRequired(Prop, PropValue, AttrList, out ErrorMessage, PropDescription))
                    ErrorList.Add(ErrorMessage);

                if (!ValidateMaxLength(Prop, PropValue, AttrList, out ErrorMessage, PropDescription))
                    ErrorList.Add(ErrorMessage);

                if (!ValidateMinLength(Prop, PropValue, AttrList, out ErrorMessage, PropDescription))
                    ErrorList.Add(ErrorMessage);

                if (!ValidateRange(Prop, PropValue, AttrList, out ErrorMessage, PropDescription))
                    ErrorList.Add(ErrorMessage);

                // check for empty List<>
                if (Prop.PropertyType.Name == typeof(List<>).Name && PropValue != null)
                {
                    if (!ValidateListCount(Prop, PropValue, out ErrorMessage, PropDescription))
                        ErrorList.Add(ErrorMessage);
                }

            }

            // check properties that are Models
            foreach (PropertyInfo Prop in PropList)
            {
                PropValue = Prop.GetValue(Model);

                if (PropValue != null)
                {
                    // property is List, Collection or Array
                    if (typeof(System.Collections.IEnumerable).IsAssignableFrom(Prop.PropertyType))
                    {
                        List = PropValue as System.Collections.IEnumerable;
                        if (List != null)
                        {
                            foreach (object Item in List)
                            {
                                if (Item != null && Item.GetType().IsClass)
                                {
                                    ValidateModel(Item, ErrorList);
                                }
                                         
                            }
                        }
                    }
                    // property is a Model too
                    else if (Prop.PropertyType.IsClass)
                    {
                        ChildModel = PropValue;
                        ValidateModel(ChildModel, ErrorList);

                    }
                }
            }
        }
       

        /* model validation */
        /// <summary>
        /// Returns a <see cref="Validator"/> based on a specified Model <see cref="Type"/>
        /// </summary>
        static public Validator GetValidator(Type ModelType)
        {
            Validator Result = ValidatorList.FirstOrDefault(x => x.Type == ModelType);

            if (Result == null)
                throw new ApplicationException($"No Validator is registered for the Model Type: {ModelType.Name}");

            return Result;
        }

        static void CheckModel(object Model)
        {
            if (Model == null)
                throw new ArgumentNullException(nameof(Model));

            if (!Model.GetType().IsClass)
                throw new ArgumentException($"Cannot validate a Model of type: {Model.GetType()}. The specified Model is not an instance of a class.");
        }
        static List<string> ValidateModel(object Model, List<string> ErrorList = null)
        {
            CheckModel(Model);

            if (ErrorList == null)
               ErrorList = new List<string>();
            Validator Validator = GetValidator(Model.GetType());
            Validator.Validate(Model, null, ErrorList);
            return ErrorList;
        }

        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(InvoicesDoc Model)
        {
            return ValidateModel(Model);
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(IncomeClassificationsDoc Model)
        {
            return ValidateModel(Model);
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(ExpensesClassificationsDoc Model)
        {
            return ValidateModel(Model);
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(PaymentMethodsDoc Model)
        {
            return ValidateModel(Model);
        }


        /// <summary>
        /// True when this library is used by a third party Invoicing Provider on behalf of a Company Entity.
        /// </summary>
        static public bool IsInvoicingProvider { get { return Api.IsInvoicingProvider; } }
    }
}
