﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapConsumerStudentDatabase.ServiceReferenceSchool {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/AnboDatabaseSoapProviderWCF")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SemesterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Semester {
            get {
                return this.SemesterField;
            }
            set {
                if ((this.SemesterField.Equals(value) != true)) {
                    this.SemesterField = value;
                    this.RaisePropertyChanged("Semester");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSchool.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        System.Threading.Tasks.Task<SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[]> GetAllStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentById", ReplyAction="http://tempuri.org/IService1/GetStudentByIdResponse")]
        SoapConsumerStudentDatabase.ServiceReferenceSchool.Student GetStudentById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentById", ReplyAction="http://tempuri.org/IService1/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<SoapConsumerStudentDatabase.ServiceReferenceSchool.Student> GetStudentByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentsByName", ReplyAction="http://tempuri.org/IService1/GetStudentsByNameResponse")]
        SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[] GetStudentsByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStudentsByName", ReplyAction="http://tempuri.org/IService1/GetStudentsByNameResponse")]
        System.Threading.Tasks.Task<SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[]> GetStudentsByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        int AddStudent(string name, byte semester);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task<int> AddStudentAsync(string name, byte semester);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SoapConsumerStudentDatabase.ServiceReferenceSchool.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SoapConsumerStudentDatabase.ServiceReferenceSchool.IService1>, SoapConsumerStudentDatabase.ServiceReferenceSchool.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task<SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[]> GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
        
        public SoapConsumerStudentDatabase.ServiceReferenceSchool.Student GetStudentById(int id) {
            return base.Channel.GetStudentById(id);
        }
        
        public System.Threading.Tasks.Task<SoapConsumerStudentDatabase.ServiceReferenceSchool.Student> GetStudentByIdAsync(int id) {
            return base.Channel.GetStudentByIdAsync(id);
        }
        
        public SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[] GetStudentsByName(string name) {
            return base.Channel.GetStudentsByName(name);
        }
        
        public System.Threading.Tasks.Task<SoapConsumerStudentDatabase.ServiceReferenceSchool.Student[]> GetStudentsByNameAsync(string name) {
            return base.Channel.GetStudentsByNameAsync(name);
        }
        
        public int AddStudent(string name, byte semester) {
            return base.Channel.AddStudent(name, semester);
        }
        
        public System.Threading.Tasks.Task<int> AddStudentAsync(string name, byte semester) {
            return base.Channel.AddStudentAsync(name, semester);
        }
    }
}