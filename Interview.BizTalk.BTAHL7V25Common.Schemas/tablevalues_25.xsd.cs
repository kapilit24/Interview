namespace BTAHL7Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://microsoft.com/HealthCare/HL7/2X/2.5/Tables",@"HL7DefinedTables")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"HL7DefinedTables"})]
    public sealed class tablevalues_25 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://microsoft.com/HealthCare/HL7/2X/2.5/Tables"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://microsoft.com/HealthCare/HL7/2X/2.5/Tables"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standards_version=""HL7.DBVersion.1_5"" document_type=""HL7 2X Schema"" version=""2.0.0104.0.2.0"" root_reference=""HL7DefinedTables"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""HL7DefinedTables"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Table1"" type=""Table1"" />
        <xs:element name=""Table10"" type=""Table10"" />
        <xs:element name=""Table100"" type=""Table100"" />
        <xs:element name=""Table103"" type=""Table103"" />
        <xs:element name=""Table104"" type=""Table104"" />
        <xs:element name=""Table105"" type=""Table105"" />
        <xs:element name=""Table106"" type=""Table106"" />
        <xs:element name=""Table107"" type=""Table107"" />
        <xs:element name=""Table108"" type=""Table108"" />
        <xs:element name=""Table109"" type=""Table109"" />
        <xs:element name=""Table110"" type=""Table110"" />
        <xs:element name=""Table111"" type=""Table111"" />
        <xs:element name=""Table112"" type=""Table112"" />
        <xs:element name=""Table113"" type=""Table113"" />
        <xs:element name=""Table114"" type=""Table114"" />
        <xs:element name=""Table115"" type=""Table115"" />
        <xs:element name=""Table116"" type=""Table116"" />
        <xs:element name=""Table117"" type=""Table117"" />
        <xs:element name=""Table118"" type=""Table118"" />
        <xs:element name=""Table119"" type=""Table119"" />
        <xs:element name=""Table121"" type=""Table121"" />
        <xs:element name=""Table122"" type=""Table122"" />
        <xs:element name=""Table123"" type=""Table123"" />
        <xs:element name=""Table124"" type=""Table124"" />
        <xs:element name=""Table125"" type=""Table125"" />
        <xs:element name=""Table126"" type=""Table126"" />
        <xs:element name=""Table127"" type=""Table127"" />
        <xs:element name=""Table128"" type=""Table128"" />
        <xs:element name=""Table129"" type=""Table129"" />
        <xs:element name=""Table130"" type=""Table130"" />
        <xs:element name=""Table131"" type=""Table131"" />
        <xs:element name=""Table132"" type=""Table132"" />
        <xs:element name=""Table133"" type=""Table133"" />
        <xs:element name=""Table135"" type=""Table135"" />
        <xs:element name=""Table136"" type=""Table136"" />
        <xs:element name=""Table137"" type=""Table137"" />
        <xs:element name=""Table139"" type=""Table139"" />
        <xs:element name=""Table140"" type=""Table140"" />
        <xs:element name=""Table141"" type=""Table141"" />
        <xs:element name=""Table142"" type=""Table142"" />
        <xs:element name=""Table143"" type=""Table143"" />
        <xs:element name=""Table144"" type=""Table144"" />
        <xs:element name=""Table145"" type=""Table145"" />
        <xs:element name=""Table146"" type=""Table146"" />
        <xs:element name=""Table147"" type=""Table147"" />
        <xs:element name=""Table148"" type=""Table148"" />
        <xs:element name=""Table149"" type=""Table149"" />
        <xs:element name=""Table150"" type=""Table150"" />
        <xs:element name=""Table151"" type=""Table151"" />
        <xs:element name=""Table152"" type=""Table152"" />
        <xs:element name=""Table153"" type=""Table153"" />
        <xs:element name=""Table155"" type=""Table155"" />
        <xs:element name=""Table156"" type=""Table156"" />
        <xs:element name=""Table157"" type=""Table157"" />
        <xs:element name=""Table158"" type=""Table158"" />
        <xs:element name=""Table159"" type=""Table159"" />
        <xs:element name=""Table160"" type=""Table160"" />
        <xs:element name=""Table161"" type=""Table161"" />
        <xs:element name=""Table162"" type=""Table162"" />
        <xs:element name=""Table163"" type=""Table163"" />
        <xs:element name=""Table164"" type=""Table164"" />
        <xs:element name=""Table165"" type=""Table165"" />
        <xs:element name=""Table166"" type=""Table166"" />
        <xs:element name=""Table167"" type=""Table167"" />
        <xs:element name=""Table168"" type=""Table168"" />
        <xs:element name=""Table169"" type=""Table169"" />
        <xs:element name=""Table17"" type=""Table17"" />
        <xs:element name=""Table170"" type=""Table170"" />
        <xs:element name=""Table171"" type=""Table171"" />
        <xs:element name=""Table172"" type=""Table172"" />
        <xs:element name=""Table173"" type=""Table173"" />
        <xs:element name=""Table174"" type=""Table174"" />
        <xs:element name=""Table175"" type=""Table175"" />
        <xs:element name=""Table177"" type=""Table177"" />
        <xs:element name=""Table178"" type=""Table178"" />
        <xs:element name=""Table179"" type=""Table179"" />
        <xs:element name=""Table18"" type=""Table18"" />
        <xs:element name=""Table180"" type=""Table180"" />
        <xs:element name=""Table181"" type=""Table181"" />
        <xs:element name=""Table182"" type=""Table182"" />
        <xs:element name=""Table183"" type=""Table183"" />
        <xs:element name=""Table184"" type=""Table184"" />
        <xs:element name=""Table185"" type=""Table185"" />
        <xs:element name=""Table186"" type=""Table186"" />
        <xs:element name=""Table187"" type=""Table187"" />
        <xs:element name=""Table188"" type=""Table188"" />
        <xs:element name=""Table189"" type=""Table189"" />
        <xs:element name=""Table19"" type=""Table19"" />
        <xs:element name=""Table190"" type=""Table190"" />
        <xs:element name=""Table191"" type=""Table191"" />
        <xs:element name=""Table193"" type=""Table193"" />
        <xs:element name=""Table2"" type=""Table2"" />
        <xs:element name=""Table200"" type=""Table200"" />
        <xs:element name=""Table201"" type=""Table201"" />
        <xs:element name=""Table202"" type=""Table202"" />
        <xs:element name=""Table203"" type=""Table203"" />
        <xs:element name=""Table204"" type=""Table204"" />
        <xs:element name=""Table205"" type=""Table205"" />
        <xs:element name=""Table206"" type=""Table206"" />
        <xs:element name=""Table207"" type=""Table207"" />
        <xs:element name=""Table208"" type=""Table208"" />
        <xs:element name=""Table209"" type=""Table209"" />
        <xs:element name=""Table21"" type=""Table21"" />
        <xs:element name=""Table210"" type=""Table210"" />
        <xs:element name=""Table211"" type=""Table211"" />
        <xs:element name=""Table212"" type=""Table212"" />
        <xs:element name=""Table213"" type=""Table213"" />
        <xs:element name=""Table214"" type=""Table214"" />
        <xs:element name=""Table215"" type=""Table215"" />
        <xs:element name=""Table216"" type=""Table216"" />
        <xs:element name=""Table217"" type=""Table217"" />
        <xs:element name=""Table218"" type=""Table218"" />
        <xs:element name=""Table219"" type=""Table219"" />
        <xs:element name=""Table22"" type=""Table22"" />
        <xs:element name=""Table220"" type=""Table220"" />
        <xs:element name=""Table222"" type=""Table222"" />
        <xs:element name=""Table223"" type=""Table223"" />
        <xs:element name=""Table224"" type=""Table224"" />
        <xs:element name=""Table225"" type=""Table225"" />
        <xs:element name=""Table227"" type=""Table227"" />
        <xs:element name=""Table228"" type=""Table228"" />
        <xs:element name=""Table229"" type=""Table229"" />
        <xs:element name=""Table23"" type=""Table23"" />
        <xs:element name=""Table230"" type=""Table230"" />
        <xs:element name=""Table231"" type=""Table231"" />
        <xs:element name=""Table232"" type=""Table232"" />
        <xs:element name=""Table233"" type=""Table233"" />
        <xs:element name=""Table234"" type=""Table234"" />
        <xs:element name=""Table235"" type=""Table235"" />
        <xs:element name=""Table236"" type=""Table236"" />
        <xs:element name=""Table237"" type=""Table237"" />
        <xs:element name=""Table238"" type=""Table238"" />
        <xs:element name=""Table239"" type=""Table239"" />
        <xs:element name=""Table24"" type=""Table24"" />
        <xs:element name=""Table240"" type=""Table240"" />
        <xs:element name=""Table241"" type=""Table241"" />
        <xs:element name=""Table242"" type=""Table242"" />
        <xs:element name=""Table243"" type=""Table243"" />
        <xs:element name=""Table244"" type=""Table244"" />
        <xs:element name=""Table245"" type=""Table245"" />
        <xs:element name=""Table246"" type=""Table246"" />
        <xs:element name=""Table247"" type=""Table247"" />
        <xs:element name=""Table248"" type=""Table248"" />
        <xs:element name=""Table249"" type=""Table249"" />
        <xs:element name=""Table250"" type=""Table250"" />
        <xs:element name=""Table251"" type=""Table251"" />
        <xs:element name=""Table252"" type=""Table252"" />
        <xs:element name=""Table253"" type=""Table253"" />
        <xs:element name=""Table254"" type=""Table254"" />
        <xs:element name=""Table255"" type=""Table255"" />
        <xs:element name=""Table256"" type=""Table256"" />
        <xs:element name=""Table257"" type=""Table257"" />
        <xs:element name=""Table258"" type=""Table258"" />
        <xs:element name=""Table259"" type=""Table259"" />
        <xs:element name=""Table260"" type=""Table260"" />
        <xs:element name=""Table261"" type=""Table261"" />
        <xs:element name=""Table262"" type=""Table262"" />
        <xs:element name=""Table263"" type=""Table263"" />
        <xs:element name=""Table264"" type=""Table264"" />
        <xs:element name=""Table265"" type=""Table265"" />
        <xs:element name=""Table267"" type=""Table267"" />
        <xs:element name=""Table268"" type=""Table268"" />
        <xs:element name=""Table269"" type=""Table269"" />
        <xs:element name=""Table27"" type=""Table27"" />
        <xs:element name=""Table270"" type=""Table270"" />
        <xs:element name=""Table271"" type=""Table271"" />
        <xs:element name=""Table272"" type=""Table272"" />
        <xs:element name=""Table273"" type=""Table273"" />
        <xs:element name=""Table275"" type=""Table275"" />
        <xs:element name=""Table276"" type=""Table276"" />
        <xs:element name=""Table277"" type=""Table277"" />
        <xs:element name=""Table278"" type=""Table278"" />
        <xs:element name=""Table279"" type=""Table279"" />
        <xs:element name=""Table280"" type=""Table280"" />
        <xs:element name=""Table281"" type=""Table281"" />
        <xs:element name=""Table282"" type=""Table282"" />
        <xs:element name=""Table283"" type=""Table283"" />
        <xs:element name=""Table284"" type=""Table284"" />
        <xs:element name=""Table285"" type=""Table285"" />
        <xs:element name=""Table286"" type=""Table286"" />
        <xs:element name=""Table287"" type=""Table287"" />
        <xs:element name=""Table288"" type=""Table288"" />
        <xs:element name=""Table289"" type=""Table289"" />
        <xs:element name=""Table291"" type=""Table291"" />
        <xs:element name=""Table292"" type=""Table292"" />
        <xs:element name=""Table293"" type=""Table293"" />
        <xs:element name=""Table294"" type=""Table294"" />
        <xs:element name=""Table295"" type=""Table295"" />
        <xs:element name=""Table296"" type=""Table296"" />
        <xs:element name=""Table297"" type=""Table297"" />
        <xs:element name=""Table298"" type=""Table298"" />
        <xs:element name=""Table299"" type=""Table299"" />
        <xs:element name=""Table3"" type=""Table3"" />
        <xs:element name=""Table300"" type=""Table300"" />
        <xs:element name=""Table301"" type=""Table301"" />
        <xs:element name=""Table302"" type=""Table302"" />
        <xs:element name=""Table303"" type=""Table303"" />
        <xs:element name=""Table304"" type=""Table304"" />
        <xs:element name=""Table305"" type=""Table305"" />
        <xs:element name=""Table306"" type=""Table306"" />
        <xs:element name=""Table307"" type=""Table307"" />
        <xs:element name=""Table308"" type=""Table308"" />
        <xs:element name=""Table309"" type=""Table309"" />
        <xs:element name=""Table311"" type=""Table311"" />
        <xs:element name=""Table312"" type=""Table312"" />
        <xs:element name=""Table313"" type=""Table313"" />
        <xs:element name=""Table315"" type=""Table315"" />
        <xs:element name=""Table316"" type=""Table316"" />
        <xs:element name=""Table317"" type=""Table317"" />
        <xs:element name=""Table319"" type=""Table319"" />
        <xs:element name=""Table32"" type=""Table32"" />
        <xs:element name=""Table320"" type=""Table320"" />
        <xs:element name=""Table321"" type=""Table321"" />
        <xs:element name=""Table322"" type=""Table322"" />
        <xs:element name=""Table323"" type=""Table323"" />
        <xs:element name=""Table324"" type=""Table324"" />
        <xs:element name=""Table325"" type=""Table325"" />
        <xs:element name=""Table326"" type=""Table326"" />
        <xs:element name=""Table327"" type=""Table327"" />
        <xs:element name=""Table328"" type=""Table328"" />
        <xs:element name=""Table329"" type=""Table329"" />
        <xs:element name=""Table330"" type=""Table330"" />
        <xs:element name=""Table331"" type=""Table331"" />
        <xs:element name=""Table332"" type=""Table332"" />
        <xs:element name=""Table333"" type=""Table333"" />
        <xs:element name=""Table334"" type=""Table334"" />
        <xs:element name=""Table335"" type=""Table335"" />
        <xs:element name=""Table336"" type=""Table336"" />
        <xs:element name=""Table337"" type=""Table337"" />
        <xs:element name=""Table338"" type=""Table338"" />
        <xs:element name=""Table339"" type=""Table339"" />
        <xs:element name=""Table340"" type=""Table340"" />
        <xs:element name=""Table341"" type=""Table341"" />
        <xs:element name=""Table342"" type=""Table342"" />
        <xs:element name=""Table343"" type=""Table343"" />
        <xs:element name=""Table344"" type=""Table344"" />
        <xs:element name=""Table345"" type=""Table345"" />
        <xs:element name=""Table346"" type=""Table346"" />
        <xs:element name=""Table347"" type=""Table347"" />
        <xs:element name=""Table348"" type=""Table348"" />
        <xs:element name=""Table349"" type=""Table349"" />
        <xs:element name=""Table350"" type=""Table350"" />
        <xs:element name=""Table351"" type=""Table351"" />
        <xs:element name=""Table353"" type=""Table353"" />
        <xs:element name=""Table354"" type=""Table354"" />
        <xs:element name=""Table355"" type=""Table355"" />
        <xs:element name=""Table356"" type=""Table356"" />
        <xs:element name=""Table357"" type=""Table357"" />
        <xs:element name=""Table358"" type=""Table358"" />
        <xs:element name=""Table359"" type=""Table359"" />
        <xs:element name=""Table360"" type=""Table360"" />
        <xs:element name=""Table361"" type=""Table361"" />
        <xs:element name=""Table362"" type=""Table362"" />
        <xs:element name=""Table363"" type=""Table363"" />
        <xs:element name=""Table364"" type=""Table364"" />
        <xs:element name=""Table365"" type=""Table365"" />
        <xs:element name=""Table366"" type=""Table366"" />
        <xs:element name=""Table367"" type=""Table367"" />
        <xs:element name=""Table368"" type=""Table368"" />
        <xs:element name=""Table369"" type=""Table369"" />
        <xs:element name=""Table370"" type=""Table370"" />
        <xs:element name=""Table371"" type=""Table371"" />
        <xs:element name=""Table372"" type=""Table372"" />
        <xs:element name=""Table373"" type=""Table373"" />
        <xs:element name=""Table374"" type=""Table374"" />
        <xs:element name=""Table375"" type=""Table375"" />
        <xs:element name=""Table376"" type=""Table376"" />
        <xs:element name=""Table377"" type=""Table377"" />
        <xs:element name=""Table378"" type=""Table378"" />
        <xs:element name=""Table379"" type=""Table379"" />
        <xs:element name=""Table38"" type=""Table38"" />
        <xs:element name=""Table380"" type=""Table380"" />
        <xs:element name=""Table381"" type=""Table381"" />
        <xs:element name=""Table382"" type=""Table382"" />
        <xs:element name=""Table383"" type=""Table383"" />
        <xs:element name=""Table384"" type=""Table384"" />
        <xs:element name=""Table385"" type=""Table385"" />
        <xs:element name=""Table386"" type=""Table386"" />
        <xs:element name=""Table387"" type=""Table387"" />
        <xs:element name=""Table388"" type=""Table388"" />
        <xs:element name=""Table389"" type=""Table389"" />
        <xs:element name=""Table391"" type=""Table391"" />
        <xs:element name=""Table392"" type=""Table392"" />
        <xs:element name=""Table393"" type=""Table393"" />
        <xs:element name=""Table394"" type=""Table394"" />
        <xs:element name=""Table395"" type=""Table395"" />
        <xs:element name=""Table396"" type=""Table396"" />
        <xs:element name=""Table397"" type=""Table397"" />
        <xs:element name=""Table398"" type=""Table398"" />
        <xs:element name=""Table399"" type=""Table399"" />
        <xs:element name=""Table4"" type=""Table4"" />
        <xs:element name=""Table401"" type=""Table401"" />
        <xs:element name=""Table402"" type=""Table402"" />
        <xs:element name=""Table403"" type=""Table403"" />
        <xs:element name=""Table404"" type=""Table404"" />
        <xs:element name=""Table405"" type=""Table405"" />
        <xs:element name=""Table406"" type=""Table406"" />
        <xs:element name=""Table409"" type=""Table409"" />
        <xs:element name=""Table411"" type=""Table411"" />
        <xs:element name=""Table412"" type=""Table412"" />
        <xs:element name=""Table413"" type=""Table413"" />
        <xs:element name=""Table414"" type=""Table414"" />
        <xs:element name=""Table415"" type=""Table415"" />
        <xs:element name=""Table416"" type=""Table416"" />
        <xs:element name=""Table417"" type=""Table417"" />
        <xs:element name=""Table418"" type=""Table418"" />
        <xs:element name=""Table42"" type=""Table42"" />
        <xs:element name=""Table421"" type=""Table421"" />
        <xs:element name=""Table422"" type=""Table422"" />
        <xs:element name=""Table423"" type=""Table423"" />
        <xs:element name=""Table424"" type=""Table424"" />
        <xs:element name=""Table425"" type=""Table425"" />
        <xs:element name=""Table426"" type=""Table426"" />
        <xs:element name=""Table427"" type=""Table427"" />
        <xs:element name=""Table428"" type=""Table428"" />
        <xs:element name=""Table429"" type=""Table429"" />
        <xs:element name=""Table43"" type=""Table43"" />
        <xs:element name=""Table430"" type=""Table430"" />
        <xs:element name=""Table431"" type=""Table431"" />
        <xs:element name=""Table432"" type=""Table432"" />
        <xs:element name=""Table433"" type=""Table433"" />
        <xs:element name=""Table434"" type=""Table434"" />
        <xs:element name=""Table435"" type=""Table435"" />
        <xs:element name=""Table436"" type=""Table436"" />
        <xs:element name=""Table437"" type=""Table437"" />
        <xs:element name=""Table438"" type=""Table438"" />
        <xs:element name=""Table44"" type=""Table44"" />
        <xs:element name=""Table440"" type=""Table440"" />
        <xs:element name=""Table441"" type=""Table441"" />
        <xs:element name=""Table442"" type=""Table442"" />
        <xs:element name=""Table443"" type=""Table443"" />
        <xs:element name=""Table444"" type=""Table444"" />
        <xs:element name=""Table445"" type=""Table445"" />
        <xs:element name=""Table446"" type=""Table446"" />
        <xs:element name=""Table447"" type=""Table447"" />
        <xs:element name=""Table448"" type=""Table448"" />
        <xs:element name=""Table45"" type=""Table45"" />
        <xs:element name=""Table450"" type=""Table450"" />
        <xs:element name=""Table451"" type=""Table451"" />
        <xs:element name=""Table452"" type=""Table452"" />
        <xs:element name=""Table453"" type=""Table453"" />
        <xs:element name=""Table454"" type=""Table454"" />
        <xs:element name=""Table455"" type=""Table455"" />
        <xs:element name=""Table456"" type=""Table456"" />
        <xs:element name=""Table457"" type=""Table457"" />
        <xs:element name=""Table458"" type=""Table458"" />
        <xs:element name=""Table459"" type=""Table459"" />
        <xs:element name=""Table46"" type=""Table46"" />
        <xs:element name=""Table460"" type=""Table460"" />
        <xs:element name=""Table461"" type=""Table461"" />
        <xs:element name=""Table462"" type=""Table462"" />
        <xs:element name=""Table463"" type=""Table463"" />
        <xs:element name=""Table464"" type=""Table464"" />
        <xs:element name=""Table465"" type=""Table465"" />
        <xs:element name=""Table466"" type=""Table466"" />
        <xs:element name=""Table467"" type=""Table467"" />
        <xs:element name=""Table468"" type=""Table468"" />
        <xs:element name=""Table469"" type=""Table469"" />
        <xs:element name=""Table470"" type=""Table470"" />
        <xs:element name=""Table471"" type=""Table471"" />
        <xs:element name=""Table472"" type=""Table472"" />
        <xs:element name=""Table473"" type=""Table473"" />
        <xs:element name=""Table474"" type=""Table474"" />
        <xs:element name=""Table475"" type=""Table475"" />
        <xs:element name=""Table476"" type=""Table476"" />
        <xs:element name=""Table477"" type=""Table477"" />
        <xs:element name=""Table478"" type=""Table478"" />
        <xs:element name=""Table479"" type=""Table479"" />
        <xs:element name=""Table48"" type=""Table48"" />
        <xs:element name=""Table480"" type=""Table480"" />
        <xs:element name=""Table482"" type=""Table482"" />
        <xs:element name=""Table483"" type=""Table483"" />
        <xs:element name=""Table484"" type=""Table484"" />
        <xs:element name=""Table485"" type=""Table485"" />
        <xs:element name=""Table487"" type=""Table487"" />
        <xs:element name=""Table488"" type=""Table488"" />
        <xs:element name=""Table489"" type=""Table489"" />
        <xs:element name=""Table49"" type=""Table49"" />
        <xs:element name=""Table490"" type=""Table490"" />
        <xs:element name=""Table491"" type=""Table491"" />
        <xs:element name=""Table492"" type=""Table492"" />
        <xs:element name=""Table493"" type=""Table493"" />
        <xs:element name=""Table494"" type=""Table494"" />
        <xs:element name=""Table495"" type=""Table495"" />
        <xs:element name=""Table496"" type=""Table496"" />
        <xs:element name=""Table497"" type=""Table497"" />
        <xs:element name=""Table498"" type=""Table498"" />
        <xs:element name=""Table499"" type=""Table499"" />
        <xs:element name=""Table5"" type=""Table5"" />
        <xs:element name=""Table50"" type=""Table50"" />
        <xs:element name=""Table500"" type=""Table500"" />
        <xs:element name=""Table501"" type=""Table501"" />
        <xs:element name=""Table502"" type=""Table502"" />
        <xs:element name=""Table503"" type=""Table503"" />
        <xs:element name=""Table504"" type=""Table504"" />
        <xs:element name=""Table505"" type=""Table505"" />
        <xs:element name=""Table506"" type=""Table506"" />
        <xs:element name=""Table507"" type=""Table507"" />
        <xs:element name=""Table508"" type=""Table508"" />
        <xs:element name=""Table509"" type=""Table509"" />
        <xs:element name=""Table51"" type=""Table51"" />
        <xs:element name=""Table510"" type=""Table510"" />
        <xs:element name=""Table511"" type=""Table511"" />
        <xs:element name=""Table512"" type=""Table512"" />
        <xs:element name=""Table513"" type=""Table513"" />
        <xs:element name=""Table514"" type=""Table514"" />
        <xs:element name=""Table515"" type=""Table515"" />
        <xs:element name=""Table516"" type=""Table516"" />
        <xs:element name=""Table517"" type=""Table517"" />
        <xs:element name=""Table518"" type=""Table518"" />
        <xs:element name=""Table519"" type=""Table519"" />
        <xs:element name=""Table52"" type=""Table52"" />
        <xs:element name=""Table521"" type=""Table521"" />
        <xs:element name=""Table523"" type=""Table523"" />
        <xs:element name=""Table524"" type=""Table524"" />
        <xs:element name=""Table525"" type=""Table525"" />
        <xs:element name=""Table526"" type=""Table526"" />
        <xs:element name=""Table527"" type=""Table527"" />
        <xs:element name=""Table528"" type=""Table528"" />
        <xs:element name=""Table529"" type=""Table529"" />
        <xs:element name=""Table53"" type=""Table53"" />
        <xs:element name=""Table530"" type=""Table530"" />
        <xs:element name=""Table531"" type=""Table531"" />
        <xs:element name=""Table532"" type=""Table532"" />
        <xs:element name=""Table533"" type=""Table533"" />
        <xs:element name=""Table534"" type=""Table534"" />
        <xs:element name=""Table535"" type=""Table535"" />
        <xs:element name=""Table536"" type=""Table536"" />
        <xs:element name=""Table537"" type=""Table537"" />
        <xs:element name=""Table538"" type=""Table538"" />
        <xs:element name=""Table539"" type=""Table539"" />
        <xs:element name=""Table540"" type=""Table540"" />
        <xs:element name=""Table541"" type=""Table541"" />
        <xs:element name=""Table542"" type=""Table542"" />
        <xs:element name=""Table543"" type=""Table543"" />
        <xs:element name=""Table544"" type=""Table544"" />
        <xs:element name=""Table545"" type=""Table545"" />
        <xs:element name=""Table547"" type=""Table547"" />
        <xs:element name=""Table548"" type=""Table548"" />
        <xs:element name=""Table549"" type=""Table549"" />
        <xs:element name=""Table55"" type=""Table55"" />
        <xs:element name=""Table550"" type=""Table550"" />
        <xs:element name=""Table552"" type=""Table552"" />
        <xs:element name=""Table56"" type=""Table56"" />
        <xs:element name=""Table59"" type=""Table59"" />
        <xs:element name=""Table6"" type=""Table6"" />
        <xs:element name=""Table61"" type=""Table61"" />
        <xs:element name=""Table62"" type=""Table62"" />
        <xs:element name=""Table63"" type=""Table63"" />
        <xs:element name=""Table64"" type=""Table64"" />
        <xs:element name=""Table65"" type=""Table65"" />
        <xs:element name=""Table66"" type=""Table66"" />
        <xs:element name=""Table68"" type=""Table68"" />
        <xs:element name=""Table69"" type=""Table69"" />
        <xs:element name=""Table7"" type=""Table7"" />
        <xs:element name=""Table70"" type=""Table70"" />
        <xs:element name=""Table72"" type=""Table72"" />
        <xs:element name=""Table73"" type=""Table73"" />
        <xs:element name=""Table74"" type=""Table74"" />
        <xs:element name=""Table76"" type=""Table76"" />
        <xs:element name=""Table78"" type=""Table78"" />
        <xs:element name=""Table8"" type=""Table8"" />
        <xs:element name=""Table80"" type=""Table80"" />
        <xs:element name=""Table83"" type=""Table83"" />
        <xs:element name=""Table84"" type=""Table84"" />
        <xs:element name=""Table85"" type=""Table85"" />
        <xs:element name=""Table86"" type=""Table86"" />
        <xs:element name=""Table87"" type=""Table87"" />
        <xs:element name=""Table88"" type=""Table88"" />
        <xs:element name=""Table89"" type=""Table89"" />
        <xs:element name=""Table9"" type=""Table9"" />
        <xs:element name=""Table91"" type=""Table91"" />
        <xs:element name=""Table92"" type=""Table92"" />
        <xs:element name=""Table93"" type=""Table93"" />
        <xs:element name=""Table98"" type=""Table98"" />
        <xs:element name=""Table99"" type=""Table99"" />
        <xs:element name=""Table9999"" type=""Table9999"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:simpleType name=""Table1"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table2"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table3"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A01"" />
      <xs:enumeration value=""A02"" />
      <xs:enumeration value=""A03"" />
      <xs:enumeration value=""A04"" />
      <xs:enumeration value=""A05"" />
      <xs:enumeration value=""A06"" />
      <xs:enumeration value=""A07"" />
      <xs:enumeration value=""A08"" />
      <xs:enumeration value=""A09"" />
      <xs:enumeration value=""A10"" />
      <xs:enumeration value=""A11"" />
      <xs:enumeration value=""A12"" />
      <xs:enumeration value=""A13"" />
      <xs:enumeration value=""A14"" />
      <xs:enumeration value=""A15"" />
      <xs:enumeration value=""A16"" />
      <xs:enumeration value=""A17"" />
      <xs:enumeration value=""A18"" />
      <xs:enumeration value=""A19"" />
      <xs:enumeration value=""A20"" />
      <xs:enumeration value=""A21"" />
      <xs:enumeration value=""A22"" />
      <xs:enumeration value=""A23"" />
      <xs:enumeration value=""A24"" />
      <xs:enumeration value=""A25"" />
      <xs:enumeration value=""A26"" />
      <xs:enumeration value=""A27"" />
      <xs:enumeration value=""A28"" />
      <xs:enumeration value=""A29"" />
      <xs:enumeration value=""A30"" />
      <xs:enumeration value=""A31"" />
      <xs:enumeration value=""A32"" />
      <xs:enumeration value=""A33"" />
      <xs:enumeration value=""A34"" />
      <xs:enumeration value=""A35"" />
      <xs:enumeration value=""A36"" />
      <xs:enumeration value=""A37"" />
      <xs:enumeration value=""A38"" />
      <xs:enumeration value=""A39"" />
      <xs:enumeration value=""A40"" />
      <xs:enumeration value=""A41"" />
      <xs:enumeration value=""A42"" />
      <xs:enumeration value=""A43"" />
      <xs:enumeration value=""A44"" />
      <xs:enumeration value=""A45"" />
      <xs:enumeration value=""A46"" />
      <xs:enumeration value=""A47"" />
      <xs:enumeration value=""A48"" />
      <xs:enumeration value=""A49"" />
      <xs:enumeration value=""A50"" />
      <xs:enumeration value=""A51"" />
      <xs:enumeration value=""A52"" />
      <xs:enumeration value=""A53"" />
      <xs:enumeration value=""A54"" />
      <xs:enumeration value=""A55"" />
      <xs:enumeration value=""A60"" />
      <xs:enumeration value=""A61"" />
      <xs:enumeration value=""A62"" />
      <xs:enumeration value=""B01"" />
      <xs:enumeration value=""B02"" />
      <xs:enumeration value=""B03"" />
      <xs:enumeration value=""B04"" />
      <xs:enumeration value=""B05"" />
      <xs:enumeration value=""B06"" />
      <xs:enumeration value=""B07"" />
      <xs:enumeration value=""B08"" />
      <xs:enumeration value=""C01"" />
      <xs:enumeration value=""C02"" />
      <xs:enumeration value=""C03"" />
      <xs:enumeration value=""C04"" />
      <xs:enumeration value=""C05"" />
      <xs:enumeration value=""C06"" />
      <xs:enumeration value=""C07"" />
      <xs:enumeration value=""C08"" />
      <xs:enumeration value=""C09"" />
      <xs:enumeration value=""C10"" />
      <xs:enumeration value=""C11"" />
      <xs:enumeration value=""C12"" />
      <xs:enumeration value=""CNQ"" />
      <xs:enumeration value=""I01"" />
      <xs:enumeration value=""I02"" />
      <xs:enumeration value=""I03"" />
      <xs:enumeration value=""I04"" />
      <xs:enumeration value=""I05"" />
      <xs:enumeration value=""I06"" />
      <xs:enumeration value=""I07"" />
      <xs:enumeration value=""I08"" />
      <xs:enumeration value=""I09"" />
      <xs:enumeration value=""I10"" />
      <xs:enumeration value=""I11"" />
      <xs:enumeration value=""I12"" />
      <xs:enumeration value=""I13"" />
      <xs:enumeration value=""I14"" />
      <xs:enumeration value=""I15"" />
      <xs:enumeration value=""J01"" />
      <xs:enumeration value=""J02"" />
      <xs:enumeration value=""K11"" />
      <xs:enumeration value=""K13"" />
      <xs:enumeration value=""K15"" />
      <xs:enumeration value=""K21"" />
      <xs:enumeration value=""K22"" />
      <xs:enumeration value=""K23"" />
      <xs:enumeration value=""K24"" />
      <xs:enumeration value=""K25"" />
      <xs:enumeration value=""M01"" />
      <xs:enumeration value=""M02"" />
      <xs:enumeration value=""M03"" />
      <xs:enumeration value=""M04"" />
      <xs:enumeration value=""M05"" />
      <xs:enumeration value=""M06"" />
      <xs:enumeration value=""M07"" />
      <xs:enumeration value=""M08"" />
      <xs:enumeration value=""M09"" />
      <xs:enumeration value=""M10"" />
      <xs:enumeration value=""M11"" />
      <xs:enumeration value=""M12"" />
      <xs:enumeration value=""M13"" />
      <xs:enumeration value=""M14"" />
      <xs:enumeration value=""M15"" />
      <xs:enumeration value=""N01"" />
      <xs:enumeration value=""N02"" />
      <xs:enumeration value=""O01"" />
      <xs:enumeration value=""O02"" />
      <xs:enumeration value=""O03"" />
      <xs:enumeration value=""O04"" />
      <xs:enumeration value=""O05"" />
      <xs:enumeration value=""O06"" />
      <xs:enumeration value=""O07"" />
      <xs:enumeration value=""O08"" />
      <xs:enumeration value=""O09"" />
      <xs:enumeration value=""O10"" />
      <xs:enumeration value=""O11"" />
      <xs:enumeration value=""O12"" />
      <xs:enumeration value=""O13"" />
      <xs:enumeration value=""O14"" />
      <xs:enumeration value=""O15"" />
      <xs:enumeration value=""O16"" />
      <xs:enumeration value=""O17"" />
      <xs:enumeration value=""O18"" />
      <xs:enumeration value=""O19"" />
      <xs:enumeration value=""O20"" />
      <xs:enumeration value=""O21"" />
      <xs:enumeration value=""O22"" />
      <xs:enumeration value=""O23"" />
      <xs:enumeration value=""O24"" />
      <xs:enumeration value=""O25"" />
      <xs:enumeration value=""O26"" />
      <xs:enumeration value=""O27"" />
      <xs:enumeration value=""O28"" />
      <xs:enumeration value=""O29"" />
      <xs:enumeration value=""O30"" />
      <xs:enumeration value=""O31"" />
      <xs:enumeration value=""O32"" />
      <xs:enumeration value=""O33"" />
      <xs:enumeration value=""O34"" />
      <xs:enumeration value=""O35"" />
      <xs:enumeration value=""O36"" />
      <xs:enumeration value=""P01"" />
      <xs:enumeration value=""P02"" />
      <xs:enumeration value=""P03"" />
      <xs:enumeration value=""P04"" />
      <xs:enumeration value=""P05"" />
      <xs:enumeration value=""P06"" />
      <xs:enumeration value=""P07"" />
      <xs:enumeration value=""P08"" />
      <xs:enumeration value=""P09"" />
      <xs:enumeration value=""P10"" />
      <xs:enumeration value=""P11"" />
      <xs:enumeration value=""P12"" />
      <xs:enumeration value=""PC1"" />
      <xs:enumeration value=""PC2"" />
      <xs:enumeration value=""PC3"" />
      <xs:enumeration value=""PC4"" />
      <xs:enumeration value=""PC5"" />
      <xs:enumeration value=""PC6"" />
      <xs:enumeration value=""PC7"" />
      <xs:enumeration value=""PC8"" />
      <xs:enumeration value=""PC9"" />
      <xs:enumeration value=""PCA"" />
      <xs:enumeration value=""PCB"" />
      <xs:enumeration value=""PCC"" />
      <xs:enumeration value=""PCD"" />
      <xs:enumeration value=""PCE"" />
      <xs:enumeration value=""PCF"" />
      <xs:enumeration value=""PCG"" />
      <xs:enumeration value=""PCH"" />
      <xs:enumeration value=""PCJ"" />
      <xs:enumeration value=""PCK"" />
      <xs:enumeration value=""PCL"" />
      <xs:enumeration value=""Q01"" />
      <xs:enumeration value=""Q02"" />
      <xs:enumeration value=""Q03"" />
      <xs:enumeration value=""Q04"" />
      <xs:enumeration value=""Q05"" />
      <xs:enumeration value=""Q06"" />
      <xs:enumeration value=""Q07"" />
      <xs:enumeration value=""Q08"" />
      <xs:enumeration value=""Q09"" />
      <xs:enumeration value=""Q11"" />
      <xs:enumeration value=""Q13"" />
      <xs:enumeration value=""Q15"" />
      <xs:enumeration value=""Q16"" />
      <xs:enumeration value=""Q17"" />
      <xs:enumeration value=""Q21"" />
      <xs:enumeration value=""Q22"" />
      <xs:enumeration value=""Q23"" />
      <xs:enumeration value=""Q24"" />
      <xs:enumeration value=""Q25"" />
      <xs:enumeration value=""Q26"" />
      <xs:enumeration value=""Q27"" />
      <xs:enumeration value=""Q28"" />
      <xs:enumeration value=""Q29"" />
      <xs:enumeration value=""Q30"" />
      <xs:enumeration value=""R01"" />
      <xs:enumeration value=""R02"" />
      <xs:enumeration value=""R03"" />
      <xs:enumeration value=""R04"" />
      <xs:enumeration value=""R07"" />
      <xs:enumeration value=""R08"" />
      <xs:enumeration value=""R09"" />
      <xs:enumeration value=""R21"" />
      <xs:enumeration value=""R22"" />
      <xs:enumeration value=""R23"" />
      <xs:enumeration value=""R24"" />
      <xs:enumeration value=""R30"" />
      <xs:enumeration value=""R31"" />
      <xs:enumeration value=""R32"" />
      <xs:enumeration value=""ROR"" />
      <xs:enumeration value=""S01"" />
      <xs:enumeration value=""S02"" />
      <xs:enumeration value=""S03"" />
      <xs:enumeration value=""S04"" />
      <xs:enumeration value=""S05"" />
      <xs:enumeration value=""S06"" />
      <xs:enumeration value=""S07"" />
      <xs:enumeration value=""S08"" />
      <xs:enumeration value=""S09"" />
      <xs:enumeration value=""S10"" />
      <xs:enumeration value=""S11"" />
      <xs:enumeration value=""S12"" />
      <xs:enumeration value=""S13"" />
      <xs:enumeration value=""S14"" />
      <xs:enumeration value=""S15"" />
      <xs:enumeration value=""S16"" />
      <xs:enumeration value=""S17"" />
      <xs:enumeration value=""S18"" />
      <xs:enumeration value=""S19"" />
      <xs:enumeration value=""S20"" />
      <xs:enumeration value=""S21"" />
      <xs:enumeration value=""S22"" />
      <xs:enumeration value=""S23"" />
      <xs:enumeration value=""S24"" />
      <xs:enumeration value=""S25"" />
      <xs:enumeration value=""S26"" />
      <xs:enumeration value=""T01"" />
      <xs:enumeration value=""T02"" />
      <xs:enumeration value=""T03"" />
      <xs:enumeration value=""T04"" />
      <xs:enumeration value=""T05"" />
      <xs:enumeration value=""T06"" />
      <xs:enumeration value=""T07"" />
      <xs:enumeration value=""T08"" />
      <xs:enumeration value=""T09"" />
      <xs:enumeration value=""T10"" />
      <xs:enumeration value=""T11"" />
      <xs:enumeration value=""T12"" />
      <xs:enumeration value=""U01"" />
      <xs:enumeration value=""U02"" />
      <xs:enumeration value=""U03"" />
      <xs:enumeration value=""U04"" />
      <xs:enumeration value=""U05"" />
      <xs:enumeration value=""U06"" />
      <xs:enumeration value=""U07"" />
      <xs:enumeration value=""U08"" />
      <xs:enumeration value=""U09"" />
      <xs:enumeration value=""U10"" />
      <xs:enumeration value=""U11"" />
      <xs:enumeration value=""U12"" />
      <xs:enumeration value=""U13"" />
      <xs:enumeration value=""V01"" />
      <xs:enumeration value=""V02"" />
      <xs:enumeration value=""V03"" />
      <xs:enumeration value=""V04"" />
      <xs:enumeration value=""Varies"" />
      <xs:enumeration value=""W01"" />
      <xs:enumeration value=""W02"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table4"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table5"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
      <xs:enumeration value=""1002-5"" />
      <xs:enumeration value=""2028-9"" />
      <xs:enumeration value=""2054-5"" />
      <xs:enumeration value=""2076-8"" />
      <xs:enumeration value=""2106-3"" />
      <xs:enumeration value=""2131-1"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table6"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ABC"" />
      <xs:enumeration value=""AGN"" />
      <xs:enumeration value=""AME"" />
      <xs:enumeration value=""AMT"" />
      <xs:enumeration value=""ANG"" />
      <xs:enumeration value=""AOG"" />
      <xs:enumeration value=""ATH"" />
      <xs:enumeration value=""BAH"" />
      <xs:enumeration value=""BAP"" />
      <xs:enumeration value=""BMA"" />
      <xs:enumeration value=""BOT"" />
      <xs:enumeration value=""BTA"" />
      <xs:enumeration value=""BTH"" />
      <xs:enumeration value=""BUD"" />
      <xs:enumeration value=""CAT"" />
      <xs:enumeration value=""CFR"" />
      <xs:enumeration value=""CHR"" />
      <xs:enumeration value=""CHS"" />
      <xs:enumeration value=""CMA"" />
      <xs:enumeration value=""CNF"" />
      <xs:enumeration value=""COC"" />
      <xs:enumeration value=""COG"" />
      <xs:enumeration value=""COI"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""COM"" />
      <xs:enumeration value=""COP"" />
      <xs:enumeration value=""COT"" />
      <xs:enumeration value=""CRR"" />
      <xs:enumeration value=""EOT"" />
      <xs:enumeration value=""EPI"" />
      <xs:enumeration value=""ERL"" />
      <xs:enumeration value=""EVC"" />
      <xs:enumeration value=""FRQ"" />
      <xs:enumeration value=""FWB"" />
      <xs:enumeration value=""GRE"" />
      <xs:enumeration value=""HIN"" />
      <xs:enumeration value=""HOT"" />
      <xs:enumeration value=""HSH"" />
      <xs:enumeration value=""HVA"" />
      <xs:enumeration value=""JAI"" />
      <xs:enumeration value=""JCO"" />
      <xs:enumeration value=""JEW"" />
      <xs:enumeration value=""JOR"" />
      <xs:enumeration value=""JOT"" />
      <xs:enumeration value=""JRC"" />
      <xs:enumeration value=""JRF"" />
      <xs:enumeration value=""JRN"" />
      <xs:enumeration value=""JWN"" />
      <xs:enumeration value=""LMS"" />
      <xs:enumeration value=""LUT"" />
      <xs:enumeration value=""MEN"" />
      <xs:enumeration value=""MET"" />
      <xs:enumeration value=""MOM"" />
      <xs:enumeration value=""MOS"" />
      <xs:enumeration value=""MOT"" />
      <xs:enumeration value=""MSH"" />
      <xs:enumeration value=""MSU"" />
      <xs:enumeration value=""NAM"" />
      <xs:enumeration value=""NAZ"" />
      <xs:enumeration value=""NOE"" />
      <xs:enumeration value=""NRL"" />
      <xs:enumeration value=""ORT"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PEN"" />
      <xs:enumeration value=""PRC"" />
      <xs:enumeration value=""PRE"" />
      <xs:enumeration value=""PRO"" />
      <xs:enumeration value=""QUA"" />
      <xs:enumeration value=""REC"" />
      <xs:enumeration value=""REO"" />
      <xs:enumeration value=""SAA"" />
      <xs:enumeration value=""SEV"" />
      <xs:enumeration value=""SHN"" />
      <xs:enumeration value=""SIK"" />
      <xs:enumeration value=""SOU"" />
      <xs:enumeration value=""SPI"" />
      <xs:enumeration value=""UCC"" />
      <xs:enumeration value=""UMD"" />
      <xs:enumeration value=""UNI"" />
      <xs:enumeration value=""UNU"" />
      <xs:enumeration value=""VAR"" />
      <xs:enumeration value=""WES"" />
      <xs:enumeration value=""WMC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table7"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table8"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table9"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A0"" />
      <xs:enumeration value=""A1"" />
      <xs:enumeration value=""A2"" />
      <xs:enumeration value=""A3"" />
      <xs:enumeration value=""A4"" />
      <xs:enumeration value=""A5"" />
      <xs:enumeration value=""A6"" />
      <xs:enumeration value=""A7"" />
      <xs:enumeration value=""A8"" />
      <xs:enumeration value=""A9"" />
      <xs:enumeration value=""B1"" />
      <xs:enumeration value=""B2"" />
      <xs:enumeration value=""B3"" />
      <xs:enumeration value=""B4"" />
      <xs:enumeration value=""B5"" />
      <xs:enumeration value=""B6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table10"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table17"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AJ"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CG"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""PY"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table18"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table19"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table21"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table22"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table23"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table24"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table27"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table32"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table38"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""SC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table42"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table43"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table44"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table45"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table46"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table48"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ADV"" />
      <xs:enumeration value=""ANU"" />
      <xs:enumeration value=""APA"" />
      <xs:enumeration value=""APM"" />
      <xs:enumeration value=""APN"" />
      <xs:enumeration value=""APP"" />
      <xs:enumeration value=""ARN"" />
      <xs:enumeration value=""CAN"" />
      <xs:enumeration value=""DEM"" />
      <xs:enumeration value=""FIN"" />
      <xs:enumeration value=""GID"" />
      <xs:enumeration value=""GOL"" />
      <xs:enumeration value=""MRI"" />
      <xs:enumeration value=""MRO"" />
      <xs:enumeration value=""NCK"" />
      <xs:enumeration value=""NSC"" />
      <xs:enumeration value=""NST"" />
      <xs:enumeration value=""ORD"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PRB"" />
      <xs:enumeration value=""PRO"" />
      <xs:enumeration value=""RAR"" />
      <xs:enumeration value=""RDR"" />
      <xs:enumeration value=""RER"" />
      <xs:enumeration value=""RES"" />
      <xs:enumeration value=""RGR"" />
      <xs:enumeration value=""ROR"" />
      <xs:enumeration value=""SAL"" />
      <xs:enumeration value=""SBK"" />
      <xs:enumeration value=""SBL"" />
      <xs:enumeration value=""SOF"" />
      <xs:enumeration value=""SOP"" />
      <xs:enumeration value=""SSA"" />
      <xs:enumeration value=""SSR"" />
      <xs:enumeration value=""STA"" />
      <xs:enumeration value=""VXI"" />
      <xs:enumeration value=""XID"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table49"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table50"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table51"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table52"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table53"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table55"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table56"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table59"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table61"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ISO"" />
      <xs:enumeration value=""M10"" />
      <xs:enumeration value=""M11"" />
      <xs:enumeration value=""NPI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table62"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table63"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ASC"" />
      <xs:enumeration value=""BRO"" />
      <xs:enumeration value=""CGV"" />
      <xs:enumeration value=""CHD"" />
      <xs:enumeration value=""DEP"" />
      <xs:enumeration value=""DOM"" />
      <xs:enumeration value=""EMC"" />
      <xs:enumeration value=""EME"" />
      <xs:enumeration value=""EMR"" />
      <xs:enumeration value=""EXF"" />
      <xs:enumeration value=""FCH"" />
      <xs:enumeration value=""FND"" />
      <xs:enumeration value=""FTH"" />
      <xs:enumeration value=""GCH"" />
      <xs:enumeration value=""GRD"" />
      <xs:enumeration value=""GRP"" />
      <xs:enumeration value=""MGR"" />
      <xs:enumeration value=""MTH"" />
      <xs:enumeration value=""NCH"" />
      <xs:enumeration value=""NON"" />
      <xs:enumeration value=""OAD"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""OWN"" />
      <xs:enumeration value=""PAR"" />
      <xs:enumeration value=""SCH"" />
      <xs:enumeration value=""SEL"" />
      <xs:enumeration value=""SIB"" />
      <xs:enumeration value=""SIS"" />
      <xs:enumeration value=""SPO"" />
      <xs:enumeration value=""TRA"" />
      <xs:enumeration value=""UNK"" />
      <xs:enumeration value=""WRD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table64"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table65"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table66"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table68"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table69"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CAR"" />
      <xs:enumeration value=""MED"" />
      <xs:enumeration value=""PUL"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""URO"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table70"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""ACNE"" />
      <xs:enumeration value=""ACNFLD"" />
      <xs:enumeration value=""AIRS"" />
      <xs:enumeration value=""ALL"" />
      <xs:enumeration value=""AMN"" />
      <xs:enumeration value=""AMP"" />
      <xs:enumeration value=""ANGI"" />
      <xs:enumeration value=""ARTC"" />
      <xs:enumeration value=""ASERU"" />
      <xs:enumeration value=""ASP"" />
      <xs:enumeration value=""ATTE"" />
      <xs:enumeration value=""AUTOC"" />
      <xs:enumeration value=""AUTP"" />
      <xs:enumeration value=""BBL"" />
      <xs:enumeration value=""BCYST"" />
      <xs:enumeration value=""BDY"" />
      <xs:enumeration value=""BIFL"" />
      <xs:enumeration value=""BITE"" />
      <xs:enumeration value=""BLD"" />
      <xs:enumeration value=""BLDA"" />
      <xs:enumeration value=""BLDC"" />
      <xs:enumeration value=""BLDCO"" />
      <xs:enumeration value=""BLDV"" />
      <xs:enumeration value=""BLEB"" />
      <xs:enumeration value=""BLIST"" />
      <xs:enumeration value=""BOIL"" />
      <xs:enumeration value=""BON"" />
      <xs:enumeration value=""BOWL"" />
      <xs:enumeration value=""BPH"" />
      <xs:enumeration value=""BPU"" />
      <xs:enumeration value=""BRN"" />
      <xs:enumeration value=""BRO"" />
      <xs:enumeration value=""BRSH"" />
      <xs:enumeration value=""BRTH"" />
      <xs:enumeration value=""BRUS"" />
      <xs:enumeration value=""BUB"" />
      <xs:enumeration value=""BULLA"" />
      <xs:enumeration value=""BX"" />
      <xs:enumeration value=""CALC"" />
      <xs:enumeration value=""CARBU"" />
      <xs:enumeration value=""CAT"" />
      <xs:enumeration value=""CBITE"" />
      <xs:enumeration value=""CDM"" />
      <xs:enumeration value=""CLIPP"" />
      <xs:enumeration value=""CNJT"" />
      <xs:enumeration value=""CNL"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""CONE"" />
      <xs:enumeration value=""CSCR"" />
      <xs:enumeration value=""CSERU"" />
      <xs:enumeration value=""CSF"" />
      <xs:enumeration value=""CSITE"" />
      <xs:enumeration value=""CSMY"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CSVR"" />
      <xs:enumeration value=""CTP"" />
      <xs:enumeration value=""CUR"" />
      <xs:enumeration value=""CVM"" />
      <xs:enumeration value=""CVPS"" />
      <xs:enumeration value=""CVPT"" />
      <xs:enumeration value=""CVX"" />
      <xs:enumeration value=""CYN"" />
      <xs:enumeration value=""CYST"" />
      <xs:enumeration value=""DBITE"" />
      <xs:enumeration value=""DCS"" />
      <xs:enumeration value=""DEC"" />
      <xs:enumeration value=""DEION"" />
      <xs:enumeration value=""DIA"" />
      <xs:enumeration value=""DIAF"" />
      <xs:enumeration value=""DISCHG"" />
      <xs:enumeration value=""DIV"" />
      <xs:enumeration value=""DOSE"" />
      <xs:enumeration value=""DRN"" />
      <xs:enumeration value=""DRNG"" />
      <xs:enumeration value=""DRNGP"" />
      <xs:enumeration value=""DUFL"" />
      <xs:enumeration value=""EAR"" />
      <xs:enumeration value=""EARW"" />
      <xs:enumeration value=""EBRUSH"" />
      <xs:enumeration value=""EEYE"" />
      <xs:enumeration value=""EFF"" />
      <xs:enumeration value=""EFFUS"" />
      <xs:enumeration value=""EFOD"" />
      <xs:enumeration value=""EISO"" />
      <xs:enumeration value=""ELT"" />
      <xs:enumeration value=""ENDC"" />
      <xs:enumeration value=""ENDM"" />
      <xs:enumeration value=""ENVIR"" />
      <xs:enumeration value=""EOS"" />
      <xs:enumeration value=""EOTH"" />
      <xs:enumeration value=""ESOI"" />
      <xs:enumeration value=""ESOS"" />
      <xs:enumeration value=""ETA"" />
      <xs:enumeration value=""ETTP"" />
      <xs:enumeration value=""ETTUB"" />
      <xs:enumeration value=""EWHI"" />
      <xs:enumeration value=""EXG"" />
      <xs:enumeration value=""EXS"" />
      <xs:enumeration value=""EXUDTE"" />
      <xs:enumeration value=""EYE"" />
      <xs:enumeration value=""FAW"" />
      <xs:enumeration value=""FBLOOD"" />
      <xs:enumeration value=""FGA"" />
      <xs:enumeration value=""FIB"" />
      <xs:enumeration value=""FIST"" />
      <xs:enumeration value=""FLD"" />
      <xs:enumeration value=""FLT"" />
      <xs:enumeration value=""FLU"" />
      <xs:enumeration value=""FLUID"" />
      <xs:enumeration value=""FOLEY"" />
      <xs:enumeration value=""FRS"" />
      <xs:enumeration value=""FSCLP"" />
      <xs:enumeration value=""FUR"" />
      <xs:enumeration value=""GAS"" />
      <xs:enumeration value=""GASA"" />
      <xs:enumeration value=""GASAN"" />
      <xs:enumeration value=""GASBR"" />
      <xs:enumeration value=""GASD"" />
      <xs:enumeration value=""GAST"" />
      <xs:enumeration value=""GEN"" />
      <xs:enumeration value=""GENC"" />
      <xs:enumeration value=""GENL"" />
      <xs:enumeration value=""GENV"" />
      <xs:enumeration value=""GRAFT"" />
      <xs:enumeration value=""GRANU"" />
      <xs:enumeration value=""GROSH"" />
      <xs:enumeration value=""GSOL"" />
      <xs:enumeration value=""GSPEC"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""GTUBE"" />
      <xs:enumeration value=""HAR"" />
      <xs:enumeration value=""HBITE"" />
      <xs:enumeration value=""HBLUD"" />
      <xs:enumeration value=""HEMAQ"" />
      <xs:enumeration value=""HEMO"" />
      <xs:enumeration value=""HERNI"" />
      <xs:enumeration value=""HEV"" />
      <xs:enumeration value=""HIC"" />
      <xs:enumeration value=""HYDC"" />
      <xs:enumeration value=""IBITE"" />
      <xs:enumeration value=""ICYST"" />
      <xs:enumeration value=""IDC"" />
      <xs:enumeration value=""IHG"" />
      <xs:enumeration value=""ILEO"" />
      <xs:enumeration value=""ILLEG"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""INCI"" />
      <xs:enumeration value=""INFIL"" />
      <xs:enumeration value=""INS"" />
      <xs:enumeration value=""INTRD"" />
      <xs:enumeration value=""ISLT"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IUD"" />
      <xs:enumeration value=""IVCAT"" />
      <xs:enumeration value=""IVFLD"" />
      <xs:enumeration value=""IVTIP"" />
      <xs:enumeration value=""JEJU"" />
      <xs:enumeration value=""JNTFLD"" />
      <xs:enumeration value=""JP"" />
      <xs:enumeration value=""KELOI"" />
      <xs:enumeration value=""KIDFLD"" />
      <xs:enumeration value=""LAM"" />
      <xs:enumeration value=""LAVG"" />
      <xs:enumeration value=""LAVGG"" />
      <xs:enumeration value=""LAVGP"" />
      <xs:enumeration value=""LAVPG"" />
      <xs:enumeration value=""LENS1"" />
      <xs:enumeration value=""LENS2"" />
      <xs:enumeration value=""LESN"" />
      <xs:enumeration value=""LIQ"" />
      <xs:enumeration value=""LIQO"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LNA"" />
      <xs:enumeration value=""LNV"" />
      <xs:enumeration value=""LSAC"" />
      <xs:enumeration value=""LYM"" />
      <xs:enumeration value=""MAC"" />
      <xs:enumeration value=""MAHUR"" />
      <xs:enumeration value=""MAR"" />
      <xs:enumeration value=""MASS"" />
      <xs:enumeration value=""MBLD"" />
      <xs:enumeration value=""MEC"" />
      <xs:enumeration value=""MILK"" />
      <xs:enumeration value=""MLK"" />
      <xs:enumeration value=""MUCOS"" />
      <xs:enumeration value=""MUCUS"" />
      <xs:enumeration value=""NAIL"" />
      <xs:enumeration value=""NASDR"" />
      <xs:enumeration value=""NEDL"" />
      <xs:enumeration value=""NEPH"" />
      <xs:enumeration value=""NGASP"" />
      <xs:enumeration value=""NGAST"" />
      <xs:enumeration value=""NGS"" />
      <xs:enumeration value=""NODUL"" />
      <xs:enumeration value=""NOS"" />
      <xs:enumeration value=""NSECR"" />
      <xs:enumeration value=""ORH"" />
      <xs:enumeration value=""ORL"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PACEM"" />
      <xs:enumeration value=""PAFL"" />
      <xs:enumeration value=""PAT"" />
      <xs:enumeration value=""PCFL"" />
      <xs:enumeration value=""PDSIT"" />
      <xs:enumeration value=""PDTS"" />
      <xs:enumeration value=""PELVA"" />
      <xs:enumeration value=""PENIL"" />
      <xs:enumeration value=""PERIA"" />
      <xs:enumeration value=""PILOC"" />
      <xs:enumeration value=""PINS"" />
      <xs:enumeration value=""PIS"" />
      <xs:enumeration value=""PLAN"" />
      <xs:enumeration value=""PLAS"" />
      <xs:enumeration value=""PLB"" />
      <xs:enumeration value=""PLC"" />
      <xs:enumeration value=""PLEVS"" />
      <xs:enumeration value=""PLR"" />
      <xs:enumeration value=""PMN"" />
      <xs:enumeration value=""PND"" />
      <xs:enumeration value=""POL"" />
      <xs:enumeration value=""POPGS"" />
      <xs:enumeration value=""POPLG"" />
      <xs:enumeration value=""POPLV"" />
      <xs:enumeration value=""PORTA"" />
      <xs:enumeration value=""PPP"" />
      <xs:enumeration value=""PROST"" />
      <xs:enumeration value=""PRP"" />
      <xs:enumeration value=""PRT"" />
      <xs:enumeration value=""PSC"" />
      <xs:enumeration value=""PUNCT"" />
      <xs:enumeration value=""PUS"" />
      <xs:enumeration value=""PUSFR"" />
      <xs:enumeration value=""PUST"" />
      <xs:enumeration value=""QC3"" />
      <xs:enumeration value=""RANDU"" />
      <xs:enumeration value=""RBC"" />
      <xs:enumeration value=""RBITE"" />
      <xs:enumeration value=""RECT"" />
      <xs:enumeration value=""RECTA"" />
      <xs:enumeration value=""RENALC"" />
      <xs:enumeration value=""RENC"" />
      <xs:enumeration value=""RES"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""SAL"" />
      <xs:enumeration value=""SCAR"" />
      <xs:enumeration value=""SCLV"" />
      <xs:enumeration value=""SCROA"" />
      <xs:enumeration value=""SECRE"" />
      <xs:enumeration value=""SER"" />
      <xs:enumeration value=""SHU"" />
      <xs:enumeration value=""SHUNF"" />
      <xs:enumeration value=""SHUNT"" />
      <xs:enumeration value=""SITE"" />
      <xs:enumeration value=""SKBP"" />
      <xs:enumeration value=""SKM"" />
      <xs:enumeration value=""SKN"" />
      <xs:enumeration value=""SMM"" />
      <xs:enumeration value=""SMN"" />
      <xs:enumeration value=""SNV"" />
      <xs:enumeration value=""SPRM"" />
      <xs:enumeration value=""SPRP"" />
      <xs:enumeration value=""SPRPB"" />
      <xs:enumeration value=""SPS"" />
      <xs:enumeration value=""SPT"" />
      <xs:enumeration value=""SPTC"" />
      <xs:enumeration value=""SPTT"" />
      <xs:enumeration value=""SPUT1"" />
      <xs:enumeration value=""SPUTIN"" />
      <xs:enumeration value=""SPUTSP"" />
      <xs:enumeration value=""STER"" />
      <xs:enumeration value=""STL"" />
      <xs:enumeration value=""STON"" />
      <xs:enumeration value=""STONE"" />
      <xs:enumeration value=""SUBMA"" />
      <xs:enumeration value=""SUBMX"" />
      <xs:enumeration value=""SUMP"" />
      <xs:enumeration value=""SUP"" />
      <xs:enumeration value=""SUTUR"" />
      <xs:enumeration value=""SWGZ"" />
      <xs:enumeration value=""SWT"" />
      <xs:enumeration value=""TASP"" />
      <xs:enumeration value=""TEAR"" />
      <xs:enumeration value=""THRB"" />
      <xs:enumeration value=""THRT"" />
      <xs:enumeration value=""TISG"" />
      <xs:enumeration value=""TISPL"" />
      <xs:enumeration value=""TISS"" />
      <xs:enumeration value=""TISU"" />
      <xs:enumeration value=""TLC"" />
      <xs:enumeration value=""TLGI"" />
      <xs:enumeration value=""TLNG"" />
      <xs:enumeration value=""TRAC"" />
      <xs:enumeration value=""TRANS"" />
      <xs:enumeration value=""TSERU"" />
      <xs:enumeration value=""TSMI"" />
      <xs:enumeration value=""TSTES"" />
      <xs:enumeration value=""TTRA"" />
      <xs:enumeration value=""TUB"" />
      <xs:enumeration value=""TUBES"" />
      <xs:enumeration value=""TUMOR"" />
      <xs:enumeration value=""TZANC"" />
      <xs:enumeration value=""UDENT"" />
      <xs:enumeration value=""ULC"" />
      <xs:enumeration value=""UMB"" />
      <xs:enumeration value=""UMED"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""URC"" />
      <xs:enumeration value=""URINB"" />
      <xs:enumeration value=""URINC"" />
      <xs:enumeration value=""URINM"" />
      <xs:enumeration value=""URINN"" />
      <xs:enumeration value=""URINP"" />
      <xs:enumeration value=""URNS"" />
      <xs:enumeration value=""URT"" />
      <xs:enumeration value=""URTH"" />
      <xs:enumeration value=""USCOP"" />
      <xs:enumeration value=""USPEC"" />
      <xs:enumeration value=""USUB"" />
      <xs:enumeration value=""VASTIP"" />
      <xs:enumeration value=""VENT"" />
      <xs:enumeration value=""VITF"" />
      <xs:enumeration value=""VOM"" />
      <xs:enumeration value=""WASH"" />
      <xs:enumeration value=""WASI"" />
      <xs:enumeration value=""WAT"" />
      <xs:enumeration value=""WB"" />
      <xs:enumeration value=""WBC"" />
      <xs:enumeration value=""WEN"" />
      <xs:enumeration value=""WICK"" />
      <xs:enumeration value=""WND"" />
      <xs:enumeration value=""WNDA"" />
      <xs:enumeration value=""WNDD"" />
      <xs:enumeration value=""WNDE"" />
      <xs:enumeration value=""WORM"" />
      <xs:enumeration value=""WRT"" />
      <xs:enumeration value=""WWA"" />
      <xs:enumeration value=""WWO"" />
      <xs:enumeration value=""WWT"" />
      <xs:enumeration value=""XXX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table72"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table73"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table74"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""BG"" />
      <xs:enumeration value=""BLB"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""CTH"" />
      <xs:enumeration value=""CUS"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""HM"" />
      <xs:enumeration value=""ICU"" />
      <xs:enumeration value=""IMM"" />
      <xs:enumeration value=""LAB"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MCB"" />
      <xs:enumeration value=""MYC"" />
      <xs:enumeration value=""NMR"" />
      <xs:enumeration value=""NMS"" />
      <xs:enumeration value=""NRS"" />
      <xs:enumeration value=""OSL"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""OUS"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PHR"" />
      <xs:enumeration value=""PHY"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""RAD"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RUS"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""VUS"" />
      <xs:enumeration value=""XRC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table76"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ADR"" />
      <xs:enumeration value=""ADT"" />
      <xs:enumeration value=""BAR"" />
      <xs:enumeration value=""BPS"" />
      <xs:enumeration value=""BRP"" />
      <xs:enumeration value=""BRT"" />
      <xs:enumeration value=""BTS"" />
      <xs:enumeration value=""CRM"" />
      <xs:enumeration value=""CSU"" />
      <xs:enumeration value=""DFT"" />
      <xs:enumeration value=""DOC"" />
      <xs:enumeration value=""DSR"" />
      <xs:enumeration value=""EAC"" />
      <xs:enumeration value=""EAN"" />
      <xs:enumeration value=""EAR"" />
      <xs:enumeration value=""EDR"" />
      <xs:enumeration value=""EQQ"" />
      <xs:enumeration value=""ERP"" />
      <xs:enumeration value=""ESR"" />
      <xs:enumeration value=""ESU"" />
      <xs:enumeration value=""INR"" />
      <xs:enumeration value=""INU"" />
      <xs:enumeration value=""LSR"" />
      <xs:enumeration value=""LSU"" />
      <xs:enumeration value=""MCF"" />
      <xs:enumeration value=""MDM"" />
      <xs:enumeration value=""MFD"" />
      <xs:enumeration value=""MFK"" />
      <xs:enumeration value=""MFN"" />
      <xs:enumeration value=""MFQ"" />
      <xs:enumeration value=""MFR"" />
      <xs:enumeration value=""NMD"" />
      <xs:enumeration value=""NMQ"" />
      <xs:enumeration value=""NMR"" />
      <xs:enumeration value=""OMB"" />
      <xs:enumeration value=""OMD"" />
      <xs:enumeration value=""OMG"" />
      <xs:enumeration value=""OMI"" />
      <xs:enumeration value=""OML"" />
      <xs:enumeration value=""OMN"" />
      <xs:enumeration value=""OMP"" />
      <xs:enumeration value=""OMS"" />
      <xs:enumeration value=""ORB"" />
      <xs:enumeration value=""ORD"" />
      <xs:enumeration value=""ORF"" />
      <xs:enumeration value=""ORG"" />
      <xs:enumeration value=""ORI"" />
      <xs:enumeration value=""ORL"" />
      <xs:enumeration value=""ORM"" />
      <xs:enumeration value=""ORN"" />
      <xs:enumeration value=""ORP"" />
      <xs:enumeration value=""ORR"" />
      <xs:enumeration value=""ORS"" />
      <xs:enumeration value=""ORU"" />
      <xs:enumeration value=""OSQ"" />
      <xs:enumeration value=""OSR"" />
      <xs:enumeration value=""OUL"" />
      <xs:enumeration value=""PEX"" />
      <xs:enumeration value=""PGL"" />
      <xs:enumeration value=""PIN"" />
      <xs:enumeration value=""PMU"" />
      <xs:enumeration value=""PPG"" />
      <xs:enumeration value=""PPP"" />
      <xs:enumeration value=""PPR"" />
      <xs:enumeration value=""PPT"" />
      <xs:enumeration value=""PPV"" />
      <xs:enumeration value=""PRR"" />
      <xs:enumeration value=""PTR"" />
      <xs:enumeration value=""QBP"" />
      <xs:enumeration value=""QCK"" />
      <xs:enumeration value=""QCN"" />
      <xs:enumeration value=""QRY"" />
      <xs:enumeration value=""QSB"" />
      <xs:enumeration value=""QSX"" />
      <xs:enumeration value=""QVR"" />
      <xs:enumeration value=""RAR"" />
      <xs:enumeration value=""RAS"" />
      <xs:enumeration value=""RCI"" />
      <xs:enumeration value=""RCL"" />
      <xs:enumeration value=""RDE"" />
      <xs:enumeration value=""RDR"" />
      <xs:enumeration value=""RDS"" />
      <xs:enumeration value=""RDY"" />
      <xs:enumeration value=""REF"" />
      <xs:enumeration value=""RER"" />
      <xs:enumeration value=""RGR"" />
      <xs:enumeration value=""RGV"" />
      <xs:enumeration value=""ROR"" />
      <xs:enumeration value=""RPA"" />
      <xs:enumeration value=""RPI"" />
      <xs:enumeration value=""RPL"" />
      <xs:enumeration value=""RPR"" />
      <xs:enumeration value=""RQA"" />
      <xs:enumeration value=""RQC"" />
      <xs:enumeration value=""RQI"" />
      <xs:enumeration value=""RQP"" />
      <xs:enumeration value=""RQQ"" />
      <xs:enumeration value=""RRA"" />
      <xs:enumeration value=""RRD"" />
      <xs:enumeration value=""RRE"" />
      <xs:enumeration value=""RRG"" />
      <xs:enumeration value=""RRI"" />
      <xs:enumeration value=""RSP"" />
      <xs:enumeration value=""RTB"" />
      <xs:enumeration value=""SIU"" />
      <xs:enumeration value=""SPQ"" />
      <xs:enumeration value=""SQM"" />
      <xs:enumeration value=""SQR"" />
      <xs:enumeration value=""SRM"" />
      <xs:enumeration value=""SRR"" />
      <xs:enumeration value=""SSR"" />
      <xs:enumeration value=""SSU"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""TBR"" />
      <xs:enumeration value=""TCR"" />
      <xs:enumeration value=""TCU"" />
      <xs:enumeration value=""UDM"" />
      <xs:enumeration value=""VQQ"" />
      <xs:enumeration value=""VXQ"" />
      <xs:enumeration value=""VXR"" />
      <xs:enumeration value=""VXU"" />
      <xs:enumeration value=""VXX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table78"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""&lt;"" />
      <xs:enumeration value=""&gt;"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""HH"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LL"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""null"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table80"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""ST"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table83"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table84"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table85"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""W"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table86"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table87"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table88"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table89"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table91"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table92"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table93"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""_"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table98"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table99"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table100"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table103"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table104"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""2.0"" />
      <xs:enumeration value=""2.0D"" />
      <xs:enumeration value=""2.1"" />
      <xs:enumeration value=""2.2"" />
      <xs:enumeration value=""2.3"" />
      <xs:enumeration value=""2.3.1"" />
      <xs:enumeration value=""2.4"" />
      <xs:enumeration value=""2.5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table105"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table106"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table107"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""L"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table108"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table109"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table110"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table111"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table112"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10 _19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21 ... 29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31 _ 39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table113"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table114"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table115"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table116"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table117"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table118"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table119"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AF"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""FU"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""HR"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""OC"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OF"" />
      <xs:enumeration value=""OH"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OR"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PY"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RO"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RU"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""UF"" />
      <xs:enumeration value=""UH"" />
      <xs:enumeration value=""UM"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""UX"" />
      <xs:enumeration value=""XO"" />
      <xs:enumeration value=""XR"" />
      <xs:enumeration value=""XX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table121"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table122"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""DP"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""NC"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""RS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table123"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
      <xs:enumeration value=""Z"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table124"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CART"" />
      <xs:enumeration value=""PORT"" />
      <xs:enumeration value=""WALK"" />
      <xs:enumeration value=""WHLC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table125"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""XAD"" />
      <xs:enumeration value=""XCN"" />
      <xs:enumeration value=""XON"" />
      <xs:enumeration value=""XPN"" />
      <xs:enumeration value=""XTN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table126"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""PG"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""ZO"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table127"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""EA"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""PA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table128"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""SV"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table129"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table130"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""HO"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""TE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table131"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table132"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table133"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""PS"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""SN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table135"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table136"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table137"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table139"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table140"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AUSA"" />
      <xs:enumeration value=""AUSAF"" />
      <xs:enumeration value=""AUSN"" />
      <xs:enumeration value=""NATO"" />
      <xs:enumeration value=""NOAA"" />
      <xs:enumeration value=""USA"" />
      <xs:enumeration value=""USAF"" />
      <xs:enumeration value=""USCG"" />
      <xs:enumeration value=""USMC"" />
      <xs:enumeration value=""USN"" />
      <xs:enumeration value=""USPHS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table141"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E1... E9"" />
      <xs:enumeration value=""O1 ... O9"" />
      <xs:enumeration value=""W1 ... W4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table142"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACT"" />
      <xs:enumeration value=""DEC"" />
      <xs:enumeration value=""RET"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table143"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table144"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table145"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""2ICU"" />
      <xs:enumeration value=""2PRI"" />
      <xs:enumeration value=""2SPR"" />
      <xs:enumeration value=""ICU"" />
      <xs:enumeration value=""PRI"" />
      <xs:enumeration value=""SPR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table146"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DF"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""UL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table147"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""2ANC"" />
      <xs:enumeration value=""2MMD"" />
      <xs:enumeration value=""3MMD"" />
      <xs:enumeration value=""ANC"" />
      <xs:enumeration value=""MMD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table148"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""PC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table149"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""PE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table150"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""IPE"" />
      <xs:enumeration value=""OPE"" />
      <xs:enumeration value=""UR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table151"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table152"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table153"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table155"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""SU"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table156"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ANY"" />
      <xs:enumeration value=""COL"" />
      <xs:enumeration value=""ORD"" />
      <xs:enumeration value=""RCT"" />
      <xs:enumeration value=""REP"" />
      <xs:enumeration value=""SCHED"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table157"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ANY"" />
      <xs:enumeration value=""CFN"" />
      <xs:enumeration value=""COR"" />
      <xs:enumeration value=""FIN"" />
      <xs:enumeration value=""PRE"" />
      <xs:enumeration value=""REP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table158"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1ST"" />
      <xs:enumeration value=""ALL"" />
      <xs:enumeration value=""LST"" />
      <xs:enumeration value=""REV"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table159"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table160"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""EARLY"" />
      <xs:enumeration value=""GUEST"" />
      <xs:enumeration value=""LATE"" />
      <xs:enumeration value=""MSG"" />
      <xs:enumeration value=""NO"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table161"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table162"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""EP"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""GTT"" />
      <xs:enumeration value=""GU"" />
      <xs:enumeration value=""IA"" />
      <xs:enumeration value=""IB"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ICV"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IH"" />
      <xs:enumeration value=""IHA"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IMR"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IO"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IT"" />
      <xs:enumeration value=""IU"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""MM"" />
      <xs:enumeration value=""MTH"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""NT"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PO"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""TD"" />
      <xs:enumeration value=""TL"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""TRA"" />
      <xs:enumeration value=""UR"" />
      <xs:enumeration value=""VG"" />
      <xs:enumeration value=""VM"" />
      <xs:enumeration value=""WND"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table163"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BU"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""LAC"" />
      <xs:enumeration value=""LACF"" />
      <xs:enumeration value=""LD"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LEJ"" />
      <xs:enumeration value=""LF"" />
      <xs:enumeration value=""LG"" />
      <xs:enumeration value=""LH"" />
      <xs:enumeration value=""LIJ"" />
      <xs:enumeration value=""LLAQ"" />
      <xs:enumeration value=""LLFA"" />
      <xs:enumeration value=""LMFA"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LPC"" />
      <xs:enumeration value=""LSC"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""LUA"" />
      <xs:enumeration value=""LUAQ"" />
      <xs:enumeration value=""LUFA"" />
      <xs:enumeration value=""LVG"" />
      <xs:enumeration value=""LVL"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OS"" />
      <xs:enumeration value=""OU"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PERIN"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RAC"" />
      <xs:enumeration value=""RACF"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""REJ"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""RG"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RIJ"" />
      <xs:enumeration value=""RLAQ"" />
      <xs:enumeration value=""RLFA"" />
      <xs:enumeration value=""RMFA"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RPC"" />
      <xs:enumeration value=""RSC"" />
      <xs:enumeration value=""RT"" />
      <xs:enumeration value=""RUA"" />
      <xs:enumeration value=""RUAQ"" />
      <xs:enumeration value=""RUFA"" />
      <xs:enumeration value=""RVG"" />
      <xs:enumeration value=""RVL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table164"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""IPPB"" />
      <xs:enumeration value=""IVP"" />
      <xs:enumeration value=""IVS"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""NEB"" />
      <xs:enumeration value=""PCA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table165"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""IF"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""IVP"" />
      <xs:enumeration value=""IVPB"" />
      <xs:enumeration value=""NB"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table166"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table167"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table168"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table169"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table170"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table171"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table172"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table173"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""IN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table174"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table175"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CDM"" />
      <xs:enumeration value=""CLN"" />
      <xs:enumeration value=""CMA"" />
      <xs:enumeration value=""CMB"" />
      <xs:enumeration value=""INV"" />
      <xs:enumeration value=""LOC"" />
      <xs:enumeration value=""OMA"" />
      <xs:enumeration value=""OMB"" />
      <xs:enumeration value=""OMC"" />
      <xs:enumeration value=""OMD"" />
      <xs:enumeration value=""OME"" />
      <xs:enumeration value=""PRA"" />
      <xs:enumeration value=""STF"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table177"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AID"" />
      <xs:enumeration value=""EMP"" />
      <xs:enumeration value=""ETH"" />
      <xs:enumeration value=""HIV"" />
      <xs:enumeration value=""PSY"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""UWM"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""VIP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table178"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""REP"" />
      <xs:enumeration value=""UPD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table179"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""SU"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table180"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""MAC"" />
      <xs:enumeration value=""MAD"" />
      <xs:enumeration value=""MDC"" />
      <xs:enumeration value=""MDL"" />
      <xs:enumeration value=""MUP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table181"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table182"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table183"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table184"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table185"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""O"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table186"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table187"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table188"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table189"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table190"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BDL"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""RH"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table191"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""multipart"" />
      <xs:enumeration value=""NS"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""TEXT"" />
      <xs:enumeration value=""TX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table193"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""UL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table200"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table201"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ASN"" />
      <xs:enumeration value=""BPN"" />
      <xs:enumeration value=""EMR"" />
      <xs:enumeration value=""NET"" />
      <xs:enumeration value=""ORN"" />
      <xs:enumeration value=""PRN"" />
      <xs:enumeration value=""VHN"" />
      <xs:enumeration value=""WPN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table202"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""Internet"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""TDD"" />
      <xs:enumeration value=""TTY"" />
      <xs:enumeration value=""X.400"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table203"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""ANC"" />
      <xs:enumeration value=""AND"" />
      <xs:enumeration value=""ANON"" />
      <xs:enumeration value=""ANT"" />
      <xs:enumeration value=""APRN"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BC"" />
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""BRN"" />
      <xs:enumeration value=""CC"" />
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""DDS"" />
      <xs:enumeration value=""DEA"" />
      <xs:enumeration value=""DFN"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DL"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""DPM"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""FI"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""HC"" />
      <xs:enumeration value=""IND"" />
      <xs:enumeration value=""JHN"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MB"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MCN"" />
      <xs:enumeration value=""MCR"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""MRT"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NII"" />
      <xs:enumeration value=""NIIP"" />
      <xs:enumeration value=""NNxxx"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NPI"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PCN"" />
      <xs:enumeration value=""PE"" />
      <xs:enumeration value=""PEN"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PNT"" />
      <xs:enumeration value=""PPN"" />
      <xs:enumeration value=""PRC"" />
      <xs:enumeration value=""PRN"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RPH"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RRI"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SS"" />
      <xs:enumeration value=""TAX"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""UPIN"" />
      <xs:enumeration value=""VN"" />
      <xs:enumeration value=""VS"" />
      <xs:enumeration value=""WC"" />
      <xs:enumeration value=""WCN"" />
      <xs:enumeration value=""XX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table204"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""SL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table205"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""DC"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""PF"" />
      <xs:enumeration value=""TF"" />
      <xs:enumeration value=""TP"" />
      <xs:enumeration value=""UP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table206"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table207"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""Not present"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table208"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""NF"" />
      <xs:enumeration value=""OK"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table209"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""EQ"" />
      <xs:enumeration value=""GE"" />
      <xs:enumeration value=""GN"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""LE"" />
      <xs:enumeration value=""LT"" />
      <xs:enumeration value=""NE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table210"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AND"" />
      <xs:enumeration value=""OR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table211"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""8859/1"" />
      <xs:enumeration value=""8859/2"" />
      <xs:enumeration value=""8859/3"" />
      <xs:enumeration value=""8859/4"" />
      <xs:enumeration value=""8859/5"" />
      <xs:enumeration value=""8859/6"" />
      <xs:enumeration value=""8859/7"" />
      <xs:enumeration value=""8859/8"" />
      <xs:enumeration value=""8859/9"" />
      <xs:enumeration value=""ASCII"" />
      <xs:enumeration value=""BIG-5"" />
      <xs:enumeration value=""CNS 11643-1992"" />
      <xs:enumeration value=""GB 18030-2000"" />
      <xs:enumeration value=""ISO IR14"" />
      <xs:enumeration value=""ISO IR159"" />
      <xs:enumeration value=""ISO IR87"" />
      <xs:enumeration value=""KS X 1001"" />
      <xs:enumeration value=""UNICODE"" />
      <xs:enumeration value=""UNICODE UTF-16"" />
      <xs:enumeration value=""UNICODE UTF-32"" />
      <xs:enumeration value=""UNICODE UTF-8"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table212"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table213"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table214"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""FP"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table215"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table216"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""DI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table217"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table218"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table219"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table220"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table222"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table223"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table224"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table225"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table227"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""ALP"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AVB"" />
      <xs:enumeration value=""AVI"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BAH"" />
      <xs:enumeration value=""BAY"" />
      <xs:enumeration value=""BP"" />
      <xs:enumeration value=""BPC"" />
      <xs:enumeration value=""CEN"" />
      <xs:enumeration value=""CHI"" />
      <xs:enumeration value=""CMP"" />
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""EVN"" />
      <xs:enumeration value=""GRE"" />
      <xs:enumeration value=""IAG"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""IUS"" />
      <xs:enumeration value=""JPN"" />
      <xs:enumeration value=""KGC"" />
      <xs:enumeration value=""LED"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MBL"" />
      <xs:enumeration value=""MED"" />
      <xs:enumeration value=""MIL"" />
      <xs:enumeration value=""MIP"" />
      <xs:enumeration value=""MSD"" />
      <xs:enumeration value=""NAB"" />
      <xs:enumeration value=""NAV"" />
      <xs:enumeration value=""NOV"" />
      <xs:enumeration value=""NYB"" />
      <xs:enumeration value=""ORT"" />
      <xs:enumeration value=""OTC"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PMC"" />
      <xs:enumeration value=""PRX"" />
      <xs:enumeration value=""PWJ"" />
      <xs:enumeration value=""SCL"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SKB"" />
      <xs:enumeration value=""UNK"" />
      <xs:enumeration value=""USA"" />
      <xs:enumeration value=""WA"" />
      <xs:enumeration value=""WAL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table228"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table229"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""M"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table230"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table231"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table232"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table233"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table234"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10D"" />
      <xs:enumeration value=""15D"" />
      <xs:enumeration value=""30D"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""7D"" />
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""RQ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table235"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table236"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table237"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table238"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table239"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table240"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table241"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table242"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table243"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table244"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table245"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table246"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table247"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""X"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table248"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table249"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table250"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table251"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""WP"" />
      <xs:enumeration value=""WT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table252"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AW"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""TC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table253"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table254"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ABS"" />
      <xs:enumeration value=""ACNC"" />
      <xs:enumeration value=""ACT"" />
      <xs:enumeration value=""APER"" />
      <xs:enumeration value=""ARB"" />
      <xs:enumeration value=""AREA"" />
      <xs:enumeration value=""ASPECT"" />
      <xs:enumeration value=""CACT"" />
      <xs:enumeration value=""CCNT"" />
      <xs:enumeration value=""CCRTO"" />
      <xs:enumeration value=""CFR"" />
      <xs:enumeration value=""CLAS"" />
      <xs:enumeration value=""CNC"" />
      <xs:enumeration value=""CNST"" />
      <xs:enumeration value=""COEF"" />
      <xs:enumeration value=""COLOR"" />
      <xs:enumeration value=""CONS"" />
      <xs:enumeration value=""CRAT"" />
      <xs:enumeration value=""CRTO"" />
      <xs:enumeration value=""DEN"" />
      <xs:enumeration value=""DEV"" />
      <xs:enumeration value=""DIFF"" />
      <xs:enumeration value=""ELAS"" />
      <xs:enumeration value=""ELPOT"" />
      <xs:enumeration value=""ELRAT"" />
      <xs:enumeration value=""ELRES"" />
      <xs:enumeration value=""ENGR"" />
      <xs:enumeration value=""ENT"" />
      <xs:enumeration value=""ENTCAT"" />
      <xs:enumeration value=""ENTNUM"" />
      <xs:enumeration value=""ENTSUB"" />
      <xs:enumeration value=""ENTVOL"" />
      <xs:enumeration value=""EQL"" />
      <xs:enumeration value=""FORCE"" />
      <xs:enumeration value=""FREQ"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""KINV"" />
      <xs:enumeration value=""LEN"" />
      <xs:enumeration value=""LINC"" />
      <xs:enumeration value=""LIQ"" />
      <xs:enumeration value=""MASS"" />
      <xs:enumeration value=""MCNC"" />
      <xs:enumeration value=""MCNT"" />
      <xs:enumeration value=""MCRTO"" />
      <xs:enumeration value=""MFR"" />
      <xs:enumeration value=""MGFLUX"" />
      <xs:enumeration value=""MINC"" />
      <xs:enumeration value=""MORPH"" />
      <xs:enumeration value=""MOTIL"" />
      <xs:enumeration value=""MRAT"" />
      <xs:enumeration value=""MRTO"" />
      <xs:enumeration value=""NCNC"" />
      <xs:enumeration value=""NCNT"" />
      <xs:enumeration value=""NFR"" />
      <xs:enumeration value=""NRTO"" />
      <xs:enumeration value=""NUM"" />
      <xs:enumeration value=""OD"" />
      <xs:enumeration value=""OSMOL"" />
      <xs:enumeration value=""PRES"" />
      <xs:enumeration value=""PRID"" />
      <xs:enumeration value=""PWR"" />
      <xs:enumeration value=""RANGE"" />
      <xs:enumeration value=""RATIO"" />
      <xs:enumeration value=""RCRLTM"" />
      <xs:enumeration value=""RDEN"" />
      <xs:enumeration value=""REL"" />
      <xs:enumeration value=""RLMCNC"" />
      <xs:enumeration value=""RLSCNC"" />
      <xs:enumeration value=""RLTM"" />
      <xs:enumeration value=""SATFR"" />
      <xs:enumeration value=""SCNC"" />
      <xs:enumeration value=""SCNCIN"" />
      <xs:enumeration value=""SCNT"" />
      <xs:enumeration value=""SCNTR"" />
      <xs:enumeration value=""SCRTO"" />
      <xs:enumeration value=""SFR"" />
      <xs:enumeration value=""SHAPE"" />
      <xs:enumeration value=""SMELL"" />
      <xs:enumeration value=""SRAT"" />
      <xs:enumeration value=""SRTO"" />
      <xs:enumeration value=""SUB"" />
      <xs:enumeration value=""SUSC"" />
      <xs:enumeration value=""TASTE"" />
      <xs:enumeration value=""TEMP"" />
      <xs:enumeration value=""TEMPDF"" />
      <xs:enumeration value=""TEMPIN"" />
      <xs:enumeration value=""THRMCNC"" />
      <xs:enumeration value=""THRSCNC"" />
      <xs:enumeration value=""TIME"" />
      <xs:enumeration value=""TITR"" />
      <xs:enumeration value=""TMDF"" />
      <xs:enumeration value=""TMSTP"" />
      <xs:enumeration value=""TRTO"" />
      <xs:enumeration value=""TYPE"" />
      <xs:enumeration value=""VCNT"" />
      <xs:enumeration value=""VEL"" />
      <xs:enumeration value=""VELRT"" />
      <xs:enumeration value=""VFR"" />
      <xs:enumeration value=""VISC"" />
      <xs:enumeration value=""VOL"" />
      <xs:enumeration value=""VRAT"" />
      <xs:enumeration value=""VRTO"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table255"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""*"" />
      <xs:enumeration value=""12H"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1W"" />
      <xs:enumeration value=""2.5H"" />
      <xs:enumeration value=""24H"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""30M"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3L"" />
      <xs:enumeration value=""3W"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4W"" />
      <xs:enumeration value=""5D"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""6D"" />
      <xs:enumeration value=""6H"" />
      <xs:enumeration value=""7H"" />
      <xs:enumeration value=""8H"" />
      <xs:enumeration value=""PT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table256"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""10D"" />
      <xs:enumeration value=""10M"" />
      <xs:enumeration value=""12H"" />
      <xs:enumeration value=""15M"" />
      <xs:enumeration value=""1H"" />
      <xs:enumeration value=""1L"" />
      <xs:enumeration value=""1M"" />
      <xs:enumeration value=""1W"" />
      <xs:enumeration value=""2.5H"" />
      <xs:enumeration value=""20M"" />
      <xs:enumeration value=""24H"" />
      <xs:enumeration value=""25M"" />
      <xs:enumeration value=""2D"" />
      <xs:enumeration value=""2H"" />
      <xs:enumeration value=""2L"" />
      <xs:enumeration value=""2M"" />
      <xs:enumeration value=""2W"" />
      <xs:enumeration value=""30M"" />
      <xs:enumeration value=""3D"" />
      <xs:enumeration value=""3H"" />
      <xs:enumeration value=""3L"" />
      <xs:enumeration value=""3M"" />
      <xs:enumeration value=""3W"" />
      <xs:enumeration value=""4D"" />
      <xs:enumeration value=""4H"" />
      <xs:enumeration value=""4M"" />
      <xs:enumeration value=""4W"" />
      <xs:enumeration value=""5D"" />
      <xs:enumeration value=""5H"" />
      <xs:enumeration value=""5M"" />
      <xs:enumeration value=""6D"" />
      <xs:enumeration value=""6H"" />
      <xs:enumeration value=""6M"" />
      <xs:enumeration value=""7D"" />
      <xs:enumeration value=""7H"" />
      <xs:enumeration value=""7M"" />
      <xs:enumeration value=""8H"" />
      <xs:enumeration value=""8H SHIFT"" />
      <xs:enumeration value=""8M"" />
      <xs:enumeration value=""9M"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""PEAK"" />
      <xs:enumeration value=""RANDOM"" />
      <xs:enumeration value=""TROUGH"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table257"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CFST"" />
      <xs:enumeration value=""EXCZ"" />
      <xs:enumeration value=""FFST"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table258"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BPU"" />
      <xs:enumeration value=""CONTROL"" />
      <xs:enumeration value=""DONOR"" />
      <xs:enumeration value=""PATIENT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table259"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""DD"" />
      <xs:enumeration value=""DG"" />
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""FA"" />
      <xs:enumeration value=""FS"" />
      <xs:enumeration value=""LP"" />
      <xs:enumeration value=""LS"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""RF"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TG"" />
      <xs:enumeration value=""US"" />
      <xs:enumeration value=""XA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table260"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table261"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""EEG"" />
      <xs:enumeration value=""EKG"" />
      <xs:enumeration value=""INF"" />
      <xs:enumeration value=""IVP"" />
      <xs:enumeration value=""OXY"" />
      <xs:enumeration value=""SUC"" />
      <xs:enumeration value=""VEN"" />
      <xs:enumeration value=""VIT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table262"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table263"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table264"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table265"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ALC"" />
      <xs:enumeration value=""AMB"" />
      <xs:enumeration value=""CAN"" />
      <xs:enumeration value=""CAR"" />
      <xs:enumeration value=""CCR"" />
      <xs:enumeration value=""CHI"" />
      <xs:enumeration value=""EDI"" />
      <xs:enumeration value=""EMR"" />
      <xs:enumeration value=""FPC"" />
      <xs:enumeration value=""INT"" />
      <xs:enumeration value=""ISO"" />
      <xs:enumeration value=""NAT"" />
      <xs:enumeration value=""NBI"" />
      <xs:enumeration value=""OBG"" />
      <xs:enumeration value=""OBS"" />
      <xs:enumeration value=""OTH"" />
      <xs:enumeration value=""PED"" />
      <xs:enumeration value=""PHY"" />
      <xs:enumeration value=""PIN"" />
      <xs:enumeration value=""PPS"" />
      <xs:enumeration value=""PRE"" />
      <xs:enumeration value=""PSI"" />
      <xs:enumeration value=""PSY"" />
      <xs:enumeration value=""REH"" />
      <xs:enumeration value=""SUR"" />
      <xs:enumeration value=""WIC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table267"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""FRI"" />
      <xs:enumeration value=""MON"" />
      <xs:enumeration value=""SAT"" />
      <xs:enumeration value=""SUN"" />
      <xs:enumeration value=""THU"" />
      <xs:enumeration value=""TUE"" />
      <xs:enumeration value=""WED"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table268"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table269"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table270"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""HP"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""SP"" />
      <xs:enumeration value=""TS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table271"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""LA"" />
      <xs:enumeration value=""PA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table272"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table273"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""CA"" />
      <xs:enumeration value=""OB"" />
      <xs:enumeration value=""UN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table275"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""PU"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table276"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CHECKUP"" />
      <xs:enumeration value=""EMERGENCY"" />
      <xs:enumeration value=""FOLLOWUP"" />
      <xs:enumeration value=""ROUTINE"" />
      <xs:enumeration value=""WALKIN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table277"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Complete"" />
      <xs:enumeration value=""Normal"" />
      <xs:enumeration value=""Tentative"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table278"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Blocked"" />
      <xs:enumeration value=""Booked"" />
      <xs:enumeration value=""Cancelled"" />
      <xs:enumeration value=""Complete"" />
      <xs:enumeration value=""Dc"" />
      <xs:enumeration value=""Deleted"" />
      <xs:enumeration value=""Noshow"" />
      <xs:enumeration value=""Overbook"" />
      <xs:enumeration value=""Pending"" />
      <xs:enumeration value=""Started"" />
      <xs:enumeration value=""Waitlist"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table279"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Confirm"" />
      <xs:enumeration value=""No"" />
      <xs:enumeration value=""Notify"" />
      <xs:enumeration value=""Yes"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table280"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table281"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Hom"" />
      <xs:enumeration value=""Lab"" />
      <xs:enumeration value=""Med"" />
      <xs:enumeration value=""Psy"" />
      <xs:enumeration value=""Rad"" />
      <xs:enumeration value=""Skn"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table282"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AM"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""SO"" />
      <xs:enumeration value=""WR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table283"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table284"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""O"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table285"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table286"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table287"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""DE"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UN"" />
      <xs:enumeration value=""UP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table288"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table289"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table291"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BASIC"" />
      <xs:enumeration value=""DICOM"" />
      <xs:enumeration value=""FAX"" />
      <xs:enumeration value=""GIF"" />
      <xs:enumeration value=""HTML"" />
      <xs:enumeration value=""JOT"" />
      <xs:enumeration value=""JPEG"" />
      <xs:enumeration value=""Octet-stream"" />
      <xs:enumeration value=""PICT"" />
      <xs:enumeration value=""PostScript"" />
      <xs:enumeration value=""RTF"" />
      <xs:enumeration value=""SGML"" />
      <xs:enumeration value=""TIFF"" />
      <xs:enumeration value=""x-hl7-cda-level-one"" />
      <xs:enumeration value=""XML"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table292"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35"" />
      <xs:enumeration value=""36"" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38"" />
      <xs:enumeration value=""39"" />
      <xs:enumeration value=""40"" />
      <xs:enumeration value=""41"" />
      <xs:enumeration value=""42"" />
      <xs:enumeration value=""43"" />
      <xs:enumeration value=""44"" />
      <xs:enumeration value=""45"" />
      <xs:enumeration value=""46"" />
      <xs:enumeration value=""47"" />
      <xs:enumeration value=""48"" />
      <xs:enumeration value=""49"" />
      <xs:enumeration value=""50"" />
      <xs:enumeration value=""51"" />
      <xs:enumeration value=""52"" />
      <xs:enumeration value=""53"" />
      <xs:enumeration value=""54"" />
      <xs:enumeration value=""55"" />
      <xs:enumeration value=""56"" />
      <xs:enumeration value=""57"" />
      <xs:enumeration value=""58"" />
      <xs:enumeration value=""59"" />
      <xs:enumeration value=""60"" />
      <xs:enumeration value=""61"" />
      <xs:enumeration value=""62"" />
      <xs:enumeration value=""63"" />
      <xs:enumeration value=""64"" />
      <xs:enumeration value=""65"" />
      <xs:enumeration value=""66"" />
      <xs:enumeration value=""67"" />
      <xs:enumeration value=""68"" />
      <xs:enumeration value=""69"" />
      <xs:enumeration value=""70"" />
      <xs:enumeration value=""71"" />
      <xs:enumeration value=""72"" />
      <xs:enumeration value=""73"" />
      <xs:enumeration value=""74"" />
      <xs:enumeration value=""75"" />
      <xs:enumeration value=""76"" />
      <xs:enumeration value=""77"" />
      <xs:enumeration value=""78"" />
      <xs:enumeration value=""79"" />
      <xs:enumeration value=""80"" />
      <xs:enumeration value=""81"" />
      <xs:enumeration value=""82"" />
      <xs:enumeration value=""83"" />
      <xs:enumeration value=""84"" />
      <xs:enumeration value=""85"" />
      <xs:enumeration value=""86"" />
      <xs:enumeration value=""87"" />
      <xs:enumeration value=""88"" />
      <xs:enumeration value=""89"" />
      <xs:enumeration value=""90"" />
      <xs:enumeration value=""91"" />
      <xs:enumeration value=""92"" />
      <xs:enumeration value=""93"" />
      <xs:enumeration value=""94"" />
      <xs:enumeration value=""95"" />
      <xs:enumeration value=""96"" />
      <xs:enumeration value=""97"" />
      <xs:enumeration value=""98"" />
      <xs:enumeration value=""99"" />
      <xs:enumeration value=""998"" />
      <xs:enumeration value=""999"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table293"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table294"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Fri"" />
      <xs:enumeration value=""Mon"" />
      <xs:enumeration value=""Prefend"" />
      <xs:enumeration value=""Prefstart"" />
      <xs:enumeration value=""Sat"" />
      <xs:enumeration value=""Sun"" />
      <xs:enumeration value=""Thu"" />
      <xs:enumeration value=""Tue"" />
      <xs:enumeration value=""Wed"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table295"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table296"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table297"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table298"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table299"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""Base64"" />
      <xs:enumeration value=""Hex"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table300"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table301"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DNS"" />
      <xs:enumeration value=""GUID"" />
      <xs:enumeration value=""HCD"" />
      <xs:enumeration value=""HL7"" />
      <xs:enumeration value=""ISO"" />
      <xs:enumeration value=""L,M,N"" />
      <xs:enumeration value=""Random"" />
      <xs:enumeration value=""URI"" />
      <xs:enumeration value=""UUID"" />
      <xs:enumeration value=""x400"" />
      <xs:enumeration value=""x500"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table302"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table303"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table304"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table305"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table306"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table307"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table308"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table309"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table311"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table312"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table313"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table315"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table316"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table317"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""9900"" />
      <xs:enumeration value=""9901"" />
      <xs:enumeration value=""9902"" />
      <xs:enumeration value=""9903"" />
      <xs:enumeration value=""9904"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table319"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table320"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table321"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""UD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table322"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""RE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table323"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table324"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""GEN"" />
      <xs:enumeration value=""IMP"" />
      <xs:enumeration value=""INF"" />
      <xs:enumeration value=""LCR"" />
      <xs:enumeration value=""LIC"" />
      <xs:enumeration value=""OVR"" />
      <xs:enumeration value=""PRL"" />
      <xs:enumeration value=""SET"" />
      <xs:enumeration value=""SHA"" />
      <xs:enumeration value=""SMK"" />
      <xs:enumeration value=""STF"" />
      <xs:enumeration value=""TEA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table325"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ALI"" />
      <xs:enumeration value=""DTY"" />
      <xs:enumeration value=""LAB"" />
      <xs:enumeration value=""LB2"" />
      <xs:enumeration value=""PAR"" />
      <xs:enumeration value=""RX"" />
      <xs:enumeration value=""RX2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table326"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""V"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table327"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table328"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table329"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""E"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table330"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""510E"" />
      <xs:enumeration value=""510K"" />
      <xs:enumeration value=""522S"" />
      <xs:enumeration value=""PMA"" />
      <xs:enumeration value=""PRE"" />
      <xs:enumeration value=""TXN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table331"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table332"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table333"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table334"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AP"" />
      <xs:enumeration value=""GT"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""PT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table335"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""BID"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""Meal Related Timings"" />
      <xs:enumeration value=""Once"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""PRN"" />
      <xs:enumeration value=""PRNxxx"" />
      <xs:enumeration value=""Q&lt;integer&gt;D"" />
      <xs:enumeration value=""Q&lt;integer&gt;H"" />
      <xs:enumeration value=""Q&lt;integer&gt;J&lt;day#&gt;"" />
      <xs:enumeration value=""Q&lt;integer&gt;L"" />
      <xs:enumeration value=""Q&lt;integer&gt;M"" />
      <xs:enumeration value=""Q&lt;integer&gt;S"" />
      <xs:enumeration value=""Q&lt;integer&gt;W"" />
      <xs:enumeration value=""QAM"" />
      <xs:enumeration value=""QHS"" />
      <xs:enumeration value=""QID"" />
      <xs:enumeration value=""QOD"" />
      <xs:enumeration value=""QPM"" />
      <xs:enumeration value=""QSHIFT"" />
      <xs:enumeration value=""TID"" />
      <xs:enumeration value=""U &lt;spec&gt;"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""xID"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table336"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table337"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table338"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CY"" />
      <xs:enumeration value=""DEA"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""L&amp;I"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MCR"" />
      <xs:enumeration value=""QA"" />
      <xs:enumeration value=""SL"" />
      <xs:enumeration value=""TAX"" />
      <xs:enumeration value=""TRL"" />
      <xs:enumeration value=""UPIN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table339"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table340"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table341"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table342"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table343"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table344"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
      <xs:enumeration value=""06"" />
      <xs:enumeration value=""07"" />
      <xs:enumeration value=""08"" />
      <xs:enumeration value=""09"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table345"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table346"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table347"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""MI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table348"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table349"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table350"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table351"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table353"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NASK"" />
      <xs:enumeration value=""NAV"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""UASK"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table354"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACK"" />
      <xs:enumeration value=""ADR_A19"" />
      <xs:enumeration value=""ADT_A01"" />
      <xs:enumeration value=""ADT_A02"" />
      <xs:enumeration value=""ADT_A03"" />
      <xs:enumeration value=""ADT_A05"" />
      <xs:enumeration value=""ADT_A06"" />
      <xs:enumeration value=""ADT_A09"" />
      <xs:enumeration value=""ADT_A15"" />
      <xs:enumeration value=""ADT_A16"" />
      <xs:enumeration value=""ADT_A17"" />
      <xs:enumeration value=""ADT_A18"" />
      <xs:enumeration value=""ADT_A20"" />
      <xs:enumeration value=""ADT_A21"" />
      <xs:enumeration value=""ADT_A24"" />
      <xs:enumeration value=""ADT_A30"" />
      <xs:enumeration value=""ADT_A37"" />
      <xs:enumeration value=""ADT_A38"" />
      <xs:enumeration value=""ADT_A39"" />
      <xs:enumeration value=""ADT_A43"" />
      <xs:enumeration value=""ADT_A45"" />
      <xs:enumeration value=""ADT_A50"" />
      <xs:enumeration value=""ADT_A52"" />
      <xs:enumeration value=""ADT_A54"" />
      <xs:enumeration value=""ADT_A60"" />
      <xs:enumeration value=""ADT_A61"" />
      <xs:enumeration value=""BAR_P01"" />
      <xs:enumeration value=""BAR_P02"" />
      <xs:enumeration value=""BAR_P05"" />
      <xs:enumeration value=""BAR_P06"" />
      <xs:enumeration value=""BAR_P10"" />
      <xs:enumeration value=""BAR_P12"" />
      <xs:enumeration value=""BPS_O29"" />
      <xs:enumeration value=""BRP_030"" />
      <xs:enumeration value=""BRT_O32"" />
      <xs:enumeration value=""BTS_O31"" />
      <xs:enumeration value=""CRM_C01"" />
      <xs:enumeration value=""CSU_C09"" />
      <xs:enumeration value=""DFT_P03"" />
      <xs:enumeration value=""DFT_P11"" />
      <xs:enumeration value=""DOC_T12"" />
      <xs:enumeration value=""DSR_P04"" />
      <xs:enumeration value=""DSR_Q01"" />
      <xs:enumeration value=""DSR_Q03"" />
      <xs:enumeration value=""EAC_U07"" />
      <xs:enumeration value=""EAN_U09"" />
      <xs:enumeration value=""EAR_U08"" />
      <xs:enumeration value=""EDR_R07"" />
      <xs:enumeration value=""EQQ_Q04"" />
      <xs:enumeration value=""ERP_R09"" />
      <xs:enumeration value=""ESR_U02"" />
      <xs:enumeration value=""ESU_U01"" />
      <xs:enumeration value=""INR_U06"" />
      <xs:enumeration value=""INU_U05"" />
      <xs:enumeration value=""LSU_U12"" />
      <xs:enumeration value=""MDM_T01"" />
      <xs:enumeration value=""MDM_T02"" />
      <xs:enumeration value=""MFD_MFA"" />
      <xs:enumeration value=""MFK_M01"" />
      <xs:enumeration value=""MFN_M01"" />
      <xs:enumeration value=""MFN_M02"" />
      <xs:enumeration value=""MFN_M03"" />
      <xs:enumeration value=""MFN_M04"" />
      <xs:enumeration value=""MFN_M05"" />
      <xs:enumeration value=""MFN_M06"" />
      <xs:enumeration value=""MFN_M07"" />
      <xs:enumeration value=""MFN_M08"" />
      <xs:enumeration value=""MFN_M09"" />
      <xs:enumeration value=""MFN_M10"" />
      <xs:enumeration value=""MFN_M11"" />
      <xs:enumeration value=""MFN_M12"" />
      <xs:enumeration value=""MFN_M13"" />
      <xs:enumeration value=""MFN_M15"" />
      <xs:enumeration value=""MFQ_M01"" />
      <xs:enumeration value=""MFR_M01"" />
      <xs:enumeration value=""NMD_N02"" />
      <xs:enumeration value=""NMQ_N01"" />
      <xs:enumeration value=""NMR_N01"" />
      <xs:enumeration value=""OMB_O27"" />
      <xs:enumeration value=""OMD_O03"" />
      <xs:enumeration value=""OMG_O19"" />
      <xs:enumeration value=""OMI_O23"" />
      <xs:enumeration value=""OML_O21"" />
      <xs:enumeration value=""OML_O33"" />
      <xs:enumeration value=""OML_O35"" />
      <xs:enumeration value=""OMN_O07"" />
      <xs:enumeration value=""OMP_O09"" />
      <xs:enumeration value=""OMS_O05"" />
      <xs:enumeration value=""ORB_O28"" />
      <xs:enumeration value=""ORD_O04"" />
      <xs:enumeration value=""ORF_R04"" />
      <xs:enumeration value=""ORG_O20"" />
      <xs:enumeration value=""ORI_O24"" />
      <xs:enumeration value=""ORL_O22"" />
      <xs:enumeration value=""ORL_O34"" />
      <xs:enumeration value=""ORL_O36"" />
      <xs:enumeration value=""ORM_O01"" />
      <xs:enumeration value=""ORN_O08"" />
      <xs:enumeration value=""ORP_O10"" />
      <xs:enumeration value=""ORR_O02"" />
      <xs:enumeration value=""ORS_O06"" />
      <xs:enumeration value=""ORU_R01"" />
      <xs:enumeration value=""ORU_R30"" />
      <xs:enumeration value=""ORU_R31"" />
      <xs:enumeration value=""ORU_R32"" />
      <xs:enumeration value=""ORU_W01"" />
      <xs:enumeration value=""OSQ_Q06"" />
      <xs:enumeration value=""OSR_Q06"" />
      <xs:enumeration value=""OUL_R21"" />
      <xs:enumeration value=""OUL_R22"" />
      <xs:enumeration value=""OUL_R23"" />
      <xs:enumeration value=""OUL_R24"" />
      <xs:enumeration value=""PEX_P07"" />
      <xs:enumeration value=""PGL_PC6"" />
      <xs:enumeration value=""PMU_B01"" />
      <xs:enumeration value=""PMU_B03"" />
      <xs:enumeration value=""PMU_B04"" />
      <xs:enumeration value=""PMU_B07"" />
      <xs:enumeration value=""PMU_B08"" />
      <xs:enumeration value=""PPG_PCG"" />
      <xs:enumeration value=""PPP_PCB"" />
      <xs:enumeration value=""PPR_PC1"" />
      <xs:enumeration value=""PPT_PCL"" />
      <xs:enumeration value=""PPV_PCA"" />
      <xs:enumeration value=""PRR_PC5"" />
      <xs:enumeration value=""PTR_PCF"" />
      <xs:enumeration value=""QBP_Q11"" />
      <xs:enumeration value=""QBP_Q13"" />
      <xs:enumeration value=""QBP_Q15"" />
      <xs:enumeration value=""QBP_Q21"" />
      <xs:enumeration value=""QCK_Q02"" />
      <xs:enumeration value=""QCN_J01"" />
      <xs:enumeration value=""QRF_W02"" />
      <xs:enumeration value=""QRY_A19"" />
      <xs:enumeration value=""QRY_P04"" />
      <xs:enumeration value=""QRY_PC4"" />
      <xs:enumeration value=""QRY_Q01"" />
      <xs:enumeration value=""QRY_Q02"" />
      <xs:enumeration value=""QRY_R02"" />
      <xs:enumeration value=""QRY_T12"" />
      <xs:enumeration value=""QSB_Q16"" />
      <xs:enumeration value=""QVR_Q17"" />
      <xs:enumeration value=""RAR_RAR"" />
      <xs:enumeration value=""RAS_O17"" />
      <xs:enumeration value=""RCI_I05"" />
      <xs:enumeration value=""RCL_I06"" />
      <xs:enumeration value=""RDE_O01"" />
      <xs:enumeration value=""RDE_O11"" />
      <xs:enumeration value=""RDR_RDR"" />
      <xs:enumeration value=""RDS_O13"" />
      <xs:enumeration value=""RDY_K15"" />
      <xs:enumeration value=""REF_I12"" />
      <xs:enumeration value=""RER_RER"" />
      <xs:enumeration value=""RGR_RGR"" />
      <xs:enumeration value=""RGV_O15"" />
      <xs:enumeration value=""ROR_ROR"" />
      <xs:enumeration value=""RPA_I08"" />
      <xs:enumeration value=""RPI_I01"" />
      <xs:enumeration value=""RPL_I02"" />
      <xs:enumeration value=""RPR_I03"" />
      <xs:enumeration value=""RQA_I08"" />
      <xs:enumeration value=""RQC_I05"" />
      <xs:enumeration value=""RQI_I01"" />
      <xs:enumeration value=""RQP_I04"" />
      <xs:enumeration value=""RQQ_Q09"" />
      <xs:enumeration value=""RRA_O02"" />
      <xs:enumeration value=""RRA_O18"" />
      <xs:enumeration value=""RRD_O14"" />
      <xs:enumeration value=""RRE_O12"" />
      <xs:enumeration value=""RRG_O16"" />
      <xs:enumeration value=""RRI_I12"" />
      <xs:enumeration value=""RSP_K11"" />
      <xs:enumeration value=""RSP_K21"" />
      <xs:enumeration value=""RSP_K22"" />
      <xs:enumeration value=""RSP_K23"" />
      <xs:enumeration value=""RTB_K13"" />
      <xs:enumeration value=""SIU_S12"" />
      <xs:enumeration value=""SPQ_Q08"" />
      <xs:enumeration value=""SQM_S25"" />
      <xs:enumeration value=""SQR_S25"" />
      <xs:enumeration value=""SRM_S01"" />
      <xs:enumeration value=""SRR_S01"" />
      <xs:enumeration value=""SSR_U04"" />
      <xs:enumeration value=""SSU_U03"" />
      <xs:enumeration value=""SUR_P09"" />
      <xs:enumeration value=""TBR_R08"" />
      <xs:enumeration value=""TBR_R09"" />
      <xs:enumeration value=""TCU_U10"" />
      <xs:enumeration value=""UDM_Q05"" />
      <xs:enumeration value=""VQQ_Q07"" />
      <xs:enumeration value=""VXQ_V01"" />
      <xs:enumeration value=""VXR_V03"" />
      <xs:enumeration value=""VXU_V04"" />
      <xs:enumeration value=""VXX_V02"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table355"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""PL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table356"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""&lt;null&gt;"" />
      <xs:enumeration value=""2.3"" />
      <xs:enumeration value=""ISO 2022-1994"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table357"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""200"" />
      <xs:enumeration value=""201"" />
      <xs:enumeration value=""202"" />
      <xs:enumeration value=""203"" />
      <xs:enumeration value=""204"" />
      <xs:enumeration value=""205"" />
      <xs:enumeration value=""206"" />
      <xs:enumeration value=""207"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table358"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table359"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2 _"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table360"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AA"" />
      <xs:enumeration value=""AAS"" />
      <xs:enumeration value=""ABA"" />
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""AS"" />
      <xs:enumeration value=""BA"" />
      <xs:enumeration value=""BBA"" />
      <xs:enumeration value=""BE"" />
      <xs:enumeration value=""BFA"" />
      <xs:enumeration value=""BN"" />
      <xs:enumeration value=""BS"" />
      <xs:enumeration value=""BSL"" />
      <xs:enumeration value=""BSN"" />
      <xs:enumeration value=""BT"" />
      <xs:enumeration value=""CANP"" />
      <xs:enumeration value=""CER"" />
      <xs:enumeration value=""CMA"" />
      <xs:enumeration value=""CNM"" />
      <xs:enumeration value=""CNP"" />
      <xs:enumeration value=""CNS"" />
      <xs:enumeration value=""CPNP"" />
      <xs:enumeration value=""CRN"" />
      <xs:enumeration value=""DBA"" />
      <xs:enumeration value=""DED"" />
      <xs:enumeration value=""DIP"" />
      <xs:enumeration value=""DO"" />
      <xs:enumeration value=""EMT"" />
      <xs:enumeration value=""EMTP"" />
      <xs:enumeration value=""FPNP"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""JD"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MBA"" />
      <xs:enumeration value=""MCE"" />
      <xs:enumeration value=""MD"" />
      <xs:enumeration value=""MDA"" />
      <xs:enumeration value=""MDI"" />
      <xs:enumeration value=""ME"" />
      <xs:enumeration value=""MED"" />
      <xs:enumeration value=""MEE"" />
      <xs:enumeration value=""MFA"" />
      <xs:enumeration value=""MME"" />
      <xs:enumeration value=""MS"" />
      <xs:enumeration value=""MSL"" />
      <xs:enumeration value=""MSN"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""NG"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PharmD"" />
      <xs:enumeration value=""PHD"" />
      <xs:enumeration value=""PHE"" />
      <xs:enumeration value=""PHS"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""RMA"" />
      <xs:enumeration value=""RPH"" />
      <xs:enumeration value=""SEC"" />
      <xs:enumeration value=""TS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table361"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table362"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table363"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table364"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1R"" />
      <xs:enumeration value=""2R"" />
      <xs:enumeration value=""AI"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""GI"" />
      <xs:enumeration value=""GR"" />
      <xs:enumeration value=""PI"" />
      <xs:enumeration value=""RE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table365"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""OP"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PD"" />
      <xs:enumeration value=""PU"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table366"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table367"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table368"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AB"" />
      <xs:enumeration value=""CL"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""EN"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""IN"" />
      <xs:enumeration value=""LC"" />
      <xs:enumeration value=""LK"" />
      <xs:enumeration value=""LO"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""SA"" />
      <xs:enumeration value=""SU"" />
      <xs:enumeration value=""TT"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table369"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""V"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table370"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table371"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACDA"" />
      <xs:enumeration value=""ACDB"" />
      <xs:enumeration value=""ACET"" />
      <xs:enumeration value=""AMIES"" />
      <xs:enumeration value=""BACTM"" />
      <xs:enumeration value=""BF10"" />
      <xs:enumeration value=""BOR"" />
      <xs:enumeration value=""BOUIN"" />
      <xs:enumeration value=""BSKM"" />
      <xs:enumeration value=""C32"" />
      <xs:enumeration value=""C38"" />
      <xs:enumeration value=""CARS"" />
      <xs:enumeration value=""CARY"" />
      <xs:enumeration value=""CHLTM"" />
      <xs:enumeration value=""CTAD"" />
      <xs:enumeration value=""EDTK"" />
      <xs:enumeration value=""EDTK15"" />
      <xs:enumeration value=""EDTK75"" />
      <xs:enumeration value=""EDTN"" />
      <xs:enumeration value=""ENT"" />
      <xs:enumeration value=""ENT+"" />
      <xs:enumeration value=""F10"" />
      <xs:enumeration value=""FDP"" />
      <xs:enumeration value=""FL10"" />
      <xs:enumeration value=""FL100"" />
      <xs:enumeration value=""HCL6"" />
      <xs:enumeration value=""HEPA"" />
      <xs:enumeration value=""HEPL"" />
      <xs:enumeration value=""HEPN"" />
      <xs:enumeration value=""HNO3"" />
      <xs:enumeration value=""JKM"" />
      <xs:enumeration value=""KARN"" />
      <xs:enumeration value=""KOX"" />
      <xs:enumeration value=""LIA"" />
      <xs:enumeration value=""M4"" />
      <xs:enumeration value=""M4RT"" />
      <xs:enumeration value=""M5"" />
      <xs:enumeration value=""MICHTM"" />
      <xs:enumeration value=""MMDTM"" />
      <xs:enumeration value=""NAF"" />
      <xs:enumeration value=""NAPS"" />
      <xs:enumeration value=""NONE"" />
      <xs:enumeration value=""PAGE"" />
      <xs:enumeration value=""PHENOL"" />
      <xs:enumeration value=""PVA"" />
      <xs:enumeration value=""RLM"" />
      <xs:enumeration value=""SILICA"" />
      <xs:enumeration value=""SPS"" />
      <xs:enumeration value=""SST"" />
      <xs:enumeration value=""STUTM"" />
      <xs:enumeration value=""THROM"" />
      <xs:enumeration value=""THYMOL"" />
      <xs:enumeration value=""THYO"" />
      <xs:enumeration value=""TOLU"" />
      <xs:enumeration value=""URETM"" />
      <xs:enumeration value=""VIRTM"" />
      <xs:enumeration value=""WEST"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table372"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BLD"" />
      <xs:enumeration value=""BSEP"" />
      <xs:enumeration value=""PLAS"" />
      <xs:enumeration value=""PPP"" />
      <xs:enumeration value=""PRP"" />
      <xs:enumeration value=""SED"" />
      <xs:enumeration value=""SER"" />
      <xs:enumeration value=""SUP"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table373"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ACID"" />
      <xs:enumeration value=""ALK"" />
      <xs:enumeration value=""DEFB"" />
      <xs:enumeration value=""FILT"" />
      <xs:enumeration value=""LDLP"" />
      <xs:enumeration value=""NEUT"" />
      <xs:enumeration value=""RECA"" />
      <xs:enumeration value=""UFIL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table374"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CNTM"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table375"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""FLUR"" />
      <xs:enumeration value=""SFHB"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table376"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AMB"" />
      <xs:enumeration value=""C37"" />
      <xs:enumeration value=""CAMB"" />
      <xs:enumeration value=""CATM"" />
      <xs:enumeration value=""CFRZ"" />
      <xs:enumeration value=""CREF"" />
      <xs:enumeration value=""DFRZ"" />
      <xs:enumeration value=""DRY"" />
      <xs:enumeration value=""FRZ"" />
      <xs:enumeration value=""MTLF"" />
      <xs:enumeration value=""NTR"" />
      <xs:enumeration value=""PRTL"" />
      <xs:enumeration value=""PSA"" />
      <xs:enumeration value=""PSO"" />
      <xs:enumeration value=""REF"" />
      <xs:enumeration value=""UFRZ"" />
      <xs:enumeration value=""UPR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table377"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A60"" />
      <xs:enumeration value=""ATM"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table378"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table379"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table380"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table381"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table382"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table383"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CW"" />
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""EW"" />
      <xs:enumeration value=""NE"" />
      <xs:enumeration value=""NW"" />
      <xs:enumeration value=""OE"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""OW"" />
      <xs:enumeration value=""QE"" />
      <xs:enumeration value=""QW"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table384"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""LI"" />
      <xs:enumeration value=""LW"" />
      <xs:enumeration value=""MR"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PW"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""SC"" />
      <xs:enumeration value=""SR"" />
      <xs:enumeration value=""SW"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table385"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table386"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table387"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ER"" />
      <xs:enumeration value=""OK"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TI"" />
      <xs:enumeration value=""UN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table388"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table389"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""R"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table391"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""OBRG"" />
      <xs:enumeration value=""ORCG"" />
      <xs:enumeration value=""PIDG"" />
      <xs:enumeration value=""RXAG"" />
      <xs:enumeration value=""RXDG"" />
      <xs:enumeration value=""RXEG"" />
      <xs:enumeration value=""RXOG"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table392"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DB"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""SS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table393"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""LINKSOFT_2.01"" />
      <xs:enumeration value=""MATCHWARE_1.2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table394"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table395"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""N"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table396"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""99zzz or L"" />
      <xs:enumeration value=""ACR"" />
      <xs:enumeration value=""ANS+"" />
      <xs:enumeration value=""ART"" />
      <xs:enumeration value=""AS4"" />
      <xs:enumeration value=""AS4E"" />
      <xs:enumeration value=""ATC"" />
      <xs:enumeration value=""C4"" />
      <xs:enumeration value=""C5"" />
      <xs:enumeration value=""CAS"" />
      <xs:enumeration value=""CD2"" />
      <xs:enumeration value=""CDCA"" />
      <xs:enumeration value=""CDCM"" />
      <xs:enumeration value=""CDS"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CLP"" />
      <xs:enumeration value=""CPTM"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""CVX"" />
      <xs:enumeration value=""DCM"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""E5"" />
      <xs:enumeration value=""E6"" />
      <xs:enumeration value=""E7"" />
      <xs:enumeration value=""ENZC"" />
      <xs:enumeration value=""FDDC"" />
      <xs:enumeration value=""FDDX"" />
      <xs:enumeration value=""FDK"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HCPCS"" />
      <xs:enumeration value=""HCPT"" />
      <xs:enumeration value=""HHC"" />
      <xs:enumeration value=""HI"" />
      <xs:enumeration value=""HL7nnnn"" />
      <xs:enumeration value=""HOT"" />
      <xs:enumeration value=""HPC"" />
      <xs:enumeration value=""I10"" />
      <xs:enumeration value=""I10P"" />
      <xs:enumeration value=""I9"" />
      <xs:enumeration value=""I9C"" />
      <xs:enumeration value=""IBT"" />
      <xs:enumeration value=""IBTnnnn"" />
      <xs:enumeration value=""IC2"" />
      <xs:enumeration value=""ICD10AM"" />
      <xs:enumeration value=""ICD10CA"" />
      <xs:enumeration value=""ICDO"" />
      <xs:enumeration value=""ICS"" />
      <xs:enumeration value=""ICSD"" />
      <xs:enumeration value=""ISO+"" />
      <xs:enumeration value=""ISOnnnn"" />
      <xs:enumeration value=""IUPC"" />
      <xs:enumeration value=""IUPP"" />
      <xs:enumeration value=""JC10"" />
      <xs:enumeration value=""JC8"" />
      <xs:enumeration value=""JJ1017"" />
      <xs:enumeration value=""LB"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""MCD"" />
      <xs:enumeration value=""MCR"" />
      <xs:enumeration value=""MDDX"" />
      <xs:enumeration value=""MEDC"" />
      <xs:enumeration value=""MEDR"" />
      <xs:enumeration value=""MEDX"" />
      <xs:enumeration value=""MGPI"" />
      <xs:enumeration value=""MVX"" />
      <xs:enumeration value=""NDA"" />
      <xs:enumeration value=""NDC"" />
      <xs:enumeration value=""NIC"" />
      <xs:enumeration value=""NPI"" />
      <xs:enumeration value=""NUBC"" />
      <xs:enumeration value=""OHA"" />
      <xs:enumeration value=""POS"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""SDM"" />
      <xs:enumeration value=""SNM"" />
      <xs:enumeration value=""SNM3"" />
      <xs:enumeration value=""SNT"" />
      <xs:enumeration value=""UC"" />
      <xs:enumeration value=""UMD"" />
      <xs:enumeration value=""UML"" />
      <xs:enumeration value=""UPC"" />
      <xs:enumeration value=""UPIN"" />
      <xs:enumeration value=""USPS"" />
      <xs:enumeration value=""W1"" />
      <xs:enumeration value=""W2"" />
      <xs:enumeration value=""W4"" />
      <xs:enumeration value=""WC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table397"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""AN"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""DN"" />
      <xs:enumeration value=""N"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table398"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""I"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table399"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table401"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""MM"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table402"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table403"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table404"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table405"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table406"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""O"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table409"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""SD"" />
      <xs:enumeration value=""SU"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table411"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table412"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table413"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table414"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table415"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""N"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table416"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table417"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""G"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table418"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2 _"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table421"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""MI"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""SE"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table422"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""99"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table423"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table424"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table425"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table426"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CRYO"" />
      <xs:enumeration value=""CRYOP"" />
      <xs:enumeration value=""FFP"" />
      <xs:enumeration value=""FFPTH"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PCA"" />
      <xs:enumeration value=""PCNEO"" />
      <xs:enumeration value=""PCW"" />
      <xs:enumeration value=""PLT"" />
      <xs:enumeration value=""PLTNEO"" />
      <xs:enumeration value=""PLTP"" />
      <xs:enumeration value=""PLTPH"" />
      <xs:enumeration value=""PLTPHLR"" />
      <xs:enumeration value=""RWB"" />
      <xs:enumeration value=""WBA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table427"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""J"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table428"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table429"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""BR"" />
      <xs:enumeration value=""DA"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DU"" />
      <xs:enumeration value=""LY"" />
      <xs:enumeration value=""MT"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""OT"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""SH"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table430"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table431"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""K"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table432"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""CH"" />
      <xs:enumeration value=""CO"" />
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""IM"" />
      <xs:enumeration value=""MO"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table433"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table434"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table435"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DNR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table436"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""CT"" />
      <xs:enumeration value=""IN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table437"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table438"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table440"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AUI"" />
      <xs:enumeration value=""CCD"" />
      <xs:enumeration value=""CCP"" />
      <xs:enumeration value=""CD"" />
      <xs:enumeration value=""CE"" />
      <xs:enumeration value=""CF"" />
      <xs:enumeration value=""CK"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CN"" />
      <xs:enumeration value=""CNE"" />
      <xs:enumeration value=""CNS"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""CQ"" />
      <xs:enumeration value=""CSU"" />
      <xs:enumeration value=""CWE"" />
      <xs:enumeration value=""CX"" />
      <xs:enumeration value=""DDI"" />
      <xs:enumeration value=""DIN"" />
      <xs:enumeration value=""DLD"" />
      <xs:enumeration value=""DLN"" />
      <xs:enumeration value=""DLT"" />
      <xs:enumeration value=""DR"" />
      <xs:enumeration value=""DT"" />
      <xs:enumeration value=""DTM"" />
      <xs:enumeration value=""DTN"" />
      <xs:enumeration value=""ED"" />
      <xs:enumeration value=""EI"" />
      <xs:enumeration value=""EIP"" />
      <xs:enumeration value=""ELD"" />
      <xs:enumeration value=""ERL"" />
      <xs:enumeration value=""FC"" />
      <xs:enumeration value=""FN"" />
      <xs:enumeration value=""FT"" />
      <xs:enumeration value=""GTS"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""ICD"" />
      <xs:enumeration value=""ID"" />
      <xs:enumeration value=""IS"" />
      <xs:enumeration value=""JCC"" />
      <xs:enumeration value=""LA1"" />
      <xs:enumeration value=""LA2"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""MO"" />
      <xs:enumeration value=""MOC"" />
      <xs:enumeration value=""MOP"" />
      <xs:enumeration value=""MSG"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NDL"" />
      <xs:enumeration value=""NM"" />
      <xs:enumeration value=""NR"" />
      <xs:enumeration value=""OCD"" />
      <xs:enumeration value=""OSD"" />
      <xs:enumeration value=""OSP"" />
      <xs:enumeration value=""PIP"" />
      <xs:enumeration value=""PL"" />
      <xs:enumeration value=""PLN"" />
      <xs:enumeration value=""PN"" />
      <xs:enumeration value=""PPN"" />
      <xs:enumeration value=""PRL"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""PTA"" />
      <xs:enumeration value=""QIP"" />
      <xs:enumeration value=""QSC"" />
      <xs:enumeration value=""RCD"" />
      <xs:enumeration value=""RFR"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RMC"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RPT"" />
      <xs:enumeration value=""SAD"" />
      <xs:enumeration value=""SCV"" />
      <xs:enumeration value=""SI"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""SPD"" />
      <xs:enumeration value=""SPS"" />
      <xs:enumeration value=""SRT"" />
      <xs:enumeration value=""ST"" />
      <xs:enumeration value=""TM"" />
      <xs:enumeration value=""TN"" />
      <xs:enumeration value=""TQ"" />
      <xs:enumeration value=""TS"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""UVC"" />
      <xs:enumeration value=""VH"" />
      <xs:enumeration value=""VID"" />
      <xs:enumeration value=""VR"" />
      <xs:enumeration value=""WVI"" />
      <xs:enumeration value=""WVS"" />
      <xs:enumeration value=""XAD"" />
      <xs:enumeration value=""XCN"" />
      <xs:enumeration value=""XON"" />
      <xs:enumeration value=""XPN"" />
      <xs:enumeration value=""XTN"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table441"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table442"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table443"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AD"" />
      <xs:enumeration value=""AT"" />
      <xs:enumeration value=""CP"" />
      <xs:enumeration value=""FHCP"" />
      <xs:enumeration value=""PP"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RT"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table444"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table445"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AL"" />
      <xs:enumeration value=""UA"" />
      <xs:enumeration value=""UD"" />
      <xs:enumeration value=""US"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table446"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table447"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table448"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table450"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""LOG"" />
      <xs:enumeration value=""SER"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table451"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ALL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table452"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""SUGGESTION"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table453"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""SUGGESTION"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table454"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""SUGGESTION"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table455"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table456"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table457"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table458"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""10"" />
      <xs:enumeration value=""11"" />
      <xs:enumeration value=""12"" />
      <xs:enumeration value=""13"" />
      <xs:enumeration value=""14"" />
      <xs:enumeration value=""15"" />
      <xs:enumeration value=""16"" />
      <xs:enumeration value=""17"" />
      <xs:enumeration value=""18"" />
      <xs:enumeration value=""19"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""20"" />
      <xs:enumeration value=""21"" />
      <xs:enumeration value=""22"" />
      <xs:enumeration value=""23"" />
      <xs:enumeration value=""24"" />
      <xs:enumeration value=""25"" />
      <xs:enumeration value=""26"" />
      <xs:enumeration value=""27"" />
      <xs:enumeration value=""28"" />
      <xs:enumeration value=""29"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""30"" />
      <xs:enumeration value=""31"" />
      <xs:enumeration value=""32"" />
      <xs:enumeration value=""33"" />
      <xs:enumeration value=""34"" />
      <xs:enumeration value=""35."" />
      <xs:enumeration value=""36."" />
      <xs:enumeration value=""37"" />
      <xs:enumeration value=""38."" />
      <xs:enumeration value=""39."" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""40."" />
      <xs:enumeration value=""41."" />
      <xs:enumeration value=""42."" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
      <xs:enumeration value=""8"" />
      <xs:enumeration value=""9"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table459"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table460"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table461"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table462"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table463"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table464"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table465"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table466"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""031"" />
      <xs:enumeration value=""163"" />
      <xs:enumeration value=""181"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table467"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""U"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table468"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table469"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""0"" />
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table470"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""Crnl"" />
      <xs:enumeration value=""DME"" />
      <xs:enumeration value=""EPO"" />
      <xs:enumeration value=""Lab"" />
      <xs:enumeration value=""Mamm"" />
      <xs:enumeration value=""NoPay"" />
      <xs:enumeration value=""OPPS"" />
      <xs:enumeration value=""PartH"" />
      <xs:enumeration value=""Pckg"" />
      <xs:enumeration value=""Thrpy"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table471"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table472"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table473"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table474"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""V"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table475"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""01"" />
      <xs:enumeration value=""02"" />
      <xs:enumeration value=""03"" />
      <xs:enumeration value=""04"" />
      <xs:enumeration value=""05"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table476"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table477"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""II"" />
      <xs:enumeration value=""III"" />
      <xs:enumeration value=""IV"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""VI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table478"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table479"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table480"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table482"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""O"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table483"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""EL"" />
      <xs:enumeration value=""EM"" />
      <xs:enumeration value=""FX"" />
      <xs:enumeration value=""IP"" />
      <xs:enumeration value=""MA"" />
      <xs:enumeration value=""PA"" />
      <xs:enumeration value=""PH"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""VC"" />
      <xs:enumeration value=""VO"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table484"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""Q"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""Z"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table485"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""PRN"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""TD&lt;integer&gt;"" />
      <xs:enumeration value=""TH&lt;integer&gt;"" />
      <xs:enumeration value=""TL&lt;integer&gt;"" />
      <xs:enumeration value=""TM&lt;integer&gt;"" />
      <xs:enumeration value=""TS&lt;integer&gt;"" />
      <xs:enumeration value=""TW&lt;integer&gt;"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table487"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table488"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ANP"" />
      <xs:enumeration value=""BAP"" />
      <xs:enumeration value=""BCAE"" />
      <xs:enumeration value=""BCAN"" />
      <xs:enumeration value=""BCPD"" />
      <xs:enumeration value=""BIO"" />
      <xs:enumeration value=""CAP"" />
      <xs:enumeration value=""CATH"" />
      <xs:enumeration value=""CVP"" />
      <xs:enumeration value=""EPLA"" />
      <xs:enumeration value=""ESWA"" />
      <xs:enumeration value=""FNA"" />
      <xs:enumeration value=""KOFFP"" />
      <xs:enumeration value=""LNA"" />
      <xs:enumeration value=""LNV"" />
      <xs:enumeration value=""MARTL"" />
      <xs:enumeration value=""ML11"" />
      <xs:enumeration value=""MLP"" />
      <xs:enumeration value=""NYP"" />
      <xs:enumeration value=""PACE"" />
      <xs:enumeration value=""PIN"" />
      <xs:enumeration value=""PNA"" />
      <xs:enumeration value=""PRIME"" />
      <xs:enumeration value=""PUMP"" />
      <xs:enumeration value=""QC5"" />
      <xs:enumeration value=""SCLP"" />
      <xs:enumeration value=""SCRAPS"" />
      <xs:enumeration value=""SHA"" />
      <xs:enumeration value=""SWA"" />
      <xs:enumeration value=""SWD"" />
      <xs:enumeration value=""TMAN"" />
      <xs:enumeration value=""TMCH"" />
      <xs:enumeration value=""TMM4"" />
      <xs:enumeration value=""TMMY"" />
      <xs:enumeration value=""TMOT"" />
      <xs:enumeration value=""TMP"" />
      <xs:enumeration value=""TMPV"" />
      <xs:enumeration value=""TMSC"" />
      <xs:enumeration value=""TMUP"" />
      <xs:enumeration value=""TMVI"" />
      <xs:enumeration value=""VENIP"" />
      <xs:enumeration value=""WOOD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table489"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AGG"" />
      <xs:enumeration value=""BHZ"" />
      <xs:enumeration value=""BIO"" />
      <xs:enumeration value=""COR"" />
      <xs:enumeration value=""ESC"" />
      <xs:enumeration value=""EXP"" />
      <xs:enumeration value=""IFL"" />
      <xs:enumeration value=""INF"" />
      <xs:enumeration value=""INJ"" />
      <xs:enumeration value=""POI"" />
      <xs:enumeration value=""RAD"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table490"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""EX"" />
      <xs:enumeration value=""QS"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RB"" />
      <xs:enumeration value=""RC"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RH"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RM"" />
      <xs:enumeration value=""RN"" />
      <xs:enumeration value=""RP"" />
      <xs:enumeration value=""RR"" />
      <xs:enumeration value=""RS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table491"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""G"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table492"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""??"" />
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table493"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AUT"" />
      <xs:enumeration value=""CLOT"" />
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""COOL"" />
      <xs:enumeration value=""FROZ"" />
      <xs:enumeration value=""HEM"" />
      <xs:enumeration value=""LIVE"" />
      <xs:enumeration value=""ROOM"" />
      <xs:enumeration value=""SNR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table494"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""M"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table495"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value="" UPP"" />
      <xs:enumeration value=""ANT"" />
      <xs:enumeration value=""BIL"" />
      <xs:enumeration value=""DIS"" />
      <xs:enumeration value=""EXT"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""LAT"" />
      <xs:enumeration value=""LLQ"" />
      <xs:enumeration value=""LOW"" />
      <xs:enumeration value=""LUQ"" />
      <xs:enumeration value=""MED"" />
      <xs:enumeration value=""POS"" />
      <xs:enumeration value=""PRO"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""RLQ"" />
      <xs:enumeration value=""RUQ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table496"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""001"" />
      <xs:enumeration value=""002"" />
      <xs:enumeration value=""003"" />
      <xs:enumeration value=""004"" />
      <xs:enumeration value=""005"" />
      <xs:enumeration value=""006"" />
      <xs:enumeration value=""007"" />
      <xs:enumeration value=""008"" />
      <xs:enumeration value=""009"" />
      <xs:enumeration value=""010"" />
      <xs:enumeration value=""011"" />
      <xs:enumeration value=""012"" />
      <xs:enumeration value=""013"" />
      <xs:enumeration value=""014"" />
      <xs:enumeration value=""015"" />
      <xs:enumeration value=""016"" />
      <xs:enumeration value=""017"" />
      <xs:enumeration value=""018"" />
      <xs:enumeration value=""019"" />
      <xs:enumeration value=""020"" />
      <xs:enumeration value=""021"" />
      <xs:enumeration value=""022"" />
      <xs:enumeration value=""023"" />
      <xs:enumeration value=""024"" />
      <xs:enumeration value=""025"" />
      <xs:enumeration value=""026"" />
      <xs:enumeration value=""027"" />
      <xs:enumeration value=""028"" />
      <xs:enumeration value=""029"" />
      <xs:enumeration value=""030"" />
      <xs:enumeration value=""031"" />
      <xs:enumeration value=""032"" />
      <xs:enumeration value=""033"" />
      <xs:enumeration value=""034"" />
      <xs:enumeration value=""035"" />
      <xs:enumeration value=""036"" />
      <xs:enumeration value=""037"" />
      <xs:enumeration value=""038"" />
      <xs:enumeration value=""039"" />
      <xs:enumeration value=""040"" />
      <xs:enumeration value=""041"" />
      <xs:enumeration value=""042"" />
      <xs:enumeration value=""043"" />
      <xs:enumeration value=""044"" />
      <xs:enumeration value=""045"" />
      <xs:enumeration value=""046"" />
      <xs:enumeration value=""047"" />
      <xs:enumeration value=""048"" />
      <xs:enumeration value=""049"" />
      <xs:enumeration value=""050"" />
      <xs:enumeration value=""051"" />
      <xs:enumeration value=""052"" />
      <xs:enumeration value=""053"" />
      <xs:enumeration value=""054"" />
      <xs:enumeration value=""055"" />
      <xs:enumeration value=""056"" />
      <xs:enumeration value=""057"" />
      <xs:enumeration value=""058"" />
      <xs:enumeration value=""059"" />
      <xs:enumeration value=""060"" />
      <xs:enumeration value=""061"" />
      <xs:enumeration value=""062"" />
      <xs:enumeration value=""063"" />
      <xs:enumeration value=""064"" />
      <xs:enumeration value=""065"" />
      <xs:enumeration value=""066"" />
      <xs:enumeration value=""067"" />
      <xs:enumeration value=""068"" />
      <xs:enumeration value=""069"" />
      <xs:enumeration value=""070"" />
      <xs:enumeration value=""071"" />
      <xs:enumeration value=""072"" />
      <xs:enumeration value=""073"" />
      <xs:enumeration value=""074"" />
      <xs:enumeration value=""075"" />
      <xs:enumeration value=""076"" />
      <xs:enumeration value=""077"" />
      <xs:enumeration value=""078"" />
      <xs:enumeration value=""079"" />
      <xs:enumeration value=""080"" />
      <xs:enumeration value=""081"" />
      <xs:enumeration value=""082"" />
      <xs:enumeration value=""083"" />
      <xs:enumeration value=""084"" />
      <xs:enumeration value=""085"" />
      <xs:enumeration value=""086"" />
      <xs:enumeration value=""087"" />
      <xs:enumeration value=""088"" />
      <xs:enumeration value=""089"" />
      <xs:enumeration value=""090"" />
      <xs:enumeration value=""091"" />
      <xs:enumeration value=""092"" />
      <xs:enumeration value=""093"" />
      <xs:enumeration value=""094"" />
      <xs:enumeration value=""095"" />
      <xs:enumeration value=""096"" />
      <xs:enumeration value=""097"" />
      <xs:enumeration value=""098"" />
      <xs:enumeration value=""099"" />
      <xs:enumeration value=""100"" />
      <xs:enumeration value=""101"" />
      <xs:enumeration value=""102"" />
      <xs:enumeration value=""103"" />
      <xs:enumeration value=""104"" />
      <xs:enumeration value=""105"" />
      <xs:enumeration value=""106"" />
      <xs:enumeration value=""107"" />
      <xs:enumeration value=""108"" />
      <xs:enumeration value=""109"" />
      <xs:enumeration value=""110"" />
      <xs:enumeration value=""111"" />
      <xs:enumeration value=""112"" />
      <xs:enumeration value=""113"" />
      <xs:enumeration value=""1137"" />
      <xs:enumeration value=""114"" />
      <xs:enumeration value=""115"" />
      <xs:enumeration value=""116"" />
      <xs:enumeration value=""117"" />
      <xs:enumeration value=""118"" />
      <xs:enumeration value=""119"" />
      <xs:enumeration value=""120"" />
      <xs:enumeration value=""121"" />
      <xs:enumeration value=""122"" />
      <xs:enumeration value=""123"" />
      <xs:enumeration value=""124"" />
      <xs:enumeration value=""125"" />
      <xs:enumeration value=""126"" />
      <xs:enumeration value=""127"" />
      <xs:enumeration value=""128"" />
      <xs:enumeration value=""129"" />
      <xs:enumeration value=""130"" />
      <xs:enumeration value=""131"" />
      <xs:enumeration value=""132"" />
      <xs:enumeration value=""133"" />
      <xs:enumeration value=""134"" />
      <xs:enumeration value=""135"" />
      <xs:enumeration value=""136"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table497"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""T"" />
      <xs:enumeration value=""V"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table498"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""A"" />
      <xs:enumeration value=""B"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""X"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table499"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""PJ"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table500"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""P"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table501"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""PR"" />
      <xs:enumeration value=""RX"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table502"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""LM"" />
      <xs:enumeration value=""MIN"" />
      <xs:enumeration value=""NC"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table503"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table504"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""EE"" />
      <xs:enumeration value=""ES"" />
      <xs:enumeration value=""SE"" />
      <xs:enumeration value=""SS"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table505"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""#"" />
      <xs:enumeration value=""*"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table506"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table507"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""N"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table508"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AU"" />
      <xs:enumeration value=""CM"" />
      <xs:enumeration value=""CS"" />
      <xs:enumeration value=""DI"" />
      <xs:enumeration value=""FR"" />
      <xs:enumeration value=""HB"" />
      <xs:enumeration value=""HL"" />
      <xs:enumeration value=""IG"" />
      <xs:enumeration value=""IR"" />
      <xs:enumeration value=""LR"" />
      <xs:enumeration value=""WA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table509"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table510"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CR"" />
      <xs:enumeration value=""DS"" />
      <xs:enumeration value=""PT"" />
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RD"" />
      <xs:enumeration value=""RE"" />
      <xs:enumeration value=""RI"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""RQ"" />
      <xs:enumeration value=""RS"" />
      <xs:enumeration value=""WA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table511"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""F"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table512"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table513"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""RA"" />
      <xs:enumeration value=""RL"" />
      <xs:enumeration value=""TR"" />
      <xs:enumeration value=""TX"" />
      <xs:enumeration value=""WA"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table514"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ABOINC"" />
      <xs:enumeration value=""ACUTHEHTR"" />
      <xs:enumeration value=""ALLERGIC1"" />
      <xs:enumeration value=""ALLERGIC2"" />
      <xs:enumeration value=""ALLERGICR"" />
      <xs:enumeration value=""ANAPHYLAC"" />
      <xs:enumeration value=""BACTCONTAM"" />
      <xs:enumeration value=""DELAYEDHTR"" />
      <xs:enumeration value=""DELAYEDSTR"" />
      <xs:enumeration value=""GVHD"" />
      <xs:enumeration value=""HYPOTENS"" />
      <xs:enumeration value=""NONHTR1"" />
      <xs:enumeration value=""NONHTR2"" />
      <xs:enumeration value=""NONHTRREC"" />
      <xs:enumeration value=""NONIMMUNE"" />
      <xs:enumeration value=""NONSPEC"" />
      <xs:enumeration value=""NORXN"" />
      <xs:enumeration value=""PTP"" />
      <xs:enumeration value=""VOLOVER"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table515"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table516"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""W"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table517"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""NPAT"" />
      <xs:enumeration value=""PAT"" />
      <xs:enumeration value=""USR"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table518"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""EQV"" />
      <xs:enumeration value=""EXTN"" />
      <xs:enumeration value=""INLV"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table519"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""_"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table521"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table523"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""%"" />
      <xs:enumeration value=""a"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table524"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table525"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table526"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table527"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""DM"" />
      <xs:enumeration value=""DW"" />
      <xs:enumeration value=""DY"" />
      <xs:enumeration value=""HD"" />
      <xs:enumeration value=""MY"" />
      <xs:enumeration value=""NH"" />
      <xs:enumeration value=""SN"" />
      <xs:enumeration value=""WY"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table528"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AC"" />
      <xs:enumeration value=""ACD"" />
      <xs:enumeration value=""ACM"" />
      <xs:enumeration value=""ACV"" />
      <xs:enumeration value=""HS"" />
      <xs:enumeration value=""IC"" />
      <xs:enumeration value=""ICD"" />
      <xs:enumeration value=""ICM"" />
      <xs:enumeration value=""ICV"" />
      <xs:enumeration value=""PC"" />
      <xs:enumeration value=""PCD"" />
      <xs:enumeration value=""PCM"" />
      <xs:enumeration value=""PCV"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table529"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""D"" />
      <xs:enumeration value=""H"" />
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""S"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table530"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""AE"" />
      <xs:enumeration value=""DEA"" />
      <xs:enumeration value=""DOD"" />
      <xs:enumeration value=""MC"" />
      <xs:enumeration value=""VA"" />
      <xs:enumeration value=""VI"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table531"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table532"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""ASKU"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""NA"" />
      <xs:enumeration value=""NASK"" />
      <xs:enumeration value=""NAV"" />
      <xs:enumeration value=""NI"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""UNK"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table533"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table534"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""O"" />
      <xs:enumeration value=""U"" />
      <xs:enumeration value=""Y"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table535"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""M"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table536"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""E"" />
      <xs:enumeration value=""I"" />
      <xs:enumeration value=""P"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""V"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table537"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""..."" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table538"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""CON"" />
      <xs:enumeration value=""CST"" />
      <xs:enumeration value=""EMP"" />
      <xs:enumeration value=""VOL"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table539"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table540"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""L"" />
      <xs:enumeration value=""R"" />
      <xs:enumeration value=""T"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table541"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table542"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table543"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table544"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table545"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table547"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""C"" />
      <xs:enumeration value=""N"" />
      <xs:enumeration value=""S"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table548"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value=""1"" />
      <xs:enumeration value=""2"" />
      <xs:enumeration value=""3"" />
      <xs:enumeration value=""4"" />
      <xs:enumeration value=""5"" />
      <xs:enumeration value=""6"" />
      <xs:enumeration value=""7"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table549"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table550"">
    <xs:restriction base=""xs:string"">
      <xs:enumeration value="" "" />
      <xs:enumeration value=""ACET"" />
      <xs:enumeration value=""ACHIL"" />
      <xs:enumeration value=""ADB"" />
      <xs:enumeration value=""ADE"" />
      <xs:enumeration value=""ADR"" />
      <xs:enumeration value=""AMN"" />
      <xs:enumeration value=""AMS"" />
      <xs:enumeration value=""ANAL"" />
      <xs:enumeration value=""ANKL"" />
      <xs:enumeration value=""ANTEC"" />
      <xs:enumeration value=""ANTECF"" />
      <xs:enumeration value=""ANTR"" />
      <xs:enumeration value=""ANUS"" />
      <xs:enumeration value=""AORTA"" />
      <xs:enumeration value=""APDX"" />
      <xs:enumeration value=""AR"" />
      <xs:enumeration value=""AREO"" />
      <xs:enumeration value=""ARM"" />
      <xs:enumeration value=""ARTE"" />
      <xs:enumeration value=""ASCIT"" />
      <xs:enumeration value=""ASCT"" />
      <xs:enumeration value=""ATR"" />
      <xs:enumeration value=""AURI"" />
      <xs:enumeration value=""AV"" />
      <xs:enumeration value=""AXI"" />
      <xs:enumeration value=""BACK"" />
      <xs:enumeration value=""BARTD"" />
      <xs:enumeration value=""BARTG"" />
      <xs:enumeration value=""BCYS"" />
      <xs:enumeration value=""BDY"" />
      <xs:enumeration value=""BID"" />
      <xs:enumeration value=""BIFL"" />
      <xs:enumeration value=""BLAD"" />
      <xs:enumeration value=""BLD"" />
      <xs:enumeration value=""BLDA"" />
      <xs:enumeration value=""BLDC"" />
      <xs:enumeration value=""BLDV"" />
      <xs:enumeration value=""BLOOD"" />
      <xs:enumeration value=""BMAR"" />
      <xs:enumeration value=""BON"" />
      <xs:enumeration value=""BOWEL"" />
      <xs:enumeration value=""BOWLA"" />
      <xs:enumeration value=""BOWSM"" />
      <xs:enumeration value=""BPH"" />
      <xs:enumeration value=""BRA"" />
      <xs:enumeration value=""BRAIN"" />
      <xs:enumeration value=""BRO"" />
      <xs:enumeration value=""BROCH"" />
      <xs:enumeration value=""BRONC"" />
      <xs:enumeration value=""BROW"" />
      <xs:enumeration value=""BRST"" />
      <xs:enumeration value=""BRSTFL"" />
      <xs:enumeration value=""BRTGF"" />
      <xs:enumeration value=""BRV"" />
      <xs:enumeration value=""BUCCA"" />
      <xs:enumeration value=""BURSA"" />
      <xs:enumeration value=""BURSF"" />
      <xs:enumeration value=""BUTT"" />
      <xs:enumeration value=""CALF"" />
      <xs:enumeration value=""CANAL"" />
      <xs:enumeration value=""CANLI"" />
      <xs:enumeration value=""CANTH"" />
      <xs:enumeration value=""CARO"" />
      <xs:enumeration value=""CARP"" />
      <xs:enumeration value=""CAVIT"" />
      <xs:enumeration value=""CBLD"" />
      <xs:enumeration value=""CDM"" />
      <xs:enumeration value=""CDUCT"" />
      <xs:enumeration value=""CECUM"" />
      <xs:enumeration value=""CERVUT"" />
      <xs:enumeration value=""CHE"" />
      <xs:enumeration value=""CHEEK"" />
      <xs:enumeration value=""CHES"" />
      <xs:enumeration value=""CHEST "" />
      <xs:enumeration value=""CHIN"" />
      <xs:enumeration value=""CIRCU"" />
      <xs:enumeration value=""CLAVI"" />
      <xs:enumeration value=""CLIT"" />
      <xs:enumeration value=""CLITO"" />
      <xs:enumeration value=""CNL"" />
      <xs:enumeration value=""COCCG"" />
      <xs:enumeration value=""COCCY"" />
      <xs:enumeration value=""COLON"" />
      <xs:enumeration value=""COLOS"" />
      <xs:enumeration value=""CONJ"" />
      <xs:enumeration value=""COR"" />
      <xs:enumeration value=""CORAL"" />
      <xs:enumeration value=""CORD"" />
      <xs:enumeration value=""CORN"" />
      <xs:enumeration value=""COS"" />
      <xs:enumeration value=""CRANE"" />
      <xs:enumeration value=""CRANF"" />
      <xs:enumeration value=""CRANO"" />
      <xs:enumeration value=""CRANP"" />
      <xs:enumeration value=""CRANS"" />
      <xs:enumeration value=""CRANT"" />
      <xs:enumeration value=""CSF"" />
      <xs:enumeration value=""CUBIT"" />
      <xs:enumeration value=""CUFF"" />
      <xs:enumeration value=""CULD"" />
      <xs:enumeration value=""CULDO"" />
      <xs:enumeration value=""CVX"" />
      <xs:enumeration value=""DELT"" />
      <xs:enumeration value=""DEN"" />
      <xs:enumeration value=""DENTA"" />
      <xs:enumeration value=""DIAF"" />
      <xs:enumeration value=""DIGIT"" />
      <xs:enumeration value=""DISC"" />
      <xs:enumeration value=""DORS"" />
      <xs:enumeration value=""DPH"" />
      <xs:enumeration value=""DUFL"" />
      <xs:enumeration value=""DUODE"" />
      <xs:enumeration value=""DUR"" />
      <xs:enumeration value=""EAR"" />
      <xs:enumeration value=""EARBI"" />
      <xs:enumeration value=""EARBM"" />
      <xs:enumeration value=""EARBS"" />
      <xs:enumeration value=""EARLO"" />
      <xs:enumeration value=""EC"" />
      <xs:enumeration value=""ELBOW"" />
      <xs:enumeration value=""ELBOWJ"" />
      <xs:enumeration value=""ENDC"" />
      <xs:enumeration value=""ENDM"" />
      <xs:enumeration value=""EOLPH"" />
      <xs:enumeration value=""EOS"" />
      <xs:enumeration value=""EPD"" />
      <xs:enumeration value=""EPICA"" />
      <xs:enumeration value=""EPICM"" />
      <xs:enumeration value=""EPIDU"" />
      <xs:enumeration value=""EPIGL"" />
      <xs:enumeration value=""ESO"" />
      <xs:enumeration value=""ESOPG"" />
      <xs:enumeration value=""ET"" />
      <xs:enumeration value=""ETHMO"" />
      <xs:enumeration value=""EUR"" />
      <xs:enumeration value=""EYE"" />
      <xs:enumeration value=""EYELI"" />
      <xs:enumeration value=""FACE"" />
      <xs:enumeration value=""FALLT"" />
      <xs:enumeration value=""FBINC"" />
      <xs:enumeration value=""FBLAC"" />
      <xs:enumeration value=""FBMAX"" />
      <xs:enumeration value=""FBNAS"" />
      <xs:enumeration value=""FBPAL"" />
      <xs:enumeration value=""FBVOM"" />
      <xs:enumeration value=""FBZYG"" />
      <xs:enumeration value=""FEMOR"" />
      <xs:enumeration value=""FEMUR"" />
      <xs:enumeration value=""FET"" />
      <xs:enumeration value=""FIBU"" />
      <xs:enumeration value=""FING"" />
      <xs:enumeration value=""FINGN"" />
      <xs:enumeration value=""FMH"" />
      <xs:enumeration value=""FOL"" />
      <xs:enumeration value=""FOOT"" />
      <xs:enumeration value=""FOREA"" />
      <xs:enumeration value=""FOREH"" />
      <xs:enumeration value=""FORES"" />
      <xs:enumeration value=""FOURC"" />
      <xs:enumeration value=""GB"" />
      <xs:enumeration value=""GEN"" />
      <xs:enumeration value=""GENC"" />
      <xs:enumeration value=""GENL"" />
      <xs:enumeration value=""GL"" />
      <xs:enumeration value=""GLAND"" />
      <xs:enumeration value=""GLANS"" />
      <xs:enumeration value=""GLUT"" />
      <xs:enumeration value=""GLUTE"" />
      <xs:enumeration value=""GLUTM"" />
      <xs:enumeration value=""GROIN"" />
      <xs:enumeration value=""GUM"" />
      <xs:enumeration value=""GVU"" />
      <xs:enumeration value=""HAL"" />
      <xs:enumeration value=""HAND"" />
      <xs:enumeration value=""HAR"" />
      <xs:enumeration value=""HART"" />
      <xs:enumeration value=""HEAD"" />
      <xs:enumeration value=""HEEL"" />
      <xs:enumeration value=""HEM"" />
      <xs:enumeration value=""HIP"" />
      <xs:enumeration value=""HIPJ"" />
      <xs:enumeration value=""HUMER"" />
      <xs:enumeration value=""HV"" />
      <xs:enumeration value=""HVB"" />
      <xs:enumeration value=""HVT"" />
      <xs:enumeration value=""HYMEN"" />
      <xs:enumeration value=""ICX"" />
      <xs:enumeration value=""ILC"" />
      <xs:enumeration value=""ILCON"" />
      <xs:enumeration value=""ILCR"" />
      <xs:enumeration value=""ILE"" />
      <xs:enumeration value=""ILEOS"" />
      <xs:enumeration value=""ILEUM"" />
      <xs:enumeration value=""ILIAC"" />
      <xs:enumeration value=""INASA"" />
      <xs:enumeration value=""INGUI"" />
      <xs:enumeration value=""INSTL"" />
      <xs:enumeration value=""INSTS"" />
      <xs:enumeration value=""INT"" />
      <xs:enumeration value=""INTRO"" />
      <xs:enumeration value=""INTRU"" />
      <xs:enumeration value=""ISCHI"" />
      <xs:enumeration value=""ISH"" />
      <xs:enumeration value=""JAW"" />
      <xs:enumeration value=""JUGI"" />
      <xs:enumeration value=""KIDN "" />
      <xs:enumeration value=""KNEE"" />
      <xs:enumeration value=""KNEEF"" />
      <xs:enumeration value=""KNEEJ"" />
      <xs:enumeration value=""LABIA"" />
      <xs:enumeration value=""LABMA"" />
      <xs:enumeration value=""LABMI"" />
      <xs:enumeration value=""LACRI"" />
      <xs:enumeration value=""LAM"" />
      <xs:enumeration value=""LARYN"" />
      <xs:enumeration value=""LEG"" />
      <xs:enumeration value=""LENS"" />
      <xs:enumeration value=""LING"" />
      <xs:enumeration value=""LINGU"" />
      <xs:enumeration value=""LIP"" />
      <xs:enumeration value=""LIVER"" />
      <xs:enumeration value=""LMN"" />
      <xs:enumeration value=""LN"" />
      <xs:enumeration value=""LNG"" />
      <xs:enumeration value=""LOBE"" />
      <xs:enumeration value=""LOCH"" />
      <xs:enumeration value=""LUMBA"" />
      <xs:enumeration value=""LUNG"" />
      <xs:enumeration value=""LYM"" />
      <xs:enumeration value=""MAC"" />
      <xs:enumeration value=""MALLE"" />
      <xs:enumeration value=""MANDI"" />
      <xs:enumeration value=""MAR"" />
      <xs:enumeration value=""MAST"" />
      <xs:enumeration value=""MAXIL"" />
      <xs:enumeration value=""MAXS"" />
      <xs:enumeration value=""MEATU"" />
      <xs:enumeration value=""MEC"" />
      <xs:enumeration value=""MEDST"" />
      <xs:enumeration value=""MEDU"" />
      <xs:enumeration value=""METAC"" />
      <xs:enumeration value=""METAT"" />
      <xs:enumeration value=""MILK"" />
      <xs:enumeration value=""MITRL"" />
      <xs:enumeration value=""MOLAR"" />
      <xs:enumeration value=""MONSU"" />
      <xs:enumeration value=""MONSV"" />
      <xs:enumeration value=""MOU"" />
      <xs:enumeration value=""MOUTH"" />
      <xs:enumeration value=""MP"" />
      <xs:enumeration value=""MPB"" />
      <xs:enumeration value=""MRSA2"" />
      <xs:enumeration value=""MYO"" />
      <xs:enumeration value=""NAIL"" />
      <xs:enumeration value=""NAILB"" />
      <xs:enumeration value=""NAILF"" />
      <xs:enumeration value=""NAILT"" />
      <xs:enumeration value=""NARES"" />
      <xs:enumeration value=""NASL"" />
      <xs:enumeration value=""NAVEL"" />
      <xs:enumeration value=""NECK"" />
      <xs:enumeration value=""NERVE"" />
      <xs:enumeration value=""NIPPL"" />
      <xs:enumeration value=""NLACR"" />
      <xs:enumeration value=""NOS"" />
      <xs:enumeration value=""NOSE"" />
      <xs:enumeration value=""NOSTR"" />
      <xs:enumeration value=""NP"" />
      <xs:enumeration value=""NSS"" />
      <xs:enumeration value=""NTRAC"" />
      <xs:enumeration value=""OCCIP"" />
      <xs:enumeration value=""OLECR"" />
      <xs:enumeration value=""OMEN"" />
      <xs:enumeration value=""ORBIT"" />
      <xs:enumeration value=""ORO"" />
      <xs:enumeration value=""OSCOX"" />
      <xs:enumeration value=""OVARY"" />
      <xs:enumeration value=""PAFL"" />
      <xs:enumeration value=""PALAT"" />
      <xs:enumeration value=""PALM"" />
      <xs:enumeration value=""PANAL"" />
      <xs:enumeration value=""PANCR"" />
      <xs:enumeration value=""PARAT"" />
      <xs:enumeration value=""PARIE"" />
      <xs:enumeration value=""PARON"" />
      <xs:enumeration value=""PAROT"" />
      <xs:enumeration value=""PAS"" />
      <xs:enumeration value=""PATEL"" />
      <xs:enumeration value=""PCARD"" />
      <xs:enumeration value=""PCLIT"" />
      <xs:enumeration value=""PELV"" />
      <xs:enumeration value=""PENIS"" />
      <xs:enumeration value=""PENSH"" />
      <xs:enumeration value=""PER"" />
      <xs:enumeration value=""PERI"" />
      <xs:enumeration value=""PERIH"" />
      <xs:enumeration value=""PERIN"" />
      <xs:enumeration value=""PERIS"" />
      <xs:enumeration value=""PERIT"" />
      <xs:enumeration value=""PERIU"" />
      <xs:enumeration value=""PERIV"" />
      <xs:enumeration value=""PERRA"" />
      <xs:enumeration value=""PERT"" />
      <xs:enumeration value=""PHALA"" />
      <xs:enumeration value=""PILO"" />
      <xs:enumeration value=""PINNA"" />
      <xs:enumeration value=""PLACF"" />
      <xs:enumeration value=""PLACM"" />
      <xs:enumeration value=""PLANT"" />
      <xs:enumeration value=""PLATH"" />
      <xs:enumeration value=""PLATS"" />
      <xs:enumeration value=""PLC"" />
      <xs:enumeration value=""PLEU"" />
      <xs:enumeration value=""PLEUR"" />
      <xs:enumeration value=""PLR"" />
      <xs:enumeration value=""PNEAL"" />
      <xs:enumeration value=""PNEPH"" />
      <xs:enumeration value=""PNM"" />
      <xs:enumeration value=""POPLI"" />
      <xs:enumeration value=""PORBI"" />
      <xs:enumeration value=""PREAU"" />
      <xs:enumeration value=""PRERE"" />
      <xs:enumeration value=""PROS"" />
      <xs:enumeration value=""PRST"" />
      <xs:enumeration value=""PTONS"" />
      <xs:enumeration value=""PUBIC"" />
      <xs:enumeration value=""PUL"" />
      <xs:enumeration value=""RADI"" />
      <xs:enumeration value=""RADIUS"" />
      <xs:enumeration value=""RBC"" />
      <xs:enumeration value=""RECTL"" />
      <xs:enumeration value=""RECTU"" />
      <xs:enumeration value=""RENL"" />
      <xs:enumeration value=""RIB"" />
      <xs:enumeration value=""RNP"" />
      <xs:enumeration value=""RPERI"" />
      <xs:enumeration value=""SAC"" />
      <xs:enumeration value=""SACIL"" />
      <xs:enumeration value=""SACRA"" />
      <xs:enumeration value=""SACRO"" />
      <xs:enumeration value=""SACRU"" />
      <xs:enumeration value=""SALGL"" />
      <xs:enumeration value=""SCALP"" />
      <xs:enumeration value=""SCAPU"" />
      <xs:enumeration value=""SCLAV"" />
      <xs:enumeration value=""SCLER"" />
      <xs:enumeration value=""SCLV"" />
      <xs:enumeration value=""SCROT"" />
      <xs:enumeration value=""SDP"" />
      <xs:enumeration value=""SEM"" />
      <xs:enumeration value=""SEMN"" />
      <xs:enumeration value=""SEPTU"" />
      <xs:enumeration value=""SEROM"" />
      <xs:enumeration value=""SGF"" />
      <xs:enumeration value=""SHIN"" />
      <xs:enumeration value=""SHOL"" />
      <xs:enumeration value=""SHOLJ"" />
      <xs:enumeration value=""SIGMO"" />
      <xs:enumeration value=""SINUS"" />
      <xs:enumeration value=""SKENE"" />
      <xs:enumeration value=""SKM"" />
      <xs:enumeration value=""SKULL"" />
      <xs:enumeration value=""SOLE"" />
      <xs:enumeration value=""SPCOR"" />
      <xs:enumeration value=""SPHEN"" />
      <xs:enumeration value=""SPLN"" />
      <xs:enumeration value=""SPRM"" />
      <xs:enumeration value=""SPX"" />
      <xs:enumeration value=""STER"" />
      <xs:enumeration value=""STOM"" />
      <xs:enumeration value=""STOMA"" />
      <xs:enumeration value=""STOOLL"" />
      <xs:enumeration value=""STUMP"" />
      <xs:enumeration value=""SUB"" />
      <xs:enumeration value=""SUBD"" />
      <xs:enumeration value=""SUBM"" />
      <xs:enumeration value=""SUBME"" />
      <xs:enumeration value=""SUBPH"" />
      <xs:enumeration value=""SUBX"" />
      <xs:enumeration value=""SUPB"" />
      <xs:enumeration value=""SUPRA"" />
      <xs:enumeration value=""SWT"" />
      <xs:enumeration value=""SWTG"" />
      <xs:enumeration value=""SYN"" />
      <xs:enumeration value=""SYNOL"" />
      <xs:enumeration value=""SYNOV"" />
      <xs:enumeration value=""TARS"" />
      <xs:enumeration value=""TBRON"" />
      <xs:enumeration value=""TCN"" />
      <xs:enumeration value=""TDUCT"" />
      <xs:enumeration value=""TEAR"" />
      <xs:enumeration value=""TEMPL"" />
      <xs:enumeration value=""TEMPO"" />
      <xs:enumeration value=""TESTI"" />
      <xs:enumeration value=""THIGH"" />
      <xs:enumeration value=""THM"" />
      <xs:enumeration value=""THORA"" />
      <xs:enumeration value=""THRB"" />
      <xs:enumeration value=""THUMB"" />
      <xs:enumeration value=""THYRD"" />
      <xs:enumeration value=""TIBIA"" />
      <xs:enumeration value=""TML"" />
      <xs:enumeration value=""TNL"" />
      <xs:enumeration value=""TOE"" />
      <xs:enumeration value=""TOEN"" />
      <xs:enumeration value=""TONG"" />
      <xs:enumeration value=""TONS"" />
      <xs:enumeration value=""TOOTH"" />
      <xs:enumeration value=""TRCHE"" />
      <xs:enumeration value=""TSK"" />
      <xs:enumeration value=""ULNA"" />
      <xs:enumeration value=""UMB"" />
      <xs:enumeration value=""UMBL"" />
      <xs:enumeration value=""URET"" />
      <xs:enumeration value=""URTH"" />
      <xs:enumeration value=""USTOM"" />
      <xs:enumeration value=""UTER"" />
      <xs:enumeration value=""UTERI"" />
      <xs:enumeration value=""VAGIN"" />
      <xs:enumeration value=""VAL"" />
      <xs:enumeration value=""VAS"" />
      <xs:enumeration value=""VASTL"" />
      <xs:enumeration value=""VAULT"" />
      <xs:enumeration value=""VCSF"" />
      <xs:enumeration value=""VCUFF"" />
      <xs:enumeration value=""VEIN"" />
      <xs:enumeration value=""VENTG"" />
      <xs:enumeration value=""VERMI"" />
      <xs:enumeration value=""VERTC"" />
      <xs:enumeration value=""VERTL"" />
      <xs:enumeration value=""VERTT"" />
      <xs:enumeration value=""VESCL"" />
      <xs:enumeration value=""VESFLD"" />
      <xs:enumeration value=""VESI"" />
      <xs:enumeration value=""VESTI"" />
      <xs:enumeration value=""VGV"" />
      <xs:enumeration value=""VITR"" />
      <xs:enumeration value=""VOC"" />
      <xs:enumeration value=""VULVA"" />
      <xs:enumeration value=""WBC"" />
      <xs:enumeration value=""WRIST"" />
    </xs:restriction>
  </xs:simpleType>
  <xs:simpleType name=""Table552"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
  <xs:simpleType name=""Table9999"">
    <xs:restriction base=""xs:string"" />
  </xs:simpleType>
</xs:schema>";
        
        public tablevalues_25() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "HL7DefinedTables";
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
