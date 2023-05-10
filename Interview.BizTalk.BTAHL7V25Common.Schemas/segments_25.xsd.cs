namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X/2.5/Segments",@"HL7DefinedSegments")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HL7DefinedSegments"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAHL7Schemas.datatypes_25", typeof(global::BTAHL7Schemas.datatypes_25))]
    public sealed class segments_25 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X/2.5/Segments"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://microsoft.com/HealthCare/HL7/2X/2.5/DataTypes"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5/Segments"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BTAHL7Schemas.datatypes_25"" namespace=""http://microsoft.com/HealthCare/HL7/2X/2.5/DataTypes"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standards_version=""HL7.DBVersion.1_5"" document_type=""HL7 2X Schema"" version=""2.0.0104.0.2.0"" root_reference=""HL7DefinedSegments"" />
      <b:references>
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5/DataTypes"" />
        <b:reference targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5/Tables"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""HL7DefinedSegments"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ABS"" type=""ABS"" />
        <xs:element name=""ACC"" type=""ACC"" />
        <xs:element name=""ADD"" type=""ADD"" />
        <xs:element name=""AFF"" type=""AFF"" />
        <xs:element name=""AIG"" type=""AIG"" />
        <xs:element name=""AIL"" type=""AIL"" />
        <xs:element name=""AIP"" type=""AIP"" />
        <xs:element name=""AIS"" type=""AIS"" />
        <xs:element name=""AL1"" type=""AL1"" />
        <xs:element name=""APR"" type=""APR"" />
        <xs:element name=""ARQ"" type=""ARQ"" />
        <xs:element name=""AUT"" type=""AUT"" />
        <xs:element name=""BLC"" type=""BLC"" />
        <xs:element name=""BLG"" type=""BLG"" />
        <xs:element name=""BPO"" type=""BPO"" />
        <xs:element name=""BPX"" type=""BPX"" />
        <xs:element name=""BTX"" type=""BTX"" />
        <xs:element name=""CDM"" type=""CDM"" />
        <xs:element name=""CER"" type=""CER"" />
        <xs:element name=""CM0"" type=""CM0"" />
        <xs:element name=""CM1"" type=""CM1"" />
        <xs:element name=""CM2"" type=""CM2"" />
        <xs:element name=""CNS"" type=""CNS"" />
        <xs:element name=""CON"" type=""CON"" />
        <xs:element name=""CSP"" type=""CSP"" />
        <xs:element name=""CSR"" type=""CSR"" />
        <xs:element name=""CSS"" type=""CSS"" />
        <xs:element name=""CTD"" type=""CTD"" />
        <xs:element name=""CTI"" type=""CTI"" />
        <xs:element name=""DB1"" type=""DB1"" />
        <xs:element name=""DG1"" type=""DG1"" />
        <xs:element name=""DRG"" type=""DRG"" />
        <xs:element name=""DSC"" type=""DSC"" />
        <xs:element name=""DSP"" type=""DSP"" />
        <xs:element name=""ECD"" type=""ECD"" />
        <xs:element name=""ECR"" type=""ECR"" />
        <xs:element name=""EDU"" type=""EDU"" />
        <xs:element name=""EQL"" type=""EQL"" />
        <xs:element name=""EQP"" type=""EQP"" />
        <xs:element name=""EQU"" type=""EQU"" />
        <xs:element name=""ERQ"" type=""ERQ"" />
        <xs:element name=""ERR"" type=""ERR"" />
        <xs:element name=""EVN"" type=""EVN"" />
        <xs:element name=""FAC"" type=""FAC"" />
        <xs:element name=""FT1"" type=""FT1"" />
        <xs:element name=""GOL"" type=""GOL"" />
        <xs:element name=""GP1"" type=""GP1"" />
        <xs:element name=""GP2"" type=""GP2"" />
        <xs:element name=""GT1"" type=""GT1"" />
        <xs:element name=""IAM"" type=""IAM"" />
        <xs:element name=""IIM"" type=""IIM"" />
        <xs:element name=""IN1"" type=""IN1"" />
        <xs:element name=""IN2"" type=""IN2"" />
        <xs:element name=""IN3"" type=""IN3"" />
        <xs:element name=""INV"" type=""INV"" />
        <xs:element name=""IPC"" type=""IPC"" />
        <xs:element name=""ISD"" type=""ISD"" />
        <xs:element name=""LAN"" type=""LAN"" />
        <xs:element name=""LCC"" type=""LCC"" />
        <xs:element name=""LCH"" type=""LCH"" />
        <xs:element name=""LDP"" type=""LDP"" />
        <xs:element name=""LOC"" type=""LOC"" />
        <xs:element name=""LRL"" type=""LRL"" />
        <xs:element name=""MFA"" type=""MFA"" />
        <xs:element name=""MFE"" type=""MFE"" />
        <xs:element name=""MFI"" type=""MFI"" />
        <xs:element name=""MRG"" type=""MRG"" />
        <xs:element name=""MSA"" type=""MSA"" />
        <xs:element name=""NCK"" type=""NCK"" />
        <xs:element name=""NDS"" type=""NDS"" />
        <xs:element name=""NK1"" type=""NK1"" />
        <xs:element name=""NPU"" type=""NPU"" />
        <xs:element name=""NSC"" type=""NSC"" />
        <xs:element name=""NST"" type=""NST"" />
        <xs:element name=""NTE"" type=""NTE"" />
        <xs:element name=""OBR"" type=""OBR"" />
        <xs:element name=""OBX"" type=""OBX"" />
        <xs:element name=""ODS"" type=""ODS"" />
        <xs:element name=""ODT"" type=""ODT"" />
        <xs:element name=""OM1"" type=""OM1"" />
        <xs:element name=""OM2"" type=""OM2"" />
        <xs:element name=""OM3"" type=""OM3"" />
        <xs:element name=""OM4"" type=""OM4"" />
        <xs:element name=""OM5"" type=""OM5"" />
        <xs:element name=""OM6"" type=""OM6"" />
        <xs:element name=""OM7"" type=""OM7"" />
        <xs:element name=""ORC"" type=""ORC"" />
        <xs:element name=""ORG"" type=""ORG"" />
        <xs:element name=""OVR"" type=""OVR"" />
        <xs:element name=""PCR"" type=""PCR"" />
        <xs:element name=""PD1"" type=""PD1"" />
        <xs:element name=""PDA"" type=""PDA"" />
        <xs:element name=""PDC"" type=""PDC"" />
        <xs:element name=""PEO"" type=""PEO"" />
        <xs:element name=""PES"" type=""PES"" />
        <xs:element name=""PID"" type=""PID"" />
        <xs:element name=""PR1"" type=""PR1"" />
        <xs:element name=""PRA"" type=""PRA"" />
        <xs:element name=""PRB"" type=""PRB"" />
        <xs:element name=""PRC"" type=""PRC"" />
        <xs:element name=""PRD"" type=""PRD"" />
        <xs:element name=""PSH"" type=""PSH"" />
        <xs:element name=""PTH"" type=""PTH"" />
        <xs:element name=""PV1"" type=""PV1"" />
        <xs:element name=""PV2"" type=""PV2"" />
        <xs:element name=""QAK"" type=""QAK"" />
        <xs:element name=""QID"" type=""QID"" />
        <xs:element name=""QPD"" type=""QPD"" />
        <xs:element name=""QRD"" type=""QRD"" />
        <xs:element name=""QRF"" type=""QRF"" />
        <xs:element name=""QRI"" type=""QRI"" />
        <xs:element name=""RCP"" type=""RCP"" />
        <xs:element name=""RDF"" type=""RDF"" />
        <xs:element name=""RDT"" type=""RDT"" />
        <xs:element name=""RF1"" type=""RF1"" />
        <xs:element name=""RGS"" type=""RGS"" />
        <xs:element name=""RMI"" type=""RMI"" />
        <xs:element name=""ROL"" type=""ROL"" />
        <xs:element name=""RQ1"" type=""RQ1"" />
        <xs:element name=""RQD"" type=""RQD"" />
        <xs:element name=""RXA"" type=""RXA"" />
        <xs:element name=""RXC"" type=""RXC"" />
        <xs:element name=""RXD"" type=""RXD"" />
        <xs:element name=""RXE"" type=""RXE"" />
        <xs:element name=""RXG"" type=""RXG"" />
        <xs:element name=""RXO"" type=""RXO"" />
        <xs:element name=""RXR"" type=""RXR"" />
        <xs:element name=""SAC"" type=""SAC"" />
        <xs:element name=""SCH"" type=""SCH"" />
        <xs:element name=""SFT"" type=""SFT"" />
        <xs:element name=""SID"" type=""SID"" />
        <xs:element name=""SPM"" type=""SPM"" />
        <xs:element name=""SPR"" type=""SPR"" />
        <xs:element name=""STF"" type=""STF"" />
        <xs:element name=""TCC"" type=""TCC"" />
        <xs:element name=""TCD"" type=""TCD"" />
        <xs:element name=""TQ1"" type=""TQ1"" />
        <xs:element name=""TQ2"" type=""TQ2"" />
        <xs:element name=""TXA"" type=""TXA"" />
        <xs:element name=""UB1"" type=""UB1"" />
        <xs:element name=""UB2"" type=""UB2"" />
        <xs:element name=""URD"" type=""URD"" />
        <xs:element name=""URS"" type=""URS"" />
        <xs:element name=""VAR"" type=""VAR"" />
        <xs:element name=""VTQ"" type=""VTQ"" />
        <xs:element name=""HXX"" type=""HXX"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""ABS"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ABS_1_DischargeCareProvider"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" name=""ABS_2_TransferMedicalServiceCode"" type=""ns0:CE_69"" />
      <xs:element minOccurs=""0"" name=""ABS_3_SeverityOfIllnessCode"" type=""ns0:CE_421"" />
      <xs:element minOccurs=""0"" name=""ABS_4_DateTimeOfAttestation"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ABS_5_AttestedBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""ABS_6_TriageCode"" type=""ns0:CE_422"" />
      <xs:element minOccurs=""0"" name=""ABS_7_AbstractCompletionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ABS_8_AbstractedBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""ABS_9_CaseCategoryCode"" type=""ns0:CE_423"" />
      <xs:element minOccurs=""0"" name=""ABS_10_CaesarianSectionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ABS_11_GestationCategoryCode"" type=""ns0:CE_424"" />
      <xs:element minOccurs=""0"" name=""ABS_12_GestationPeriodWeeks"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""ABS_13_NewbornCode"" type=""ns0:CE_425"" />
      <xs:element minOccurs=""0"" name=""ABS_14_StillbornIndicator"" type=""ns0:ID_136"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ACC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ACC_1_AccidentDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ACC_2_AccidentCode"" type=""ns0:CE_50"" />
      <xs:element minOccurs=""0"" name=""ACC_3_AccidentLocation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""ACC_4_AutoAccidentState"" type=""ns0:CE_347"" />
      <xs:element minOccurs=""0"" name=""ACC_5_AccidentJobRelatedIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ACC_6_AccidentDeathIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ACC_7_EnteredBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""ACC_8_AccidentDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""ACC_9_BroughtInBy"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""ACC_10_PoliceNotifiedIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ACC_11_AccidentAddress"" type=""ns0:XAD"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ADD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ADD_1_AddendumContinuationPointer"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AFF"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""AFF_1_SetId_Aff"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""AFF_2_ProfessionalOrganization"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""AFF_3_ProfessionalOrganizationAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AFF_4_ProfessionalOrganizationAffiliationDateRange"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""AFF_5_ProfessionalAffiliationAdditionalInformation"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AIG"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""AIG_1_SetIdAig"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""AIG_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""0"" name=""AIG_3_ResourceId"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""AIG_4_ResourceType"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AIG_5_ResourceGroup"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIG_6_ResourceQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIG_7_ResourceQuantityUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIG_8_StartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""AIG_9_StartDateTimeOffset"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIG_10_StartDateTimeOffsetUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIG_11_Duration"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIG_12_DurationUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIG_13_AllowSubstitutionCode"" type=""ns0:IS_279"" />
      <xs:element minOccurs=""0"" name=""AIG_14_FillerStatusCode"" type=""ns0:CE_278"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AIL"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""AIL_1_SetIdAil"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""AIL_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AIL_3_LocationResourceId"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""AIL_4_LocationTypeAil"" type=""ns0:CE_305"" />
      <xs:element minOccurs=""0"" name=""AIL_5_LocationGroup"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIL_6_StartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""AIL_7_StartDateTimeOffset"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIL_8_StartDateTimeOffsetUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIL_9_Duration"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIL_10_DurationUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIL_11_AllowSubstitutionCode"" type=""ns0:IS_279"" />
      <xs:element minOccurs=""0"" name=""AIL_12_FillerStatusCode"" type=""ns0:CE_278"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AIP"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""AIP_1_SetIdAip"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""AIP_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AIP_3_PersonnelResourceId"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""AIP_4_ResourceType"" type=""ns0:CE_182"" />
      <xs:element minOccurs=""0"" name=""AIP_5_ResourceGroup"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIP_6_StartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""AIP_7_StartDateTimeOffset"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIP_8_StartDateTimeOffsetUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIP_9_Duration"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIP_10_DurationUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIP_11_AllowSubstitutionCode"" type=""ns0:IS_279"" />
      <xs:element minOccurs=""0"" name=""AIP_12_FillerStatusCode"" type=""ns0:CE_278"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AIS"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""AIS_1_SetIdAis"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""AIS_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""1"" name=""AIS_3_UniversalServiceIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIS_4_StartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""AIS_5_StartDateTimeOffset"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIS_6_StartDateTimeOffsetUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIS_7_Duration"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AIS_8_DurationUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AIS_9_AllowSubstitutionCode"" type=""ns0:IS_279"" />
      <xs:element minOccurs=""0"" name=""AIS_10_FillerStatusCode"" type=""ns0:CE_278"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AIS_11_PlacerSupplementalServiceInformation"" type=""ns0:CE_411"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AIS_12_FillerSupplementalServiceInformation"" type=""ns0:CE_411"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AL1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""AL1_1_SetIdAl1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""AL1_2_AllergenTypeCode"" type=""ns0:CE_127"" />
      <xs:element minOccurs=""1"" name=""AL1_3_AllergenCodeMnemonicDescription"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""AL1_4_AllergySeverityCode"" type=""ns0:CE_128"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AL1_5_AllergyReactionCode"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""AL1_6_IdentificationDate"" type=""ns0:DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""APR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""APR_1_TimeSelectionCriteria"" type=""ns0:SCV_294"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""APR_2_ResourceSelectionCriteria"" type=""ns0:SCV_294"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""APR_3_LocationSelectionCriteria"" type=""ns0:SCV_294"" />
      <xs:element minOccurs=""0"" name=""APR_4_SlotSpacingCriteria"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""APR_5_FillerOverrideCriteria"" type=""ns0:SCV"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ARQ"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ARQ_1_PlacerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ARQ_2_FillerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ARQ_3_OccurrenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""ARQ_4_PlacerGroupNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ARQ_5_ScheduleId"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ARQ_6_RequestEventReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ARQ_7_AppointmentReason"" type=""ns0:CE_276"" />
      <xs:element minOccurs=""0"" name=""ARQ_8_AppointmentType"" type=""ns0:CE_277"" />
      <xs:element minOccurs=""0"" name=""ARQ_9_AppointmentDuration"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""ARQ_10_AppointmentDurationUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ARQ_11_RequestedStartDateTimeRange"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""ARQ_12_PriorityArq"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""ARQ_13_RepeatingInterval"" type=""ns0:RI"" />
      <xs:element minOccurs=""0"" name=""ARQ_14_RepeatingIntervalDuration"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ARQ_15_PlacerContactPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ARQ_16_PlacerContactPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ARQ_17_PlacerContactAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""ARQ_18_PlacerContactLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ARQ_19_EnteredByPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ARQ_20_EnteredByPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""ARQ_21_EnteredByLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""ARQ_22_ParentPlacerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ARQ_23_ParentFillerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ARQ_24_PlacerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ARQ_25_FillerOrderNumber"" type=""ns0:EI"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AUT"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""AUT_1_AuthorizingPayorPlanId"" type=""ns0:CE_72"" />
      <xs:element minOccurs=""1"" name=""AUT_2_AuthorizingPayorCompanyId"" type=""ns0:CE_285"" />
      <xs:element minOccurs=""0"" name=""AUT_3_AuthorizingPayorCompanyName"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""AUT_4_AuthorizationEffectiveDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""AUT_5_AuthorizationExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""AUT_6_AuthorizationIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""AUT_7_ReimbursementLimit"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""AUT_8_RequestedNumberOfTreatments"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AUT_9_AuthorizedNumberOfTreatments"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""AUT_10_ProcessDate"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BLC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BLC_1_BloodProductCode"" type=""ns0:CE_426"" />
      <xs:element minOccurs=""0"" name=""BLC_2_BloodAmount"" type=""ns0:CQ"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BLG"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""BLG_1_WhenToCharge"" type=""ns0:CCD_100"" />
      <xs:element minOccurs=""0"" name=""BLG_2_ChargeType"" type=""ns0:ID_122"" />
      <xs:element minOccurs=""0"" name=""BLG_3_AccountId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""BLG_4_ChargeTypeReason"" type=""ns0:CWE_475"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BPO"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""BPO_1_SetId_Bpo"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""BPO_2_BpUniversalServiceId"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BPO_3_BpProcessingRequirements"" type=""ns0:CWE_508"" />
      <xs:element minOccurs=""1"" name=""BPO_4_BpQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""BPO_5_BpAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""BPO_6_BpUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""BPO_7_BpIntendedUseDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""BPO_8_BpIntendedDispenseFromLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""BPO_9_BpIntendedDispenseFromAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""BPO_10_BpRequestedDispenseDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""BPO_11_BpRequestedDispenseToLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""BPO_12_BpRequestedDispenseToAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BPO_13_BpIndicationForUse"" type=""ns0:CWE_509"" />
      <xs:element minOccurs=""0"" name=""BPO_14_BpInformedConsentIndicator"" type=""ns0:ID_136"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BPX"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""BPX_1_SetId_Bpx"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""BPX_2_BpDispenseStatus"" type=""ns0:CWE_510"" />
      <xs:element minOccurs=""1"" name=""BPX_3_BpStatus"" type=""ns0:ID_511"" />
      <xs:element minOccurs=""1"" name=""BPX_4_BpDateTimeOfStatus"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""BPX_5_BcDonationId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""BPX_6_BcComponent"" type=""ns0:CNE"" />
      <xs:element minOccurs=""0"" name=""BPX_7_BcDonationTypeIntendedUse"" type=""ns0:CNE"" />
      <xs:element minOccurs=""0"" name=""BPX_8_CpCommercialProduct"" type=""ns0:CWE_512"" />
      <xs:element minOccurs=""0"" name=""BPX_9_CpManufacturer"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""BPX_10_CpLotNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""BPX_11_BpBloodGroup"" type=""ns0:CNE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BPX_12_BcSpecialTesting"" type=""ns0:CNE"" />
      <xs:element minOccurs=""0"" name=""BPX_13_BpExpirationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""BPX_14_BpQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""BPX_15_BpAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""BPX_16_BpUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""BPX_17_BpUniqueId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""BPX_18_BpActualDispensedToLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""BPX_19_BpActualDispensedToAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""BPX_20_BpDispensedToReceiver"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""BPX_21_BpDispensingIndividual"" type=""ns0:XCN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BTX"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""BTX_1_SetId_Btx"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""BTX_2_BcDonationId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""BTX_3_BcComponent"" type=""ns0:CNE"" />
      <xs:element minOccurs=""0"" name=""BTX_4_BcBloodGroup"" type=""ns0:CNE"" />
      <xs:element minOccurs=""0"" name=""BTX_5_CpCommercialProduct"" type=""ns0:CWE_512"" />
      <xs:element minOccurs=""0"" name=""BTX_6_CpManufacturer"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""BTX_7_CpLotNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""BTX_8_BpQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""BTX_9_BpAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""BTX_10_BpUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""BTX_11_BpTransfusionDispositionStatus"" type=""ns0:CWE_513"" />
      <xs:element minOccurs=""1"" name=""BTX_12_BpMessageStatus"" type=""ns0:ID_511"" />
      <xs:element minOccurs=""1"" name=""BTX_13_BpDateTimeOfStatus"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""BTX_14_BpAdministrator"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""BTX_15_BpVerifier"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""BTX_16_BpTransfusionStartDateTimeOfStatus"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""BTX_17_BpTransfusionEndDateTimeOfStatus"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""BTX_18_BpAdverseReactionType"" type=""ns0:CWE_514"" />
      <xs:element minOccurs=""0"" name=""BTX_19_BpTransfusionInterruptedReason"" type=""ns0:CWE_515"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CDM"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CDM_1_PrimaryKeyValueCdm"" type=""ns0:CE_132"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CDM_2_ChargeCodeAlias"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""CDM_3_ChargeDescriptionShort"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""CDM_4_ChargeDescriptionLong"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""CDM_5_DescriptionOverrideIndicator"" type=""ns0:IS_268"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CDM_6_ExplodingCharges"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CDM_7_ProcedureCode"" type=""ns0:CE_88"" />
      <xs:element minOccurs=""0"" name=""CDM_8_ActiveInactiveFlag"" type=""ns0:ID_183"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CDM_9_InventoryNumber"" type=""ns0:CE_463"" />
      <xs:element minOccurs=""0"" name=""CDM_10_ResourceLoad"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CDM_11_ContractNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CDM_12_ContractOrganization"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""CDM_13_RoomFeeIndicator"" type=""ns0:ID_136"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CER"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CER_1_SetId_Cer"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""CER_2_SerialNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""CER_3_Version"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""CER_4_GrantingAuthority"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""CER_5_IssuingAuthority"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""CER_6_SignatureOfIssuingAuthority"" type=""ns0:ED"" />
      <xs:element minOccurs=""0"" name=""CER_7_GrantingCountry"" type=""ns0:ID_399"" />
      <xs:element minOccurs=""0"" name=""CER_8_GrantingStateProvince"" type=""ns0:CWE_347"" />
      <xs:element minOccurs=""0"" name=""CER_9_GrantingCountyParish"" type=""ns0:CWE_289"" />
      <xs:element minOccurs=""0"" name=""CER_10_CertificateType"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""CER_11_CertificateDomain"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""CER_12_SubjectId"" type=""ns0:ID"" />
      <xs:element minOccurs=""1"" name=""CER_13_SubjectName"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CER_14_SubjectDirectoryAttributeExtensionHealthProfessionalData"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""CER_15_SubjectPublicKeyInfo"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""CER_16_AuthorityKeyIdentifier"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""CER_17_BasicConstraint"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CER_18_CrlDistributionPoint"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""CER_19_JurisdictionCountry"" type=""ns0:ID_399"" />
      <xs:element minOccurs=""0"" name=""CER_20_JurisdictionStateProvince"" type=""ns0:CWE_347"" />
      <xs:element minOccurs=""0"" name=""CER_21_JurisdictionCountyParish"" type=""ns0:CWE_289"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CER_22_JurisdictionBreadth"" type=""ns0:CWE_547"" />
      <xs:element minOccurs=""0"" name=""CER_23_GrantingDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_24_IssuingDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_25_ActivationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_26_InactivationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_27_ExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_28_RenewalDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_29_RevocationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CER_30_RevocationReasonCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CER_31_CertificateStatus"" type=""ns0:CWE_536"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CM0"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CM0_1_SetIdCm0"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""CM0_2_SponsorStudyId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CM0_3_AlternateStudyId"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""CM0_4_TitleOfStudy"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CM0_5_ChairmanOfStudy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""CM0_6_LastIrbApprovalDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""CM0_7_TotalAccrualToDate"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""CM0_8_LastAccrualDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CM0_9_ContactForStudy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""CM0_10_ContactSTelephoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CM0_11_ContactSAddress"" type=""ns0:XAD"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CM1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CM1_1_SetIdCm1"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""CM1_2_StudyPhaseIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""CM1_3_DescriptionOfStudyPhase"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CM2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CM2_1_SetIdCm2"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""CM2_2_ScheduledTimePoint"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CM2_3_DescriptionOfTimePoint"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""CM2_4_EventsScheduledThisTimePoint"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CNS"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""CNS_1_StartingNotificationReferenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""CNS_2_EndingNotificationReferenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""CNS_3_StartingNotificationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CNS_4_EndingNotificationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CNS_5_StartingNotificationCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CNS_6_EndingNotificationCode"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CON"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CON_1_SetIdCon"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""CON_2_ConsentType"" type=""ns0:CWE_496"" />
      <xs:element minOccurs=""0"" name=""CON_3_ConsentFormId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""CON_4_ConsentFormNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CON_5_ConsentText"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CON_6_SubjectSpecificConsentText"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CON_7_ConsentBackground"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CON_8_SubjectSpecificConsentBackground"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CON_9_ConsenterImposedLimitations"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" name=""CON_10_ConsentMode"" type=""ns0:CNE_497"" />
      <xs:element minOccurs=""1"" name=""CON_11_ConsentStatus"" type=""ns0:CNE_498"" />
      <xs:element minOccurs=""0"" name=""CON_12_ConsentDiscussionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CON_13_ConsentDecisionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CON_14_ConsentEffectiveDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CON_15_ConsentEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CON_16_SubjectCompetenceIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""CON_17_TranslatorAssistanceIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""CON_18_LanguageTranslatedTo"" type=""ns0:ID_296"" />
      <xs:element minOccurs=""0"" name=""CON_19_InformationalMaterialSuppliedIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""CON_20_ConsentBypassReason"" type=""ns0:CWE_499"" />
      <xs:element minOccurs=""0"" name=""CON_21_ConsentDisclosureLevel"" type=""ns0:ID_500"" />
      <xs:element minOccurs=""0"" name=""CON_22_ConsentNonDisclosureReason"" type=""ns0:CWE_501"" />
      <xs:element minOccurs=""0"" name=""CON_23_NonSubjectConsenterReason"" type=""ns0:CWE_502"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""CON_24_ConsenterId"" type=""ns0:XPN"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""CON_25_RelationshipToSubjectTable"" type=""ns0:IS_548"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CSP"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CSP_1_StudyPhaseIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""CSP_2_DateTimeStudyPhaseBegan"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CSP_3_DateTimeStudyPhaseEnded"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CSP_4_StudyPhaseEvaluability"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CSR"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CSR_1_SponsorStudyId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""CSR_2_AlternateStudyId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""CSR_3_InstitutionRegisteringThePatient"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""CSR_4_SponsorPatientId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""CSR_5_AlternatePatientIdCsr"" type=""ns0:CX"" />
      <xs:element minOccurs=""1"" name=""CSR_6_DateTimeOfPatientStudyRegistration"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CSR_7_PersonPerformingStudyRegistration"" type=""ns0:XCN"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""CSR_8_StudyAuthorizingProvider"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""CSR_9_DateTimePatientStudyConsentSigned"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CSR_10_PatientStudyEligibilityStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CSR_11_StudyRandomizationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CSR_12_RandomizedStudyArm"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CSR_13_StratumForStudyRandomization"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CSR_14_PatientEvaluabilityStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CSR_15_DateTimeEndedStudy"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""CSR_16_ReasonEndedStudy"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CSS"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CSS_1_StudyScheduledTimePoint"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CSS_2_StudyScheduledPatientTimePoint"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CSS_3_StudyQualityControlCodes"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CTD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""CTD_1_ContactRole"" type=""ns0:CE_131"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CTD_2_ContactName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CTD_3_ContactAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""CTD_4_ContactLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CTD_5_ContactCommunicationInformation"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""CTD_6_PreferredMethodOfContact"" type=""ns0:CE_185"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""CTD_7_ContactIdentifiers"" type=""ns0:PLN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""CTI"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""CTI_1_SponsorStudyId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""CTI_2_StudyPhaseIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""CTI_3_StudyScheduledTimePoint"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DB1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""DB1_1_SetIdDb1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""DB1_2_DisabledPersonCode"" type=""ns0:IS_334"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DB1_3_DisabledPersonIdentifier"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""DB1_4_DisabledIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""DB1_5_DisabilityStartDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""DB1_6_DisabilityEndDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""DB1_7_DisabilityReturnToWorkDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""DB1_8_DisabilityUnableToWorkDate"" type=""ns0:DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DG1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""DG1_1_SetIdDg1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""DG1_2_DiagnosisCodingMethod"" type=""ns0:ID_53"" />
      <xs:element minOccurs=""0"" name=""DG1_3_DiagnosisCodeDg1"" type=""ns0:CE_51"" />
      <xs:element minOccurs=""0"" name=""DG1_4_DiagnosisDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""DG1_5_DiagnosisDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""DG1_6_DiagnosisType"" type=""ns0:IS_52"" />
      <xs:element minOccurs=""0"" name=""DG1_7_MajorDiagnosticCategory"" type=""ns0:CE_118"" />
      <xs:element minOccurs=""0"" name=""DG1_8_DiagnosticRelatedGroup"" type=""ns0:CE_55"" />
      <xs:element minOccurs=""0"" name=""DG1_9_DrgApprovalIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""DG1_10_DrgGrouperReviewCode"" type=""ns0:IS_56"" />
      <xs:element minOccurs=""0"" name=""DG1_11_OutlierType"" type=""ns0:CE_83"" />
      <xs:element minOccurs=""0"" name=""DG1_12_OutlierDays"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""DG1_13_OutlierCost"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""DG1_14_GrouperVersionAndType"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""DG1_15_DiagnosisPriority"" type=""ns0:ID_359"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""DG1_16_DiagnosingClinician"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""DG1_17_DiagnosisClassification"" type=""ns0:IS_228"" />
      <xs:element minOccurs=""0"" name=""DG1_18_ConfidentialIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""DG1_19_AttestationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""DG1_20_DiagnosisIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""DG1_21_DiagnosisActionCode"" type=""ns0:ID_206"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DRG"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DRG_1_DiagnosticRelatedGroup"" type=""ns0:CE_55"" />
      <xs:element minOccurs=""0"" name=""DRG_2_DrgAssignedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""DRG_3_DrgApprovalIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""DRG_4_DrgGrouperReviewCode"" type=""ns0:IS_56"" />
      <xs:element minOccurs=""0"" name=""DRG_5_OutlierType"" type=""ns0:CE_83"" />
      <xs:element minOccurs=""0"" name=""DRG_6_OutlierDays"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""DRG_7_OutlierCost"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""DRG_8_DrgPayor"" type=""ns0:IS_229"" />
      <xs:element minOccurs=""0"" name=""DRG_9_OutlierReimbursement"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""DRG_10_ConfidentialIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""DRG_11_DrgTransferType"" type=""ns0:IS_415"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DSC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DSC_1_ContinuationPointer"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""DSC_2_ContinuationStyle"" type=""ns0:ID_398"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""DSP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""DSP_1_SetIdDsp"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""DSP_2_DisplayLevel"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""DSP_3_DataLine"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""DSP_4_LogicalBreakPoint"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""DSP_5_ResultId"" type=""ns0:TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ECD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ECD_1_ReferenceCommandNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""ECD_2_RemoteControlCommand"" type=""ns0:CE_368"" />
      <xs:element minOccurs=""0"" name=""ECD_3_ResponseRequired"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ECD_4_RequestedCompletionTime"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ECD_5_Parameters"" type=""ns0:TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ECR"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ECR_1_CommandResponse"" type=""ns0:CE_387"" />
      <xs:element minOccurs=""1"" name=""ECR_2_DateTimeCompleted"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ECR_3_CommandResponseParameters"" type=""ns0:TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EDU"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""EDU_1_SetId_Edu"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""EDU_2_AcademicDegree"" type=""ns0:IS_360"" />
      <xs:element minOccurs=""0"" name=""EDU_3_AcademicDegreeProgramDateRange"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""EDU_4_AcademicDegreeProgramParticipationDateRange"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""EDU_5_AcademicDegreeGrantedDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""EDU_6_School"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""EDU_7_SchoolTypeCode"" type=""ns0:CE_402"" />
      <xs:element minOccurs=""0"" name=""EDU_8_SchoolAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EDU_9_MajorFieldOfStudy"" type=""ns0:CWE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EQL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EQL_1_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""EQL_2_QueryResponseFormatCode"" type=""ns0:ID_106"" />
      <xs:element minOccurs=""1"" name=""EQL_3_EqlQueryName"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""EQL_4_EqlQueryStatement"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EQP"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""EQP_1_EventType"" type=""ns0:CE_450"" />
      <xs:element minOccurs=""0"" name=""EQP_2_FileName"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""EQP_3_StartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""EQP_4_EndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""EQP_5_TransactionData"" type=""ns0:FT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EQU"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""EQU_1_EquipmentInstanceIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""EQU_2_EventDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""EQU_3_EquipmentState"" type=""ns0:CE_365"" />
      <xs:element minOccurs=""0"" name=""EQU_4_LocalRemoteControlState"" type=""ns0:CE_366"" />
      <xs:element minOccurs=""0"" name=""EQU_5_AlertLevel"" type=""ns0:CE_367"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ERQ"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ERQ_1_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""ERQ_2_EventIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERQ_3_InputParameterList"" type=""ns0:QIP"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ERR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_1_ErrorCodeAndLocation"" type=""ns0:ELD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_2_ErrorLocation"" type=""ns0:ERL"" />
      <xs:element minOccurs=""1"" name=""ERR_3_Hl7ErrorCode"" type=""ns0:CWE_357"" />
      <xs:element minOccurs=""1"" name=""ERR_4_Severity"" type=""ns0:ID_516"" />
      <xs:element minOccurs=""0"" name=""ERR_5_ApplicationErrorCode"" type=""ns0:CWE_533"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_6_ApplicationErrorParameter"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""ERR_7_DiagnosticInformation"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""ERR_8_UserMessage"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_9_InformPersonIndicator"" type=""ns0:IS_517"" />
      <xs:element minOccurs=""0"" name=""ERR_10_OverrideType"" type=""ns0:CWE_518"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_11_OverrideReasonCode"" type=""ns0:CWE_519"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ERR_12_HelpDeskContactPoint"" type=""ns0:XTN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""EVN"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""EVN_1_EventTypeCode"" type=""ns0:ID_3"" />
      <xs:element minOccurs=""1"" name=""EVN_2_RecordedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""EVN_3_DateTimePlannedEvent"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""EVN_4_EventReasonCode"" type=""ns0:IS_62"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""EVN_5_OperatorId"" type=""ns0:XCN_188"" />
      <xs:element minOccurs=""0"" name=""EVN_6_EventOccurred"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""EVN_7_EventFacility"" type=""ns0:HD"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""FAC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""FAC_1_FacilityIdFac"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""FAC_2_FacilityType"" type=""ns0:ID_331"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""FAC_3_FacilityAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""1"" name=""FAC_4_FacilityTelecommunication"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FAC_5_ContactPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FAC_6_ContactTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FAC_7_ContactAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FAC_8_ContactTelecommunication"" type=""ns0:XTN"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""FAC_9_SignatureAuthority"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""FAC_10_SignatureAuthorityTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FAC_11_SignatureAuthorityAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""FAC_12_SignatureAuthorityTelecommunication"" type=""ns0:XTN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""FT1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""FT1_1_SetIdFt1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""FT1_2_TransactionId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""FT1_3_TransactionBatchId"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""FT1_4_TransactionDate"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""FT1_5_TransactionPostingDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""FT1_6_TransactionType"" type=""ns0:IS_17"" />
      <xs:element minOccurs=""1"" name=""FT1_7_TransactionCode"" type=""ns0:CE_132"" />
      <xs:element minOccurs=""0"" name=""FT1_8_TransactionDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""FT1_9_TransactionDescriptionAlt"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""FT1_10_TransactionQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""FT1_11_TransactionAmountExtended"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""FT1_12_TransactionAmountUnit"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""FT1_13_DepartmentCode"" type=""ns0:CE_49"" />
      <xs:element minOccurs=""0"" name=""FT1_14_InsurancePlanId"" type=""ns0:CE_72"" />
      <xs:element minOccurs=""0"" name=""FT1_15_InsuranceAmount"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""FT1_16_AssignedPatientLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""FT1_17_FeeSchedule"" type=""ns0:IS_24"" />
      <xs:element minOccurs=""0"" name=""FT1_18_PatientType"" type=""ns0:IS_18"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FT1_19_DiagnosisCodeFt1"" type=""ns0:CE_51"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FT1_20_PerformedByCode"" type=""ns0:XCN_84"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FT1_21_OrderedByCode"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""FT1_22_UnitCost"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""FT1_23_FillerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FT1_24_EnteredByCode"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""FT1_25_ProcedureCode"" type=""ns0:CE_88"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FT1_26_ProcedureCodeModifier"" type=""ns0:CE_340"" />
      <xs:element minOccurs=""0"" name=""FT1_27_AdvancedBeneficiaryNoticeCode"" type=""ns0:CE_339"" />
      <xs:element minOccurs=""0"" name=""FT1_28_MedicallyNecessaryDuplicateProcedureReason"" type=""ns0:CWE_476"" />
      <xs:element minOccurs=""0"" name=""FT1_29_NdcCode"" type=""ns0:CNE_549"" />
      <xs:element minOccurs=""0"" name=""FT1_30_PaymentReferenceId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""FT1_31_TransactionReferenceKey"" type=""ns0:SI"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""GOL"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""GOL_1_ActionCode"" type=""ns0:ID_287"" />
      <xs:element minOccurs=""1"" name=""GOL_2_ActionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""GOL_3_GoalId"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""GOL_4_GoalInstanceId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""GOL_5_EpisodeOfCareId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""GOL_6_GoalListPriority"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""GOL_7_GoalEstablishedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GOL_8_ExpectedGoalAchieveDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GOL_9_GoalClassification"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""GOL_10_GoalManagementDiscipline"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""GOL_11_CurrentGoalReviewStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""GOL_12_CurrentGoalReviewDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GOL_13_NextGoalReviewDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GOL_14_PreviousGoalReviewDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GOL_15_GoalReviewInterval"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" name=""GOL_16_GoalEvaluation"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GOL_17_GoalEvaluationComment"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""GOL_18_GoalLifeCycleStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""GOL_19_GoalLifeCycleStatusDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GOL_20_GoalTargetType"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GOL_21_GoalTargetName"" type=""ns0:XPN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""GP1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""GP1_1_TypeOfBillCode"" type=""ns0:IS_455"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GP1_2_RevenueCode"" type=""ns0:IS_456"" />
      <xs:element minOccurs=""0"" name=""GP1_3_OverallClaimDispositionCode"" type=""ns0:IS_457"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GP1_4_OceEditsPerVisitCode"" type=""ns0:IS_458"" />
      <xs:element minOccurs=""0"" name=""GP1_5_OutlierCost"" type=""ns0:CP"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""GP2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""GP2_1_RevenueCode"" type=""ns0:IS_456"" />
      <xs:element minOccurs=""0"" name=""GP2_2_NumberOfServiceUnits"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""GP2_3_Charge"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""GP2_4_ReimbursementActionCode"" type=""ns0:IS_459"" />
      <xs:element minOccurs=""0"" name=""GP2_5_DenialOrRejectionCode"" type=""ns0:IS_460"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GP2_6_OceEditCode"" type=""ns0:IS_458"" />
      <xs:element minOccurs=""0"" name=""GP2_7_AmbulatoryPaymentClassificationCode"" type=""ns0:CE_466"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GP2_8_ModifierEditCode"" type=""ns0:IS_467"" />
      <xs:element minOccurs=""0"" name=""GP2_9_PaymentAdjustmentCode"" type=""ns0:IS_468"" />
      <xs:element minOccurs=""0"" name=""GP2_10_PackagingStatusCode"" type=""ns0:IS_469"" />
      <xs:element minOccurs=""0"" name=""GP2_11_ExpectedCmsPaymentAmount"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""GP2_12_ReimbursementTypeCode"" type=""ns0:IS_470"" />
      <xs:element minOccurs=""0"" name=""GP2_13_CoPayAmount"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""GP2_14_PayRatePerServiceUnit"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""GT1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""GT1_1_SetIdGt1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_2_GuarantorNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""GT1_3_GuarantorName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_4_GuarantorSpouseName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_5_GuarantorAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_6_GuarantorPhNumHome"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_7_GuarantorPhNumBusiness"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""GT1_8_GuarantorDateTimeOfBirth"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GT1_9_GuarantorAdministrativeSex"" type=""ns0:IS_1"" />
      <xs:element minOccurs=""0"" name=""GT1_10_GuarantorType"" type=""ns0:IS_68"" />
      <xs:element minOccurs=""0"" name=""GT1_11_GuarantorRelationship"" type=""ns0:CE_63"" />
      <xs:element minOccurs=""0"" name=""GT1_12_GuarantorSsn"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""GT1_13_GuarantorDateBegin"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""GT1_14_GuarantorDateEnd"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""GT1_15_GuarantorPriority"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_16_GuarantorEmployerName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_17_GuarantorEmployerAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_18_GuarantorEmployerPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_19_GuarantorEmployeeIdNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""GT1_20_GuarantorEmploymentStatus"" type=""ns0:IS_66"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_21_GuarantorOrganizationName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""GT1_22_GuarantorBillingHoldFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""GT1_23_GuarantorCreditRatingCode"" type=""ns0:CE_341"" />
      <xs:element minOccurs=""0"" name=""GT1_24_GuarantorDeathDateAndTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""GT1_25_GuarantorDeathFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""GT1_26_GuarantorChargeAdjustmentCode"" type=""ns0:CE_218"" />
      <xs:element minOccurs=""0"" name=""GT1_27_GuarantorHouseholdAnnualIncome"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""GT1_28_GuarantorHouseholdSize"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_29_GuarantorEmployerIdNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""GT1_30_GuarantorMaritalStatusCode"" type=""ns0:CE_2"" />
      <xs:element minOccurs=""0"" name=""GT1_31_GuarantorHireEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""GT1_32_EmploymentStopDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""GT1_33_LivingDependency"" type=""ns0:IS_223"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_34_AmbulatoryStatus"" type=""ns0:IS_9"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_35_Citizenship"" type=""ns0:CE_171"" />
      <xs:element minOccurs=""0"" name=""GT1_36_PrimaryLanguage"" type=""ns0:CE_296"" />
      <xs:element minOccurs=""0"" name=""GT1_37_LivingArrangement"" type=""ns0:IS_220"" />
      <xs:element minOccurs=""0"" name=""GT1_38_PublicityCode"" type=""ns0:CE_215"" />
      <xs:element minOccurs=""0"" name=""GT1_39_ProtectionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""GT1_40_StudentIndicator"" type=""ns0:IS_231"" />
      <xs:element minOccurs=""0"" name=""GT1_41_Religion"" type=""ns0:CE_6"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_42_MotherSMaidenName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""GT1_43_Nationality"" type=""ns0:CE_212"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_44_EthnicGroup"" type=""ns0:CE_189"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_45_ContactPersonSName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_46_ContactPersonSTelephoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""GT1_47_ContactReason"" type=""ns0:CE_222"" />
      <xs:element minOccurs=""0"" name=""GT1_48_ContactRelationship"" type=""ns0:IS_63"" />
      <xs:element minOccurs=""0"" name=""GT1_49_JobTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""GT1_50_JobCodeClass"" type=""ns0:JCC"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_51_GuarantorEmployerSOrganizationName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""GT1_52_Handicap"" type=""ns0:IS_295"" />
      <xs:element minOccurs=""0"" name=""GT1_53_JobStatus"" type=""ns0:IS_311"" />
      <xs:element minOccurs=""0"" name=""GT1_54_GuarantorFinancialClass"" type=""ns0:FC"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GT1_55_GuarantorRace"" type=""ns0:CE_5"" />
      <xs:element minOccurs=""0"" name=""GT1_56_GuarantorBirthPlace"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""GT1_57_VipIndicator"" type=""ns0:IS_99"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IAM"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""IAM_1_SetIdIam"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""IAM_2_AllergenTypeCode"" type=""ns0:CE_127"" />
      <xs:element minOccurs=""1"" name=""IAM_3_AllergenCodeMnemonicDescription"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""IAM_4_AllergySeverityCode"" type=""ns0:CE_128"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IAM_5_AllergyReactionCode"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""IAM_6_AllergyActionCode"" type=""ns0:CNE_323"" />
      <xs:element minOccurs=""0"" name=""IAM_7_AllergyUniqueIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""IAM_8_ActionReason"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IAM_9_SensitivityToCausativeAgentCode"" type=""ns0:CE_436"" />
      <xs:element minOccurs=""0"" name=""IAM_10_AllergenGroupCodeMnemonicDescription"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""IAM_11_OnsetDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IAM_12_OnsetDateText"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IAM_13_ReportedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""IAM_14_ReportedBy"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""IAM_15_RelationshipToPatientCode"" type=""ns0:CE_63"" />
      <xs:element minOccurs=""0"" name=""IAM_16_AlertDeviceCode"" type=""ns0:CE_437"" />
      <xs:element minOccurs=""0"" name=""IAM_17_AllergyClinicalStatusCode"" type=""ns0:CE_438"" />
      <xs:element minOccurs=""0"" name=""IAM_18_StatusedByPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""IAM_19_StatusedByOrganization"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""IAM_20_StatusedAtDateTime"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IIM"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""IIM_1_PrimaryKeyValueIim"" type=""ns0:CWE"" />
      <xs:element minOccurs=""1"" name=""IIM_2_ServiceItemCode"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""IIM_3_InventoryLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IIM_4_InventoryExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""IIM_5_InventoryManufacturerName"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""IIM_6_InventoryLocation"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""IIM_7_InventoryReceivedDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""IIM_8_InventoryReceivedQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""IIM_9_InventoryReceivedQuantityUnit"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""IIM_10_InventoryReceivedItemCost"" type=""ns0:MO"" />
      <xs:element minOccurs=""0"" name=""IIM_11_InventoryOnHandDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""IIM_12_InventoryOnHandQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""IIM_13_InventoryOnHandQuantityUnit"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""IIM_14_ProcedureCode"" type=""ns0:CE_88"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IIM_15_ProcedureCodeModifier"" type=""ns0:CE_340"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IN1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""IN1_1_SetIdIn1"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""IN1_2_InsurancePlanId"" type=""ns0:CE_72"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""IN1_3_InsuranceCompanyId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_4_InsuranceCompanyName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_5_InsuranceCompanyAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_6_InsuranceCoContactPerson"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_7_InsuranceCoPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""IN1_8_GroupNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_9_GroupName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_10_InsuredSGroupEmpId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_11_InsuredSGroupEmpName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""IN1_12_PlanEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN1_13_PlanExpirationDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN1_14_AuthorizationInformation"" type=""ns0:AUI"" />
      <xs:element minOccurs=""0"" name=""IN1_15_PlanType"" type=""ns0:IS_86"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_16_NameOfInsured"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""IN1_17_InsuredSRelationshipToPatient"" type=""ns0:CE_63"" />
      <xs:element minOccurs=""0"" name=""IN1_18_InsuredSDateOfBirth"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_19_InsuredSAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""IN1_20_AssignmentOfBenefits"" type=""ns0:IS_135"" />
      <xs:element minOccurs=""0"" name=""IN1_21_CoordinationOfBenefits"" type=""ns0:IS_173"" />
      <xs:element minOccurs=""0"" name=""IN1_22_CoordOfBenPriority"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN1_23_NoticeOfAdmissionFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN1_24_NoticeOfAdmissionDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN1_25_ReportOfEligibilityFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN1_26_ReportOfEligibilityDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN1_27_ReleaseInformationCode"" type=""ns0:IS_93"" />
      <xs:element minOccurs=""0"" name=""IN1_28_PreAdmitCertPac"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN1_29_VerificationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_30_VerificationBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""IN1_31_TypeOfAgreementCode"" type=""ns0:IS_98"" />
      <xs:element minOccurs=""0"" name=""IN1_32_BillingStatus"" type=""ns0:IS_22"" />
      <xs:element minOccurs=""0"" name=""IN1_33_LifetimeReserveDays"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""IN1_34_DelayBeforeLRDay"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""IN1_35_CompanyPlanCode"" type=""ns0:IS_42"" />
      <xs:element minOccurs=""0"" name=""IN1_36_PolicyNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN1_37_PolicyDeductible"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""IN1_38_PolicyLimitAmount"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""IN1_39_PolicyLimitDays"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""IN1_40_RoomRateSemiPrivate"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""IN1_41_RoomRatePrivate"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" name=""IN1_42_InsuredSEmploymentStatus"" type=""ns0:CE_66"" />
      <xs:element minOccurs=""0"" name=""IN1_43_InsuredSAdministrativeSex"" type=""ns0:IS_1"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_44_InsuredSEmployerSAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""IN1_45_VerificationStatus"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN1_46_PriorInsurancePlanId"" type=""ns0:IS_72"" />
      <xs:element minOccurs=""0"" name=""IN1_47_CoverageType"" type=""ns0:IS_309"" />
      <xs:element minOccurs=""0"" name=""IN1_48_Handicap"" type=""ns0:IS_295"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN1_49_InsuredSIdNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""IN1_50_SignatureCode"" type=""ns0:IS_535"" />
      <xs:element minOccurs=""0"" name=""IN1_51_SignatureCodeDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN1_52_Insured_sBirthPlace"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN1_53_VipIndicator"" type=""ns0:IS_99"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IN2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_1_InsuredSEmployeeId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""IN2_2_InsuredSSocialSecurityNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_3_InsuredSEmployerSNameAndId"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""IN2_4_EmployerInformationData"" type=""ns0:IS_139"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_5_MailClaimParty"" type=""ns0:IS_137"" />
      <xs:element minOccurs=""0"" name=""IN2_6_MedicareHealthInsCardNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_7_MedicaidCaseName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""IN2_8_MedicaidCaseNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_9_MilitarySponsorName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""IN2_10_MilitaryIdNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN2_11_DependentOfMilitaryRecipient"" type=""ns0:CE_342"" />
      <xs:element minOccurs=""0"" name=""IN2_12_MilitaryOrganization"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN2_13_MilitaryStation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN2_14_MilitaryService"" type=""ns0:IS_140"" />
      <xs:element minOccurs=""0"" name=""IN2_15_MilitaryRankGrade"" type=""ns0:IS_141"" />
      <xs:element minOccurs=""0"" name=""IN2_16_MilitaryStatus"" type=""ns0:IS_142"" />
      <xs:element minOccurs=""0"" name=""IN2_17_MilitaryRetireDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN2_18_MilitaryNonAvailCertOnFile"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN2_19_BabyCoverage"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN2_20_CombineBabyBill"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN2_21_BloodDeductible"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_22_SpecialCoverageApprovalName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""IN2_23_SpecialCoverageApprovalTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_24_NonCoveredInsuranceCode"" type=""ns0:IS_143"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_25_PayorId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_26_PayorSubscriberId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""IN2_27_EligibilitySource"" type=""ns0:IS_144"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_28_RoomCoverageTypeAmount"" type=""ns0:RMC"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_29_PolicyTypeAmount"" type=""ns0:PTA"" />
      <xs:element minOccurs=""0"" name=""IN2_30_DailyDeductible"" type=""ns0:DDI"" />
      <xs:element minOccurs=""0"" name=""IN2_31_LivingDependency"" type=""ns0:IS_223"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_32_AmbulatoryStatus"" type=""ns0:IS_9"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_33_Citizenship"" type=""ns0:CE_171"" />
      <xs:element minOccurs=""0"" name=""IN2_34_PrimaryLanguage"" type=""ns0:CE_296"" />
      <xs:element minOccurs=""0"" name=""IN2_35_LivingArrangement"" type=""ns0:IS_220"" />
      <xs:element minOccurs=""0"" name=""IN2_36_PublicityCode"" type=""ns0:CE_215"" />
      <xs:element minOccurs=""0"" name=""IN2_37_ProtectionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN2_38_StudentIndicator"" type=""ns0:IS_231"" />
      <xs:element minOccurs=""0"" name=""IN2_39_Religion"" type=""ns0:CE_6"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_40_MotherSMaidenName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""IN2_41_Nationality"" type=""ns0:CE_212"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_42_EthnicGroup"" type=""ns0:CE_189"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_43_MaritalStatus"" type=""ns0:CE_2"" />
      <xs:element minOccurs=""0"" name=""IN2_44_InsuredSEmploymentStartDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN2_45_EmploymentStopDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN2_46_JobTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN2_47_JobCodeClass"" type=""ns0:JCC"" />
      <xs:element minOccurs=""0"" name=""IN2_48_JobStatus"" type=""ns0:IS_311"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_49_EmployerContactPersonName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_50_EmployerContactPersonPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""IN2_51_EmployerContactReason"" type=""ns0:IS_222"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_52_InsuredSContactPersonSName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_53_InsuredSContactPersonPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_54_InsuredSContactPersonReason"" type=""ns0:IS_222"" />
      <xs:element minOccurs=""0"" name=""IN2_55_RelationshipToThePatientStartDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_56_RelationshipToThePatientStopDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN2_57_InsuranceCoContactReason"" type=""ns0:IS_232"" />
      <xs:element minOccurs=""0"" name=""IN2_58_InsuranceCoContactPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""IN2_59_PolicyScope"" type=""ns0:IS_312"" />
      <xs:element minOccurs=""0"" name=""IN2_60_PolicySource"" type=""ns0:IS_313"" />
      <xs:element minOccurs=""0"" name=""IN2_61_PatientMemberNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""IN2_62_GuarantorSRelationshipToInsured"" type=""ns0:CE_63"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_63_InsuredSPhoneNumberHome"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_64_InsuredSEmployerPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""IN2_65_MilitaryHandicappedProgram"" type=""ns0:CE_343"" />
      <xs:element minOccurs=""0"" name=""IN2_66_SuspendFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN2_67_CopayLimitFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN2_68_StoplossLimitFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_69_InsuredOrganizationNameAndId"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_70_InsuredEmployerOrganizationNameAndId"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN2_71_Race"" type=""ns0:CE_5"" />
      <xs:element minOccurs=""0"" name=""IN2_72_CmsPatient_sRelationshipToInsured"" type=""ns0:CE_344"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IN3"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""IN3_1_SetIdIn3"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""IN3_2_CertificationNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_3_CertifiedBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""IN3_4_CertificationRequired"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""IN3_5_Penalty"" type=""ns0:MOP"" />
      <xs:element minOccurs=""0"" name=""IN3_6_CertificationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""IN3_7_CertificationModifyDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_8_Operator"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""IN3_9_CertificationBeginDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN3_10_CertificationEndDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN3_11_Days"" type=""ns0:DTN"" />
      <xs:element minOccurs=""0"" name=""IN3_12_NonConcurCodeDescription"" type=""ns0:CE_233"" />
      <xs:element minOccurs=""0"" name=""IN3_13_NonConcurEffectiveDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_14_PhysicianReviewer"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" name=""IN3_15_CertificationContact"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_16_CertificationContactPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""IN3_17_AppealReason"" type=""ns0:CE_345"" />
      <xs:element minOccurs=""0"" name=""IN3_18_CertificationAgency"" type=""ns0:CE_346"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_19_CertificationAgencyPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_20_PreCertificationRequirement"" type=""ns0:ICD"" />
      <xs:element minOccurs=""0"" name=""IN3_21_CaseManager"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""IN3_22_SecondOpinionDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""IN3_23_SecondOpinionStatus"" type=""ns0:IS_151"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_24_SecondOpinionDocumentationReceived"" type=""ns0:IS_152"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IN3_25_SecondOpinionPhysician"" type=""ns0:XCN_10"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""INV"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""INV_1_SubstanceIdentifier"" type=""ns0:CE_451"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""INV_2_SubstanceStatus"" type=""ns0:CE_383"" />
      <xs:element minOccurs=""0"" name=""INV_3_SubstanceType"" type=""ns0:CE_384"" />
      <xs:element minOccurs=""0"" name=""INV_4_InventoryContainerIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""INV_5_ContainerCarrierIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""INV_6_PositionOnCarrier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""INV_7_InitialQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""INV_8_CurrentQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""INV_9_AvailableQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""INV_10_ConsumptionQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""INV_11_QuantityUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""INV_12_ExpirationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""INV_13_FirstUsedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""INV_14_OnBoardStabilityDuration"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""INV_15_TestFluidIdentifierS"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""INV_16_ManufacturerLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""INV_17_ManufacturerIdentifier"" type=""ns0:CE_385"" />
      <xs:element minOccurs=""0"" name=""INV_18_SupplierIdentifier"" type=""ns0:CE_386"" />
      <xs:element minOccurs=""0"" name=""INV_19_OnBoardStabilityTime"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""INV_20_TargetValue"" type=""ns0:CQ"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""IPC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""IPC_1_AccessionIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""IPC_2_RequestedProcedureId"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""IPC_3_StudyInstanceUid"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""IPC_4_ScheduledProcedureStepId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""IPC_5_Modality"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IPC_6_ProtocolCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""IPC_7_ScheduledStationName"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IPC_8_ScheduledProcedureStepLocation"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""IPC_9_ScheduledAeTitle"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ISD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ISD_1_ReferenceInteractionNumberUniqueIdentifier"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""ISD_2_InteractionTypeIdentifier"" type=""ns0:CE_368"" />
      <xs:element minOccurs=""1"" name=""ISD_3_InteractionActiveState"" type=""ns0:CE_387"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LAN"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""LAN_1_SetId_Lan"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""LAN_2_LanguageCode"" type=""ns0:CE_296"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LAN_3_LanguageAbilityCode"" type=""ns0:CE_403"" />
      <xs:element minOccurs=""0"" name=""LAN_4_LanguageProficiencyCode"" type=""ns0:CE_404"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LCC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""LCC_1_PrimaryKeyValueLcc"" type=""ns0:PL"" />
      <xs:element minOccurs=""1"" name=""LCC_2_LocationDepartment"" type=""ns0:CE_264"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LCC_3_AccommodationType"" type=""ns0:CE_129"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""LCC_4_ChargeCode"" type=""ns0:CE_132"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LCH"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""LCH_1_PrimaryKeyValueLch"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""LCH_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""0"" name=""LCH_3_SegmentUniqueKey"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""LCH_4_LocationCharacteristicId"" type=""ns0:CE_324"" />
      <xs:element minOccurs=""1"" name=""LCH_5_LocationCharacteristicValueLch"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LDP"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""LDP_1_PrimaryKeyValueLdp"" type=""ns0:PL"" />
      <xs:element minOccurs=""1"" name=""LDP_2_LocationDepartment"" type=""ns0:CE_264"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LDP_3_LocationService"" type=""ns0:IS_69"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LDP_4_SpecialtyType"" type=""ns0:CE_265"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LDP_5_ValidPatientClasses"" type=""ns0:IS_4"" />
      <xs:element minOccurs=""0"" name=""LDP_6_ActiveInactiveFlag"" type=""ns0:ID_183"" />
      <xs:element minOccurs=""0"" name=""LDP_7_ActivationDateLdp"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""LDP_8_InactivationDateLdp"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""LDP_9_InactivatedReason"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LDP_10_VisitingHours"" type=""ns0:VH_267"" />
      <xs:element minOccurs=""0"" name=""LDP_11_ContactPhone"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""LDP_12_LocationCostCenter"" type=""ns0:CE_462"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LOC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""LOC_1_PrimaryKeyValueLoc"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""LOC_2_LocationDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""LOC_3_LocationTypeLoc"" type=""ns0:IS_260"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LOC_4_OrganizationNameLoc"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LOC_5_LocationAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LOC_6_LocationPhone"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LOC_7_LicenseNumber"" type=""ns0:CE_461"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LOC_8_LocationEquipment"" type=""ns0:IS_261"" />
      <xs:element minOccurs=""0"" name=""LOC_9_LocationServiceCode"" type=""ns0:IS_442"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""LRL"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""LRL_1_PrimaryKeyValueLrl"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""LRL_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""0"" name=""LRL_3_SegmentUniqueKey"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""LRL_4_LocationRelationshipId"" type=""ns0:CE_325"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LRL_5_OrganizationalLocationRelationshipValue"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""LRL_6_PatientLocationRelationshipValue"" type=""ns0:PL"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MFA"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""MFA_1_RecordLevelEventCode"" type=""ns0:ID_180"" />
      <xs:element minOccurs=""0"" name=""MFA_2_MfnControlId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""MFA_3_EventCompletionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""MFA_4_MfnRecordLevelErrorReturn"" type=""ns0:CE_181"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""MFA_5_PrimaryKeyValueMfa"" type=""ns0:Varies_9999"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""MFA_6_PrimaryKeyValueTypeMfa"" type=""ns0:ID_355"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MFE"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""MFE_1_RecordLevelEventCode"" type=""ns0:ID_180"" />
      <xs:element minOccurs=""0"" name=""MFE_2_MfnControlId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""MFE_3_EffectiveDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""MFE_4_PrimaryKeyValueMfe"" type=""ns0:Varies_9999"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""MFE_5_PrimaryKeyValueType"" type=""ns0:ID_355"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MFI"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""MFI_1_MasterFileIdentifier"" type=""ns0:CE_175"" />
      <xs:element minOccurs=""0"" name=""MFI_2_MasterFileApplicationIdentifier"" type=""ns0:HD_361"" />
      <xs:element minOccurs=""1"" name=""MFI_3_FileLevelEventCode"" type=""ns0:ID_178"" />
      <xs:element minOccurs=""0"" name=""MFI_4_EnteredDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""MFI_5_EffectiveDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""MFI_6_ResponseLevelCode"" type=""ns0:ID_179"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MRG"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""MRG_1_PriorPatientIdentifierList"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MRG_2_PriorAlternatePatientId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""MRG_3_PriorPatientAccountNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""MRG_4_PriorPatientId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""MRG_5_PriorVisitNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""MRG_6_PriorAlternateVisitId"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""MRG_7_PriorPatientName"" type=""ns0:XPN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""MSA"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""MSA_1_AcknowledgmentCode"" type=""ns0:ID_8"" />
      <xs:element minOccurs=""1"" name=""MSA_2_MessageControlId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""MSA_3_TextMessage"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""MSA_4_ExpectedSequenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""MSA_5_DelayedAcknowledgmentType"" type=""ns0:ID"" />
      <xs:element minOccurs=""0"" name=""MSA_6_ErrorCondition"" type=""ns0:CE_357"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NCK"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""NCK_1_SystemDateTime"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NDS"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""NDS_1_NotificationReferenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""NDS_2_NotificationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""NDS_3_NotificationAlertSeverity"" type=""ns0:CE_367"" />
      <xs:element minOccurs=""1"" name=""NDS_4_NotificationCode"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NK1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""NK1_1_SetIdNk1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_2_Name"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""NK1_3_Relationship"" type=""ns0:CE_63"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_4_Address"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_5_PhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_6_BusinessPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""NK1_7_ContactRole"" type=""ns0:CE_131"" />
      <xs:element minOccurs=""0"" name=""NK1_8_StartDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""NK1_9_EndDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""NK1_10_NextOfKinAssociatedPartiesJobTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NK1_11_NextOfKinAssociatedPartiesJobCodeClass"" type=""ns0:JCC"" />
      <xs:element minOccurs=""0"" name=""NK1_12_NextOfKinAssociatedPartiesEmployeeNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_13_OrganizationNameNk1"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""NK1_14_MaritalStatus"" type=""ns0:CE_2"" />
      <xs:element minOccurs=""0"" name=""NK1_15_AdministrativeSex"" type=""ns0:IS_1"" />
      <xs:element minOccurs=""0"" name=""NK1_16_DateTimeOfBirth"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_17_LivingDependency"" type=""ns0:IS_223"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_18_AmbulatoryStatus"" type=""ns0:IS_9"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_19_Citizenship"" type=""ns0:CE_171"" />
      <xs:element minOccurs=""0"" name=""NK1_20_PrimaryLanguage"" type=""ns0:CE_296"" />
      <xs:element minOccurs=""0"" name=""NK1_21_LivingArrangement"" type=""ns0:IS_220"" />
      <xs:element minOccurs=""0"" name=""NK1_22_PublicityCode"" type=""ns0:CE_215"" />
      <xs:element minOccurs=""0"" name=""NK1_23_ProtectionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""NK1_24_StudentIndicator"" type=""ns0:IS_231"" />
      <xs:element minOccurs=""0"" name=""NK1_25_Religion"" type=""ns0:CE_6"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_26_MotherSMaidenName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""NK1_27_Nationality"" type=""ns0:CE_212"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_28_EthnicGroup"" type=""ns0:CE_189"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_29_ContactReason"" type=""ns0:CE_222"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_30_ContactPersonSName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_31_ContactPersonSTelephoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_32_ContactPersonSAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_33_NextOfKinAssociatedPartySIdentifiers"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""NK1_34_JobStatus"" type=""ns0:IS_311"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NK1_35_Race"" type=""ns0:CE_5"" />
      <xs:element minOccurs=""0"" name=""NK1_36_Handicap"" type=""ns0:IS_295"" />
      <xs:element minOccurs=""0"" name=""NK1_37_ContactPersonSocialSecurityNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NK1_38_NextOfKinBirthPlace"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NK1_39_VipIndicator"" type=""ns0:IS_99"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NPU"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""NPU_1_BedLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""NPU_2_BedStatus"" type=""ns0:IS_116"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NSC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""NSC_1_ApplicationChangeType"" type=""ns0:IS_409"" />
      <xs:element minOccurs=""0"" name=""NSC_2_CurrentCpu"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NSC_3_CurrentFileserver"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NSC_4_CurrentApplication"" type=""ns0:HD"" />
      <xs:element minOccurs=""0"" name=""NSC_5_CurrentFacility"" type=""ns0:HD"" />
      <xs:element minOccurs=""0"" name=""NSC_6_NewCpu"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NSC_7_NewFileserver"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NSC_8_NewApplication"" type=""ns0:HD"" />
      <xs:element minOccurs=""0"" name=""NSC_9_NewFacility"" type=""ns0:HD"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NST"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""NST_1_StatisticsAvailable"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""NST_2_SourceIdentifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""NST_3_SourceType"" type=""ns0:ID_332"" />
      <xs:element minOccurs=""0"" name=""NST_4_StatisticsStart"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""NST_5_StatisticsEnd"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""NST_6_ReceiveCharacterCount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_7_SendCharacterCount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_8_MessagesReceived"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_9_MessagesSent"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_10_ChecksumErrorsReceived"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_11_LengthErrorsReceived"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_12_OtherErrorsReceived"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_13_ConnectTimeouts"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_14_ReceiveTimeouts"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""NST_15_ApplicationControlLevelErrors"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""NTE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""NTE_1_SetIdNte"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""NTE_2_SourceOfComment"" type=""ns0:ID_105"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""NTE_3_Comment"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" name=""NTE_4_CommentType"" type=""ns0:CE_364"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OBR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OBR_1_SetIdObr"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""OBR_2_PlacerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""OBR_3_FillerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""OBR_4_UniversalServiceIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBR_5_Priority_Obr"" type=""ns0:ID"" />
      <xs:element minOccurs=""0"" name=""OBR_6_RequestedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBR_7_ObservationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBR_8_ObservationEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBR_9_CollectionVolume"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_10_CollectorIdentifier"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""OBR_11_SpecimenActionCode"" type=""ns0:ID_65"" />
      <xs:element minOccurs=""0"" name=""OBR_12_DangerCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBR_13_RelevantClinicalInformation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OBR_14_SpecimenReceivedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBR_15_SpecimenSource"" type=""ns0:SPS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_16_OrderingProvider"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_17_OrderCallbackPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""OBR_18_PlacerField1"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OBR_19_PlacerField2"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OBR_20_FillerField1"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OBR_21_FillerField2"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OBR_22_ResultsRptStatusChngDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBR_23_ChargeToPractice"" type=""ns0:MOC"" />
      <xs:element minOccurs=""0"" name=""OBR_24_DiagnosticServSectId"" type=""ns0:ID_74"" />
      <xs:element minOccurs=""0"" name=""OBR_25_ResultStatus"" type=""ns0:ID_123"" />
      <xs:element minOccurs=""0"" name=""OBR_26_ParentResult"" type=""ns0:PRL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_27_QuantityTiming"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_28_ResultCopiesTo"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""OBR_29_Parent"" type=""ns0:EIP"" />
      <xs:element minOccurs=""0"" name=""OBR_30_TransportationMode"" type=""ns0:ID_124"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_31_ReasonForStudy"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBR_32_PrincipalResultInterpreter"" type=""ns0:NDL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_33_AssistantResultInterpreter"" type=""ns0:NDL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_34_Technician"" type=""ns0:NDL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_35_Transcriptionist"" type=""ns0:NDL"" />
      <xs:element minOccurs=""0"" name=""OBR_36_ScheduledDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBR_37_NumberOfSampleContainers"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_38_TransportLogisticsOfCollectedSample"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_39_CollectorSComment"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBR_40_TransportArrangementResponsibility"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBR_41_TransportArranged"" type=""ns0:ID_224"" />
      <xs:element minOccurs=""0"" name=""OBR_42_EscortRequired"" type=""ns0:ID_225"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_43_PlannedPatientTransportComment"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBR_44_ProcedureCode"" type=""ns0:CE_88"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_45_ProcedureCodeModifier"" type=""ns0:CE_340"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_46_PlacerSupplementalServiceInformation"" type=""ns0:CE_411"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBR_47_FillerSupplementalServiceInformation"" type=""ns0:CE_411"" />
      <xs:element minOccurs=""0"" name=""OBR_48_MedicallyNecessaryDuplicateProcedureReason"" type=""ns0:CWE_476"" />
      <xs:element minOccurs=""0"" name=""OBR_49_ResultHandling"" type=""ns0:IS_507"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OBX"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OBX_1_SetIdObx"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""OBX_2_ValueType"" type=""ns0:ID_125"" />
      <xs:element minOccurs=""1"" name=""OBX_3_ObservationIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBX_4_ObservationSubId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_5_ObservationValue"" type=""ns0:varies"" />
      <xs:element minOccurs=""0"" name=""OBX_6_Units"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""OBX_7_ReferencesRange"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_8_AbnormalFlags"" type=""ns0:IS_78"" />
      <xs:element minOccurs=""0"" name=""OBX_9_Probability"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_10_NatureOfAbnormalTest"" type=""ns0:ID_80"" />
      <xs:element minOccurs=""1"" name=""OBX_11_ObservationResultStatus"" type=""ns0:ID_85"" />
      <xs:element minOccurs=""0"" name=""OBX_12_EffectiveDateOfReferenceRange"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBX_13_UserDefinedAccessChecks"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OBX_14_DateTimeOfTheObservation"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OBX_15_ProducerSId"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_16_ResponsibleObserver"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_17_ObservationMethod"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OBX_18_EquipmentInstanceIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""OBX_19_DateTimeOfTheAnalysis"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ODS"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ODS_1_Type"" type=""ns0:ID_159"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ODS_2_ServicePeriod"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ODS_3_DietSupplementOrPreferenceCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ODS_4_TextInstruction"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ODT"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ODT_1_TrayType"" type=""ns0:CE_160"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ODT_2_ServicePeriod"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ODT_3_TextInstruction"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""OM1_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""OM1_2_ProducerSServiceTestObservationId"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_3_PermittedDataTypes"" type=""ns0:ID_125"" />
      <xs:element minOccurs=""1"" name=""OM1_4_SpecimenRequired"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""1"" name=""OM1_5_ProducerId"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_6_ObservationDescription"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM1_7_OtherServiceTestObservationIdsForTheObservation"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""OM1_8_OtherNames"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM1_9_PreferredReportNameForTheObservation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM1_10_PreferredShortNameOrMnemonicForObservation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM1_11_PreferredLongNameForTheObservation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM1_12_Orderability"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_13_IdentityOfInstrumentUsedToPerformThisStudy"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_14_CodedRepresentationOfMethod"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_15_PortableDeviceIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_16_ObservationProducingDepartmentSection"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_17_TelephoneNumberOfSection"" type=""ns0:XTN"" />
      <xs:element minOccurs=""1"" name=""OM1_18_NatureOfServiceTestObservation"" type=""ns0:IS_174"" />
      <xs:element minOccurs=""0"" name=""OM1_19_ReportSubheader"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_20_ReportDisplayOrder"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM1_21_DateTimeStampForAnyChangeInDefinitionForTheObservation"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM1_22_EffectiveDateTimeOfChange"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM1_23_TypicalTurnAroundTime"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM1_24_ProcessingTime"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_25_ProcessingPriority"" type=""ns0:ID_168"" />
      <xs:element minOccurs=""0"" name=""OM1_26_ReportingPriority"" type=""ns0:ID_169"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_27_OutsideSiteSWhereObservationMayBePerformed"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_28_AddressOfOutsideSiteS"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""OM1_29_PhoneNumberOfOutsideSite"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""OM1_30_ConfidentialityCode"" type=""ns0:CWE_177"" />
      <xs:element minOccurs=""0"" name=""OM1_31_ObservationsRequiredToInterpretTheObservation"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_32_InterpretationOfObservations"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM1_33_ContraindicationsToObservations"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_34_ReflexTestsObservations"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_35_RulesThatTriggerReflexTesting"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM1_36_FixedCannedMessage"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_37_PatientPreparation"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM1_38_ProcedureMedication"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_39_FactorsThatMayAffectTheObservation"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM1_40_ServiceTestObservationPerformanceSchedule"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM1_41_DescriptionOfTestMethods"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM1_42_KindOfQuantityObserved"" type=""ns0:CE_254"" />
      <xs:element minOccurs=""0"" name=""OM1_43_PointVersusInterval"" type=""ns0:CE_255"" />
      <xs:element minOccurs=""0"" name=""OM1_44_ChallengeInformation"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM1_45_RelationshipModifier"" type=""ns0:CE_258"" />
      <xs:element minOccurs=""0"" name=""OM1_46_TargetAnatomicSiteOfTest"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM1_47_ModalityOfImagingMeasurement"" type=""ns0:CE_259"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OM2_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM2_2_UnitsOfMeasure"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM2_3_RangeOfDecimalPrecision"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM2_4_CorrespondingSiUnitsOfMeasure"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM2_5_SiConversionFactor"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM2_6_ReferenceNormalRangeOrdinalAndContinuousObservations"" type=""ns0:RFR"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM2_7_CriticalRangeForOrdinalAndContinuousObservations"" type=""ns0:RFR"" />
      <xs:element minOccurs=""0"" name=""OM2_8_AbsoluteRangeForOrdinalAndContinuousObservations"" type=""ns0:RFR"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM2_9_DeltaCheckCriteria"" type=""ns0:DLT"" />
      <xs:element minOccurs=""0"" name=""OM2_10_MinimumMeaningfulIncrements"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM3"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OM3_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM3_2_PreferredCodingSystem"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM3_3_ValidCodedAnswers"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM3_4_NormalTextCodesForCategoricalObservations"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM3_5_AbnormalTextCodesForCategoricalObservations"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM3_6_CriticalTextCodesForCategoricalObservations"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM3_7_ValueType"" type=""ns0:ID_125"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM4"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OM4_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM4_2_DerivedSpecimen"" type=""ns0:ID_170"" />
      <xs:element minOccurs=""0"" name=""OM4_3_ContainerDescription"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM4_4_ContainerVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM4_5_ContainerUnits"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM4_6_Specimen"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM4_7_Additive"" type=""ns0:CWE_371"" />
      <xs:element minOccurs=""0"" name=""OM4_8_Preparation"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM4_9_SpecialHandlingRequirements"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OM4_10_NormalCollectionVolume"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""OM4_11_MinimumCollectionVolume"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""OM4_12_SpecimenRequirements"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM4_13_SpecimenPriorities"" type=""ns0:ID_27"" />
      <xs:element minOccurs=""0"" name=""OM4_14_SpecimenRetentionTime"" type=""ns0:CQ"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM5"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OM5_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM5_2_TestObservationsIncludedWithinAnOrderedTestBattery"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM5_3_ObservationIdSuffixes"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM6"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OM6_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM6_2_DerivationRule"" type=""ns0:TX"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OM7"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""OM7_1_SequenceNumberTestObservationMasterFile"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""OM7_2_UniversalServiceIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM7_3_CategoryIdentifier"" type=""ns0:CE_412"" />
      <xs:element minOccurs=""0"" name=""OM7_4_CategoryDescription"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM7_5_CategorySynonym"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""OM7_6_EffectiveTestServiceStartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM7_7_EffectiveTestServiceEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM7_8_TestServiceDefaultDurationQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM7_9_TestServiceDefaultDurationUnits"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" name=""OM7_10_TestServiceDefaultFrequency"" type=""ns0:IS_335"" />
      <xs:element minOccurs=""0"" name=""OM7_11_ConsentIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""OM7_12_ConsentIdentifier"" type=""ns0:CE_413"" />
      <xs:element minOccurs=""0"" name=""OM7_13_ConsentEffectiveStartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM7_14_ConsentEffectiveEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM7_15_ConsentIntervalQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM7_16_ConsentIntervalUnits"" type=""ns0:CE_414"" />
      <xs:element minOccurs=""0"" name=""OM7_17_ConsentWaitingPeriodQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""OM7_18_ConsentWaitingPeriodUnits"" type=""ns0:CE_414"" />
      <xs:element minOccurs=""0"" name=""OM7_19_EffectiveDateTimeOfChange"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""OM7_20_EnteredBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM7_21_OrderableAtLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""OM7_22_FormularyStatus"" type=""ns0:IS_473"" />
      <xs:element minOccurs=""0"" name=""OM7_23_SpecialOrderIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OM7_24_PrimaryKeyValueCdm"" type=""ns0:CE_132"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ORC_1_OrderControl"" type=""ns0:ID_119"" />
      <xs:element minOccurs=""0"" name=""ORC_2_PlacerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ORC_3_FillerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ORC_4_PlacerGroupNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""ORC_5_OrderStatus"" type=""ns0:ID_38"" />
      <xs:element minOccurs=""0"" name=""ORC_6_ResponseFlag"" type=""ns0:ID_121"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_7_QuantityTiming"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" name=""ORC_8_Parent"" type=""ns0:EIP"" />
      <xs:element minOccurs=""0"" name=""ORC_9_DateTimeOfTransaction"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_10_EnteredBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_11_VerifiedBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_12_OrderingProvider"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""ORC_13_EntererSLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_14_CallBackPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""ORC_15_OrderEffectiveDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ORC_16_OrderControlCodeReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ORC_17_EnteringOrganization"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ORC_18_EnteringDevice"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_19_ActionBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""ORC_20_AdvancedBeneficiaryNoticeCode"" type=""ns0:CE_339"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_21_OrderingFacilityName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_22_OrderingFacilityAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_23_OrderingFacilityPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORC_24_OrderingProviderAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""ORC_25_OrderStatusModifier"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""ORC_26_AdvancedBeneficiaryNoticeOverrideReason"" type=""ns0:CWE_552"" />
      <xs:element minOccurs=""0"" name=""ORC_27_FillerSExpectedAvailabilityDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ORC_28_ConfidentialityCode"" type=""ns0:CWE_177"" />
      <xs:element minOccurs=""0"" name=""ORC_29_OrderType"" type=""ns0:CWE_482"" />
      <xs:element minOccurs=""0"" name=""ORC_30_EntererAuthorizationMode"" type=""ns0:CNE_483"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORG"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""ORG_1_SetId_Org"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""ORG_2_OrganizationUnitCode"" type=""ns0:CE_405"" />
      <xs:element minOccurs=""0"" name=""ORG_3_OrganizationUnitTypeCode"" type=""ns0:CE_474"" />
      <xs:element minOccurs=""0"" name=""ORG_4_PrimaryOrgUnitIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ORG_5_PractitionerOrgUnitIdentifier"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""ORG_6_HealthCareProviderTypeCode"" type=""ns0:CE_452"" />
      <xs:element minOccurs=""0"" name=""ORG_7_HealthCareProviderClassificationCode"" type=""ns0:CE_453"" />
      <xs:element minOccurs=""0"" name=""ORG_8_HealthCareProviderAreaOfSpecializationCode"" type=""ns0:CE_454"" />
      <xs:element minOccurs=""0"" name=""ORG_9_EffectiveDateRange"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""ORG_10_EmploymentStatusCode"" type=""ns0:CE_66"" />
      <xs:element minOccurs=""0"" name=""ORG_11_BoardApprovalIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""ORG_12_PrimaryCarePhysicianIndicator"" type=""ns0:ID_136"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""OVR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""OVR_1_BusinessRuleOverrideType"" type=""ns0:CWE_518"" />
      <xs:element minOccurs=""0"" name=""OVR_2_BusinessRuleOverrideCode"" type=""ns0:CWE_521"" />
      <xs:element minOccurs=""0"" name=""OVR_3_OverrideComments"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""OVR_4_OverrideEnteredBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""OVR_5_OverrideAuthorizedBy"" type=""ns0:XCN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PCR"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""PCR_1_ImplicatedProduct"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PCR_2_GenericProduct"" type=""ns0:IS_249"" />
      <xs:element minOccurs=""0"" name=""PCR_3_ProductClass"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PCR_4_TotalDurationOfTherapy"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""PCR_5_ProductManufactureDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PCR_6_ProductExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PCR_7_ProductImplantationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PCR_8_ProductExplantationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PCR_9_SingleUseDevice"" type=""ns0:IS_244"" />
      <xs:element minOccurs=""0"" name=""PCR_10_IndicationForProductUse"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PCR_11_ProductProblem"" type=""ns0:IS_245"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PCR_12_ProductSerialLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PCR_13_ProductAvailableForInspection"" type=""ns0:IS_246"" />
      <xs:element minOccurs=""0"" name=""PCR_14_ProductEvaluationPerformed"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PCR_15_ProductEvaluationStatus"" type=""ns0:CE_247"" />
      <xs:element minOccurs=""0"" name=""PCR_16_ProductEvaluationResults"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PCR_17_EvaluatedProductSource"" type=""ns0:ID_248"" />
      <xs:element minOccurs=""0"" name=""PCR_18_DateProductReturnedToManufacturer"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PCR_19_DeviceOperatorQualifications"" type=""ns0:ID_242"" />
      <xs:element minOccurs=""0"" name=""PCR_20_RelatednessAssessment"" type=""ns0:ID_250"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PCR_21_ActionTakenInResponseToTheEvent"" type=""ns0:ID_251"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PCR_22_EventCausalityObservations"" type=""ns0:ID_252"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PCR_23_IndirectExposureMechanism"" type=""ns0:ID_253"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PD1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PD1_1_LivingDependency"" type=""ns0:IS_223"" />
      <xs:element minOccurs=""0"" name=""PD1_2_LivingArrangement"" type=""ns0:IS_220"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PD1_3_PatientPrimaryFacility"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PD1_4_PatientPrimaryCareProviderNameIdNo"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""PD1_5_StudentIndicator"" type=""ns0:IS_231"" />
      <xs:element minOccurs=""0"" name=""PD1_6_Handicap"" type=""ns0:IS_295"" />
      <xs:element minOccurs=""0"" name=""PD1_7_LivingWillCode"" type=""ns0:IS_315"" />
      <xs:element minOccurs=""0"" name=""PD1_8_OrganDonorCode"" type=""ns0:IS_316"" />
      <xs:element minOccurs=""0"" name=""PD1_9_SeparateBill"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PD1_10_DuplicatePatient"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""PD1_11_PublicityCode"" type=""ns0:CE_215"" />
      <xs:element minOccurs=""0"" name=""PD1_12_ProtectionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PD1_13_ProtectionIndicatorEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PD1_14_PlaceOfWorship"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PD1_15_AdvanceDirectiveCode"" type=""ns0:CE_435"" />
      <xs:element minOccurs=""0"" name=""PD1_16_ImmunizationRegistryStatus"" type=""ns0:IS_441"" />
      <xs:element minOccurs=""0"" name=""PD1_17_ImmunizationRegistryStatusEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PD1_18_PublicityCodeEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PD1_19_MilitaryBranch"" type=""ns0:IS_140"" />
      <xs:element minOccurs=""0"" name=""PD1_20_MilitaryRankGrade"" type=""ns0:IS_141"" />
      <xs:element minOccurs=""0"" name=""PD1_21_MilitaryStatus"" type=""ns0:IS_142"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PDA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PDA_1_DeathCauseCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PDA_2_DeathLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""PDA_3_DeathCertifiedIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PDA_4_DeathCertificateSignedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PDA_5_DeathCertifiedBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""PDA_6_AutopsyIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PDA_7_AutopsyStartAndEndDateTime"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""PDA_8_AutopsyPerformedBy"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""PDA_9_CoronerIndicator"" type=""ns0:ID_136"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PDC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""PDC_1_ManufacturerDistributor"" type=""ns0:XON"" />
      <xs:element minOccurs=""1"" name=""PDC_2_Country"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""PDC_3_BrandName"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PDC_4_DeviceFamilyName"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PDC_5_GenericName"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PDC_6_ModelIdentifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PDC_7_CatalogueIdentifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PDC_8_OtherIdentifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PDC_9_ProductCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PDC_10_MarketingBasis"" type=""ns0:ID_330"" />
      <xs:element minOccurs=""0"" name=""PDC_11_MarketingApprovalId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PDC_12_LabeledShelfLife"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""PDC_13_ExpectedShelfLife"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""PDC_14_DateFirstMarketed"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PDC_15_DateLastMarketed"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PEO"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_1_EventIdentifiersUsed"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_2_EventSymptomDiagnosisCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""PEO_3_EventOnsetDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PEO_4_EventExacerbationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PEO_5_EventImprovedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PEO_6_EventEndedDataTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_7_EventLocationOccurredAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_8_EventQualification"" type=""ns0:ID_237"" />
      <xs:element minOccurs=""0"" name=""PEO_9_EventSerious"" type=""ns0:ID_238"" />
      <xs:element minOccurs=""0"" name=""PEO_10_EventExpected"" type=""ns0:ID_239"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_11_EventOutcome"" type=""ns0:ID_240"" />
      <xs:element minOccurs=""0"" name=""PEO_12_PatientOutcome"" type=""ns0:ID_241"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_13_EventDescriptionFromOthers"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_14_EventFromOriginalReporter"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_15_EventDescriptionFromPatient"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_16_EventDescriptionFromPractitioner"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_17_EventDescriptionFromAutopsy"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_18_CauseOfDeath"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_19_PrimaryObserverName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_20_PrimaryObserverAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PEO_21_PrimaryObserverTelephone"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""PEO_22_PrimaryObserverSQualification"" type=""ns0:ID_242"" />
      <xs:element minOccurs=""0"" name=""PEO_23_ConfirmationProvidedBy"" type=""ns0:ID_242"" />
      <xs:element minOccurs=""0"" name=""PEO_24_PrimaryObserverAwareDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PEO_25_PrimaryObserverSIdentityMayBeDivulged"" type=""ns0:ID_243"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PES"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_1_SenderOrganizationName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_2_SenderIndividualName"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_3_SenderAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_4_SenderTelephone"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""PES_5_SenderEventIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""PES_6_SenderSequenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_7_SenderEventDescription"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" name=""PES_8_SenderComment"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" name=""PES_9_SenderAwareDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""PES_10_EventReportDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_11_EventReportTimingType"" type=""ns0:ID_234"" />
      <xs:element minOccurs=""0"" name=""PES_12_EventReportSource"" type=""ns0:ID_235"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PES_13_EventReportedTo"" type=""ns0:ID_236"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PID"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PID_1_SetIdPid"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""PID_2_PatientId"" type=""ns0:CX"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""PID_3_PatientIdentifierList"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_4_AlternatePatientIdPid"" type=""ns0:CX"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""PID_5_PatientName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_6_MotherSMaidenName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" name=""PID_7_DateTimeOfBirth"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PID_8_AdministrativeSex"" type=""ns0:IS_1"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_9_PatientAlias"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_10_Race"" type=""ns0:CE_5"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_11_PatientAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""PID_12_CountyCode"" type=""ns0:IS_289"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_13_PhoneNumberHome"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_14_PhoneNumberBusiness"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""PID_15_PrimaryLanguage"" type=""ns0:CE_296"" />
      <xs:element minOccurs=""0"" name=""PID_16_MaritalStatus"" type=""ns0:CE_2"" />
      <xs:element minOccurs=""0"" name=""PID_17_Religion"" type=""ns0:CE_6"" />
      <xs:element minOccurs=""0"" name=""PID_18_PatientAccountNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""PID_19_SsnNumberPatient"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PID_20_DriverSLicenseNumberPatient"" type=""ns0:DLN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_21_MotherSIdentifier"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_22_EthnicGroup"" type=""ns0:CE_189"" />
      <xs:element minOccurs=""0"" name=""PID_23_BirthPlace"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PID_24_MultipleBirthIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PID_25_BirthOrder"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_26_Citizenship"" type=""ns0:CE_171"" />
      <xs:element minOccurs=""0"" name=""PID_27_VeteransMilitaryStatus"" type=""ns0:CE_172"" />
      <xs:element minOccurs=""0"" name=""PID_28_Nationality"" type=""ns0:CE_212"" />
      <xs:element minOccurs=""0"" name=""PID_29_PatientDeathDateAndTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PID_30_PatientDeathIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PID_31_IdentityUnknownIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_32_IdentityReliabilityCode"" type=""ns0:IS_445"" />
      <xs:element minOccurs=""0"" name=""PID_33_LastUpdateDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PID_34_LastUpdateFacility"" type=""ns0:HD"" />
      <xs:element minOccurs=""0"" name=""PID_35_SpeciesCode"" type=""ns0:CE_446"" />
      <xs:element minOccurs=""0"" name=""PID_36_BreedCode"" type=""ns0:CE_447"" />
      <xs:element minOccurs=""0"" name=""PID_37_Strain"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PID_38_ProductionClassCode"" type=""ns0:CE_429"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PID_39_TribalCitizenship"" type=""ns0:CWE_171"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PR1"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""PR1_1_SetIdPr1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""PR1_2_ProcedureCodingMethod"" type=""ns0:IS_89"" />
      <xs:element minOccurs=""1"" name=""PR1_3_ProcedureCode"" type=""ns0:CE_88"" />
      <xs:element minOccurs=""0"" name=""PR1_4_ProcedureDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""PR1_5_ProcedureDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PR1_6_ProcedureFunctionalType"" type=""ns0:IS_230"" />
      <xs:element minOccurs=""0"" name=""PR1_7_ProcedureMinutes"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PR1_8_Anesthesiologist"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" name=""PR1_9_AnesthesiaCode"" type=""ns0:IS_19"" />
      <xs:element minOccurs=""0"" name=""PR1_10_AnesthesiaMinutes"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PR1_11_Surgeon"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PR1_12_ProcedurePractitioner"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" name=""PR1_13_ConsentCode"" type=""ns0:CE_59"" />
      <xs:element minOccurs=""0"" name=""PR1_14_ProcedurePriority"" type=""ns0:ID_418"" />
      <xs:element minOccurs=""0"" name=""PR1_15_AssociatedDiagnosisCode"" type=""ns0:CE_51"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PR1_16_ProcedureCodeModifier"" type=""ns0:CE_340"" />
      <xs:element minOccurs=""0"" name=""PR1_17_ProcedureDrgType"" type=""ns0:IS_416"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PR1_18_TissueTypeCode"" type=""ns0:CE_417"" />
      <xs:element minOccurs=""0"" name=""PR1_19_ProcedureIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""PR1_20_ProcedureActionCode"" type=""ns0:ID_206"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PRA"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PRA_1_PrimaryKeyValuePra"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRA_2_PractitionerGroup"" type=""ns0:CE_358"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRA_3_PractitionerCategory"" type=""ns0:IS_186"" />
      <xs:element minOccurs=""0"" name=""PRA_4_ProviderBilling"" type=""ns0:ID_187"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRA_5_Specialty"" type=""ns0:SPD_337"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRA_6_PractitionerIdNumbers"" type=""ns0:PLN_338"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRA_7_Privileges"" type=""ns0:PIP"" />
      <xs:element minOccurs=""0"" name=""PRA_8_DateEnteredPractice"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PRA_9_Institution"" type=""ns0:CE_537"" />
      <xs:element minOccurs=""0"" name=""PRA_10_DateLeftPractice"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRA_11_GovernmentReimbursementBillingEligibility"" type=""ns0:CE_401"" />
      <xs:element minOccurs=""0"" name=""PRA_12_SetIdPra"" type=""ns0:SI"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PRB"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""PRB_1_ActionCode"" type=""ns0:ID_287"" />
      <xs:element minOccurs=""1"" name=""PRB_2_ActionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""PRB_3_ProblemId"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""PRB_4_ProblemInstanceId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""PRB_5_EpisodeOfCareId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""PRB_6_ProblemListPriority"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PRB_7_ProblemEstablishedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRB_8_AnticipatedProblemResolutionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRB_9_ActualProblemResolutionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRB_10_ProblemClassification"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRB_11_ProblemManagementDiscipline"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_12_ProblemPersistence"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_13_ProblemConfirmationStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_14_ProblemLifeCycleStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_15_ProblemLifeCycleStatusDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRB_16_ProblemDateOfOnset"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRB_17_ProblemOnsetText"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PRB_18_ProblemRanking"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_19_CertaintyOfProblem"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_20_ProbabilityOfProblem01"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PRB_21_IndividualAwarenessOfProblem"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_22_ProblemPrognosis"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_23_IndividualAwarenessOfPrognosis"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PRB_24_FamilySignificantOtherAwarenessOfProblemPrognosis"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PRB_25_SecuritySensitivity"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PRC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""PRC_1_PrimaryKeyValuePrc"" type=""ns0:CE_132"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRC_2_FacilityIdPrc"" type=""ns0:CE_464"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRC_3_Department"" type=""ns0:CE_184"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRC_4_ValidPatientClasses"" type=""ns0:IS_4"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRC_5_Price"" type=""ns0:CP"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRC_6_Formula"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PRC_7_MinimumQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PRC_8_MaximumQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PRC_9_MinimumPrice"" type=""ns0:MO"" />
      <xs:element minOccurs=""0"" name=""PRC_10_MaximumPrice"" type=""ns0:MO"" />
      <xs:element minOccurs=""0"" name=""PRC_11_EffectiveStartDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRC_12_EffectiveEndDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRC_13_PriceOverrideFlag"" type=""ns0:IS_268"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRC_14_BillingCategory"" type=""ns0:CE_293"" />
      <xs:element minOccurs=""0"" name=""PRC_15_ChargeableFlag"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PRC_16_ActiveInactiveFlag"" type=""ns0:ID_183"" />
      <xs:element minOccurs=""0"" name=""PRC_17_Cost"" type=""ns0:MO"" />
      <xs:element minOccurs=""0"" name=""PRC_18_ChargeOnIndicator"" type=""ns0:IS_269"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PRD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""PRD_1_ProviderRole"" type=""ns0:CE_286"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRD_2_ProviderName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRD_3_ProviderAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""PRD_4_ProviderLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRD_5_ProviderCommunicationInformation"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""PRD_6_PreferredMethodOfContact"" type=""ns0:CE_185"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PRD_7_ProviderIdentifiers"" type=""ns0:PLN"" />
      <xs:element minOccurs=""0"" name=""PRD_8_EffectiveStartDateOfProviderRole"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PRD_9_EffectiveEndDateOfProviderRole"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PSH"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""PSH_1_ReportType"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PSH_2_ReportFormIdentifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""PSH_3_ReportDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PSH_4_ReportIntervalStartDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PSH_5_ReportIntervalEndDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PSH_6_QuantityManufactured"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""PSH_7_QuantityDistributed"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""PSH_8_QuantityDistributedMethod"" type=""ns0:ID_329"" />
      <xs:element minOccurs=""0"" name=""PSH_9_QuantityDistributedComment"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" name=""PSH_10_QuantityInUse"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""PSH_11_QuantityInUseMethod"" type=""ns0:ID_329"" />
      <xs:element minOccurs=""0"" name=""PSH_12_QuantityInUseComment"" type=""ns0:FT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PSH_13_NumberOfProductExperienceReportsFiledByFacility"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PSH_14_NumberOfProductExperienceReportsFiledByDistributor"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PTH"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""PTH_1_ActionCode"" type=""ns0:ID_287"" />
      <xs:element minOccurs=""1"" name=""PTH_2_PathwayId"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""PTH_3_PathwayInstanceId"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""PTH_4_PathwayEstablishedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PTH_5_PathwayLifeCycleStatus"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PTH_6_ChangePathwayLifeCycleStatusDateTime"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PV1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PV1_1_SetIdPv1"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""PV1_2_PatientClass"" type=""ns0:IS_4"" />
      <xs:element minOccurs=""0"" name=""PV1_3_AssignedPatientLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""PV1_4_AdmissionType"" type=""ns0:IS_7"" />
      <xs:element minOccurs=""0"" name=""PV1_5_PreadmitNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" name=""PV1_6_PriorPatientLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_7_AttendingDoctor"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_8_ReferringDoctor"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_9_ConsultingDoctor"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" name=""PV1_10_HospitalService"" type=""ns0:IS_69"" />
      <xs:element minOccurs=""0"" name=""PV1_11_TemporaryLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""PV1_12_PreadmitTestIndicator"" type=""ns0:IS_87"" />
      <xs:element minOccurs=""0"" name=""PV1_13_ReAdmissionIndicator"" type=""ns0:IS_92"" />
      <xs:element minOccurs=""0"" name=""PV1_14_AdmitSource"" type=""ns0:IS_23"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_15_AmbulatoryStatus"" type=""ns0:IS_9"" />
      <xs:element minOccurs=""0"" name=""PV1_16_VipIndicator"" type=""ns0:IS_99"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_17_AdmittingDoctor"" type=""ns0:XCN_10"" />
      <xs:element minOccurs=""0"" name=""PV1_18_PatientType"" type=""ns0:IS_18"" />
      <xs:element minOccurs=""0"" name=""PV1_19_VisitNumber"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_20_FinancialClass"" type=""ns0:FC_64"" />
      <xs:element minOccurs=""0"" name=""PV1_21_ChargePriceIndicator"" type=""ns0:IS_32"" />
      <xs:element minOccurs=""0"" name=""PV1_22_CourtesyCode"" type=""ns0:IS_45"" />
      <xs:element minOccurs=""0"" name=""PV1_23_CreditRating"" type=""ns0:IS_46"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_24_ContractCode"" type=""ns0:IS_44"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_25_ContractEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_26_ContractAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_27_ContractPeriod"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_28_InterestCode"" type=""ns0:IS_73"" />
      <xs:element minOccurs=""0"" name=""PV1_29_TransferToBadDebtCode"" type=""ns0:IS_110"" />
      <xs:element minOccurs=""0"" name=""PV1_30_TransferToBadDebtDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV1_31_BadDebtAgencyCode"" type=""ns0:IS_21"" />
      <xs:element minOccurs=""0"" name=""PV1_32_BadDebtTransferAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_33_BadDebtRecoveryAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_34_DeleteAccountIndicator"" type=""ns0:IS_111"" />
      <xs:element minOccurs=""0"" name=""PV1_35_DeleteAccountDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV1_36_DischargeDisposition"" type=""ns0:IS_112"" />
      <xs:element minOccurs=""0"" name=""PV1_37_DischargedToLocation"" type=""ns0:DLD_113"" />
      <xs:element minOccurs=""0"" name=""PV1_38_DietType"" type=""ns0:CE_114"" />
      <xs:element minOccurs=""0"" name=""PV1_39_ServicingFacility"" type=""ns0:IS_115"" />
      <xs:element minOccurs=""0"" name=""PV1_40_BedStatus"" type=""ns0:IS_116"" />
      <xs:element minOccurs=""0"" name=""PV1_41_AccountStatus"" type=""ns0:IS_117"" />
      <xs:element minOccurs=""0"" name=""PV1_42_PendingLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""PV1_43_PriorTemporaryLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""PV1_44_AdmitDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_45_DischargeDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PV1_46_CurrentPatientBalance"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_47_TotalCharges"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_48_TotalAdjustments"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_49_TotalPayments"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV1_50_AlternateVisitId"" type=""ns0:CX_203"" />
      <xs:element minOccurs=""0"" name=""PV1_51_VisitIndicator"" type=""ns0:IS_326"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV1_52_OtherHealthcareProvider"" type=""ns0:XCN_10"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""PV2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""PV2_1_PriorPendingLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""PV2_2_AccommodationCode"" type=""ns0:CE_129"" />
      <xs:element minOccurs=""0"" name=""PV2_3_AdmitReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""PV2_4_TransferReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_5_PatientValuables"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""PV2_6_PatientValuablesLocation"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_7_VisitUserCode"" type=""ns0:IS_130"" />
      <xs:element minOccurs=""0"" name=""PV2_8_ExpectedAdmitDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PV2_9_ExpectedDischargeDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PV2_10_EstimatedLengthOfInpatientStay"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV2_11_ActualLengthOfInpatientStay"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV2_12_VisitDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_13_ReferralSourceCode"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""PV2_14_PreviousServiceDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV2_15_EmploymentIllnessRelatedIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_16_PurgeStatusCode"" type=""ns0:IS_213"" />
      <xs:element minOccurs=""0"" name=""PV2_17_PurgeStatusDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV2_18_SpecialProgramCode"" type=""ns0:IS_214"" />
      <xs:element minOccurs=""0"" name=""PV2_19_RetentionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_20_ExpectedNumberOfInsurancePlans"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""PV2_21_VisitPublicityCode"" type=""ns0:IS_215"" />
      <xs:element minOccurs=""0"" name=""PV2_22_VisitProtectionIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_23_ClinicOrganizationName"" type=""ns0:XON"" />
      <xs:element minOccurs=""0"" name=""PV2_24_PatientStatusCode"" type=""ns0:IS_216"" />
      <xs:element minOccurs=""0"" name=""PV2_25_VisitPriorityCode"" type=""ns0:IS_217"" />
      <xs:element minOccurs=""0"" name=""PV2_26_PreviousTreatmentDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV2_27_ExpectedDischargeDisposition"" type=""ns0:IS_112"" />
      <xs:element minOccurs=""0"" name=""PV2_28_SignatureOnFileDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV2_29_FirstSimilarIllnessDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV2_30_PatientChargeAdjustmentCode"" type=""ns0:CE_218"" />
      <xs:element minOccurs=""0"" name=""PV2_31_RecurringServiceCode"" type=""ns0:IS_219"" />
      <xs:element minOccurs=""0"" name=""PV2_32_BillingMediaCode"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_33_ExpectedSurgeryDateAndTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PV2_34_MilitaryPartnershipCode"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_35_MilitaryNonAvailabilityCode"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_36_NewbornBabyIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_37_BabyDetainedIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""PV2_38_ModeOfArrivalCode"" type=""ns0:CE_430"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_39_RecreationalDrugUseCode"" type=""ns0:CE_431"" />
      <xs:element minOccurs=""0"" name=""PV2_40_AdmissionLevelOfCareCode"" type=""ns0:CE_432"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_41_PrecautionCode"" type=""ns0:CE_433"" />
      <xs:element minOccurs=""0"" name=""PV2_42_PatientConditionCode"" type=""ns0:CE_434"" />
      <xs:element minOccurs=""0"" name=""PV2_43_LivingWillCode"" type=""ns0:IS_315"" />
      <xs:element minOccurs=""0"" name=""PV2_44_OrganDonorCode"" type=""ns0:IS_316"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_45_AdvanceDirectiveCode"" type=""ns0:CE_435"" />
      <xs:element minOccurs=""0"" name=""PV2_46_PatientStatusEffectiveDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""PV2_47_ExpectedLoaReturnDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""PV2_48_ExpectedPreAdmissionTestingDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PV2_49_NotifyClergyCode"" type=""ns0:IS_534"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QAK"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""QAK_1_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""QAK_2_QueryResponseStatus"" type=""ns0:ID_208"" />
      <xs:element minOccurs=""0"" name=""QAK_3_MessageQueryName"" type=""ns0:CE_471"" />
      <xs:element minOccurs=""0"" name=""QAK_4_HitCount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""QAK_5_ThisPayload"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""QAK_6_HitsRemaining"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QID"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""QID_1_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""QID_2_MessageQueryName"" type=""ns0:CE_471"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QPD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""QPD_1_MessageQueryName"" type=""ns0:CE_471"" />
      <xs:element minOccurs=""0"" name=""QPD_2_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""QPD_3_UserParametersInSuccessiveFields"" type=""ns0:varies"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QRD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""QRD_1_QueryDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""QRD_2_QueryFormatCode"" type=""ns0:ID_106"" />
      <xs:element minOccurs=""1"" name=""QRD_3_QueryPriority"" type=""ns0:ID_91"" />
      <xs:element minOccurs=""1"" name=""QRD_4_QueryId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""QRD_5_DeferredResponseType"" type=""ns0:ID_107"" />
      <xs:element minOccurs=""0"" name=""QRD_6_DeferredResponseDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""QRD_7_QuantityLimitedRequest"" type=""ns0:CQ_126"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""QRD_8_WhoSubjectFilter"" type=""ns0:XCN"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""QRD_9_WhatSubjectFilter"" type=""ns0:CE_48"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""QRD_10_WhatDepartmentDataCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRD_11_WhatDataCodeValueQual"" type=""ns0:VR"" />
      <xs:element minOccurs=""0"" name=""QRD_12_QueryResultsLevel"" type=""ns0:ID_108"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QRF"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""QRF_1_WhereSubjectFilter"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""QRF_2_WhenDataStartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""QRF_3_WhenDataEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRF_4_WhatUserQualifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRF_5_OtherQrySubjectFilter"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRF_6_WhichDateTimeQualifier"" type=""ns0:ID_156"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRF_7_WhichDateTimeStatusQualifier"" type=""ns0:ID_157"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRF_8_DateTimeSelectionQualifier"" type=""ns0:ID_158"" />
      <xs:element minOccurs=""0"" name=""QRF_9_WhenQuantityTimingQualifier"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" name=""QRF_10_SearchConfidenceThreshold"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""QRI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""QRI_1_CandidateConfidence"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""QRI_2_MatchReasonCode"" type=""ns0:IS_392"" />
      <xs:element minOccurs=""0"" name=""QRI_3_AlgorithmDescriptor"" type=""ns0:CE_393"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RCP"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RCP_1_QueryPriority"" type=""ns0:ID_91"" />
      <xs:element minOccurs=""0"" name=""RCP_2_QuantityLimitedRequest"" type=""ns0:CQ_126"" />
      <xs:element minOccurs=""0"" name=""RCP_3_ResponseModality"" type=""ns0:CE_394"" />
      <xs:element minOccurs=""0"" name=""RCP_4_ExecutionAndDeliveryTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RCP_5_ModifyIndicator"" type=""ns0:ID_395"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RCP_6_SortByField"" type=""ns0:SRT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RCP_7_SegmentGroupInclusion"" type=""ns0:ID"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RDF"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RDF_1_NumberOfColumnsPerRow"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""RDF_2_ColumnDescription"" type=""ns0:RCD_440"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RDT"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RDT_1_ColumnValue"" type=""ns0:varies"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RF1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RF1_1_ReferralStatus"" type=""ns0:CE_283"" />
      <xs:element minOccurs=""0"" name=""RF1_2_ReferralPriority"" type=""ns0:CE_280"" />
      <xs:element minOccurs=""0"" name=""RF1_3_ReferralType"" type=""ns0:CE_281"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RF1_4_ReferralDisposition"" type=""ns0:CE_282"" />
      <xs:element minOccurs=""0"" name=""RF1_5_ReferralCategory"" type=""ns0:CE_284"" />
      <xs:element minOccurs=""1"" name=""RF1_6_OriginatingReferralIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""RF1_7_EffectiveDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RF1_8_ExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RF1_9_ProcessDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RF1_10_ReferralReason"" type=""ns0:CE_336"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RF1_11_ExternalReferralIdentifier"" type=""ns0:EI"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RGS"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RGS_1_SetIdRgs"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""RGS_2_SegmentActionCode"" type=""ns0:ID_206"" />
      <xs:element minOccurs=""0"" name=""RGS_3_ResourceGroupId"" type=""ns0:CE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RMI"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RMI_1_RiskManagementIncidentCode"" type=""ns0:CE_427"" />
      <xs:element minOccurs=""0"" name=""RMI_2_DateTimeIncident"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RMI_3_IncidentTypeCode"" type=""ns0:CE_428"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ROL"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""ROL_1_RoleInstanceId"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""ROL_2_ActionCode"" type=""ns0:ID_287"" />
      <xs:element minOccurs=""1"" name=""ROL_3_RoleRol"" type=""ns0:CE_443"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""ROL_4_RolePerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""ROL_5_RoleBeginDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ROL_6_RoleEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""ROL_7_RoleDuration"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ROL_8_RoleActionReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_9_ProviderType"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""ROL_10_OrganizationUnitType"" type=""ns0:CE_406"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_11_OfficeHomeAddressBirthplace"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ROL_12_Phone"" type=""ns0:XTN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RQ1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RQ1_1_AnticipatedPrice"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RQ1_2_ManufacturerIdentifier"" type=""ns0:CE_385"" />
      <xs:element minOccurs=""0"" name=""RQ1_3_ManufacturerSCatalog"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RQ1_4_VendorId"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RQ1_5_VendorCatalog"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RQ1_6_Taxable"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""RQ1_7_SubstituteAllowed"" type=""ns0:ID_136"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RQD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RQD_1_RequisitionLineNumber"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""RQD_2_ItemCodeInternal"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RQD_3_ItemCodeExternal"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RQD_4_HospitalItemCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RQD_5_RequisitionQuantity"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RQD_6_RequisitionUnitOfMeasure"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RQD_7_DeptCostCenter"" type=""ns0:IS_319"" />
      <xs:element minOccurs=""0"" name=""RQD_8_ItemNaturalAccountCode"" type=""ns0:IS_320"" />
      <xs:element minOccurs=""0"" name=""RQD_9_DeliverToId"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RQD_10_DateNeeded"" type=""ns0:DT"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXA"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RXA_1_GiveSubIdCounter"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""RXA_2_AdministrationSubIdCounter"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""RXA_3_DateTimeStartOfAdministration"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""RXA_4_DateTimeEndOfAdministration"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""RXA_5_AdministeredCode"" type=""ns0:CE_292"" />
      <xs:element minOccurs=""1"" name=""RXA_6_AdministeredAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXA_7_AdministeredUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXA_8_AdministeredDosageForm"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_9_AdministrationNotes"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_10_AdministeringProvider"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""RXA_11_AdministeredAtLocation"" type=""ns0:LA2"" />
      <xs:element minOccurs=""0"" name=""RXA_12_AdministeredPerTimeUnit"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXA_13_AdministeredStrength"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXA_14_AdministeredStrengthUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_15_SubstanceLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_16_SubstanceExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_17_SubstanceManufacturerName"" type=""ns0:CE_227"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_18_SubstanceTreatmentRefusalReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXA_19_Indication"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXA_20_CompletionStatus"" type=""ns0:ID_322"" />
      <xs:element minOccurs=""0"" name=""RXA_21_ActionCodeRxa"" type=""ns0:ID_323"" />
      <xs:element minOccurs=""0"" name=""RXA_22_SystemEntryDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RXA_23_AdministeredDrugStrengthVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXA_24_AdministeredDrugStrengthVolumeUnits"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXA_25_AdministeredBarcodeIdentifier"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXA_26_PharmacyOrderType"" type=""ns0:ID_480"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RXC_1_RxComponentType"" type=""ns0:ID_166"" />
      <xs:element minOccurs=""1"" name=""RXC_2_ComponentCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""RXC_3_ComponentAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""RXC_4_ComponentUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXC_5_ComponentStrength"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXC_6_ComponentStrengthUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXC_7_SupplementaryCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXC_8_ComponentDrugStrengthVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXC_9_ComponentDrugStrengthVolumeUnits"" type=""ns0:CWE"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RXD_1_DispenseSubIdCounter"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""RXD_2_DispenseGiveCode"" type=""ns0:CE_292"" />
      <xs:element minOccurs=""1"" name=""RXD_3_DateTimeDispensed"" type=""ns0:TS"" />
      <xs:element minOccurs=""1"" name=""RXD_4_ActualDispenseAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXD_5_ActualDispenseUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_6_ActualDosageForm"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""RXD_7_PrescriptionNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXD_8_NumberOfRefillsRemaining"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_9_DispenseNotes"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_10_DispensingProvider"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""RXD_11_SubstitutionStatus"" type=""ns0:ID_167"" />
      <xs:element minOccurs=""0"" name=""RXD_12_TotalDailyDose"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""RXD_13_DispenseToLocation"" type=""ns0:LA2"" />
      <xs:element minOccurs=""0"" name=""RXD_14_NeedsHumanReview"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_15_PharmacyTreatmentSupplierSSpecialDispensingInstructions"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_16_ActualStrength"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXD_17_ActualStrengthUnit"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_18_SubstanceLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_19_SubstanceExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_20_SubstanceManufacturerName"" type=""ns0:CE_227"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_21_Indication"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_22_DispensePackageSize"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXD_23_DispensePackageSizeUnit"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_24_DispensePackageMethod"" type=""ns0:ID_321"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXD_25_SupplementaryCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_26_InitiatingLocation"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_27_PackagingAssemblyLocation"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXD_28_ActualDrugStrengthVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXD_29_ActualDrugStrengthVolumeUnits"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXD_30_DispenseToPharmacy"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXD_31_DispenseToPharmacyAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""RXD_32_PharmacyOrderType"" type=""ns0:ID_480"" />
      <xs:element minOccurs=""0"" name=""RXD_33_DispenseType"" type=""ns0:CWE_484"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXE"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RXE_1_QuantityTiming"" type=""ns0:TQ"" />
      <xs:element minOccurs=""1"" name=""RXE_2_GiveCode"" type=""ns0:CE_292"" />
      <xs:element minOccurs=""1"" name=""RXE_3_GiveAmountMinimum"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_4_GiveAmountMaximum"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""RXE_5_GiveUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_6_GiveDosageForm"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_7_ProviderSAdministrationInstructions"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_8_DeliverToLocation"" type=""ns0:LA1"" />
      <xs:element minOccurs=""0"" name=""RXE_9_SubstitutionStatus"" type=""ns0:ID_167"" />
      <xs:element minOccurs=""0"" name=""RXE_10_DispenseAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_11_DispenseUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_12_NumberOfRefills"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_13_OrderingProviderSDeaNumber"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_14_PharmacistTreatmentSupplierSVerifierId"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""RXE_15_PrescriptionNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXE_16_NumberOfRefillsRemaining"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_17_NumberOfRefillsDosesDispensed"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_18_DTOfMostRecentRefillOrDoseDispensed"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RXE_19_TotalDailyDose"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""RXE_20_NeedsHumanReview"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_21_PharmacyTreatmentSupplierSSpecialDispensingInstructions"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_22_GivePerTimeUnit"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXE_23_GiveRateAmount"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXE_24_GiveRateUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_25_GiveStrength"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_26_GiveStrengthUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_27_GiveIndication"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_28_DispensePackageSize"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_29_DispensePackageSizeUnit"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_30_DispensePackageMethod"" type=""ns0:ID_321"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_31_SupplementaryCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXE_32_OriginalOrderDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""RXE_33_GiveDrugStrengthVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_34_GiveDrugStrengthVolumeUnits"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXE_35_ControlledSubstanceSchedule"" type=""ns0:CWE_477"" />
      <xs:element minOccurs=""0"" name=""RXE_36_FormularyStatus"" type=""ns0:ID_478"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXE_37_PharmaceuticalSubstanceAlternative"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXE_38_PharmacyOfMostRecentFill"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXE_39_InitialDispenseAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXE_40_DispensingPharmacy"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXE_41_DispensingPharmacyAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""RXE_42_DeliverToPatientLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""RXE_43_DeliverToAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""RXE_44_PharmacyOrderType"" type=""ns0:ID_480"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXG"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RXG_1_GiveSubIdCounter"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXG_2_DispenseSubIdCounter"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXG_3_QuantityTiming"" type=""ns0:TQ"" />
      <xs:element minOccurs=""1"" name=""RXG_4_GiveCode"" type=""ns0:CE_292"" />
      <xs:element minOccurs=""1"" name=""RXG_5_GiveAmountMinimum"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXG_6_GiveAmountMaximum"" type=""ns0:NM"" />
      <xs:element minOccurs=""1"" name=""RXG_7_GiveUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXG_8_GiveDosageForm"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXG_9_AdministrationNotes"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXG_10_SubstitutionStatus"" type=""ns0:ID_167"" />
      <xs:element minOccurs=""0"" name=""RXG_11_DispenseToLocation"" type=""ns0:LA2"" />
      <xs:element minOccurs=""0"" name=""RXG_12_NeedsHumanReview"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXG_13_PharmacyTreatmentSupplierSSpecialAdministrationInstructions"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXG_14_GivePerTimeUnit"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXG_15_GiveRateAmount"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXG_16_GiveRateUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXG_17_GiveStrength"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXG_18_GiveStrengthUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXG_19_SubstanceLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXG_20_SubstanceExpirationDate"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXG_21_SubstanceManufacturerName"" type=""ns0:CE_227"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXG_22_Indication"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXG_23_GiveDrugStrengthVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXG_24_GiveDrugStrengthVolumeUnits"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXG_25_GiveBarcodeIdentifier"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXG_26_PharmacyOrderType"" type=""ns0:ID_480"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXO"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""RXO_1_RequestedGiveCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_2_RequestedGiveAmountMinimum"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXO_3_RequestedGiveAmountMaximum"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXO_4_RequestedGiveUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_5_RequestedDosageForm"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXO_6_ProviderSPharmacyTreatmentInstructions"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXO_7_ProviderSAdministrationInstructions"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_8_DeliverToLocation"" type=""ns0:LA1"" />
      <xs:element minOccurs=""0"" name=""RXO_9_AllowSubstitutions"" type=""ns0:ID_161"" />
      <xs:element minOccurs=""0"" name=""RXO_10_RequestedDispenseCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_11_RequestedDispenseAmount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXO_12_RequestedDispenseUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_13_NumberOfRefills"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXO_14_OrderingProviderSDeaNumber"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXO_15_PharmacistTreatmentSupplierSVerifierId"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""RXO_16_NeedsHumanReview"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""RXO_17_RequestedGivePerTimeUnit"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXO_18_RequestedGiveStrength"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXO_19_RequestedGiveStrengthUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXO_20_Indication"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_21_RequestedGiveRateAmount"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""RXO_22_RequestedGiveRateUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_23_TotalDailyDose"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""RXO_24_SupplementaryCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXO_25_RequestedDrugStrengthVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""RXO_26_RequestedDrugStrengthVolumeUnits"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""RXO_27_PharmacyOrderType"" type=""ns0:ID_480"" />
      <xs:element minOccurs=""0"" name=""RXO_28_DispensingInterval"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""RXR"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""RXR_1_Route"" type=""ns0:CE_162"" />
      <xs:element minOccurs=""0"" name=""RXR_2_AdministrationSite"" type=""ns0:CWE_163"" />
      <xs:element minOccurs=""0"" name=""RXR_3_AdministrationDevice"" type=""ns0:CE_164"" />
      <xs:element minOccurs=""0"" name=""RXR_4_AdministrationMethod"" type=""ns0:CWE_165"" />
      <xs:element minOccurs=""0"" name=""RXR_5_RoutingInstruction"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""RXR_6_AdministrationSiteModifier"" type=""ns0:CWE_495"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SAC"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SAC_1_ExternalAccessionIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_2_AccessionIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_3_ContainerIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_4_PrimaryParentContainerIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_5_EquipmentContainerIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_6_SpecimenSource"" type=""ns0:SPS"" />
      <xs:element minOccurs=""0"" name=""SAC_7_RegistrationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""SAC_8_ContainerStatus"" type=""ns0:CE_370"" />
      <xs:element minOccurs=""0"" name=""SAC_9_CarrierType"" type=""ns0:CE_378"" />
      <xs:element minOccurs=""0"" name=""SAC_10_CarrierIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_11_PositionInCarrier"" type=""ns0:NA"" />
      <xs:element minOccurs=""0"" name=""SAC_12_TrayTypeSac"" type=""ns0:CE_379"" />
      <xs:element minOccurs=""0"" name=""SAC_13_TrayIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SAC_14_PositionInTray"" type=""ns0:NA"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAC_15_Location"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_16_ContainerHeight"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_17_ContainerDiameter"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_18_BarrierDelta"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_19_BottomDelta"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_20_ContainerHeightDiameterDeltaUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_21_ContainerVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_22_AvailableSpecimenVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_23_InitialSpecimenVolume"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_24_VolumeUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_25_SeparatorType"" type=""ns0:CE_380"" />
      <xs:element minOccurs=""0"" name=""SAC_26_CapType"" type=""ns0:CE_381"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAC_27_Additive"" type=""ns0:CWE_371"" />
      <xs:element minOccurs=""0"" name=""SAC_28_SpecimenComponent"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_29_DilutionFactor"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""SAC_30_Treatment"" type=""ns0:CE_373"" />
      <xs:element minOccurs=""0"" name=""SAC_31_Temperature"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""SAC_32_HemolysisIndex"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_33_HemolysisIndexUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_34_LipemiaIndex"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_35_LipemiaIndexUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_36_IcterusIndex"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_37_IcterusIndexUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SAC_38_FibrinIndex"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SAC_39_FibrinIndexUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAC_40_SystemInducedContaminants"" type=""ns0:CE_374"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAC_41_DrugInterference"" type=""ns0:CE_382"" />
      <xs:element minOccurs=""0"" name=""SAC_42_ArtificialBlood"" type=""ns0:CE_375"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAC_43_SpecialHandlingCode"" type=""ns0:CWE_376"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SAC_44_OtherEnvironmentalFactors"" type=""ns0:CE_377"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SCH"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SCH_1_PlacerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SCH_2_FillerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SCH_3_OccurrenceNumber"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SCH_4_PlacerGroupNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SCH_5_ScheduleId"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""SCH_6_EventReason"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SCH_7_AppointmentReason"" type=""ns0:CE_276"" />
      <xs:element minOccurs=""0"" name=""SCH_8_AppointmentType"" type=""ns0:CE_277"" />
      <xs:element minOccurs=""0"" name=""SCH_9_AppointmentDuration"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SCH_10_AppointmentDurationUnits"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_11_AppointmentTimingQuantity"" type=""ns0:TQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_12_PlacerContactPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""SCH_13_PlacerContactPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_14_PlacerContactAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""SCH_15_PlacerContactLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""SCH_16_FillerContactPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""SCH_17_FillerContactPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_18_FillerContactAddress"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" name=""SCH_19_FillerContactLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""SCH_20_EnteredByPerson"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_21_EnteredByPhoneNumber"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" name=""SCH_22_EnteredByLocation"" type=""ns0:PL"" />
      <xs:element minOccurs=""0"" name=""SCH_23_ParentPlacerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SCH_24_ParentFillerAppointmentId"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""SCH_25_FillerStatusCode"" type=""ns0:CE_278"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_26_PlacerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SCH_27_FillerOrderNumber"" type=""ns0:EI"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SFT"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""SFT_1_SoftwareVendorOrganization"" type=""ns0:XON"" />
      <xs:element minOccurs=""1"" name=""SFT_2_SoftwareCertifiedVersionOrReleaseNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""SFT_3_SoftwareProductName"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""SFT_4_SoftwareBinaryId"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""SFT_5_SoftwareProductInformation"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""SFT_6_SoftwareInstallDate"" type=""ns0:TS"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SID"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SID_1_ApplicationMethodIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""SID_2_SubstanceLotNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""SID_3_SubstanceContainerIdentifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""SID_4_SubstanceManufacturerIdentifier"" type=""ns0:CE_385"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SPM"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SPM_1_SetId_Spm"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""SPM_2_SpecimenId"" type=""ns0:EIP"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_3_SpecimenParentIds"" type=""ns0:EIP"" />
      <xs:element minOccurs=""1"" name=""SPM_4_SpecimenType"" type=""ns0:CWE_487"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_5_SpecimenTypeModifier"" type=""ns0:CWE_541"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_6_SpecimenAdditives"" type=""ns0:CWE_371"" />
      <xs:element minOccurs=""0"" name=""SPM_7_SpecimenCollectionMethod"" type=""ns0:CWE_488"" />
      <xs:element minOccurs=""0"" name=""SPM_8_SpecimenSourceSite"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_9_SpecimenSourceSiteModifier"" type=""ns0:CWE_542"" />
      <xs:element minOccurs=""0"" name=""SPM_10_SpecimenCollectionSite"" type=""ns0:CWE_543"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_11_SpecimenRole"" type=""ns0:CWE_369"" />
      <xs:element minOccurs=""0"" name=""SPM_12_SpecimenCollectionAmount"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""SPM_13_GroupedSpecimenCount"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_14_SpecimenDescription"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_15_SpecimenHandlingCode"" type=""ns0:CWE_376"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_16_SpecimenRiskCode"" type=""ns0:CWE_489"" />
      <xs:element minOccurs=""0"" name=""SPM_17_SpecimenCollectionDateTime"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""SPM_18_SpecimenReceivedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""SPM_19_SpecimenExpirationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""SPM_20_SpecimenAvailability"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_21_SpecimenRejectReason"" type=""ns0:CWE_490"" />
      <xs:element minOccurs=""0"" name=""SPM_22_SpecimenQuality"" type=""ns0:CWE_491"" />
      <xs:element minOccurs=""0"" name=""SPM_23_SpecimenAppropriateness"" type=""ns0:CWE_492"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPM_24_SpecimenCondition"" type=""ns0:CWE_493"" />
      <xs:element minOccurs=""0"" name=""SPM_25_SpecimenCurrentQuantity"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""SPM_26_NumberOfSpecimenContainers"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""SPM_27_ContainerType"" type=""ns0:CWE"" />
      <xs:element minOccurs=""0"" name=""SPM_28_ContainerCondition"" type=""ns0:CWE_544"" />
      <xs:element minOccurs=""0"" name=""SPM_29_SpecimenChildRole"" type=""ns0:CWE_494"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SPR"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""SPR_1_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""SPR_2_QueryResponseFormatCode"" type=""ns0:ID_106"" />
      <xs:element minOccurs=""1"" name=""SPR_3_StoredProcedureName"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SPR_4_InputParameterList"" type=""ns0:QIP"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""STF"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""STF_1_PrimaryKeyValueStf"" type=""ns0:CE_9999"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_2_StaffIdentifierList"" type=""ns0:CX"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_3_StaffName"" type=""ns0:XPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_4_StaffType"" type=""ns0:IS_182"" />
      <xs:element minOccurs=""0"" name=""STF_5_AdministrativeSex"" type=""ns0:IS_1"" />
      <xs:element minOccurs=""0"" name=""STF_6_DateTimeOfBirth"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""STF_7_ActiveInactiveFlag"" type=""ns0:ID_183"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_8_Department"" type=""ns0:CE_184"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_9_HospitalServiceStf"" type=""ns0:CE_69"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_10_Phone"" type=""ns0:XTN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_11_OfficeHomeAddressBirthplace"" type=""ns0:XAD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_12_InstitutionActivationDate"" type=""ns0:DIN_537"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_13_InstitutionInactivationDate"" type=""ns0:DIN_537"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_14_BackupPersonId"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_15_EMailAddress"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""STF_16_PreferredMethodOfContact"" type=""ns0:CE_185"" />
      <xs:element minOccurs=""0"" name=""STF_17_MaritalStatus"" type=""ns0:CE_2"" />
      <xs:element minOccurs=""0"" name=""STF_18_JobTitle"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""STF_19_JobCodeClass"" type=""ns0:JCC"" />
      <xs:element minOccurs=""0"" name=""STF_20_EmploymentStatusCode"" type=""ns0:CE_66"" />
      <xs:element minOccurs=""0"" name=""STF_21_AdditionalInsuredOnAuto"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""STF_22_DriverSLicenseNumberStaff"" type=""ns0:DLN"" />
      <xs:element minOccurs=""0"" name=""STF_23_CopyAutoIns"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""STF_24_AutoInsExpires"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""STF_25_DateLastDmvReview"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""STF_26_DateNextDmvReview"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""STF_27_Race"" type=""ns0:CE_5"" />
      <xs:element minOccurs=""0"" name=""STF_28_EthnicGroup"" type=""ns0:CE_189"" />
      <xs:element minOccurs=""0"" name=""STF_29_ReActivationApprovalIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_30_Citizenship"" type=""ns0:CE_171"" />
      <xs:element minOccurs=""0"" name=""STF_31_DeathDateAndTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""STF_32_DeathIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""STF_33_InstitutionRelationshipTypeCode"" type=""ns0:CWE_538"" />
      <xs:element minOccurs=""0"" name=""STF_34_InstitutionRelationshipPeriod"" type=""ns0:DR"" />
      <xs:element minOccurs=""0"" name=""STF_35_ExpectedReturnDate"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STF_36_CostCenterCode"" type=""ns0:CWE_539"" />
      <xs:element minOccurs=""0"" name=""STF_37_GenericClassificationIndicator"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""STF_38_InactiveReasonCode"" type=""ns0:CWE_540"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TCC"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""TCC_1_UniversalServiceIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""TCC_2_TestApplicationIdentifier"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""TCC_3_SpecimenSource"" type=""ns0:SPS"" />
      <xs:element minOccurs=""0"" name=""TCC_4_AutoDilutionFactorDefault"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCC_5_RerunDilutionFactorDefault"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCC_6_PreDilutionFactorDefault"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCC_7_EndogenousContentOfPreDilutionDiluent"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCC_8_InventoryLimitsWarningLevel"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""TCC_9_AutomaticRerunAllowed"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""TCC_10_AutomaticRepeatAllowed"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""TCC_11_AutomaticReflexAllowed"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""TCC_12_EquipmentDynamicRange"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCC_13_Units"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""TCC_14_ProcessingType"" type=""ns0:CE_388"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TCD"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""TCD_1_UniversalServiceIdentifier"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" name=""TCD_2_AutoDilutionFactor"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCD_3_RerunDilutionFactor"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCD_4_PreDilutionFactor"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCD_5_EndogenousContentOfPreDilutionDiluent"" type=""ns0:SN"" />
      <xs:element minOccurs=""0"" name=""TCD_6_AutomaticRepeatAllowed"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""TCD_7_ReflexAllowed"" type=""ns0:ID_136"" />
      <xs:element minOccurs=""0"" name=""TCD_8_AnalyteRepeatStatus"" type=""ns0:CE_389"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TQ1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TQ1_1_SetIdTq1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""TQ1_2_Quantity"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ1_3_RepeatPattern"" type=""ns0:RPT_335"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ1_4_ExplicitTime"" type=""ns0:TM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ1_5_RelativeTimeAndUnits"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""TQ1_6_ServiceDuration"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""TQ1_7_StartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""TQ1_8_EndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ1_9_Priority"" type=""ns0:CWE_485"" />
      <xs:element minOccurs=""0"" name=""TQ1_10_ConditionText"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""TQ1_11_TextInstruction"" type=""ns0:TX"" />
      <xs:element minOccurs=""0"" name=""TQ1_12_Conjunction"" type=""ns0:ID_427"" />
      <xs:element minOccurs=""0"" name=""TQ1_13_OccurrenceDuration"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""TQ1_14_TotalOccurrenceS"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TQ2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""TQ2_1_SetIdTq2"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""TQ2_2_SequenceResultsFlag"" type=""ns0:ID_503"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ2_3_RelatedPlacerNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ2_4_RelatedFillerNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TQ2_5_RelatedPlacerGroupNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""TQ2_6_SequenceConditionCode"" type=""ns0:ID_504"" />
      <xs:element minOccurs=""0"" name=""TQ2_7_CyclicEntryExitIndicator"" type=""ns0:ID_505"" />
      <xs:element minOccurs=""0"" name=""TQ2_8_SequenceConditionTimeInterval"" type=""ns0:CQ"" />
      <xs:element minOccurs=""0"" name=""TQ2_9_CyclicGroupMaximumNumberOfRepeats"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""TQ2_10_SpecialServiceRequestRelationship"" type=""ns0:ID_506"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""TXA"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""TXA_1_SetIdTxa"" type=""ns0:SI"" />
      <xs:element minOccurs=""1"" name=""TXA_2_DocumentType"" type=""ns0:IS_270"" />
      <xs:element minOccurs=""0"" name=""TXA_3_DocumentContentPresentation"" type=""ns0:ID_191"" />
      <xs:element minOccurs=""0"" name=""TXA_4_ActivityDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_5_PrimaryActivityProviderCodeName"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""TXA_6_OriginationDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""TXA_7_TranscriptionDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_8_EditDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_9_OriginatorCodeName"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_10_AssignedDocumentAuthenticator"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_11_TranscriptionistCodeName"" type=""ns0:XCN"" />
      <xs:element minOccurs=""1"" name=""TXA_12_UniqueDocumentNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""TXA_13_ParentDocumentNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_14_PlacerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""TXA_15_FillerOrderNumber"" type=""ns0:EI"" />
      <xs:element minOccurs=""0"" name=""TXA_16_UniqueDocumentFileName"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""TXA_17_DocumentCompletionStatus"" type=""ns0:ID_271"" />
      <xs:element minOccurs=""0"" name=""TXA_18_DocumentConfidentialityStatus"" type=""ns0:ID_272"" />
      <xs:element minOccurs=""0"" name=""TXA_19_DocumentAvailabilityStatus"" type=""ns0:ID_273"" />
      <xs:element minOccurs=""0"" name=""TXA_20_DocumentStorageStatus"" type=""ns0:ID_275"" />
      <xs:element minOccurs=""0"" name=""TXA_21_DocumentChangeReason"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_22_AuthenticationPersonTimeStamp"" type=""ns0:PPN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""TXA_23_DistributedCopiesCodeAndNameOfRecipients"" type=""ns0:XCN"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""UB1"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""UB1_1_SetIdUb1"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""UB1_2_BloodDeductible43"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""UB1_3_BloodFurnishedPintsOf40"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""UB1_4_BloodReplacedPints41"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""UB1_5_BloodNotReplacedPints42"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""UB1_6_CoInsuranceDays25"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB1_7_ConditionCode3539"" type=""ns0:IS_43"" />
      <xs:element minOccurs=""0"" name=""UB1_8_CoveredDays23"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""UB1_9_NonCoveredDays24"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB1_10_ValueAmountCode4649"" type=""ns0:UVC"" />
      <xs:element minOccurs=""0"" name=""UB1_11_NumberOfGraceDays90"" type=""ns0:NM"" />
      <xs:element minOccurs=""0"" name=""UB1_12_SpecialProgramIndicator44"" type=""ns0:CE_348"" />
      <xs:element minOccurs=""0"" name=""UB1_13_PsroUrApprovalIndicator87"" type=""ns0:CE_349"" />
      <xs:element minOccurs=""0"" name=""UB1_14_PsroUrApprovedStayFm88"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""UB1_15_PsroUrApprovedStayTo89"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB1_16_Occurrence2832"" type=""ns0:OCD"" />
      <xs:element minOccurs=""0"" name=""UB1_17_OccurrenceSpan33"" type=""ns0:CE_351"" />
      <xs:element minOccurs=""0"" name=""UB1_18_OccurSpanStartDate33"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""UB1_19_OccurSpanEndDate33"" type=""ns0:DT"" />
      <xs:element minOccurs=""0"" name=""UB1_20_Ub82Locator2"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB1_21_Ub82Locator9"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB1_22_Ub82Locator27"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB1_23_Ub82Locator45"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""UB2"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""UB2_1_SetIdUb2"" type=""ns0:SI"" />
      <xs:element minOccurs=""0"" name=""UB2_2_CoInsuranceDays9"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_3_ConditionCode2430"" type=""ns0:IS_43"" />
      <xs:element minOccurs=""0"" name=""UB2_4_CoveredDays7"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB2_5_NonCoveredDays8"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_6_ValueAmountCode"" type=""ns0:UVC"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_7_OccurrenceCodeDate3235"" type=""ns0:OCD"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_8_OccurrenceSpanCodeDates36"" type=""ns0:OSP"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_9_Ub92Locator2State"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_10_Ub92Locator11State"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB2_11_Ub92Locator31National"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_12_DocumentControlNumber"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_13_Ub92Locator49National"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_14_Ub92Locator56State"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB2_15_Ub92Locator57National"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""UB2_16_Ub92Locator78State"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""UB2_17_SpecialVisitCount"" type=""ns0:NM"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""URD"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""URD_1_RUDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""URD_2_ReportPriority"" type=""ns0:ID_109"" />
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""URD_3_RUWhoSubjectDefinition"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URD_4_RUWhatSubjectDefinition"" type=""ns0:CE_48"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URD_5_RUWhatDepartmentCode"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URD_6_RUDisplayPrintLocations"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""URD_7_RUResultsLevel"" type=""ns0:ID_108"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""URS"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""URS_1_RUWhereSubjectDefinition"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" name=""URS_2_RUWhenDataStartDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""URS_3_RUWhenDataEndDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URS_4_RUWhatUserQualifier"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URS_5_RUOtherResultsSubjectDefinition"" type=""ns0:ST"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URS_6_RUWhichDateTimeQualifier"" type=""ns0:ID_156"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URS_7_RUWhichDateTimeStatusQualifier"" type=""ns0:ID_157"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""URS_8_RUDateTimeSelectionQualifier"" type=""ns0:ID_158"" />
      <xs:element minOccurs=""0"" name=""URS_9_RUQuantityTimingQualifier"" type=""ns0:TQ"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VAR"">
    <xs:sequence>
      <xs:element minOccurs=""1"" name=""VAR_1_VarianceInstanceId"" type=""ns0:EI"" />
      <xs:element minOccurs=""1"" name=""VAR_2_DocumentedDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" name=""VAR_3_StatedVarianceDateTime"" type=""ns0:TS"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""VAR_4_VarianceOriginator"" type=""ns0:XCN"" />
      <xs:element minOccurs=""0"" name=""VAR_5_VarianceClassification"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""VAR_6_VarianceDescription"" type=""ns0:ST"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""VTQ"">
    <xs:sequence>
      <xs:element minOccurs=""0"" name=""VTQ_1_QueryTag"" type=""ns0:ST"" />
      <xs:element minOccurs=""1"" name=""VTQ_2_QueryResponseFormatCode"" type=""ns0:ID_106"" />
      <xs:element minOccurs=""1"" name=""VTQ_3_VtQueryName"" type=""ns0:CE"" />
      <xs:element minOccurs=""1"" name=""VTQ_4_VirtualTableName"" type=""ns0:CE"" />
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""VTQ_5_SelectionCriteria"" type=""ns0:QSC"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""HXX"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SegmentData"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public segments_25() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HL7DefinedSegments";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
