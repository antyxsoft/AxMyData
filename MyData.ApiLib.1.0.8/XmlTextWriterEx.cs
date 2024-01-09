using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.ApiLib
{

    /*
        // Usage

        using (StringWriter SW = new StringWriter())
        {
            using (XmlTextWriterEx TW = new XmlTextWriterEx(SW))
            {
                Doc.Save(TW);
                XmlText = SW.ToString();
            }
        }   

     */

    /// <summary>
    /// Modified XML writer that writes (almost) no namespaces out with pretty formatting
    /// <para>FROM: https://stackoverflow.com/a/6659714/1779320</para>
    /// </summary>
    public class XmlTextWriterEx : XmlTextWriter
    {
        bool SkipAttribute = false;

        /* construction */
        public XmlTextWriterEx(TextWriter writer)
            : base(writer)
        {
            this.Formatting = System.Xml.Formatting.Indented;
        }

        /* overrides */
        public override void WriteStartElement(string prefix, string localName, string ns)
        {
            base.WriteStartElement(null, localName, null);
        }
        public override void WriteStartAttribute(string prefix, string localName, string ns)
        {
            //If the prefix or localname are "xmlns", don't write it.
            //HOWEVER... if the 1st element (root?) has a namespace we will write it.
            if ((prefix.CompareTo("xmlns") == 0 || localName.CompareTo("xmlns") == 0)) 
            {
                SkipAttribute = true;
            }
            else
            {
                base.WriteStartAttribute(null, localName, null);
            }
        }
        public override void WriteString(string text)
        {
            //If we are writing an attribute, the text for the xmlns
            //or xmlns:prefix declaration would occur here.  Skip
            //it if this is the case.
            if (!SkipAttribute)
            {
                base.WriteString(text);
            }
        }
        public override void WriteEndAttribute()
        {
            //If we skipped the WriteStartAttribute call, we have to
            //skip the WriteEndAttribute call as well or else the XmlWriter
            //will have an invalid state.
            if (!SkipAttribute)
            {
                base.WriteEndAttribute();
            }
            //reset the boolean for the next attribute.
            SkipAttribute = false;
        }
        public override void WriteQualifiedName(string localName, string ns)
        {
            //Always write the qualified name using only the
            //localname.
            base.WriteQualifiedName(localName, null);
        }
    }
}
