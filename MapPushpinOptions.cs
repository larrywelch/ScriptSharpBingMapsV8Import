// MapPushpinOptions.cs
// Script#/Libraries/Microsoft/BingMaps
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    // TODO: Make properties
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapPushpinOptions {
        public MapPoint Anchor;
        public string Color;
        [ScriptName("color")]
        public MapColor PinColor;
        public string Cursor;
        public bool Draggable;
        public bool EnableClickedStyle;
        public bool EnableHoverStyle;
        public string Icon;
        public bool RoundClickableArea;
        public string SubTitle;
        public string Title;
        public string Text;
        public MapPoint TextOffset;
        public bool Visible;

    }
}
