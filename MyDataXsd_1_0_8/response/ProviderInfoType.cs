// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Open Xsd2Code. Version 3.4.2.41979 MIT License (MIT) 
//    <NameSpace>MyDataXsd</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><GenerateSeparateFiles>True</GenerateSeparateFiles><OutputFilePath>response-v1.0.8.designer.cs</OutputFilePath><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><EnableEncoding>False</EnableEncoding><Encoder>UTF8</Encoder><UseBaseClass>False</UseBaseClass><BaseClassName>EntityBase</BaseClassName><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net20</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9174
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyDataXsd {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.1+6249aec1f88eb051eadc7d928205edd1c2d96aad")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
    public partial class ProviderInfoType {
        
        [System.Xml.Serialization.XmlElementAttribute("VATNumber")]
        public List<string> VATNumber;
        
        public ProviderInfoType() {
            this.VATNumber = new List<string>();
        }
    }
}
