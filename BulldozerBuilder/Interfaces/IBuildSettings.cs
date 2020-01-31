using System;
using System.Collections.Generic;
using System.Text;


namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    interface IBuildSettings: IIncludeSettings
    {
        IEnumerable<ISQLObject> SQLObjects { get; }
    }
}
