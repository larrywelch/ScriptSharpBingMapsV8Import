// HeatMapLayer.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [ScriptName("HeatMapLayer")]
    public sealed class HeatMapLayer : MapLayer
    {
        #region Constructor
        public HeatMapLayer(List<MapLocation> locations)
        { }

        public HeatMapLayer(MapLocation[] locations)
        { }
        public HeatMapLayer(MapPushpin[] pushpins)
        { }
        public HeatMapLayer(MapLocation[] locations, HeatMapLayerOptions options)
        { }
        public HeatMapLayer(MapPushpin[] pushpins, HeatMapLayerOptions options)
        { }
        #endregion Constructor

        #region Methods

        //public void Clear() { }

        //public void Dispose() { }

        //public bool GetVisible() { return true; }
        public void SetLocations(List<MapLocation> locations) { }
        public void SetLocations(MapLocation[] locations) { }

        public void SetLocations(MapPushpin[] pushpins) { }

        public void SetOptions(HeatMapLayerOptions options) { }

        //public void SetVisible(bool visible) { }

        #endregion Methods

    }
}
