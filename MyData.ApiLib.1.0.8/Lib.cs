namespace MyData.ApiLib
{

    /// <summary>
    /// Represents this library
    /// </summary>
    public static class Lib
    {
        /// <summary>
        /// Returns an array of Type of A types, in a safe manner
        /// </summary>
        static public Type[] GetTypesSafe(this Assembly A)
        {
            try
            {
                if (A != null)
                    return A.GetTypes();
            }
            catch
            {
            }

            return new Type[0];
        }
        /// <summary>
        /// Returns a list of class types derived from BaseClass
        /// </summary>
        static public void FindDerivedClasses(Type BaseClass, Assembly Assembly, List<Type> Result)
        {
            if (BaseClass.IsClass)
            {
                try
                {
                    Type[] Types = Assembly.GetTypesSafe();

                    foreach (Type T in Types)
                    {
                        try
                        {
                            if (T.IsClass && T.IsSubclassOf(BaseClass))
                                Result.Add(T);
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Returns true if a specified type is a numeric one.
        /// <para>FROM: http://stackoverflow.com/a/5182747/172132</para>
        /// </summary>
        static public bool IsNumericType(Type Type)
        {
            if (Type == null)
                return false;


            switch (Type.GetTypeCode(Type))
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
                    if (Type.IsGenericType && Type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        return IsNumericType(Nullable.GetUnderlyingType(Type));
                    }
                    return false;
            }
            return false;
        }
    }
}
