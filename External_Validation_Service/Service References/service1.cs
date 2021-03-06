﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3082
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvsServiceHost.service1
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ihe.net.gazelle/", ConfigurationName="EvsServiceHost.service1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ihe.net.gazelle/IService1/Validate", ReplyAction="http://ihe.net.gazelle/IService1/ValidateResponse")]
        string Validate(string oid, string xmlReferencedStandard, string xmlValidationContext, string xmlObjectMetaData, byte[] binaryObjectData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ihe.net.gazelle/IService1/GetSummaryResults", ReplyAction="http://ihe.net.gazelle/IService1/GetSummaryResultsResponse")]
        string GetSummaryResults(string oid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ihe.net.gazelle/IService1/GetDetailedResults", ReplyAction="http://ihe.net.gazelle/IService1/GetDetailedResultsResponse")]
        string GetDetailedResults(string oid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ihe.net.gazelle/IService1/ClearResultsCache", ReplyAction="http://ihe.net.gazelle/IService1/ClearResultsCacheResponse")]
        void ClearResultsCache();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ihe.net.gazelle/IService1/GetValidationServiceStatus", ReplyAction="http://ihe.net.gazelle/IService1/GetValidationServiceStatusResponse")]
        string GetValidationServiceStatus();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IService1Channel : EvsServiceHost.service1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EvsServiceHost.service1.IService1>, EvsServiceHost.service1.IService1
    {
        
        public Service1Client()
        {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string Validate(string oid, string xmlReferencedStandard, string xmlValidationContext, string xmlObjectMetaData, byte[] binaryObjectData)
        {
            return base.Channel.Validate(oid, xmlReferencedStandard, xmlValidationContext, xmlObjectMetaData, binaryObjectData);
        }
        
        public string GetSummaryResults(string oid)
        {
            return base.Channel.GetSummaryResults(oid);
        }
        
        public string GetDetailedResults(string oid)
        {
            return base.Channel.GetDetailedResults(oid);
        }
        
        public void ClearResultsCache()
        {
            base.Channel.ClearResultsCache();
        }
        
        public string GetValidationServiceStatus()
        {
            return base.Channel.GetValidationServiceStatus();
        }
    }
}
