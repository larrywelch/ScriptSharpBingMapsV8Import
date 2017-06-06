// MapMouseEventArgs.cs
// Script#/Libraries/Microsoft/BingMaps
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapMouseEventArgs : MapEventArgs {

        #region Constructor

        public MapMouseEventArgs()
        { }

        #endregion Constructor

        #region Properties

        public Map Target;

        [ScriptName("target")]
        public IPrimitive TargetAsIPrimitive;

        #endregion Properties
    }
}
