﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grup__8_Annonser.ServiceReferenceAnnonser {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AnnonsKlass", Namespace="http://schemas.datacontract.org/2004/07/AdvertisingService")]
    [System.SerializableAttribute()]
    public partial class AnnonsKlass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int addIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string onHooverTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string resourceField;
        
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
        public int addId {
            get {
                return this.addIdField;
            }
            set {
                if ((this.addIdField.Equals(value) != true)) {
                    this.addIdField = value;
                    this.RaisePropertyChanged("addId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string onHooverText {
            get {
                return this.onHooverTextField;
            }
            set {
                if ((object.ReferenceEquals(this.onHooverTextField, value) != true)) {
                    this.onHooverTextField = value;
                    this.RaisePropertyChanged("onHooverText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string resource {
            get {
                return this.resourceField;
            }
            set {
                if ((object.ReferenceEquals(this.resourceField, value) != true)) {
                    this.resourceField = value;
                    this.RaisePropertyChanged("resource");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceAnnonser.IServiceAdvertising")]
    public interface IServiceAdvertising {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DoWork", ReplyAction="http://tempuri.org/IServiceAdvertising/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DoWork", ReplyAction="http://tempuri.org/IServiceAdvertising/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DoILive", ReplyAction="http://tempuri.org/IServiceAdvertising/DoILiveResponse")]
        string DoILive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DoILive", ReplyAction="http://tempuri.org/IServiceAdvertising/DoILiveResponse")]
        System.Threading.Tasks.Task<string> DoILiveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/RndAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/RndAnnonsResponse")]
        Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass RndAnnons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/RndAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/RndAnnonsResponse")]
        System.Threading.Tasks.Task<Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass> RndAnnonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/GetAnnonsId", ReplyAction="http://tempuri.org/IServiceAdvertising/GetAnnonsIdResponse")]
        Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass GetAnnonsId(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/GetAnnonsId", ReplyAction="http://tempuri.org/IServiceAdvertising/GetAnnonsIdResponse")]
        System.Threading.Tasks.Task<Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass> GetAnnonsIdAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/ReadAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/ReadAnnonsResponse")]
        Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass[] ReadAnnons();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/ReadAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/ReadAnnonsResponse")]
        System.Threading.Tasks.Task<Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass[]> ReadAnnonsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/CreateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/CreateAnnonsResponse")]
        void CreateAnnons(string resource, string onHooverText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/CreateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/CreateAnnonsResponse")]
        System.Threading.Tasks.Task CreateAnnonsAsync(string resource, string onHooverText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/UpdateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/UpdateAnnonsResponse")]
        void UpdateAnnons(Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass Update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/UpdateAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/UpdateAnnonsResponse")]
        System.Threading.Tasks.Task UpdateAnnonsAsync(Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass Update);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DeleteAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/DeleteAnnonsResponse")]
        void DeleteAnnons(System.Nullable<int> addId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceAdvertising/DeleteAnnons", ReplyAction="http://tempuri.org/IServiceAdvertising/DeleteAnnonsResponse")]
        System.Threading.Tasks.Task DeleteAnnonsAsync(System.Nullable<int> addId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceAdvertisingChannel : Grup__8_Annonser.ServiceReferenceAnnonser.IServiceAdvertising, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAdvertisingClient : System.ServiceModel.ClientBase<Grup__8_Annonser.ServiceReferenceAnnonser.IServiceAdvertising>, Grup__8_Annonser.ServiceReferenceAnnonser.IServiceAdvertising {
        
        public ServiceAdvertisingClient() {
        }
        
        public ServiceAdvertisingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAdvertisingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdvertisingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAdvertisingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string DoILive() {
            return base.Channel.DoILive();
        }
        
        public System.Threading.Tasks.Task<string> DoILiveAsync() {
            return base.Channel.DoILiveAsync();
        }
        
        public Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass RndAnnons() {
            return base.Channel.RndAnnons();
        }
        
        public System.Threading.Tasks.Task<Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass> RndAnnonsAsync() {
            return base.Channel.RndAnnonsAsync();
        }
        
        public Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass GetAnnonsId(System.Nullable<int> id) {
            return base.Channel.GetAnnonsId(id);
        }
        
        public System.Threading.Tasks.Task<Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass> GetAnnonsIdAsync(System.Nullable<int> id) {
            return base.Channel.GetAnnonsIdAsync(id);
        }
        
        public Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass[] ReadAnnons() {
            return base.Channel.ReadAnnons();
        }
        
        public System.Threading.Tasks.Task<Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass[]> ReadAnnonsAsync() {
            return base.Channel.ReadAnnonsAsync();
        }
        
        public void CreateAnnons(string resource, string onHooverText) {
            base.Channel.CreateAnnons(resource, onHooverText);
        }
        
        public System.Threading.Tasks.Task CreateAnnonsAsync(string resource, string onHooverText) {
            return base.Channel.CreateAnnonsAsync(resource, onHooverText);
        }
        
        public void UpdateAnnons(Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass Update) {
            base.Channel.UpdateAnnons(Update);
        }
        
        public System.Threading.Tasks.Task UpdateAnnonsAsync(Grup__8_Annonser.ServiceReferenceAnnonser.AnnonsKlass Update) {
            return base.Channel.UpdateAnnonsAsync(Update);
        }
        
        public void DeleteAnnons(System.Nullable<int> addId) {
            base.Channel.DeleteAnnons(addId);
        }
        
        public System.Threading.Tasks.Task DeleteAnnonsAsync(System.Nullable<int> addId) {
            return base.Channel.DeleteAnnonsAsync(addId);
        }
    }
}