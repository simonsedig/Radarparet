﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skolskjuts_etjanst.BookingServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bookings", Namespace="http://schemas.datacontract.org/2004/07/Skolskjuts_etjanst")]
    [System.SerializableAttribute()]
    public partial class Bookings : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookingServiceReference.IBookingService")]
    public interface IBookingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/RetrieveAllBookings", ReplyAction="http://tempuri.org/IBookingService/RetrieveAllBookingsResponse")]
        Skolskjuts_etjanst.BookingServiceReference.Bookings[] RetrieveAllBookings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookingService/RetrieveAllBookings", ReplyAction="http://tempuri.org/IBookingService/RetrieveAllBookingsResponse")]
        System.Threading.Tasks.Task<Skolskjuts_etjanst.BookingServiceReference.Bookings[]> RetrieveAllBookingsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookingServiceChannel : Skolskjuts_etjanst.BookingServiceReference.IBookingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookingServiceClient : System.ServiceModel.ClientBase<Skolskjuts_etjanst.BookingServiceReference.IBookingService>, Skolskjuts_etjanst.BookingServiceReference.IBookingService {
        
        public BookingServiceClient() {
        }
        
        public BookingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Skolskjuts_etjanst.BookingServiceReference.Bookings[] RetrieveAllBookings() {
            return base.Channel.RetrieveAllBookings();
        }
        
        public System.Threading.Tasks.Task<Skolskjuts_etjanst.BookingServiceReference.Bookings[]> RetrieveAllBookingsAsync() {
            return base.Channel.RetrieveAllBookingsAsync();
        }
    }
}
