// MapLayerCollection.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [ScriptName("LayerCollection")]
    public sealed class MapLayerCollection
    {
        #region Properties

        public int Length;

        #endregion Properties

        #region Methods

        public void Clear() { }
        public int IndexOf(MapLayer layer) { return 0; }
        public void Insert(MapLayer layer) { }
        public void InsertAll(MapLayer[] layers) { }
        public void Remove(MapLayer layer) { }
        public void RemoveAt(int idx) { }

        #endregion Methods
    }
}
