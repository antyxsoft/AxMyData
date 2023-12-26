using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MyData.RestApi
{

    /// <summary>
    /// XML helper
    /// </summary>
    static internal class ApiXml
    {
        /// <summary>
        /// Serializes a specified instance and returns the XML string.
        /// </summary>
        static public string Serialize<T>(T Instance)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(T));

            using (StringWriter Writer = new StringWriter())
            {
                Serializer.Serialize(Writer, Instance);
                return Writer.ToString();
            }
        }
        /// <summary>
        /// Deserializes an XML string and returns an instance of a specified type.
        /// </summary>
        static public T Deserialize<T>(string XmlText) where T : class  
        {
            T Result;
            XmlSerializer Serializer = new XmlSerializer(typeof(T));
            using (StringReader Reader = new StringReader(XmlText))
            {
                Result =  Serializer.Deserialize(Reader) as T;
            }

            return Result;
        }
        /// <summary>
        /// Deserializes an XML string and returns an instance of a specified type.
        /// </summary>
        static public object Deserialize(string XmlText, Type type) 
        {
            object Result;
            XmlSerializer Serializer = new XmlSerializer(type);
            using (StringReader Reader = new StringReader(XmlText))
            {
                Result = Serializer.Deserialize(Reader);
            }

            return Result;
        }
     }
}
