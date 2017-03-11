// MapEntityCollectionChangedEventArgs.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    public sealed class MapEntityCollectionChangedEventArgs : MapEventArgs {

        #region Constructor

        private MapEntityCollectionChangedEventArgs() {
        }

        #endregion Constructor

        #region Properties

        public MapEntityCollection Collection;

        public MapEntity Data;

        #endregion Properties
    }
}
