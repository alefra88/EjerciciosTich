﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace business.refWSAlumnos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AportacionesIMSS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AportacionesIMSS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal EnfermedadMaternidadField;
        
        private decimal InvalidezVidaField;
        
        private decimal RetiroField;
        
        private decimal CesantiaField;
        
        private decimal InfonavitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal EnfermedadMaternidad {
            get {
                return this.EnfermedadMaternidadField;
            }
            set {
                if ((this.EnfermedadMaternidadField.Equals(value) != true)) {
                    this.EnfermedadMaternidadField = value;
                    this.RaisePropertyChanged("EnfermedadMaternidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal InvalidezVida {
            get {
                return this.InvalidezVidaField;
            }
            set {
                if ((this.InvalidezVidaField.Equals(value) != true)) {
                    this.InvalidezVidaField = value;
                    this.RaisePropertyChanged("InvalidezVida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Retiro {
            get {
                return this.RetiroField;
            }
            set {
                if ((this.RetiroField.Equals(value) != true)) {
                    this.RetiroField = value;
                    this.RaisePropertyChanged("Retiro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal Cesantia {
            get {
                return this.CesantiaField;
            }
            set {
                if ((this.CesantiaField.Equals(value) != true)) {
                    this.CesantiaField = value;
                    this.RaisePropertyChanged("Cesantia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public decimal Infonavit {
            get {
                return this.InfonavitField;
            }
            set {
                if ((this.InfonavitField.Equals(value) != true)) {
                    this.InfonavitField = value;
                    this.RaisePropertyChanged("Infonavit");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemTablaISR", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ItemTablaISR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal LimiteInferiorField;
        
        private decimal LimiteSuperiorField;
        
        private decimal CuotaFijaField;
        
        private decimal ExcedenteField;
        
        private decimal SubsidioField;
        
        private decimal ISRField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal LimiteInferior {
            get {
                return this.LimiteInferiorField;
            }
            set {
                if ((this.LimiteInferiorField.Equals(value) != true)) {
                    this.LimiteInferiorField = value;
                    this.RaisePropertyChanged("LimiteInferior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal LimiteSuperior {
            get {
                return this.LimiteSuperiorField;
            }
            set {
                if ((this.LimiteSuperiorField.Equals(value) != true)) {
                    this.LimiteSuperiorField = value;
                    this.RaisePropertyChanged("LimiteSuperior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public decimal CuotaFija {
            get {
                return this.CuotaFijaField;
            }
            set {
                if ((this.CuotaFijaField.Equals(value) != true)) {
                    this.CuotaFijaField = value;
                    this.RaisePropertyChanged("CuotaFija");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal Excedente {
            get {
                return this.ExcedenteField;
            }
            set {
                if ((this.ExcedenteField.Equals(value) != true)) {
                    this.ExcedenteField = value;
                    this.RaisePropertyChanged("Excedente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public decimal Subsidio {
            get {
                return this.SubsidioField;
            }
            set {
                if ((this.SubsidioField.Equals(value) != true)) {
                    this.SubsidioField = value;
                    this.RaisePropertyChanged("Subsidio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public decimal ISR {
            get {
                return this.ISRField;
            }
            set {
                if ((this.ISRField.Equals(value) != true)) {
                    this.ISRField = value;
                    this.RaisePropertyChanged("ISR");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="refWSAlumnos.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CalcularIMSSResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularIMSS", ReplyAction="*")]
        business.refWSAlumnos.CalcularIMSSResponse CalcularIMSS(business.refWSAlumnos.CalcularIMSSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularIMSS", ReplyAction="*")]
        System.Threading.Tasks.Task<business.refWSAlumnos.CalcularIMSSResponse> CalcularIMSSAsync(business.refWSAlumnos.CalcularIMSSRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CalcularISRResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularISR", ReplyAction="*")]
        business.refWSAlumnos.CalcularISRResponse CalcularISR(business.refWSAlumnos.CalcularISRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularISR", ReplyAction="*")]
        System.Threading.Tasks.Task<business.refWSAlumnos.CalcularISRResponse> CalcularISRAsync(business.refWSAlumnos.CalcularISRRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularIMSSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularIMSS", Namespace="http://tempuri.org/", Order=0)]
        public business.refWSAlumnos.CalcularIMSSRequestBody Body;
        
        public CalcularIMSSRequest() {
        }
        
        public CalcularIMSSRequest(business.refWSAlumnos.CalcularIMSSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularIMSSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public CalcularIMSSRequestBody() {
        }
        
        public CalcularIMSSRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularIMSSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularIMSSResponse", Namespace="http://tempuri.org/", Order=0)]
        public business.refWSAlumnos.CalcularIMSSResponseBody Body;
        
        public CalcularIMSSResponse() {
        }
        
        public CalcularIMSSResponse(business.refWSAlumnos.CalcularIMSSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularIMSSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public business.refWSAlumnos.AportacionesIMSS CalcularIMSSResult;
        
        public CalcularIMSSResponseBody() {
        }
        
        public CalcularIMSSResponseBody(business.refWSAlumnos.AportacionesIMSS CalcularIMSSResult) {
            this.CalcularIMSSResult = CalcularIMSSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularISRRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularISR", Namespace="http://tempuri.org/", Order=0)]
        public business.refWSAlumnos.CalcularISRRequestBody Body;
        
        public CalcularISRRequest() {
        }
        
        public CalcularISRRequest(business.refWSAlumnos.CalcularISRRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularISRRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public CalcularISRRequestBody() {
        }
        
        public CalcularISRRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularISRResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularISRResponse", Namespace="http://tempuri.org/", Order=0)]
        public business.refWSAlumnos.CalcularISRResponseBody Body;
        
        public CalcularISRResponse() {
        }
        
        public CalcularISRResponse(business.refWSAlumnos.CalcularISRResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularISRResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public business.refWSAlumnos.ItemTablaISR CalcularISRResult;
        
        public CalcularISRResponseBody() {
        }
        
        public CalcularISRResponseBody(business.refWSAlumnos.ItemTablaISR CalcularISRResult) {
            this.CalcularISRResult = CalcularISRResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : business.refWSAlumnos.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<business.refWSAlumnos.WebService1Soap>, business.refWSAlumnos.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        business.refWSAlumnos.CalcularIMSSResponse business.refWSAlumnos.WebService1Soap.CalcularIMSS(business.refWSAlumnos.CalcularIMSSRequest request) {
            return base.Channel.CalcularIMSS(request);
        }
        
        public business.refWSAlumnos.AportacionesIMSS CalcularIMSS(int id) {
            business.refWSAlumnos.CalcularIMSSRequest inValue = new business.refWSAlumnos.CalcularIMSSRequest();
            inValue.Body = new business.refWSAlumnos.CalcularIMSSRequestBody();
            inValue.Body.id = id;
            business.refWSAlumnos.CalcularIMSSResponse retVal = ((business.refWSAlumnos.WebService1Soap)(this)).CalcularIMSS(inValue);
            return retVal.Body.CalcularIMSSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<business.refWSAlumnos.CalcularIMSSResponse> business.refWSAlumnos.WebService1Soap.CalcularIMSSAsync(business.refWSAlumnos.CalcularIMSSRequest request) {
            return base.Channel.CalcularIMSSAsync(request);
        }
        
        public System.Threading.Tasks.Task<business.refWSAlumnos.CalcularIMSSResponse> CalcularIMSSAsync(int id) {
            business.refWSAlumnos.CalcularIMSSRequest inValue = new business.refWSAlumnos.CalcularIMSSRequest();
            inValue.Body = new business.refWSAlumnos.CalcularIMSSRequestBody();
            inValue.Body.id = id;
            return ((business.refWSAlumnos.WebService1Soap)(this)).CalcularIMSSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        business.refWSAlumnos.CalcularISRResponse business.refWSAlumnos.WebService1Soap.CalcularISR(business.refWSAlumnos.CalcularISRRequest request) {
            return base.Channel.CalcularISR(request);
        }
        
        public business.refWSAlumnos.ItemTablaISR CalcularISR(int id) {
            business.refWSAlumnos.CalcularISRRequest inValue = new business.refWSAlumnos.CalcularISRRequest();
            inValue.Body = new business.refWSAlumnos.CalcularISRRequestBody();
            inValue.Body.id = id;
            business.refWSAlumnos.CalcularISRResponse retVal = ((business.refWSAlumnos.WebService1Soap)(this)).CalcularISR(inValue);
            return retVal.Body.CalcularISRResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<business.refWSAlumnos.CalcularISRResponse> business.refWSAlumnos.WebService1Soap.CalcularISRAsync(business.refWSAlumnos.CalcularISRRequest request) {
            return base.Channel.CalcularISRAsync(request);
        }
        
        public System.Threading.Tasks.Task<business.refWSAlumnos.CalcularISRResponse> CalcularISRAsync(int id) {
            business.refWSAlumnos.CalcularISRRequest inValue = new business.refWSAlumnos.CalcularISRRequest();
            inValue.Body = new business.refWSAlumnos.CalcularISRRequestBody();
            inValue.Body.id = id;
            return ((business.refWSAlumnos.WebService1Soap)(this)).CalcularISRAsync(inValue);
        }
    }
}
