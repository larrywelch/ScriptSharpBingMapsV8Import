// MapTypeEventArgs.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class MapTypeEventArgs : EventArgs
    {
        #region Constructor

        public MapTypeEventArgs() { }

        #endregion Constructor

        #region Properties

        public MapType NewMapTypeId;
        public MapType OldMapTypeId;
        public Map Target;
        public string TargetType;

        #endregion Properties
    }
}
