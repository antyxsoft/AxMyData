namespace MyData.ApiLib
{

    /// <summary>
    /// Helper class. Represents this library
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

        /* type helpers */
        /// <summary>
        /// Returns true if a type defines a default public constructor
        /// </summary>
        static public bool HasDefaultConstructor(this Type ClassType)
        {
            if (ClassType != null)
            {
                BindingFlags BindingFlags = BindingFlags.Instance | BindingFlags.Public;
                ConstructorInfo Constructor = ClassType.GetConstructor(BindingFlags, null, new Type[0], null);
                return Constructor != null;
            }

            return false;
        }
        /// <summary>
        /// A kind of "virtual constructor" of any type of object. 
        /// Example call for a constructor with no params/arguments
        ///    Create(typeof(object), new Type[]{ },  new object[]{ });
        /// </summary>
        static public object Create(this Type ClassType, Type[] Params, object[] Args)
        {
            if (ClassType != null)
            {
                BindingFlags BindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
                ConstructorInfo Constructor = ClassType.GetConstructor(BindingFlags, null, Params, null);
                if (Constructor == null)
                    throw new ApplicationException("Constructor not found for class: " + ClassType.Name);
                return Constructor.Invoke(Args);
            }

            return null;
        }
        /// <summary>
        /// Tries to infer Type-s of Args. If an Arg is null, it infers the typeof(object)
        /// </summary>
        static public Type[] GetArgTypes(object[] Args)
        {
            if ((Args == null) || (Args.Length == 0))
                return new Type[0];

            Type[] Result = new Type[Args.Length];

            for (int i = 0; i < Args.Length; i++)
            {
                if (Args[i] == null)
                    Result[i] = typeof(object);
                else
                    Result[i] = Args[i].GetType();
            }

            return Result;
        }
        /// <summary>
        /// A kind of "virtual constructor" of any type of object. 
        /// Example call for a constructor
        ///    Create(typeof(object), new object[]{ });
        /// </summary>
        static public object Create(this Type ClassType, object[] Args)
        {
            return Create(ClassType, GetArgTypes(Args), Args);
        }
        /// <summary>
        /// A kind of "virtual constructor" of any type of object. 
        /// Example call for a constructor with no params/arguments
        ///    Create(typeof(object));
        /// </summary>
        static public object Create(this Type ClassType)
        {
            if (ClassType.HasDefaultConstructor())
                return Create(ClassType, new Type[] { }, new object[] { });
            return null;
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
