// ClusterLayer.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [ScriptName("ClusterLayer")]
    public class ClusterLayer : MapLayer
    {

        #region Constructor

        public ClusterLayer(MapPushpin[] pushpins)
        { }

        public ClusterLayer(MapPushpin[] pushpins, ClusterLayerOptions options)
        { }

        public ClusterLayer(List<MapPushpin> pushpins)
        { }

        public ClusterLayer(List<MapPushpin> pushpins, ClusterLayerOptions options)
        { }
        #endregion Constructor

        #region Methods
        public MapPushpin[] GetDisplayedPushpins()
        { return null; }

        [ScriptName("getDisplayedPushpins")]
        public List<MapPushpin> GetDisplayedPushpinsAsList()
        { return null;  }

        public ClusterLayerOptions GetOptions()
        { return null; }

        public MapPushpin[] GetPushpins()
        { return null; }

        [ScriptName("getPushpins")]
        public List<MapPushpin> GetPushpinsAsList()
        { return null; }

        [ScriptName("getClusterPushpinByGridKey")]
        public MapPushpin GetPushpinByGridKey(Number gridKey)
        { return null; }

        public ClusterPushpin GetClusterPushpinByGridKey(Number gridKey)
        { return null; }

        public void SetOptions(ClusterLayerOptions options)
        { }

        public void SetPushpins(MapPushpin[] pushpins)
        { }

        public void SetPushpins(List<MapPushpin> pushpins)
        { }

        #endregion

    }
}
