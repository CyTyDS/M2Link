﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M2LinkXamarin.WebService.Clients
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://schemas.datacontract.org/2004/07/M2Link.WebServiceModels")]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string PseudoField;
        
        private System.Guid UserIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pseudo
        {
            get
            {
                return this.PseudoField;
            }
            set
            {
                this.PseudoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="M2LinkXamarin.WebService.Clients.IWSLogin")]
    public interface IWSLogin
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSLogin/DoWork", ReplyAction="http://tempuri.org/IWSLogin/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSLogin/DoWork", ReplyAction="http://tempuri.org/IWSLogin/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSLogin/HelloWorld", ReplyAction="http://tempuri.org/IWSLogin/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSLogin/HelloWorld", ReplyAction="http://tempuri.org/IWSLogin/HelloWorldResponse")]
        System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState);
        
        string EndHelloWorld(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSLogin/Validate", ReplyAction="http://tempuri.org/IWSLogin/ValidateResponse")]
        M2LinkXamarin.WebService.Clients.UserModel Validate(string nom, string mdp);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IWSLogin/Validate", ReplyAction="http://tempuri.org/IWSLogin/ValidateResponse")]
        System.IAsyncResult BeginValidate(string nom, string mdp, System.AsyncCallback callback, object asyncState);
        
        M2LinkXamarin.WebService.Clients.UserModel EndValidate(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSLoginChannel : M2LinkXamarin.WebService.Clients.IWSLogin, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSLoginClient : System.ServiceModel.ClientBase<M2LinkXamarin.WebService.Clients.IWSLogin>, M2LinkXamarin.WebService.Clients.IWSLogin
    {
        
        public WSLoginClient()
        {
        }
        
        public WSLoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public WSLoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public WSLoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public WSLoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void DoWork()
        {
            base.Channel.DoWork();
        }
        
        public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        public void EndDoWork(System.IAsyncResult result)
        {
            base.Channel.EndDoWork(result);
        }
        
        public string HelloWorld()
        {
            return base.Channel.HelloWorld();
        }
        
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginHelloWorld(callback, asyncState);
        }
        
        public string EndHelloWorld(System.IAsyncResult result)
        {
            return base.Channel.EndHelloWorld(result);
        }
        
        public M2LinkXamarin.WebService.Clients.UserModel Validate(string nom, string mdp)
        {
            return base.Channel.Validate(nom, mdp);
        }
        
        public System.IAsyncResult BeginValidate(string nom, string mdp, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginValidate(nom, mdp, callback, asyncState);
        }
        
        public M2LinkXamarin.WebService.Clients.UserModel EndValidate(System.IAsyncResult result)
        {
            return base.Channel.EndValidate(result);
        }
    }
}