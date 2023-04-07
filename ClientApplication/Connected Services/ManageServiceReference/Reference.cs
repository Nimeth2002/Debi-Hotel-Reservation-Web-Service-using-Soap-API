﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.ManageServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ManageServiceReference.ManageWebServiceSoap")]
    public interface ManageWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name RoomId from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddRoom", ReplyAction="*")]
        ClientApplication.ManageServiceReference.AddRoomResponse AddRoom(ClientApplication.ManageServiceReference.AddRoomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddRoom", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientApplication.ManageServiceReference.AddRoomResponse> AddRoomAsync(ClientApplication.ManageServiceReference.AddRoomRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRoomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRoom", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplication.ManageServiceReference.AddRoomRequestBody Body;
        
        public AddRoomRequest() {
        }
        
        public AddRoomRequest(ClientApplication.ManageServiceReference.AddRoomRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRoomRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string RoomId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string RoomType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Country;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Price;
        
        public AddRoomRequestBody() {
        }
        
        public AddRoomRequestBody(string RoomId, string RoomType, string Country, string Price) {
            this.RoomId = RoomId;
            this.RoomType = RoomType;
            this.Country = Country;
            this.Price = Price;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRoomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRoomResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientApplication.ManageServiceReference.AddRoomResponseBody Body;
        
        public AddRoomResponse() {
        }
        
        public AddRoomResponse(ClientApplication.ManageServiceReference.AddRoomResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRoomResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AddRoomResult;
        
        public AddRoomResponseBody() {
        }
        
        public AddRoomResponseBody(string AddRoomResult) {
            this.AddRoomResult = AddRoomResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ManageWebServiceSoapChannel : ClientApplication.ManageServiceReference.ManageWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManageWebServiceSoapClient : System.ServiceModel.ClientBase<ClientApplication.ManageServiceReference.ManageWebServiceSoap>, ClientApplication.ManageServiceReference.ManageWebServiceSoap {
        
        public ManageWebServiceSoapClient() {
        }
        
        public ManageWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManageWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManageWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManageWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplication.ManageServiceReference.AddRoomResponse ClientApplication.ManageServiceReference.ManageWebServiceSoap.AddRoom(ClientApplication.ManageServiceReference.AddRoomRequest request) {
            return base.Channel.AddRoom(request);
        }
        
        public string AddRoom(string RoomId, string RoomType, string Country, string Price) {
            ClientApplication.ManageServiceReference.AddRoomRequest inValue = new ClientApplication.ManageServiceReference.AddRoomRequest();
            inValue.Body = new ClientApplication.ManageServiceReference.AddRoomRequestBody();
            inValue.Body.RoomId = RoomId;
            inValue.Body.RoomType = RoomType;
            inValue.Body.Country = Country;
            inValue.Body.Price = Price;
            ClientApplication.ManageServiceReference.AddRoomResponse retVal = ((ClientApplication.ManageServiceReference.ManageWebServiceSoap)(this)).AddRoom(inValue);
            return retVal.Body.AddRoomResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplication.ManageServiceReference.AddRoomResponse> ClientApplication.ManageServiceReference.ManageWebServiceSoap.AddRoomAsync(ClientApplication.ManageServiceReference.AddRoomRequest request) {
            return base.Channel.AddRoomAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ManageServiceReference.AddRoomResponse> AddRoomAsync(string RoomId, string RoomType, string Country, string Price) {
            ClientApplication.ManageServiceReference.AddRoomRequest inValue = new ClientApplication.ManageServiceReference.AddRoomRequest();
            inValue.Body = new ClientApplication.ManageServiceReference.AddRoomRequestBody();
            inValue.Body.RoomId = RoomId;
            inValue.Body.RoomType = RoomType;
            inValue.Body.Country = Country;
            inValue.Body.Price = Price;
            return ((ClientApplication.ManageServiceReference.ManageWebServiceSoap)(this)).AddRoomAsync(inValue);
        }
    }
}