﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace mernissServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS", ConfigurationName="mernissServiceReference.KPSPublicSoap")]
    public interface KPSPublicSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        System.Threading.Tasks.Task<mernissServiceReference.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(mernissServiceReference.TCKimlikNoDogrulaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrula", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public mernissServiceReference.TCKimlikNoDogrulaRequestBody Body;
        
        public TCKimlikNoDogrulaRequest()
        {
        }
        
        public TCKimlikNoDogrulaRequest(mernissServiceReference.TCKimlikNoDogrulaRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long TCKimlikNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int DogumYili;
        
        public TCKimlikNoDogrulaRequestBody()
        {
        }
        
        public TCKimlikNoDogrulaRequestBody(long TCKimlikNo, string Ad, string Soyad, int DogumYili)
        {
            this.TCKimlikNo = TCKimlikNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumYili = DogumYili;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public  partial class TCKimlikNoDogrulaResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrulaResponse", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public   mernissServiceReference.TCKimlikNoDogrulaResponseBody Body;
        
        public  TCKimlikNoDogrulaResponse()
        {
            
        }
        
        public TCKimlikNoDogrulaResponse(mernissServiceReference.TCKimlikNoDogrulaResponseBody Body)
        {
            this.Body = Body;
        }
       
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool TCKimlikNoDogrulaResult;
        
        public TCKimlikNoDogrulaResponseBody()
        {
        }
        
        public TCKimlikNoDogrulaResponseBody(bool TCKimlikNoDogrulaResult)
        {
            this.TCKimlikNoDogrulaResult = TCKimlikNoDogrulaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface KPSPublicSoapChannel : mernissServiceReference.KPSPublicSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class KPSPublicSoapClient : System.ServiceModel.ClientBase<mernissServiceReference.KPSPublicSoap>, mernissServiceReference.KPSPublicSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public KPSPublicSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(KPSPublicSoapClient.GetBindingForEndpoint(endpointConfiguration), KPSPublicSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KPSPublicSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(KPSPublicSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KPSPublicSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(KPSPublicSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KPSPublicSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }

        public KPSPublicSoapClient()
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<mernissServiceReference.TCKimlikNoDogrulaResponse> mernissServiceReference.KPSPublicSoap.TCKimlikNoDogrulaAsync(mernissServiceReference.TCKimlikNoDogrulaRequest request)
        {
            return base.Channel.TCKimlikNoDogrulaAsync(request);
        }
        
        public System.Threading.Tasks.Task<mernissServiceReference.TCKimlikNoDogrulaResponse> TCKimlikNoDogrula(long TCKimlikNo, string Ad, string Soyad, int DogumYili)
        {
            mernissServiceReference.TCKimlikNoDogrulaRequest inValue = new mernissServiceReference.TCKimlikNoDogrulaRequest();
            inValue.Body = new mernissServiceReference.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            return ((mernissServiceReference.KPSPublicSoap)(this)).TCKimlikNoDogrulaAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.KPSPublicSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        internal bool TCKimlikNoDogrulaAsync(long v1, string v2, string v3, int year)
        {
            throw new NotImplementedException();
        }

        public enum EndpointConfiguration
        {
            
            KPSPublicSoap,
            
            KPSPublicSoap12,
        }
    }
}
