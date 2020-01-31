using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.CustomExceptions;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Factories;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary
{
    public static class DataMapping
    {
        public static IDataMap GetCSharpDataMap()
        {
            ICSharpDataType[] cSharpDataTypesArray = new ICSharpDataType[31];
            
            cSharpDataTypesArray[0] = DataTypeMapFactory.CreateCSharpDataType("8.0", "long", "Int64", "bigint");
            cSharpDataTypesArray[1] = DataTypeMapFactory.CreateCSharpDataType("8.0", "byte[]", "Byte[]", "binary", true);
            cSharpDataTypesArray[2] = DataTypeMapFactory.CreateCSharpDataType("8.0", "bool", "Boolean", "bit");
            cSharpDataTypesArray[3] = DataTypeMapFactory.CreateCSharpDataType("8.0", "char[]", "Char[]", "char", true);
            cSharpDataTypesArray[4] = DataTypeMapFactory.CreateCSharpDataType("8.0", "DateTime", "DateTime", "date");
            cSharpDataTypesArray[5] = DataTypeMapFactory.CreateCSharpDataType("8.0", "DateTime", "DateTime", "datetime");
            cSharpDataTypesArray[6] = DataTypeMapFactory.CreateCSharpDataType("8.0", "DateTime", "DateTime", "datetime2");
            cSharpDataTypesArray[7] = DataTypeMapFactory.CreateCSharpDataType("8.0", "DateTimeOffset", "DateTimeOffset", "datetimeoffset");
            cSharpDataTypesArray[8] = DataTypeMapFactory.CreateCSharpDataType("8.0", "decimal", "Decimal", "decimal");
            cSharpDataTypesArray[9] = DataTypeMapFactory.CreateCSharpDataType("8.0", "double", "Double", "float");
            cSharpDataTypesArray[10] = DataTypeMapFactory.CreateCSharpDataType("8.0", "byte[]", "Byte[]", "image");
            cSharpDataTypesArray[11] = DataTypeMapFactory.CreateCSharpDataType("8.0", "decimal", "Decimal", "money");
            cSharpDataTypesArray[12] = DataTypeMapFactory.CreateCSharpDataType("8.0", "char[]", "Char[]", "nchar", true);
            cSharpDataTypesArray[13] = DataTypeMapFactory.CreateCSharpDataType("8.0", "string", "String", "nText");
            cSharpDataTypesArray[14] = DataTypeMapFactory.CreateCSharpDataType("8.0", "decimal", "Decimal", "numeric");
            cSharpDataTypesArray[15] = DataTypeMapFactory.CreateCSharpDataType("8.0", "string", "String", "nvarchar", true);
            cSharpDataTypesArray[16] = DataTypeMapFactory.CreateCSharpDataType("8.0", "single", "Single", "real");
            cSharpDataTypesArray[17] = DataTypeMapFactory.CreateCSharpDataType("8.0", "byte[]", "Byte[]", "rowversion");
            cSharpDataTypesArray[18] = DataTypeMapFactory.CreateCSharpDataType("8.0", "DateTime", "DateTime", "smalldatetime");
            cSharpDataTypesArray[19] = DataTypeMapFactory.CreateCSharpDataType("8.0", "short", "Int16", "smallint");
            cSharpDataTypesArray[20] = DataTypeMapFactory.CreateCSharpDataType("8.0", "int", "Int32", "int");
            cSharpDataTypesArray[21] = DataTypeMapFactory.CreateCSharpDataType("8.0", "decimal", "Decimal", "smallmoney");
            cSharpDataTypesArray[22] = DataTypeMapFactory.CreateCSharpDataType("8.0", "object", "Object", "sql_variant");
            cSharpDataTypesArray[23] = DataTypeMapFactory.CreateCSharpDataType("8.0", "string", "String", "text");
            cSharpDataTypesArray[24] = DataTypeMapFactory.CreateCSharpDataType("8.0", "TimeSpan", "TimeSpan", "time");
            cSharpDataTypesArray[25] = DataTypeMapFactory.CreateCSharpDataType("8.0", "byte[]", "Byte[]", "timestamp");
            cSharpDataTypesArray[26] = DataTypeMapFactory.CreateCSharpDataType("8.0", "byte", "Byte", "tinyint");
            cSharpDataTypesArray[27] = DataTypeMapFactory.CreateCSharpDataType("8.0", "Guid", "Guid", "uniqueidentifier");
            cSharpDataTypesArray[28] = DataTypeMapFactory.CreateCSharpDataType("8.0", "byte[]", "Byte[]", "varbinary", true);
            cSharpDataTypesArray[29] = DataTypeMapFactory.CreateCSharpDataType("8.0", "string", "String", "varchar", true);
            cSharpDataTypesArray[30] = DataTypeMapFactory.CreateCSharpDataType("8.0", "Xml", "Xml", "xml");

            return (new CSharpDataMap(cSharpDataTypesArray));
        }

        private class CSharpDataMap : IDataMap
        {            
            ImmutableDictionary<string, ILanguageDataTypeMap> globalMappedDataTypes;
            public CSharpDataMap(ICSharpDataType[] cSharpDataTypes)
            {
                if (cSharpDataTypes == null)
                {
                    ArgumentNullException innerException = new ArgumentNullException("cSharpDataTypes");
                    throw new MissingParameterException("cSharpDataTypes", "CSharpDataMap.Ctor", "Null Parameter", innerException);
                }

                globalMappedDataTypes = ImmutableDictionary.Create<string, ILanguageDataTypeMap>();

                foreach (var cSharpDataType in cSharpDataTypes)
                {
                    globalMappedDataTypes.Add(cSharpDataType.CommonName, cSharpDataType);
                }               
            }
            public IImmutableDictionary<string, ILanguageDataTypeMap> MappedDataTypes { get { return globalMappedDataTypes; } }
        }

    }
}
