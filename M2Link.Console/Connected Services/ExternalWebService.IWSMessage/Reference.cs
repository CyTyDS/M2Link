﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M2Link.Console.ExternalWebService.IWSMessage {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MessageModel", Namespace="http://schemas.datacontract.org/2004/07/M2Link.WebServiceModels")]
    [System.SerializableAttribute()]
    public partial class MessageModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid MessageIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UserIdField;
        
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
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid MessageId {
            get {
                return this.MessageIdField;
            }
            set {
                if ((this.MessageIdField.Equals(value) != true)) {
                    this.MessageIdField = value;
                    this.RaisePropertyChanged("MessageId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExternalWebService.IWSMessage.IWSMessage")]
    public interface IWSMessage {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/DoWork", ReplyAction="http://tempuri.org/IWSMessage/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/DoWork", ReplyAction="http://tempuri.org/IWSMessage/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/GetMessages", ReplyAction="http://tempuri.org/IWSMessage/GetMessagesResponse")]
        M2Link.Console.ExternalWebService.IWSMessage.MessageModel[] GetMessages(System.Guid user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/GetMessages", ReplyAction="http://tempuri.org/IWSMessage/GetMessagesResponse")]
        System.Threading.Tasks.Task<M2Link.Console.ExternalWebService.IWSMessage.MessageModel[]> GetMessagesAsync(System.Guid user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/CreateMessage", ReplyAction="http://tempuri.org/IWSMessage/CreateMessageResponse")]
        M2Link.Console.ExternalWebService.IWSMessage.MessageModel CreateMessage(System.Guid user, string messageContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWSMessage/CreateMessage", ReplyAction="http://tempuri.org/IWSMessage/CreateMessageResponse")]
        System.Threading.Tasks.Task<M2Link.Console.ExternalWebService.IWSMessage.MessageModel> CreateMessageAsync(System.Guid user, string messageContent);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWSMessageChannel : M2Link.Console.ExternalWebService.IWSMessage.IWSMessage, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSMessageClient : System.ServiceModel.ClientBase<M2Link.Console.ExternalWebService.IWSMessage.IWSMessage>, M2Link.Console.ExternalWebService.IWSMessage.IWSMessage {
        
        public WSMessageClient() {
        }
        
        public WSMessageClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSMessageClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSMessageClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSMessageClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public M2Link.Console.ExternalWebService.IWSMessage.MessageModel[] GetMessages(System.Guid user) {
            return base.Channel.GetMessages(user);
        }
        
        public System.Threading.Tasks.Task<M2Link.Console.ExternalWebService.IWSMessage.MessageModel[]> GetMessagesAsync(System.Guid user) {
            return base.Channel.GetMessagesAsync(user);
        }
        
        public M2Link.Console.ExternalWebService.IWSMessage.MessageModel CreateMessage(System.Guid user, string messageContent) {
            return base.Channel.CreateMessage(user, messageContent);
        }
        
        public System.Threading.Tasks.Task<M2Link.Console.ExternalWebService.IWSMessage.MessageModel> CreateMessageAsync(System.Guid user, string messageContent) {
            return base.Channel.CreateMessageAsync(user, messageContent);
        }
    }
}
