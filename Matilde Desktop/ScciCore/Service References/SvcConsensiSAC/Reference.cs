﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnicodeSrl.ScciCore.SvcConsensiSAC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SvcConsensiSAC.IScciConsensiSAC")]
    public interface IScciConsensiSAC {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScciConsensiSAC/AggiungiConsenso", ReplyAction="http://tempuri.org/IScciConsensiSAC/AggiungiConsensoResponse")]
        string AggiungiConsenso(string idsac, string pazientecognome, string pazientenome, string pazientecodicefiscale, string operatoreid, string operatorecognome, string operatorenome, string operatorecomputer, string tipoconsenso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IScciConsensiSACChannel : UnicodeSrl.ScciCore.SvcConsensiSAC.IScciConsensiSAC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ScciConsensiSACClient : System.ServiceModel.ClientBase<UnicodeSrl.ScciCore.SvcConsensiSAC.IScciConsensiSAC>, UnicodeSrl.ScciCore.SvcConsensiSAC.IScciConsensiSAC {
        
        public ScciConsensiSACClient() {
        }
        
        public ScciConsensiSACClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ScciConsensiSACClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScciConsensiSACClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ScciConsensiSACClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AggiungiConsenso(string idsac, string pazientecognome, string pazientenome, string pazientecodicefiscale, string operatoreid, string operatorecognome, string operatorenome, string operatorecomputer, string tipoconsenso) {
            return base.Channel.AggiungiConsenso(idsac, pazientecognome, pazientenome, pazientecodicefiscale, operatoreid, operatorecognome, operatorenome, operatorecomputer, tipoconsenso);
        }
    }
}
