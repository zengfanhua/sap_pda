﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.8000.
// 
namespace SmartDeviceProject1.ZSDI504 {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    // CODEGEN: 未处理命名空间“http://schemas.xmlsoap.org/ws/2004/09/policy”中的可选 WSDL 扩展元素“Policy”。
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="binding", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class zsdi504 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public zsdi504() {
            this.Url = "http://sapdev.orgcanmaking.com:8000/sap/bc/srt/rfc/sap/zsdi504/500/zsdi504/bindin" +
                "g";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("Zsdi504Response", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
        public Zsdi504Response Zsdi504([System.Xml.Serialization.XmlElementAttribute("Zsdi504", Namespace="urn:sap-com:document:sap:soap:functions:mc-style")] Zsdi5041 Zsdi5041) {
            object[] results = this.Invoke("Zsdi504", new object[] {
                        Zsdi5041});
            return ((Zsdi504Response)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginZsdi504(Zsdi5041 Zsdi5041, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Zsdi504", new object[] {
                        Zsdi5041}, callback, asyncState);
        }
        
        /// <remarks/>
        public Zsdi504Response EndZsdi504(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((Zsdi504Response)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zsdi5041 {
        
        private Zsdi504[] itabField;
        
        private string lgortField;
        
        private string vbelnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zsdi504[] Itab {
            get {
                return this.itabField;
            }
            set {
                this.itabField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lgort {
            get {
                return this.lgortField;
            }
            set {
                this.lgortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Vbeln {
            get {
                return this.vbelnField;
            }
            set {
                this.vbelnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zsdi504 {
        
        private string vbelnField;
        
        private string posnrField;
        
        private string maktxField;
        
        private string zlgortField;
        
        private decimal mengeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Vbeln {
            get {
                return this.vbelnField;
            }
            set {
                this.vbelnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Posnr {
            get {
                return this.posnrField;
            }
            set {
                this.posnrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Maktx {
            get {
                return this.maktxField;
            }
            set {
                this.maktxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Zlgort {
            get {
                return this.zlgortField;
            }
            set {
                this.zlgortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public decimal Menge {
            get {
                return this.mengeField;
            }
            set {
                this.mengeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:sap-com:document:sap:soap:functions:mc-style")]
    public partial class Zsdi504Response {
        
        private Zsdi504[] itabField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public Zsdi504[] Itab {
            get {
                return this.itabField;
            }
            set {
                this.itabField = value;
            }
        }
    }
}
