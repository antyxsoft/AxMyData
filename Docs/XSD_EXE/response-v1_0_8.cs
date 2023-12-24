﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.4084.0.
// 
namespace AxMyData.AADE {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ResponseDoc {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response")]
        public ResponseType[] response;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ResponseType {
        
        /// <remarks/>
        public int index;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indexSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("authenticationCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("cancellationMark", typeof(long))]
        [System.Xml.Serialization.XmlElementAttribute("classificationMark", typeof(long))]
        [System.Xml.Serialization.XmlElementAttribute("errors", typeof(ResponseTypeErrors))]
        [System.Xml.Serialization.XmlElementAttribute("invoiceMark", typeof(long))]
        [System.Xml.Serialization.XmlElementAttribute("invoiceUid", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("paymentMethodMark", typeof(long))]
        [System.Xml.Serialization.XmlElementAttribute("qrUrl", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("receptionEmails", typeof(receptionEmailsType))]
        [System.Xml.Serialization.XmlElementAttribute("receptionProviders", typeof(receptionProvidersType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <remarks/>
        public string statusCode;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ResponseTypeErrors {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error")]
        public ErrorType[] error;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ErrorType {
        
        /// <remarks/>
        public string message;
        
        /// <remarks/>
        public string code;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class receptionEmailsType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email")]
        public string[] email;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProviderInfoType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VATNumber")]
        public string[] VATNumber;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class receptionProvidersType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProviderInfo")]
        public ProviderInfoType[] ProviderInfo;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        authenticationCode,
        
        /// <remarks/>
        cancellationMark,
        
        /// <remarks/>
        classificationMark,
        
        /// <remarks/>
        errors,
        
        /// <remarks/>
        invoiceMark,
        
        /// <remarks/>
        invoiceUid,
        
        /// <remarks/>
        paymentMethodMark,
        
        /// <remarks/>
        qrUrl,
        
        /// <remarks/>
        receptionEmails,
        
        /// <remarks/>
        receptionProviders,
    }
}
