using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Immutable;

namespace AICorporation.Bulldozer.BulldozerBuilderLibrary.Interfaces
{
    public interface IDataMap
    {
        IImmutableDictionary<string, ILanguageDataTypeMap> MappedDataTypes { get; }
    }
}
