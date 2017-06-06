// IPrimitiveChangedEventArgs.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class IPrimitiveChangedEventArgs
    {
        public string Name;
        public IPrimitive sender;
    }
}
