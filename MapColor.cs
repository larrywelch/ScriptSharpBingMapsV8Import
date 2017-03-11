// MapColor.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapColor
    {
        #region Constructor

        public MapColor(int a, int r, int g, int b) {
        }

        #endregion Constructor

        #region Properties
        
        public int A;
        public int R;
        public int G;
        public int B;

        #endregion Properties

        #region Methods
        
        public MapColor Clone() { return null; }
        public int GetOpacity() { return 0; }
        public string ToHex() { return string.Empty; }
        public string ToRgba() { return string.Empty; }

        #endregion Methods

        #region Static Methods

        public static MapColor Clone(MapColor color) { return null; }
        public static MapColor FromHex(string hex) { return null; }

        #endregion Static Methods
    }
}
