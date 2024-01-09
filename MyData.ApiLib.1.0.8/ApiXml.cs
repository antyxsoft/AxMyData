using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MyData.ApiLib
{

    /// <summary>
    /// XML helper
    /// </summary>
    static public class ApiXml
    { 

        /// <summary>
        /// Serializes a specified instance and returns the XML string.
        /// </summary>
        static string Serialize_OLD<T>(T Instance)
        {    
            XmlSerializer Serializer = new XmlSerializer(typeof(T));

            using (StringWriter Writer = new StringWriter())
            {
                Serializer.Serialize(Writer, Instance);
                return Writer.ToString();
            }
        }

        /// <summary>
        /// Removes an Attribure from an XmlElement by name, if exists.
        /// </summary>
        static void RemoveAttribute(XmlElement Element, string AttrName)
        {
            if (Element.Attributes != null && Element.Attributes.GetNamedItem(AttrName) != null)
            {
                XmlAttribute Attr = Element.GetAttributeNode(AttrName);
                if (Attr != null)
                    Element.RemoveAttributeNode(Attr);
            }           
        }
        /// <summary>
        /// Remove null nodes, i.e. having an Attribute as xsi:nil='true'
        /// </summary>
        static string RemoveNilElements(string XmlText)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.LoadXml(XmlText); 
            XmlElement Root = Doc.DocumentElement;

            // remove null nodes, i.e. having an Attribute as xsi:nil='true'
            if (Root.Attributes != null && Root.Attributes.GetNamedItem("xmlns:xsi") != null)
            {
                XmlNode Attr = Root.Attributes.GetNamedItem("xmlns:xsi");
                if (Attr != null)
                {
                    string XmlNs = Attr.Value;
                    XmlNamespaceManager NsMngr = new XmlNamespaceManager(Doc.NameTable);
                    NsMngr.AddNamespace("xsi", XmlNs);

                    // get null nodes and remove them
                    XmlNodeList NodeList = Root.SelectNodes("//*[@xsi:nil='true']", NsMngr);
                    if (NodeList != null && NodeList.Count > 0)
                    {
                        foreach (XmlNode Node in NodeList)
                            Node.ParentNode.RemoveChild(Node);
                    }
                }
            }
 
            // remove root namespaces, if exist
            RemoveAttribute(Root, "xmlns:xsi");
            RemoveAttribute(Root, "xmlns:xsd"); 

            // get the xml text
            using (StringWriter SW = new StringWriter())
            {
                using (XmlTextWriterEx TW = new XmlTextWriterEx(SW))    // removes node namespaces
                {
                    Doc.Save(TW);
                    XmlText = SW.ToString();
                }
            }
 
            return XmlText;
        }
    
        /// <summary>
        /// Serializes a specified instance and returns the XML string.
        /// </summary>
        static public string Serialize<T>(T Instance)
        {
            string XmlText;
            XmlSerializer Serializer = new XmlSerializer(typeof(T));

            using (StringWriter Writer = new StringWriter())
            {
                Serializer.Serialize(Writer, Instance);
                XmlText = Writer.ToString();
            }

            XmlText = RemoveNilElements(XmlText);
            return XmlText;

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
