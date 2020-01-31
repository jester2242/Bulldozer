using System;
using System.Collections.Generic;
using System.Text;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Enums
{
    public enum BulldozerBuildSettingsFlags
    {      
        UseStoredProcedures = 1,
        RunSqlScripts = 2,
        EntitiesInSingleFile = 4,
        DataAccessLayerInSngleFile = 16,
        CreateCustomListsForEntities = 32
    }
    public enum BulldozerIncludeSQLObjectFlags
    {
        IncludeTables = 1,
        IncludeViews = 2
    }
}
