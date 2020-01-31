using System;
using System.Collections.Generic;
using System.Text;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    public interface ICSharpDataType: ILanguageDataTypeMap
    {
        string Version { get; }
    }
}
