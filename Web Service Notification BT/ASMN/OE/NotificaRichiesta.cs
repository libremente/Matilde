﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.0.30319.1.
// 
namespace UnicodeSrl.ASMN.WebNotificationService.OE
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "BasicHttpBinding_IService", Namespace = "http://schemas.progel.it/WCF/OE/RichiestaEroganteGenerico/1.0")]
    public interface IBasicHttpBinding_INotificaRichiesta
    {

        /// <remarks/>
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://schemas.progel.it/WCF/OE/RichiestaEroganteGenerico/1.0/IService/ListenData" +
            "", RequestNamespace = "http://schemas.progel.it/WCF/OE/RichiestaEroganteGenerico/1.0", ResponseNamespace = "http://schemas.progel.it/WCF/OE/RichiestaEroganteGenerico/1.0", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        void ListenData([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] RichiestaType value);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class RichiestaType
    {

        private string idRichiestaOrderEntryField;

        private System.Nullable<System.DateTime> dataVersioneField;

        private string idRichiestaRichiedenteField;

        private SistemaType sistemaRichiedenteField;

        private StrutturaType unitaOperativaRichiedenteField;

        private SistemaType sistemaEroganteField;

        private string numeroNosologicoField;

        private CodiceDescrizioneType regimeField;

        private System.DateTime dataRichiestaField;

        private string operazioneOrderEntryField;

        private System.Nullable<System.DateTime> dataPrenotazioneField;

        private bool dataPrenotazioneFieldSpecified;

        private OperatoreType operatoreField;

        private CodiceDescrizioneType prioritaField;

        private PazienteType pazienteField;

        private string noteField;

        private ConsensoType[] consensiField;

        private DatoNomeValoreType[] datiAggiuntiviField;

        private DatoNomeValoreType[] datiPersistentiField;

        private RigaRichiestaType[] righeRichiesteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRichiestaOrderEntry
        {
            get
            {
                return this.idRichiestaOrderEntryField;
            }
            set
            {
                this.idRichiestaOrderEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> DataVersione
        {
            get
            {
                return this.dataVersioneField;
            }
            set
            {
                this.dataVersioneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRichiestaRichiedente
        {
            get
            {
                return this.idRichiestaRichiedenteField;
            }
            set
            {
                this.idRichiestaRichiedenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SistemaType SistemaRichiedente
        {
            get
            {
                return this.sistemaRichiedenteField;
            }
            set
            {
                this.sistemaRichiedenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public StrutturaType UnitaOperativaRichiedente
        {
            get
            {
                return this.unitaOperativaRichiedenteField;
            }
            set
            {
                this.unitaOperativaRichiedenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public SistemaType SistemaErogante
        {
            get
            {
                return this.sistemaEroganteField;
            }
            set
            {
                this.sistemaEroganteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string NumeroNosologico
        {
            get
            {
                return this.numeroNosologicoField;
            }
            set
            {
                this.numeroNosologicoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CodiceDescrizioneType Regime
        {
            get
            {
                return this.regimeField;
            }
            set
            {
                this.regimeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DataRichiesta
        {
            get
            {
                return this.dataRichiestaField;
            }
            set
            {
                this.dataRichiestaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OperazioneOrderEntry
        {
            get
            {
                return this.operazioneOrderEntryField;
            }
            set
            {
                this.operazioneOrderEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> DataPrenotazione
        {
            get
            {
                return this.dataPrenotazioneField;
            }
            set
            {
                this.dataPrenotazioneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataPrenotazioneSpecified
        {
            get
            {
                return this.dataPrenotazioneFieldSpecified;
            }
            set
            {
                this.dataPrenotazioneFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OperatoreType Operatore
        {
            get
            {
                return this.operatoreField;
            }
            set
            {
                this.operatoreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CodiceDescrizioneType Priorita
        {
            get
            {
                return this.prioritaField;
            }
            set
            {
                this.prioritaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public PazienteType Paziente
        {
            get
            {
                return this.pazienteField;
            }
            set
            {
                this.pazienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Consenso")]
        public ConsensoType[] Consensi
        {
            get
            {
                return this.consensiField;
            }
            set
            {
                this.consensiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DatoAggiuntivo")]
        public DatoNomeValoreType[] DatiAggiuntivi
        {
            get
            {
                return this.datiAggiuntiviField;
            }
            set
            {
                this.datiAggiuntiviField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DatoPersistente")]
        public DatoNomeValoreType[] DatiPersistenti
        {
            get
            {
                return this.datiPersistentiField;
            }
            set
            {
                this.datiPersistentiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RigaRichiesta")]
        public RigaRichiestaType[] RigheRichieste
        {
            get
            {
                return this.righeRichiesteField;
            }
            set
            {
                this.righeRichiesteField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class SistemaType
    {

        private CodiceDescrizioneType aziendaField;

        private CodiceDescrizioneType sistemaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CodiceDescrizioneType Azienda
        {
            get
            {
                return this.aziendaField;
            }
            set
            {
                this.aziendaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CodiceDescrizioneType Sistema
        {
            get
            {
                return this.sistemaField;
            }
            set
            {
                this.sistemaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class CodiceDescrizioneType
    {

        private string codiceField;

        private string descrizioneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Codice
        {
            get
            {
                return this.codiceField;
            }
            set
            {
                this.codiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Descrizione
        {
            get
            {
                return this.descrizioneField;
            }
            set
            {
                this.descrizioneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class PrestazioneType
    {

        private string codiceField;

        private string descrizioneField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Codice
        {
            get
            {
                return this.codiceField;
            }
            set
            {
                this.codiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Descrizione
        {
            get
            {
                return this.descrizioneField;
            }
            set
            {
                this.descrizioneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class RigaRichiestaType
    {

        private string idRigaOrderEntryField;

        private string operazioneOrderEntryField;

        private string idRigaRichiedenteField;

        private string idRigaEroganteField;

        private string idRichiestaEroganteField;

        private PrestazioneType prestazioneField;

        private ConsensoType[] consensiField;

        private DatoNomeValoreType[] datiAggiuntiviField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRigaOrderEntry
        {
            get
            {
                return this.idRigaOrderEntryField;
            }
            set
            {
                this.idRigaOrderEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string OperazioneOrderEntry
        {
            get
            {
                return this.operazioneOrderEntryField;
            }
            set
            {
                this.operazioneOrderEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRigaRichiedente
        {
            get
            {
                return this.idRigaRichiedenteField;
            }
            set
            {
                this.idRigaRichiedenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRigaErogante
        {
            get
            {
                return this.idRigaEroganteField;
            }
            set
            {
                this.idRigaEroganteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRichiestaErogante
        {
            get
            {
                return this.idRichiestaEroganteField;
            }
            set
            {
                this.idRichiestaEroganteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public PrestazioneType Prestazione
        {
            get
            {
                return this.prestazioneField;
            }
            set
            {
                this.prestazioneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Consenso")]
        public ConsensoType[] Consensi
        {
            get
            {
                return this.consensiField;
            }
            set
            {
                this.consensiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DatoAggiuntivo")]
        public DatoNomeValoreType[] DatiAggiuntivi
        {
            get
            {
                return this.datiAggiuntiviField;
            }
            set
            {
                this.datiAggiuntiviField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class ConsensoType
    {

        private string tipoField;

        private bool valoreField;

        private System.DateTime dataField;

        private bool dataFieldSpecified;

        private OperatoreType operatoreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        /// <remarks/>
        public bool Valore
        {
            get
            {
                return this.valoreField;
            }
            set
            {
                this.valoreField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataSpecified
        {
            get
            {
                return this.dataFieldSpecified;
            }
            set
            {
                this.dataFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public OperatoreType Operatore
        {
            get
            {
                return this.operatoreField;
            }
            set
            {
                this.operatoreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class OperatoreType
    {

        private string idField;

        private string cognomeField;

        private string nomeField;

        private string codiceFiscaleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Cognome
        {
            get
            {
                return this.cognomeField;
            }
            set
            {
                this.cognomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceFiscale
        {
            get
            {
                return this.codiceFiscaleField;
            }
            set
            {
                this.codiceFiscaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class DatoNomeValoreType
    {

        private string idField;

        private string nomeField;

        private string tipoDatoField;

        private string tipoContenutoField;

        private string valoreDatoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TipoDato
        {
            get
            {
                return this.tipoDatoField;
            }
            set
            {
                this.tipoDatoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TipoContenuto
        {
            get
            {
                return this.tipoContenutoField;
            }
            set
            {
                this.tipoContenutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ValoreDato
        {
            get
            {
                return this.valoreDatoField;
            }
            set
            {
                this.valoreDatoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class PazienteType
    {

        private string idRichiedenteField;

        private string idSacField;

        private string anagraficaCodiceField;

        private string anagraficaNomeField;

        private string codiceFiscaleField;

        private string cognomeField;

        private string nomeField;

        private System.Nullable<System.DateTime> dataNascitaField;

        private bool dataNascitaFieldSpecified;

        private string comuneNascitaField;

        private string codiceIstatComuneNascitaField;

        private string sessoField;

        private string indirizzoResidenzaField;

        private string comuneResidenzaField;

        private string codiceIstatComuneResidenzaField;

        private string capResidenzaField;

        private string nazionalitaField;

        private string codiceIstatNazionalitaField;

        private string cittadinanzaField;

        private string codiceIstatCittadinanzaField;

        private System.DateTime dataModificaField;

        private bool dataModificaFieldSpecified;

        private string tesseraSanitariaField;

        private string codiceUslField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdRichiedente
        {
            get
            {
                return this.idRichiedenteField;
            }
            set
            {
                this.idRichiedenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IdSac
        {
            get
            {
                return this.idSacField;
            }
            set
            {
                this.idSacField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AnagraficaCodice
        {
            get
            {
                return this.anagraficaCodiceField;
            }
            set
            {
                this.anagraficaCodiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string AnagraficaNome
        {
            get
            {
                return this.anagraficaNomeField;
            }
            set
            {
                this.anagraficaNomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceFiscale
        {
            get
            {
                return this.codiceFiscaleField;
            }
            set
            {
                this.codiceFiscaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Cognome
        {
            get
            {
                return this.cognomeField;
            }
            set
            {
                this.cognomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Nome
        {
            get
            {
                return this.nomeField;
            }
            set
            {
                this.nomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> DataNascita
        {
            get
            {
                return this.dataNascitaField;
            }
            set
            {
                this.dataNascitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataNascitaSpecified
        {
            get
            {
                return this.dataNascitaFieldSpecified;
            }
            set
            {
                this.dataNascitaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ComuneNascita
        {
            get
            {
                return this.comuneNascitaField;
            }
            set
            {
                this.comuneNascitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceIstatComuneNascita
        {
            get
            {
                return this.codiceIstatComuneNascitaField;
            }
            set
            {
                this.codiceIstatComuneNascitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Sesso
        {
            get
            {
                return this.sessoField;
            }
            set
            {
                this.sessoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string IndirizzoResidenza
        {
            get
            {
                return this.indirizzoResidenzaField;
            }
            set
            {
                this.indirizzoResidenzaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string ComuneResidenza
        {
            get
            {
                return this.comuneResidenzaField;
            }
            set
            {
                this.comuneResidenzaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceIstatComuneResidenza
        {
            get
            {
                return this.codiceIstatComuneResidenzaField;
            }
            set
            {
                this.codiceIstatComuneResidenzaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CapResidenza
        {
            get
            {
                return this.capResidenzaField;
            }
            set
            {
                this.capResidenzaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Nazionalita
        {
            get
            {
                return this.nazionalitaField;
            }
            set
            {
                this.nazionalitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceIstatNazionalita
        {
            get
            {
                return this.codiceIstatNazionalitaField;
            }
            set
            {
                this.codiceIstatNazionalitaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Cittadinanza
        {
            get
            {
                return this.cittadinanzaField;
            }
            set
            {
                this.cittadinanzaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceIstatCittadinanza
        {
            get
            {
                return this.codiceIstatCittadinanzaField;
            }
            set
            {
                this.codiceIstatCittadinanzaField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DataModifica
        {
            get
            {
                return this.dataModificaField;
            }
            set
            {
                this.dataModificaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataModificaSpecified
        {
            get
            {
                return this.dataModificaFieldSpecified;
            }
            set
            {
                this.dataModificaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string TesseraSanitaria
        {
            get
            {
                return this.tesseraSanitariaField;
            }
            set
            {
                this.tesseraSanitariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string CodiceUsl
        {
            get
            {
                return this.codiceUslField;
            }
            set
            {
                this.codiceUslField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.progel.it/WCF/OE/EroganteGenericoTypes/1.1")]
    public partial class StrutturaType
    {

        private CodiceDescrizioneType aziendaField;

        private CodiceDescrizioneType unitaOperativaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CodiceDescrizioneType Azienda
        {
            get
            {
                return this.aziendaField;
            }
            set
            {
                this.aziendaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CodiceDescrizioneType UnitaOperativa
        {
            get
            {
                return this.unitaOperativaField;
            }
            set
            {
                this.unitaOperativaField = value;
            }
        }
    }


}
