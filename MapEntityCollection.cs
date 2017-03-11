// MapEntityCollection.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [ScriptName("EntityCollection")]
    [Imported]
    public sealed class MapEntityCollection
    {

        #region Constructors

        public MapEntityCollection() { }

        #endregion Constructors

        #region Methods

        public void Clear() { }

        public MapEntity Get(int index) { return null; }

        public int GetLength() { return 0; }

        public int IndexOf(MapEntity entity) { return 0; }

        public void Insert(MapEntity entity, int index) { }

        public void Insert(MapEntityCollection entities, int index) { }

        public MapEntity Pop() { return null; }

        public void Push(MapEntity entity) { }

        public void Push(MapEntity[] entity) { }

        public MapEntity Remove(MapEntity entity) { return null; }

        public MapEntity RemoveAt(int index) { return null; }
       
        #endregion Methods

    }
}
