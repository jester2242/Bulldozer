using System;
using System.Collections.Generic;
using System.Text;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Enums;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.CustomExceptions;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Factories
{
    public static class SQLObjectFactory
    {
        public static ISQLObject CreateSQLObject(string name, SQLObjectType sQLObjectType)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new MissingParameterException("name", "SQLObjectFactory.CreateSQLObject(string name, SQLObjectType sQLObjectType)", "SQLObjectFactory was passed an empty or null name string");
                }

                return (new MuteableSQLObject(name, sQLObjectType));
            }
            catch (Exception)
            {
                throw;
            }           
        }
        private sealed class MuteableSQLObject : ISQLObject
        {
            private string globalName;
            private SQLObjectType globalSQLObjectType;
            public MuteableSQLObject(string name, SQLObjectType sQLObjectType)
            {
                globalName = name;
                globalSQLObjectType = sQLObjectType;
            }
            public string Name
            {
                get { return globalName; }
            }
            public SQLObjectType SQLObjectType
            {
                get { return globalSQLObjectType; }
            }
        }
    }
}
