﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grup__8_Annonser.ServiceReferenceLogin {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLogin.ILoggin")]
    public interface ILoggin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggin/GetLoginData", ReplyAction="http://tempuri.org/ILoggin/GetLoginDataResponse")]
        string GetLoginData(string Anvandarnamn, string Losenord, string LogginCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggin/GetLoginData", ReplyAction="http://tempuri.org/ILoggin/GetLoginDataResponse")]
        System.Threading.Tasks.Task<string> GetLoginDataAsync(string Anvandarnamn, string Losenord, string LogginCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggin/DoILive", ReplyAction="http://tempuri.org/ILoggin/DoILiveResponse")]
        string DoILive();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoggin/DoILive", ReplyAction="http://tempuri.org/ILoggin/DoILiveResponse")]
        System.Threading.Tasks.Task<string> DoILiveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILogginChannel : Grup__8_Annonser.ServiceReferenceLogin.ILoggin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LogginClient : System.ServiceModel.ClientBase<Grup__8_Annonser.ServiceReferenceLogin.ILoggin>, Grup__8_Annonser.ServiceReferenceLogin.ILoggin {
        
        public LogginClient() {
        }
        
        public LogginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LogginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LogginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetLoginData(string Anvandarnamn, string Losenord, string LogginCode) {
            return base.Channel.GetLoginData(Anvandarnamn, Losenord, LogginCode);
        }
        
        public System.Threading.Tasks.Task<string> GetLoginDataAsync(string Anvandarnamn, string Losenord, string LogginCode) {
            return base.Channel.GetLoginDataAsync(Anvandarnamn, Losenord, LogginCode);
        }
        
        public string DoILive() {
            return base.Channel.DoILive();
        }
        
        public System.Threading.Tasks.Task<string> DoILiveAsync() {
            return base.Channel.DoILiveAsync();
        }
    }
}
