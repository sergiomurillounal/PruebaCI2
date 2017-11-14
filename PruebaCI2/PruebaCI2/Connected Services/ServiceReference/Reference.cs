﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaCI2.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarTareas", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PruebaCI2.ServiceReference.TareaResponse[] ConsultarTareas(string consulta, bool sesion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConsultarTareas", ReplyAction="*")]
        System.Threading.Tasks.Task<PruebaCI2.ServiceReference.TareaResponse[]> ConsultarTareasAsync(string consulta, bool sesion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CrearTarea", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PruebaCI2.ServiceReference.TareaResponse CrearTarea(System.DateTime fecha_creacion, string descripcion, string estado, System.DateTime fecha_vencimiento, decimal autor, bool sesion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CrearTarea", ReplyAction="*")]
        System.Threading.Tasks.Task<PruebaCI2.ServiceReference.TareaResponse> CrearTareaAsync(System.DateTime fecha_creacion, string descripcion, string estado, System.DateTime fecha_vencimiento, decimal autor, bool sesion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarTarea", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        PruebaCI2.ServiceReference.TareaResponse ActualizarTarea(PruebaCI2.ServiceReference.Tareas tarea, bool sesion_activa, decimal usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarTarea", ReplyAction="*")]
        System.Threading.Tasks.Task<PruebaCI2.ServiceReference.TareaResponse> ActualizarTareaAsync(PruebaCI2.ServiceReference.Tareas tarea, bool sesion_activa, decimal usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarTarea", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void EliminarTarea(decimal codigo, bool sesion_activa, decimal usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarTarea", ReplyAction="*")]
        System.Threading.Tasks.Task EliminarTareaAsync(decimal codigo, bool sesion_activa, decimal usuario);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TareaResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal codigoField;
        
        private System.DateTime fecha_creacionField;
        
        private string descripcionField;
        
        private string estadoField;
        
        private System.DateTime fecha_vencimientoField;
        
        private decimal autorField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public decimal Codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("Codigo");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Fecha_creacion {
            get {
                return this.fecha_creacionField;
            }
            set {
                this.fecha_creacionField = value;
                this.RaisePropertyChanged("Fecha_creacion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("Descripcion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("Estado");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime Fecha_vencimiento {
            get {
                return this.fecha_vencimientoField;
            }
            set {
                this.fecha_vencimientoField = value;
                this.RaisePropertyChanged("Fecha_vencimiento");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal Autor {
            get {
                return this.autorField;
            }
            set {
                this.autorField = value;
                this.RaisePropertyChanged("Autor");
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
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Tareas : object, System.ComponentModel.INotifyPropertyChanged {
        
        private decimal codigo_tareaField;
        
        private System.DateTime fecha_creacionField;
        
        private string descripcionField;
        
        private string estadoField;
        
        private System.DateTime fecha_vencimientoField;
        
        private decimal autorField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public decimal Codigo_tarea {
            get {
                return this.codigo_tareaField;
            }
            set {
                this.codigo_tareaField = value;
                this.RaisePropertyChanged("Codigo_tarea");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime Fecha_creacion {
            get {
                return this.fecha_creacionField;
            }
            set {
                this.fecha_creacionField = value;
                this.RaisePropertyChanged("Fecha_creacion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
                this.RaisePropertyChanged("Descripcion");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
                this.RaisePropertyChanged("Estado");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime Fecha_vencimiento {
            get {
                return this.fecha_vencimientoField;
            }
            set {
                this.fecha_vencimientoField = value;
                this.RaisePropertyChanged("Fecha_vencimiento");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public decimal Autor {
            get {
                return this.autorField;
            }
            set {
                this.autorField = value;
                this.RaisePropertyChanged("Autor");
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
    public interface WebServiceSoapChannel : PruebaCI2.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<PruebaCI2.ServiceReference.WebServiceSoap>, PruebaCI2.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PruebaCI2.ServiceReference.TareaResponse[] ConsultarTareas(string consulta, bool sesion) {
            return base.Channel.ConsultarTareas(consulta, sesion);
        }
        
        public System.Threading.Tasks.Task<PruebaCI2.ServiceReference.TareaResponse[]> ConsultarTareasAsync(string consulta, bool sesion) {
            return base.Channel.ConsultarTareasAsync(consulta, sesion);
        }
        
        public PruebaCI2.ServiceReference.TareaResponse CrearTarea(System.DateTime fecha_creacion, string descripcion, string estado, System.DateTime fecha_vencimiento, decimal autor, bool sesion) {
            return base.Channel.CrearTarea(fecha_creacion, descripcion, estado, fecha_vencimiento, autor, sesion);
        }
        
        public System.Threading.Tasks.Task<PruebaCI2.ServiceReference.TareaResponse> CrearTareaAsync(System.DateTime fecha_creacion, string descripcion, string estado, System.DateTime fecha_vencimiento, decimal autor, bool sesion) {
            return base.Channel.CrearTareaAsync(fecha_creacion, descripcion, estado, fecha_vencimiento, autor, sesion);
        }
        
        public PruebaCI2.ServiceReference.TareaResponse ActualizarTarea(PruebaCI2.ServiceReference.Tareas tarea, bool sesion_activa, decimal usuario) {
            return base.Channel.ActualizarTarea(tarea, sesion_activa, usuario);
        }
        
        public System.Threading.Tasks.Task<PruebaCI2.ServiceReference.TareaResponse> ActualizarTareaAsync(PruebaCI2.ServiceReference.Tareas tarea, bool sesion_activa, decimal usuario) {
            return base.Channel.ActualizarTareaAsync(tarea, sesion_activa, usuario);
        }
        
        public void EliminarTarea(decimal codigo, bool sesion_activa, decimal usuario) {
            base.Channel.EliminarTarea(codigo, sesion_activa, usuario);
        }
        
        public System.Threading.Tasks.Task EliminarTareaAsync(decimal codigo, bool sesion_activa, decimal usuario) {
            return base.Channel.EliminarTareaAsync(codigo, sesion_activa, usuario);
        }
    }
}
