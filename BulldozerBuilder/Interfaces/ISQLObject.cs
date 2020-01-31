using System;
using System.Collections.Generic;
using System.Text;
using AICorporation.Bulldozer.BulldozerBuilderLibrary.Enums;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    public interface ISQLObject
    {
            string Name { get; }
            SQLObjectType SQLObjectType { get; }
    }
}
