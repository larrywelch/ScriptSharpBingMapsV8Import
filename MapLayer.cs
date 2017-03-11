// MapLayer.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [ScriptName("Layer")]
    public sealed class MapLayer
    {
        #region Constructors

        public MapLayer() { }

        public MapLayer(string id) { }

        #endregion Constructors

        #region Properties

        public string Id;

        #endregion Properties

        #region Methods

        public void Add(MapEntity entity) { }

        public void Add(MapEntity entity, int index) { }

        public void Add(MapEntityCollection entities) { }

        public void Add(MapEntityCollection entities, int index) { }

        public void Clear() { }

        public void Dispose() { }

        public string GetId() { return string.Empty; }

        public MapEntity[] GetPrimitives() { return null;  }

        public bool GetVisible() { return false; }

        public int GetZIndex() { return 0; }

        public MapEntity Remove(MapEntity entity) { return entity; }

        public MapEntity RemoveAt(int index) { return null; }

        public void SetPrimitives(MapEntity[] entity) { }

        public void SetVisible(bool value) { }

        public void SetZIndex() { }

        #endregion Methods

    }
}
