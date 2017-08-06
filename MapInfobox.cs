// MapInfobox.cs
// Script#/Libraries/Microsoft/BingMaps
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {
    [Imported]
    //[IgnoreNamespace]
    [ScriptName("Infobox")]
    public sealed class MapInfobox : MapEntity {

        #region Constructors

        public MapInfobox(MapLocation location) {
        }

        public MapInfobox(MapLocation location, MapInfoboxOptions options) {
        }

        #endregion

        #region Methods

        public MapInfoboxOptions[] GetActions() { return null; }

        public MapPoint GetAnchor() { return null; }

        public string GetDescription() { return string.Empty; }

        public Number GetHeight() { return 0; }

        public string GetHtmlContent() {  return string.Empty; }

        public MapLocation GetLocation() { return null; }

        public Number GetMaxHeight() { return 0; }

        public Number GetMaxWidth() { return 0; }

        public MapPoint GetOffset() { return null; }

        public MapInfoboxOptions GetOptions() { return null; }

        public bool GetShowCloseButton() { return false; }

        public bool GetShowPointer() { return false; }

        public string GetTitle() { return string.Empty; }

        public Number GetWidth() { return 0; }

        public Number GetZIndex() { return 0; }

        public void SetHtmlContent(string content) { }

        public void SetLocation(MapLocation loc) { }

        public void SetMap(Map map) { }

        public void SetOptions(MapInfoboxOptions opt) {
        }

        #endregion

    }
}
