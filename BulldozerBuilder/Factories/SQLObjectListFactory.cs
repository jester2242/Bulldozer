using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.CustomExceptions;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Factories
{
    public static class SQLObjectListFactory
    {
        public static IImmutableList<ISQLObject> CreateSQLObjectListFactory(ISQLObject[] sQLObjects)
        {
            if(sQLObjects == null || sQLObjects.Length < 1)
            {
                throw new MissingParameterException("sQLObjects", "SQLObjectListFactory.CreateSQLObjectListFactory()");
            }

            IImmutableList<ISQLObject> returnList = ImmutableList.Create<ISQLObject>(sQLObjects);
            return (returnList);
        }
    }
}
