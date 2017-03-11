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

        public bool handled;

        public bool IsPrimary;

        public bool isSecondary;

        public bool isTouchEvent;

        public object OriginalEvent;

        public int PageX;

        public int PageY;

        public object Target;

        public string TargetType;

        public int wheelDelta;

        #endregion Properties

        #region Methods

        public int GetX() { return 0; }

        public int GetY() { return 0; }

        #endregion Methods
    }
}
