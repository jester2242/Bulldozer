using System;
using System.Collections.Generic;
using System.Text;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    public interface ILanguageDataTypeMap: ISQLServerDataType
    {
        string CommonName { get; }
        string LongName { get; }
    }
}
