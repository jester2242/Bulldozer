using System;
using System.Collections.Generic;
using System.Text;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    public interface ISQLServerDataType
    {
        string SQLDataTypeName { get; }
        bool SQLRequiresSize { get; }
        int SQLSize { get; }
    }
}
