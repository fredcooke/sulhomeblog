﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceRoutingClient.ServVersion1Ref {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServVersion1Ref.IVersionService")]
    public interface IVersionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVersionService/GetMessage", ReplyAction="http://tempuri.org/IVersionService/GetMessageResponse")]
        string GetMessage();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVersionServiceChannel : ServiceRoutingClient.ServVersion1Ref.IVersionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VersionServiceClient : System.ServiceModel.ClientBase<ServiceRoutingClient.ServVersion1Ref.IVersionService>, ServiceRoutingClient.ServVersion1Ref.IVersionService {
        
        public VersionServiceClient() {
        }
        
        public VersionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VersionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VersionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VersionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage() {
            return base.Channel.GetMessage();
        }
    }
}
