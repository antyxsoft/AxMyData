namespace MyData.ApiLib
{
    /// <summary>
    /// Helper for validating MyData models just before an API call
    /// </summary>
    static public class ModelValidator
    {

        static Dictionary<Type, PropertyInfo[]> TypePropertiesDic = new Dictionary<Type, PropertyInfo[]>();

        /* public helpers */
        /// <summary>
        /// Returns true if a specified type is a numeric one.
        /// <para>FROM: http://stackoverflow.com/a/5182747/172132</para>
        /// </summary>
        static public bool IsNumericType(Type T)
        {
            if (T == null) 
                return false;

            
            switch (Type.GetTypeCode(T))
            {
                case TypeCode.Byte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.SByte:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                case TypeCode.Object:
                    if (T.IsGenericType && T.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        return IsNumericType(Nullable.GetUnderlyingType(T));
                    }
                    return false;
            }
            return false;
        }
        /// <summary>
        /// Returns the list of <see cref="PropertyInfo"/> properties of a specified instance.
        /// </summary>
        static public PropertyInfo[] GetProperties(object Model)
        {
            Type T = Model.GetType(); 

            if (!TypePropertiesDic.ContainsKey(T))
                TypePropertiesDic[T] = T.GetProperties();

            return TypePropertiesDic[T];
        }
        /// <summary>
        /// Returns a property's <see cref="Attribute"/>, if exists, else null.
        /// </summary>
        static public T GetPropertyAttribute<T>(PropertyInfo Prop, object[] AttributeList) where T : Attribute
        {
            T Result = AttributeList.FirstOrDefault(Attr => Attr is T) as T;
            return Result;
        }
        /// <summary>
        /// Returns a description of a specified property.
        /// <para>The description contains the Name of the property and the value of the <see cref="DescriptionAttribute"/>, if available.</para>
        /// </summary>
        static public string GetPropertyDescription(PropertyInfo Prop, object[] AttributeList)  
        {
            DescriptionAttribute DescriptionAttr = GetPropertyAttribute<DescriptionAttribute>(Prop, AttributeList);
            string PropName = Prop.Name;
            string Description = DescriptionAttr != null? DescriptionAttr.Description: "Μη διαθέσιμη.";

            return $"Ιδιότητα: {PropName} - Περιγραφή: {Description}.";
        }

        /* validation helpers */
        /// <summary>
        /// Returns true if a specified value represents a MyData currency
        /// </summary>
        static public bool IsValidCurrency(string Value)
        {
            return Enum.GetNames(typeof(CurrencyType)).Contains(Value);
        }

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
                ErrorMessage = $"{PropDescription} Απαιτείται τιμή για το πεδίο.";
            }

            return true;
        }
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="MaxLengthAttribute"/>. </para>
        /// </summary>
        static public bool ValidateMaxLength(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage)
        {
            ErrorMessage = "";
            if (Prop.PropertyType != typeof(string))
                return true;

            MaxLengthAttribute Attr = GetPropertyAttribute<MaxLengthAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = Attr.FormatErrorMessage(Prop.Name);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="MinLengthAttribute"/>. </para>
        /// </summary>
        static public bool ValidateMinLength(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage)
        {
            ErrorMessage = "";
            if (Prop.PropertyType != typeof(string))
                return true;

            MinLengthAttribute Attr = GetPropertyAttribute<MinLengthAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = Attr.FormatErrorMessage(Prop.Name);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Property value validator. Returns true if the property value passes the test.
        /// <para>Validates a property when it is decorated with the <see cref="RangeAttribute"/>. </para>
        /// </summary>
        static public bool ValidateRange(PropertyInfo Prop, object PropValue, object[] AttributeList, out string ErrorMessage)
        {
            ErrorMessage = "";
            if (!IsNumericType(Prop.PropertyType))
                return true;

            RangeAttribute Attr = GetPropertyAttribute<RangeAttribute>(Prop, AttributeList);
            if (Attr != null && !Attr.IsValid(PropValue))
            {
                ErrorMessage = Attr.FormatErrorMessage(Prop.Name);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates a specified model based on <see cref="Attribute"/> decoration of its properties.
        /// <para>It uses the following attributes: <see cref="RequiredAttribute"/>, <see cref="MaxLengthAttribute"/>, <see cref="MinLengthAttribute"/>, <see cref="RangeAttribute"/> and <see cref="DescriptionAttribute"/>.</para>
        /// </summary>
        static public void ValidatePropertiesByAttributes(List<string> ErrorList, object Model)
        {
            object Value;
            string ErrorMessage;
            string Description;
            
            PropertyInfo[] PropList = GetProperties(Model);
            object[] AttrList;

            object ChildModel;
            System.Collections.IEnumerable List; 

            foreach (PropertyInfo Prop in PropList)
            {
                AttrList = Prop.GetCustomAttributes(true);
                Value = Prop.GetValue(Model);
                Description = GetPropertyDescription(Prop, AttrList);

                if (!ValidateRequired(Prop, Value, AttrList, out ErrorMessage, Description))
                    ErrorList.Add(ErrorMessage);

                if (!ValidateMaxLength(Prop, Value, AttrList, out ErrorMessage))
                    ErrorList.Add(ErrorMessage);

                if (!ValidateMinLength(Prop, Value, AttrList, out ErrorMessage))
                    ErrorList.Add(ErrorMessage);

                if (!ValidateRange(Prop, Value, AttrList, out ErrorMessage))
                    ErrorList.Add(ErrorMessage);

                if (Value != null)
                {
                    // property is List, Collection or Array
                    if (typeof(System.Collections.IEnumerable).IsAssignableFrom(Prop.PropertyType))
                    {
                        List = Value as System.Collections.IEnumerable;
                        if (List != null)
                        {
                            foreach (object Item in List)
                            {
                                if (Item != null && Item.GetType().IsClass)
                                    ValidateModel(ErrorList, Item);
                            }
                        }
                    }
                    // property is a Model too
                    else if (Prop.PropertyType.IsClass)
                    {
                        ChildModel = Value;
                        ValidateModel(ErrorList, ChildModel);
                    }
                }
            }

 
        }
       
        /// <summary>
        /// Validates the properties of a specified model.
        /// </summary>
        static public void ValidateModel(List<string> ErrorList, object Model)
        {
            if (Model == null)
                throw new ArgumentNullException(nameof(Model));

            if (!Model.GetType().IsClass)
                throw new ArgumentException($"Cannot validate a Model of type: {Model.GetType()}. The specified Model is not an instance of a class.");

            // validate the properties of the passed in model
            ValidatePropertiesByAttributes(ErrorList, Model);
        }


        /* model validation */
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(InvoicesDoc Model)
        {
            List<string> ErrorList = new List<string>();
            InvoicesValidator.Validate(ErrorList, Model);
            return ErrorList;
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(IncomeClassificationsDoc Model)
        {
            List<string> ErrorList = new List<string>();
            IncomeClassificationsValidator.Validate(ErrorList, Model);
            return ErrorList;
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(ExpensesClassificationsDoc Model)
        {
            List<string> ErrorList = new List<string>();
            ExpensesClassificationsValidator.Validate(ErrorList, Model);
            return ErrorList;
        }
        /// <summary>
        /// Validates a MyData model. Returns a list of errors or, when no error, an empty list
        /// </summary>
        static public List<string> Validate(PaymentMethodsDoc Model)
        {
            List<string> ErrorList = new List<string>();
            PaymentMethodsValidator.Validate(ErrorList, Model);
            return ErrorList;
        }




    }
}
