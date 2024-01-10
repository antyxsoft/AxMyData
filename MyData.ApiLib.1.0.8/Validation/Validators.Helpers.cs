 

namespace MyData.ApiLib
{

    /// <summary>
    /// Helper for validating MyData models just before an API call
    /// </summary>
    public static partial class Validators
    {
        static Dictionary<Type, PropertyInfo[]> TypePropertiesDic = new Dictionary<Type, PropertyInfo[]>();
        static Dictionary<Type, Attribute[]> TypeAttributesDic = new Dictionary<Type, Attribute[]>();




        /* Model and Model Type helpers */
        /// <summary>
        /// Returns an <see cref="Attribute"/> list of a Model Type
        /// </summary>
        static public Attribute[] GetTypeAttributes(Type Type)
        {
            if (Type == null)
                return new Attribute[0];

            if (!TypeAttributesDic.ContainsKey(Type))
                TypeAttributesDic[Type] = Type.GetCustomAttributes().ToList().ToArray();

            return TypeAttributesDic[Type];
        }
        /// <summary>
        /// Returns an <see cref="Attribute"/> list of a Model Type
        /// </summary>
        static public Attribute[] GetTypeAttributes(object Model)
        {
            if (Model == null)
                return new Attribute[0];

            Type Type = Model.GetType();

            return GetTypeAttributes(Type);
        }
        /// <summary>
        /// Returns a Type's <see cref="Attribute"/>, if exists, else null.
        /// </summary>
        static public AttrType GetTypeAttribute<AttrType>(Type Type) where AttrType : Attribute
        {
            Attribute[] AttributeList = GetTypeAttributes(Type);
            AttrType Result = AttributeList.FirstOrDefault(Attr => Attr is AttrType) as AttrType;
            return Result;
        }
        /// <summary>
        /// Returns a description of a specified Model Type.
        /// <para>The description contains the Name of the Model Type and the value of the <see cref="DescriptionAttribute"/>, if available.</para>
        /// </summary>
        static public string GetTypeDescription(Type Type)
        {
            if (Type == null)
                return "Model Type is null";

            DescriptionAttribute DescriptionAttr = GetTypeAttribute<DescriptionAttribute>(Type);

            string Description = DescriptionAttr != null ? DescriptionAttr.Description : "Μη διαθέσιμη.";
            return $"Model Τύπος: {Type.Name} - Περιγραφή: {Description}";

        }
        /// <summary>
        /// Returns a description of a specified Model Type.
        /// <para>The description contains the Name of the Model Type and the value of the <see cref="DescriptionAttribute"/>, if available.</para>
        /// </summary>
        static public string GetModelDescription(object Model)
        {
            if (Model == null)
                return "Model is null";

            return GetTypeDescription(Model.GetType());
        }

        /* Property helpers */

        /// <summary>
        /// Returns the list of <see cref="PropertyInfo"/> properties of a specified instance.
        /// </summary>
        static public PropertyInfo[] GetProperties(object Model)
        {
            if (Model == null)
                return new PropertyInfo[0];

            Type T = Model.GetType();

            if (!TypePropertiesDic.ContainsKey(T))
                TypePropertiesDic[T] = T.GetProperties();

            return TypePropertiesDic[T];
        }
        static public PropertyInfo GetProperty(Type Type, string PropName)
        {
            PropertyInfo[] PropList = GetProperties(Type);
            PropertyInfo Result = PropList.FirstOrDefault(x => x.Name == PropName);
            return Result;
        }
        static public PropertyInfo GetProperty(object Model, string PropName)
        {
            return GetProperty(Model.GetType(), PropName);
        }
        /// <summary>
        /// Returns a property's <see cref="Attribute"/>, if exists, else null.
        /// </summary>
        static public AttrType GetPropertyAttribute<AttrType>(PropertyInfo Prop, object[] AttributeList = null) where AttrType : Attribute
        {
            if (AttributeList == null)
                AttributeList = Prop.GetCustomAttributes(true);

            AttrType Result = AttributeList.FirstOrDefault(Attr => Attr is AttrType) as AttrType;
            return Result;
        }
        /// <summary>
        /// Returns a description of a specified property.
        /// <para>The description contains the Name of the property and the value of the <see cref="DescriptionAttribute"/>, if available.</para>
        /// </summary>
        static public string GetPropertyDescription(PropertyInfo Prop, object[] AttributeList = null)
        {
            DescriptionAttribute DescriptionAttr = GetPropertyAttribute<DescriptionAttribute>(Prop, AttributeList);
            string PropName = Prop.Name;
            string Description = DescriptionAttr != null ? DescriptionAttr.Description : "Μη διαθέσιμη.";
 
            string ClassDescription = GetTypeDescription(Prop.DeclaringType);

            return $"{ClassDescription} - Ιδιότητα: {PropName} - Τύπος: {Prop.PropertyType.Name} - Περιγραφή: {Description}";
        }
        static public string GetPropertyDescription(object Model,  string PropName)
        {
            PropertyInfo Prop = GetProperty(Model, PropName);
            return GetPropertyDescription(Prop);
        }

        static public string FormatPropertyError(object Model, string PropName, string ErrorMessage)
        {
            string PropDescription = Validators.GetPropertyDescription(Model, PropName);
            return $"{PropDescription} - {ErrorMessage}";
        }
    }
}
