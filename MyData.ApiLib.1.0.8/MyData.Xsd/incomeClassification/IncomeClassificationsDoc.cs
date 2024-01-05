//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1057.0
namespace MyData.Xsd
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>Χαρατηρισμοί Εσόδων Πρότυπων Παραστατικών ΑΑΔΕ</para>
    /// </summary>
    [DescriptionAttribute("Χαρατηρισμοί Εσόδων Πρότυπων Παραστατικών ΑΑΔΕ")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1057.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("IncomeClassificationsDoc", Namespace="https://www.aade.gr/myDATA/incomeClassificaton/v1.0", AnonymousType=true)]
    [XmlRootAttribute("IncomeClassificationsDoc", Namespace="https://www.aade.gr/myDATA/incomeClassificaton/v1.0")]
    public partial class IncomeClassificationsDoc
    {
        
        [XmlIgnoreAttribute()]
        private List<InvoiceIncomeClassificationType> _incomeInvoiceClassification;
        
        [RequiredAttribute()]
        [XmlElementAttribute("incomeInvoiceClassification")]
        public List<InvoiceIncomeClassificationType> incomeInvoiceClassification
        {
            get
            {
                return _incomeInvoiceClassification;
            }
            set
            {
                _incomeInvoiceClassification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="IncomeClassificationsDoc" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="IncomeClassificationsDoc" /> class.</para>
        /// </summary>
        public IncomeClassificationsDoc()
        {
            this._incomeInvoiceClassification = new List<InvoiceIncomeClassificationType>();
        }
    }
}
