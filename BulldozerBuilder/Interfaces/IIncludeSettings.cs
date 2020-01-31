using System;
using System.Collections.Generic;
using System.Text;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    interface IIncludeSettings : ISettings
    {
        int SQLObjectsToInclude { get; }
    }
}
