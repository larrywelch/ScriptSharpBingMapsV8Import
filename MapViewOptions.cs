// MapViewOptions.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapViewOptions {

        public MapLocationRect Bounds;
        public MapLocation Center;
        public int Heading;
        public MapLabelOverlay LabelOverlay;
        [ScriptName("mapTypeId")]
        public MapType MapType;
        public int Padding;
        public int Pitch;
        public int Zoom;
    }
}
