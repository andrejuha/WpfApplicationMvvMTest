﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetalogixDemoClient.MetalogixService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyWcfItem", Namespace="http://schemas.datacontract.org/2004/07/MetalogixDemoService")]
    [System.SerializableAttribute()]
    public partial class CompanyWcfItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CompanyTypeEnumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MetalogixDemoClient.MetalogixService.CompanyTypeItem CompanyTypeItemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ContryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int CompanyTypeEnum {
            get {
                return this.CompanyTypeEnumField;
            }
            set {
                if ((this.CompanyTypeEnumField.Equals(value) != true)) {
                    this.CompanyTypeEnumField = value;
                    this.RaisePropertyChanged("CompanyTypeEnum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MetalogixDemoClient.MetalogixService.CompanyTypeItem CompanyTypeItem {
            get {
                return this.CompanyTypeItemField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyTypeItemField, value) != true)) {
                    this.CompanyTypeItemField = value;
                    this.RaisePropertyChanged("CompanyTypeItem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ContryCode {
            get {
                return this.ContryCodeField;
            }
            set {
                if ((this.ContryCodeField.Equals(value) != true)) {
                    this.ContryCodeField = value;
                    this.RaisePropertyChanged("ContryCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyTypeItem", Namespace="http://schemas.datacontract.org/2004/07/MetalogixDemoService")]
    [System.SerializableAttribute()]
    public partial class CompanyTypeItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MetalogixService.IMetalogixDemoService")]
    public interface IMetalogixDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/GetData", ReplyAction="http://tempuri.org/IMetalogixDemoService/GetDataResponse")]
        void GetData(System.Action<MetalogixDemoClient.MetalogixService.CompanyWcfItem, System.Exception> callback);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/GetData", ReplyAction="http://tempuri.org/IMetalogixDemoService/GetDataResponse")]
        System.Threading.Tasks.Task GetDataAsync(System.Action<MetalogixDemoClient.MetalogixService.CompanyWcfItem, System.Exception> callback);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/GetAllCompanies", ReplyAction="http://tempuri.org/IMetalogixDemoService/GetAllCompaniesResponse")]
        MetalogixDemoClient.MetalogixService.CompanyWcfItem[] GetAllCompanies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/GetAllCompanies", ReplyAction="http://tempuri.org/IMetalogixDemoService/GetAllCompaniesResponse")]
        System.Threading.Tasks.Task<MetalogixDemoClient.MetalogixService.CompanyWcfItem[]> GetAllCompaniesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/UpdateCompany", ReplyAction="http://tempuri.org/IMetalogixDemoService/UpdateCompanyResponse")]
        string UpdateCompany(MetalogixDemoClient.MetalogixService.CompanyWcfItem company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/UpdateCompany", ReplyAction="http://tempuri.org/IMetalogixDemoService/UpdateCompanyResponse")]
        System.Threading.Tasks.Task<string> UpdateCompanyAsync(MetalogixDemoClient.MetalogixService.CompanyWcfItem company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/AddCompany", ReplyAction="http://tempuri.org/IMetalogixDemoService/AddCompanyResponse")]
        string AddCompany(MetalogixDemoClient.MetalogixService.CompanyWcfItem company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/AddCompany", ReplyAction="http://tempuri.org/IMetalogixDemoService/AddCompanyResponse")]
        System.Threading.Tasks.Task<string> AddCompanyAsync(MetalogixDemoClient.MetalogixService.CompanyWcfItem company);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/GetCompany", ReplyAction="http://tempuri.org/IMetalogixDemoService/GetCompanyResponse")]
        MetalogixDemoClient.MetalogixService.CompanyWcfItem GetCompany(int Id, string companyName, string countryCode, string companyType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMetalogixDemoService/GetCompany", ReplyAction="http://tempuri.org/IMetalogixDemoService/GetCompanyResponse")]
        System.Threading.Tasks.Task<MetalogixDemoClient.MetalogixService.CompanyWcfItem> GetCompanyAsync(int Id, string companyName, string countryCode, string companyType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMetalogixDemoServiceChannel : MetalogixDemoClient.MetalogixService.IMetalogixDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MetalogixDemoServiceClient : System.ServiceModel.ClientBase<MetalogixDemoClient.MetalogixService.IMetalogixDemoService>, MetalogixDemoClient.MetalogixService.IMetalogixDemoService {
        
        public MetalogixDemoServiceClient() {
        }
        
        public MetalogixDemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MetalogixDemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetalogixDemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetalogixDemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetData(System.Action<MetalogixDemoClient.MetalogixService.CompanyWcfItem, System.Exception> callback) {
            base.Channel.GetData(callback);
        }
        
        public System.Threading.Tasks.Task GetDataAsync(System.Action<MetalogixDemoClient.MetalogixService.CompanyWcfItem, System.Exception> callback) {
            return base.Channel.GetDataAsync(callback);
        }
        
        public MetalogixDemoClient.MetalogixService.CompanyWcfItem[] GetAllCompanies() {
            return base.Channel.GetAllCompanies();
        }
        
        public System.Threading.Tasks.Task<MetalogixDemoClient.MetalogixService.CompanyWcfItem[]> GetAllCompaniesAsync() {
            return base.Channel.GetAllCompaniesAsync();
        }
        
        public string UpdateCompany(MetalogixDemoClient.MetalogixService.CompanyWcfItem company) {
            return base.Channel.UpdateCompany(company);
        }
        
        public System.Threading.Tasks.Task<string> UpdateCompanyAsync(MetalogixDemoClient.MetalogixService.CompanyWcfItem company) {
            return base.Channel.UpdateCompanyAsync(company);
        }
        
        public string AddCompany(MetalogixDemoClient.MetalogixService.CompanyWcfItem company) {
            return base.Channel.AddCompany(company);
        }
        
        public System.Threading.Tasks.Task<string> AddCompanyAsync(MetalogixDemoClient.MetalogixService.CompanyWcfItem company) {
            return base.Channel.AddCompanyAsync(company);
        }
        
        public MetalogixDemoClient.MetalogixService.CompanyWcfItem GetCompany(int Id, string companyName, string countryCode, string companyType) {
            return base.Channel.GetCompany(Id, companyName, countryCode, companyType);
        }
        
        public System.Threading.Tasks.Task<MetalogixDemoClient.MetalogixService.CompanyWcfItem> GetCompanyAsync(int Id, string companyName, string countryCode, string companyType) {
            return base.Channel.GetCompanyAsync(Id, companyName, countryCode, companyType);
        }
    }
}
