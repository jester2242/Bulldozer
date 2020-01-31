using System;
using System.Collections.Generic;
using System.Text;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Factories
{
    public static class DataTypeMapFactory
    {

        public static ICSharpDataType CreateCSharpDataType(string version, string commonName, string longName, string sQLDataTypeName, bool sQLRequiresSize = false, int sQLSize = 0)
        {
            //TODO: CSharpDataType Creation Parameter Checks
            return new CSharpDataType(version, commonName, longName, sQLDataTypeName, sQLRequiresSize, sQLSize);
        }
        private class CSharpDataType : ICSharpDataType
        {
            private string globalVersion;
            private string globalCommonName;
            private string globalLongName;
            private string globalSQLDataTypeName;
            private bool globalSQLRequiresSize;
            private int globalSQLSize;

            public CSharpDataType(string version, string commonName, string longName,string sQLDataTypeName, bool sQLRequiresSize, int sQLSize)
            {
                
                globalVersion = version;
                globalCommonName = commonName;
                globalLongName = longName;
                globalSQLDataTypeName = sQLDataTypeName;
                globalSQLRequiresSize = sQLRequiresSize;
                globalSQLSize = sQLSize;
            }

            public string Version { get { return globalVersion;  } }

            public string CommonName { get { return globalCommonName;  } }

            public string LongName { get { return globalLongName; } }

            public string SQLDataTypeName { get { return globalSQLDataTypeName; } }

            public bool SQLRequiresSize { get { return globalSQLRequiresSize; } }

            public int SQLSize { get { return globalSQLSize; } }
        }
    }    
}
