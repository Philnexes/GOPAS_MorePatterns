﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientDemo.Brokers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Brokers.IBroker")]
    public interface IBroker {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/RegisterAddress", ReplyAction="http://tempuri.org/IBroker/RegisterAddressResponse")]
        void RegisterAddress(string id, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/RegisterAddress", ReplyAction="http://tempuri.org/IBroker/RegisterAddressResponse")]
        System.Threading.Tasks.Task RegisterAddressAsync(string id, string address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/GetAddress", ReplyAction="http://tempuri.org/IBroker/GetAddressResponse")]
        string GetAddress(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBroker/GetAddress", ReplyAction="http://tempuri.org/IBroker/GetAddressResponse")]
        System.Threading.Tasks.Task<string> GetAddressAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBrokerChannel : ClientDemo.Brokers.IBroker, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BrokerClient : System.ServiceModel.ClientBase<ClientDemo.Brokers.IBroker>, ClientDemo.Brokers.IBroker {
        
        public BrokerClient() {
        }
        
        public BrokerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BrokerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BrokerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void RegisterAddress(string id, string address) {
            base.Channel.RegisterAddress(id, address);
        }
        
        public System.Threading.Tasks.Task RegisterAddressAsync(string id, string address) {
            return base.Channel.RegisterAddressAsync(id, address);
        }
        
        public string GetAddress(string id) {
            return base.Channel.GetAddress(id);
        }
        
        public System.Threading.Tasks.Task<string> GetAddressAsync(string id) {
            return base.Channel.GetAddressAsync(id);
        }
    }
}