// ClusterLayerOptions.cs
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [ScriptName("Object")]
    public class ClusterLayerOptions
    {
        #region Public Properties

        public bool ClusteringEnabled;
        // public ClusterPlacementType clusterPlacementType
        public Number GridSize;
        public MapPoint LayerOffset;
        public bool Visible;
        public Number zIndex;

        #endregion Public Properties
    }
}
