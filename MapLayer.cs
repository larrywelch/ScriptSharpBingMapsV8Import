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
    public class MapLayer
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

        public IPrimitive[] GetPrimitives() { return null;  }
        [ScriptName("getPrimitives")]
        public List<IPrimitive> GetPrimitivesAsList() { return null; }

        public bool GetVisible() { return false; }

        public int GetZIndex() { return 0; }

        public IPrimitive Remove(IPrimitive primitive) { return null; }

        public IPrimitive RemoveAt(int index) { return null; }

        public void SetPrimitives(IPrimitive[] primitives) { }
        public void SetPrimitives(List<IPrimitive> primitives) { }

        public void SetVisible(bool value) { }

        public void SetZIndex() { }

        #endregion Methods

    }
}
