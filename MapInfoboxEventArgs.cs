// MapInfoboxEventArgs.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class MapInfoboxEventArgs
    {
        #region Constructor

        public MapInfoboxEventArgs() { }

        #endregion

        #region Properties

        public string EventName;
        public Number PageX;
        public Number PageY;
        public MapInfobox Target;
        public string TargetType;

        #endregion

    }
}
