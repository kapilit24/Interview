namespace Interview.BizTalk.BTAHL7V25Common.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class BTAHL72XMLReceivePipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.Solutions.BTAHL7.Pipelines.HL72XmlD"+
"asm,Microsoft.Solutions.BTAHL7.HL72XmlDasm, Version=1.3.0.0, Culture=neutral, PublicKeyToken=31bf385"+
"6ad364e35</Name>          <ComponentName>BTAHL7 2.Xml Disassembler</ComponentName>          <Descrip"+
"tion>Disassembler for HL7 2.Xml documents</Description>          <Version>1.0</Version>          <Pr"+
"operties />          <CachedDisplayName>BTAHL7 2.Xml Disassembler</CachedDisplayName>          <Cach"+
"edIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>    "+
"  <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execM"+
"ethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>    <St"+
"age>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccur"+
"s=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </S"+
"tage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "d7561ee6-2f90-49bf-bcb5-a9aa3296a48c";
        
        public BTAHL72XMLReceivePipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.Solutions.BTAHL7.Pipelines.HL72XmlDasm,Microsoft.Solutions.BTAHL7.HL72XmlDasm, Version=1.3.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
