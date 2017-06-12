﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace ConsumeServicesCourseGradingWeb.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name StudentFirstName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertStudent", ReplyAction="*")]
        ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponse InsertStudent(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertStudent", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponse> InsertStudentAsync(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest request);
        
        // CODEGEN: Generating message contract since element name AssessType from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertAssessments", ReplyAction="*")]
        ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponse InsertAssessments(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertAssessments", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponse> InsertAssessmentsAsync(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertStudentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertStudent", Namespace="http://tempuri.org/", Order=0)]
        public ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequestBody Body;
        
        public InsertStudentRequest() {
        }
        
        public InsertStudentRequest(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertStudentRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int Sid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string StudentFirstName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StudentLastName;
        
        public InsertStudentRequestBody() {
        }
        
        public InsertStudentRequestBody(int Sid, string StudentFirstName, string StudentLastName) {
            this.Sid = Sid;
            this.StudentFirstName = StudentFirstName;
            this.StudentLastName = StudentLastName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertStudentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertStudentResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponseBody Body;
        
        public InsertStudentResponse() {
        }
        
        public InsertStudentResponse(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertStudentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertStudentResult;
        
        public InsertStudentResponseBody() {
        }
        
        public InsertStudentResponseBody(int InsertStudentResult) {
            this.InsertStudentResult = InsertStudentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertAssessmentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertAssessments", Namespace="http://tempuri.org/", Order=0)]
        public ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequestBody Body;
        
        public InsertAssessmentsRequest() {
        }
        
        public InsertAssessmentsRequest(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertAssessmentsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AID;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int SID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string AssessType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Date;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string MaxMark;
        
        public InsertAssessmentsRequestBody() {
        }
        
        public InsertAssessmentsRequestBody(int AID, int SID, string AssessType, string Date, string MaxMark) {
            this.AID = AID;
            this.SID = SID;
            this.AssessType = AssessType;
            this.Date = Date;
            this.MaxMark = MaxMark;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertAssessmentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertAssessmentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponseBody Body;
        
        public InsertAssessmentsResponse() {
        }
        
        public InsertAssessmentsResponse(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertAssessmentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertAssessmentsResult;
        
        public InsertAssessmentsResponseBody() {
        }
        
        public InsertAssessmentsResponseBody(int InsertAssessmentsResult) {
            this.InsertAssessmentsResult = InsertAssessmentsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap>, ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponse ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap.InsertStudent(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest request) {
            return base.Channel.InsertStudent(request);
        }
        
        public int InsertStudent(int Sid, string StudentFirstName, string StudentLastName) {
            ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest inValue = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest();
            inValue.Body = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequestBody();
            inValue.Body.Sid = Sid;
            inValue.Body.StudentFirstName = StudentFirstName;
            inValue.Body.StudentLastName = StudentLastName;
            ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponse retVal = ((ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap)(this)).InsertStudent(inValue);
            return retVal.Body.InsertStudentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponse> ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap.InsertStudentAsync(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest request) {
            return base.Channel.InsertStudentAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentResponse> InsertStudentAsync(int Sid, string StudentFirstName, string StudentLastName) {
            ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest inValue = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequest();
            inValue.Body = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertStudentRequestBody();
            inValue.Body.Sid = Sid;
            inValue.Body.StudentFirstName = StudentFirstName;
            inValue.Body.StudentLastName = StudentLastName;
            return ((ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap)(this)).InsertStudentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponse ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap.InsertAssessments(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest request) {
            return base.Channel.InsertAssessments(request);
        }
        
        public int InsertAssessments(int AID, int SID, string AssessType, string Date, string MaxMark) {
            ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest inValue = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest();
            inValue.Body = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequestBody();
            inValue.Body.AID = AID;
            inValue.Body.SID = SID;
            inValue.Body.AssessType = AssessType;
            inValue.Body.Date = Date;
            inValue.Body.MaxMark = MaxMark;
            ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponse retVal = ((ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap)(this)).InsertAssessments(inValue);
            return retVal.Body.InsertAssessmentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponse> ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap.InsertAssessmentsAsync(ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest request) {
            return base.Channel.InsertAssessmentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsResponse> InsertAssessmentsAsync(int AID, int SID, string AssessType, string Date, string MaxMark) {
            ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest inValue = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequest();
            inValue.Body = new ConsumeServicesCourseGradingWeb.ServiceReference1.InsertAssessmentsRequestBody();
            inValue.Body.AID = AID;
            inValue.Body.SID = SID;
            inValue.Body.AssessType = AssessType;
            inValue.Body.Date = Date;
            inValue.Body.MaxMark = MaxMark;
            return ((ConsumeServicesCourseGradingWeb.ServiceReference1.ServiceSoap)(this)).InsertAssessmentsAsync(inValue);
        }

        internal void InsertStudent()
        {
            throw new NotImplementedException();
        }
    }
}
