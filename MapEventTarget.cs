// MapEventTarget.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {


    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptConstants(UseNames = true)]
    public enum MapEventTarget {

        Map = 0,

        Pushpin = 1,

        Polygon = 2,

        Polyline = 3
    }
}
