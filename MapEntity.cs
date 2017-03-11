// MapEntity.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public abstract class MapEntity {

        [ScriptName("metadata")]
        public object MetaData;

        public bool GetVisible() { return false; }
    }
}
