﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace proxyws.sevicewtfocad {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosWebSSMSOSoap", Namespace="http://localhost/ZeroIdentidad/")]
    public partial class ServiciosWebSSMSO : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback MetControlIdentidadOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosWebSSMSO() {
            this.Url = global::proxyws.Properties.Settings.Default.proxyws_sevicewtfocad_ServiciosWebSSMSO;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event MetControlIdentidadCompletedEventHandler MetControlIdentidadCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://localhost/ZeroIdentidad/MetControlIdentidad", RequestNamespace="http://localhost/ZeroIdentidad/", ResponseNamespace="http://localhost/ZeroIdentidad/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public sIdentidad MetControlIdentidad(ingresoIdentidad ZeroIdentidad) {
            object[] results = this.Invoke("MetControlIdentidad", new object[] {
                        ZeroIdentidad});
            return ((sIdentidad)(results[0]));
        }
        
        /// <remarks/>
        public void MetControlIdentidadAsync(ingresoIdentidad ZeroIdentidad) {
            this.MetControlIdentidadAsync(ZeroIdentidad, null);
        }
        
        /// <remarks/>
        public void MetControlIdentidadAsync(ingresoIdentidad ZeroIdentidad, object userState) {
            if ((this.MetControlIdentidadOperationCompleted == null)) {
                this.MetControlIdentidadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMetControlIdentidadOperationCompleted);
            }
            this.InvokeAsync("MetControlIdentidad", new object[] {
                        ZeroIdentidad}, this.MetControlIdentidadOperationCompleted, userState);
        }
        
        private void OnMetControlIdentidadOperationCompleted(object arg) {
            if ((this.MetControlIdentidadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MetControlIdentidadCompleted(this, new MetControlIdentidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/ZeroIdentidad/")]
    public partial class ingresoIdentidad {
        
        private string nUsuarioField;
        
        private string nPasswordField;
        
        /// <comentarios/>
        public string nUsuario {
            get {
                return this.nUsuarioField;
            }
            set {
                this.nUsuarioField = value;
            }
        }
        
        /// <comentarios/>
        public string nPassword {
            get {
                return this.nPasswordField;
            }
            set {
                this.nPasswordField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://localhost/ZeroIdentidad/")]
    public partial class sIdentidad {
        
        private string nfechaEmisionField;
        
        private string nRunField;
        
        private string nDigitoField;
        
        private string nNombresField;
        
        private string nCargoEmpresaField;
        
        private string nRunEmpresaField;
        
        private string nNombreEmpresaField;
        
        private string nNombreNodoField;
        
        private string nPerfilField;
        
        private string ncodigoField;
        
        private string ndescripcionField;
        
        /// <comentarios/>
        public string nfechaEmision {
            get {
                return this.nfechaEmisionField;
            }
            set {
                this.nfechaEmisionField = value;
            }
        }
        
        /// <comentarios/>
        public string nRun {
            get {
                return this.nRunField;
            }
            set {
                this.nRunField = value;
            }
        }
        
        /// <comentarios/>
        public string nDigito {
            get {
                return this.nDigitoField;
            }
            set {
                this.nDigitoField = value;
            }
        }
        
        /// <comentarios/>
        public string nNombres {
            get {
                return this.nNombresField;
            }
            set {
                this.nNombresField = value;
            }
        }
        
        /// <comentarios/>
        public string nCargoEmpresa {
            get {
                return this.nCargoEmpresaField;
            }
            set {
                this.nCargoEmpresaField = value;
            }
        }
        
        /// <comentarios/>
        public string nRunEmpresa {
            get {
                return this.nRunEmpresaField;
            }
            set {
                this.nRunEmpresaField = value;
            }
        }
        
        /// <comentarios/>
        public string nNombreEmpresa {
            get {
                return this.nNombreEmpresaField;
            }
            set {
                this.nNombreEmpresaField = value;
            }
        }
        
        /// <comentarios/>
        public string nNombreNodo {
            get {
                return this.nNombreNodoField;
            }
            set {
                this.nNombreNodoField = value;
            }
        }
        
        /// <comentarios/>
        public string nPerfil {
            get {
                return this.nPerfilField;
            }
            set {
                this.nPerfilField = value;
            }
        }
        
        /// <comentarios/>
        public string ncodigo {
            get {
                return this.ncodigoField;
            }
            set {
                this.ncodigoField = value;
            }
        }
        
        /// <comentarios/>
        public string ndescripcion {
            get {
                return this.ndescripcionField;
            }
            set {
                this.ndescripcionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void MetControlIdentidadCompletedEventHandler(object sender, MetControlIdentidadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MetControlIdentidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MetControlIdentidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public sIdentidad Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((sIdentidad)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591