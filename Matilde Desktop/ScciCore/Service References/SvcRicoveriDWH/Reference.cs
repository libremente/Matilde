﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnicodeSrl.ScciCore.SvcRicoveriDWH {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RisultatiLabAll", Namespace="http://schemas.datacontract.org/2004/07/WsSCCI")]
    [System.SerializableAttribute()]
    public partial class RisultatiLabAll : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodPrescrizioneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodSezioneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescPrescrizioneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescrSezioneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdRefertoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double QuantitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RisultatoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RisultatoNumericoAssenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UMField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodPrescrizione {
            get {
                return this.CodPrescrizioneField;
            }
            set {
                if ((object.ReferenceEquals(this.CodPrescrizioneField, value) != true)) {
                    this.CodPrescrizioneField = value;
                    this.RaisePropertyChanged("CodPrescrizione");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodSezione {
            get {
                return this.CodSezioneField;
            }
            set {
                if ((object.ReferenceEquals(this.CodSezioneField, value) != true)) {
                    this.CodSezioneField = value;
                    this.RaisePropertyChanged("CodSezione");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Commenti {
            get {
                return this.CommentiField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentiField, value) != true)) {
                    this.CommentiField = value;
                    this.RaisePropertyChanged("Commenti");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescPrescrizione {
            get {
                return this.DescPrescrizioneField;
            }
            set {
                if ((object.ReferenceEquals(this.DescPrescrizioneField, value) != true)) {
                    this.DescPrescrizioneField = value;
                    this.RaisePropertyChanged("DescPrescrizione");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescrSezione {
            get {
                return this.DescrSezioneField;
            }
            set {
                if ((object.ReferenceEquals(this.DescrSezioneField, value) != true)) {
                    this.DescrSezioneField = value;
                    this.RaisePropertyChanged("DescrSezione");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdReferto {
            get {
                return this.IdRefertoField;
            }
            set {
                if ((object.ReferenceEquals(this.IdRefertoField, value) != true)) {
                    this.IdRefertoField = value;
                    this.RaisePropertyChanged("IdReferto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Quantita {
            get {
                return this.QuantitaField;
            }
            set {
                if ((this.QuantitaField.Equals(value) != true)) {
                    this.QuantitaField = value;
                    this.RaisePropertyChanged("Quantita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Risultato {
            get {
                return this.RisultatoField;
            }
            set {
                if ((object.ReferenceEquals(this.RisultatoField, value) != true)) {
                    this.RisultatoField = value;
                    this.RaisePropertyChanged("Risultato");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RisultatoNumericoAssente {
            get {
                return this.RisultatoNumericoAssenteField;
            }
            set {
                if ((this.RisultatoNumericoAssenteField.Equals(value) != true)) {
                    this.RisultatoNumericoAssenteField = value;
                    this.RaisePropertyChanged("RisultatoNumericoAssente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UM {
            get {
                return this.UMField;
            }
            set {
                if ((object.ReferenceEquals(this.UMField, value) != true)) {
                    this.UMField = value;
                    this.RaisePropertyChanged("UM");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SvcRicoveriDWH.IScciRicoveriDWH")]
    public interface IScciRicoveriDWH {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScciRicoveriDWH/RicoveroPerId", ReplyAction="http://tempuri.org/IScciRicoveriDWH/RicoveroPerIdResponse")]
        UnicodeSrl.Scci.DataContracts.RicoveroDWH RicoveroPerId(string idricovero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScciRicoveriDWH/RicercaRicoveriDWH", ReplyAction="http://tempuri.org/IScciRicoveriDWH/RicercaRicoveriDWHResponse")]
        UnicodeSrl.Scci.DataContracts.RicoveroDWHSintetico[] RicercaRicoveriDWH(string idsac, System.DateTime datainizio, System.DateTime datafine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScciRicoveriDWH/RicercaDatiLabDWH", ReplyAction="http://tempuri.org/IScciRicoveriDWH/RicercaDatiLabDWHResponse")]
        UnicodeSrl.Scci.DataContracts.RisultatiLab[] RicercaDatiLabDWH(string idsac, System.DateTime datainizio, System.DateTime datafine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScciRicoveriDWH/RicercaDatiLabDWHUM", ReplyAction="http://tempuri.org/IScciRicoveriDWH/RicercaDatiLabDWHUMResponse")]
        UnicodeSrl.Scci.DataContracts.RisultatiLabUM[] RicercaDatiLabDWHUM(string idsac, System.DateTime datainizio, System.DateTime datafine);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScciRicoveriDWH/RicercaDatiLabDWHAll", ReplyAction="http://tempuri.org/IScciRicoveriDWH/RicercaDatiLabDWHAllResponse")]
        UnicodeSrl.ScciCore.SvcRicoveriDWH.RisultatiLabAll[] RicercaDatiLabDWHAll(string idsac, System.DateTime datainizio, System.DateTime datafine);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScciRicoveriDWHChannel : UnicodeSrl.ScciCore.SvcRicoveriDWH.IScciRicoveriDWH, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScciRicoveriDWHClient : System.ServiceModel.ClientBase<UnicodeSrl.ScciCore.SvcRicoveriDWH.IScciRicoveriDWH>, UnicodeSrl.ScciCore.SvcRicoveriDWH.IScciRicoveriDWH {
        
        public ScciRicoveriDWHClient() {
        }
        
        public ScciRicoveriDWHClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScciRicoveriDWHClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScciRicoveriDWHClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScciRicoveriDWHClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UnicodeSrl.Scci.DataContracts.RicoveroDWH RicoveroPerId(string idricovero) {
            return base.Channel.RicoveroPerId(idricovero);
        }
        
        public UnicodeSrl.Scci.DataContracts.RicoveroDWHSintetico[] RicercaRicoveriDWH(string idsac, System.DateTime datainizio, System.DateTime datafine) {
            return base.Channel.RicercaRicoveriDWH(idsac, datainizio, datafine);
        }
        
        public UnicodeSrl.Scci.DataContracts.RisultatiLab[] RicercaDatiLabDWH(string idsac, System.DateTime datainizio, System.DateTime datafine) {
            return base.Channel.RicercaDatiLabDWH(idsac, datainizio, datafine);
        }
        
        public UnicodeSrl.Scci.DataContracts.RisultatiLabUM[] RicercaDatiLabDWHUM(string idsac, System.DateTime datainizio, System.DateTime datafine) {
            return base.Channel.RicercaDatiLabDWHUM(idsac, datainizio, datafine);
        }
        
        public UnicodeSrl.ScciCore.SvcRicoveriDWH.RisultatiLabAll[] RicercaDatiLabDWHAll(string idsac, System.DateTime datainizio, System.DateTime datafine) {
            return base.Channel.RicercaDatiLabDWHAll(idsac, datainizio, datafine);
        }
    }
}
