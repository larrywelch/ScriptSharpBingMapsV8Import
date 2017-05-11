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
    }
}
