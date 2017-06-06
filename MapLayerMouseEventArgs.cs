// MapLayerMouseEventArgs.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapLayerMouseEventArgs : MapEventArgs
    {
        #region Constructor

        public MapLayerMouseEventArgs()
        { }

        #endregion Constructor

        #region Properties

        public MapLayer Target;
        public IPrimitive Primitive;

        #endregion Properties
    }
}
