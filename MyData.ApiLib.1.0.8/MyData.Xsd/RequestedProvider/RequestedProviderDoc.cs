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
    
    
    /// <summary>
    /// <para>Παραστατικά από Πάροχο</para>
    /// </summary>
    [DescriptionAttribute("Παραστατικά από Πάροχο")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "")]
    [SerializableAttribute()]
    [XmlTypeAttribute("RequestedProviderDoc", Namespace="", AnonymousType=true)]
    [XmlRootAttribute("RequestedProviderDoc", Namespace="")]
    public partial class RequestedProviderDoc
    {
        
        [XmlElementAttribute("continuationToken")]
        public List<ContinuationTokenType> continuationToken { get; set; }
        
        [XmlElementAttribute("InvoiceProviderType")]
        public List<InvoiceProviderType> InvoiceProviderType { get; set; }
    }
}
