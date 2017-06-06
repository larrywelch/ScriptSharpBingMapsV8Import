// ClusterPushpin.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    public class ClusterPushpin
    {
        #region Properties

        public MapPushpin[] ContainsPushpins;

        [ScriptName("containedPushpins")]
        public List<MapPushpin> ContainsPushpinsAsList;

        public Number GridKey;

        #endregion Properties
    }
}
