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
    /// <para>Μέθοδοι Πληρωμής</para>
    /// </summary>
    [DescriptionAttribute("Μέθοδοι Πληρωμής")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1057.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PaymentMethodsDoc", Namespace="https://www.aade.gr/myDATA/paymentMethod/v1.0", AnonymousType=true)]
    [XmlRootAttribute("PaymentMethodsDoc", Namespace="https://www.aade.gr/myDATA/paymentMethod/v1.0")]
    public partial class PaymentMethodsDoc
    {
        
        [XmlIgnoreAttribute()]
        private List<PaymentMethodType> _paymentMethods;
        
        [RequiredAttribute()]
        [XmlElementAttribute("paymentMethods")]
        public List<PaymentMethodType> paymentMethods
        {
            get
            {
                return _paymentMethods;
            }
            set
            {
                _paymentMethods = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="PaymentMethodsDoc" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="PaymentMethodsDoc" /> class.</para>
        /// </summary>
        public PaymentMethodsDoc()
        {
            this._paymentMethods = new List<PaymentMethodType>();
        }
    }
}
