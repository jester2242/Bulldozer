using System;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Entities;
using System.Collections.Immutable;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.CustomExceptions;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary
{
    public static class Action
    {
        public static IImmutableList<ISQLObject> GetSQLObjectList(Settings settings)
        {
            if(settings == null)
            {
                ArgumentNullException argumentNullException = new ArgumentNullException("settings");
                throw new MissingParameterException("settings", "Action.GetSQLObjectList", "Missing Parameter", argumentNullException);
            }

            return null;
        }
       
    }
}
