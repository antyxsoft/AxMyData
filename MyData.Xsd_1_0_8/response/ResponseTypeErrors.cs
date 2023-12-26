using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData.Xsd
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.1+6249aec1f88eb051eadc7d928205edd1c2d96aad")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseTypeErrors
    {

        private List<ErrorType> errorField;

        public ResponseTypeErrors()
        {
            this.errorField = new List<ErrorType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("error")]
        public List<ErrorType> error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }
    }
}
