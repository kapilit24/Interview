namespace Interview.BizTalk.HL7.SQL.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Sending_Facility", XPath = @"/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Sending_Facility' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Message_Type", XPath = @"/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Message_Type' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Patient_ID", XPath = @"/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Patient_ID' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SP_BTS_SET_PATIENT_HL7", @"SP_BTS_SET_PATIENT_HL7Response"})]
    public sealed class TypedProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedProcedure.dbo</fileNameHint>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SP_BTS_SET_PATIENT_HL7"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/SP_BTS_SET_PATIENT_HL7</doc:action>
      </xs:documentation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Sending_Facility' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Message_Type' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Patient_ID' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Sending_Facility"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""50"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Message_Type"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""8"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Patient_ID"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""50"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""SP_BTS_SET_PATIENT_HL7Response"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/SP_BTS_SET_PATIENT_HL7/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public TypedProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "SP_BTS_SET_PATIENT_HL7";
                _RootElements[1] = "SP_BTS_SET_PATIENT_HL7Response";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"SP_BTS_SET_PATIENT_HL7")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Sending_Facility", XPath = @"/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Sending_Facility' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Message_Type", XPath = @"/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Message_Type' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Patient_ID", XPath = @"/*[local-name()='SP_BTS_SET_PATIENT_HL7' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']/*[local-name()='Patient_ID' and namespace-uri()='http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SP_BTS_SET_PATIENT_HL7"})]
        public sealed class SP_BTS_SET_PATIENT_HL7 : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SP_BTS_SET_PATIENT_HL7() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SP_BTS_SET_PATIENT_HL7";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"SP_BTS_SET_PATIENT_HL7Response")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SP_BTS_SET_PATIENT_HL7Response"})]
        public sealed class SP_BTS_SET_PATIENT_HL7Response : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SP_BTS_SET_PATIENT_HL7Response() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SP_BTS_SET_PATIENT_HL7Response";
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
}
