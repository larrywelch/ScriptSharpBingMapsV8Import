// MapPushpin.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [ScriptName("Pushpin")]
    public sealed class MapPushpin : MapEntity {

        #region Constructors

        public MapPushpin(MapLocation location)
        {
        }

        public MapPushpin(MapLocation location, MapPushpinOptions options) {
        }

        #endregion Constructors

        #region Methods

        public MapPoint GetAnchor() { return null; }

        public bool GetClickedStyleEnabled() { return false; }

        public object GetColor() { return string.Empty; }
        [ScriptName("getColor")]
        public string GetColorAsString() { return string.Empty; }
        [ScriptName("getColor")]
        public MapColor GetColorAsColor() { return null;  }

        public string GetCursor() { return string.Empty; }

        public bool GetDraggable() { return false; }

        public bool GetHoverStyleEnabled() { return false; }

        public string GetIcon() { return string.Empty; }

        public MapLocation GetLocation() { return null; }

        public bool GetRoundClickableArea() { return false; }

        public string GetText() { return string.Empty; }

        public MapPoint GetTextOffset() { return null; }

        public string GetTitle() { return string.Empty; }

        public string GetSubTitle() { return string.Empty; }

        public bool Visible() { return false; }

        public void SetLocation(MapLocation location) {
        }

        public void SetOptions(MapPushpinOptions options) {
        }

        #endregion Methods
    }
}
