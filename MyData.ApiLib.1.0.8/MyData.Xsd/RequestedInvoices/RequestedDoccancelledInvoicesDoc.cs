//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator
namespace MyData.Xsd
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [SerializableAttribute()]
    [XmlTypeAttribute("RequestedDoccancelledInvoicesDoc", Namespace="http://www.aade.gr/myDATA/invoice/v1.0", AnonymousType=true)]
    public partial class RequestedDoccancelledInvoicesDoc
    {
        
        [XmlElementAttribute("cancelledInvoice")]
        public List<CancelledInvoiceType> cancelledInvoice { get; set; }
    }
}
