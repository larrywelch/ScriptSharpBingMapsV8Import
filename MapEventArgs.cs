// MapEventArgs.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class MapEventArgs : EventArgs {

        #region Constructor

        internal MapEventArgs() {
        }

        #endregion Constructor

        #region Properties

        public string EventName;
        public MapLocation Location;
        public Number PageX;
        public Number PageY;
        public MapPoint Point;
        public string TargetType;

        #endregion Properties

        #region Methods

        public int GetX() { return 0; }

        public int GetY() { return 0; }

        #endregion Methods
    }
}
