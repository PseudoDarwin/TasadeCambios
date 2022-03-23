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

namespace ConsolaVerificacionMes.bcn_ref {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Tipo_Cambio_BCNSoap", Namespace="http://servicios.bcn.gob.ni/")]
    public partial class Tipo_Cambio_BCN : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RecuperaTC_DiaOperationCompleted;
        
        private System.Threading.SendOrPostCallback RecuperaTC_MesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Tipo_Cambio_BCN() {
            this.Url = global::ConsolaVerificacionMes.Properties.Settings.Default.ConsolaVerificacionMes_bcn_ref_Tipo_Cambio_BCN;
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
        public event RecuperaTC_DiaCompletedEventHandler RecuperaTC_DiaCompleted;
        
        /// <remarks/>
        public event RecuperaTC_MesCompletedEventHandler RecuperaTC_MesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios.bcn.gob.ni/RecuperaTC_Dia", RequestNamespace="http://servicios.bcn.gob.ni/", ResponseNamespace="http://servicios.bcn.gob.ni/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double RecuperaTC_Dia(int Ano, int Mes, int Dia) {
            object[] results = this.Invoke("RecuperaTC_Dia", new object[] {
                        Ano,
                        Mes,
                        Dia});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void RecuperaTC_DiaAsync(int Ano, int Mes, int Dia) {
            this.RecuperaTC_DiaAsync(Ano, Mes, Dia, null);
        }
        
        /// <remarks/>
        public void RecuperaTC_DiaAsync(int Ano, int Mes, int Dia, object userState) {
            if ((this.RecuperaTC_DiaOperationCompleted == null)) {
                this.RecuperaTC_DiaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecuperaTC_DiaOperationCompleted);
            }
            this.InvokeAsync("RecuperaTC_Dia", new object[] {
                        Ano,
                        Mes,
                        Dia}, this.RecuperaTC_DiaOperationCompleted, userState);
        }
        
        private void OnRecuperaTC_DiaOperationCompleted(object arg) {
            if ((this.RecuperaTC_DiaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecuperaTC_DiaCompleted(this, new RecuperaTC_DiaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://servicios.bcn.gob.ni/RecuperaTC_Mes", RequestNamespace="http://servicios.bcn.gob.ni/", ResponseNamespace="http://servicios.bcn.gob.ni/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode RecuperaTC_Mes(int Ano, int Mes) {
            object[] results = this.Invoke("RecuperaTC_Mes", new object[] {
                        Ano,
                        Mes});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void RecuperaTC_MesAsync(int Ano, int Mes) {
            this.RecuperaTC_MesAsync(Ano, Mes, null);
        }
        
        /// <remarks/>
        public void RecuperaTC_MesAsync(int Ano, int Mes, object userState) {
            if ((this.RecuperaTC_MesOperationCompleted == null)) {
                this.RecuperaTC_MesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecuperaTC_MesOperationCompleted);
            }
            this.InvokeAsync("RecuperaTC_Mes", new object[] {
                        Ano,
                        Mes}, this.RecuperaTC_MesOperationCompleted, userState);
        }
        
        private void OnRecuperaTC_MesOperationCompleted(object arg) {
            if ((this.RecuperaTC_MesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecuperaTC_MesCompleted(this, new RecuperaTC_MesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RecuperaTC_DiaCompletedEventHandler(object sender, RecuperaTC_DiaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RecuperaTC_DiaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RecuperaTC_DiaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void RecuperaTC_MesCompletedEventHandler(object sender, RecuperaTC_MesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RecuperaTC_MesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RecuperaTC_MesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591