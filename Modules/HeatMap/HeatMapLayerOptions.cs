// HeatMapLayerOptions.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class MapColorGradient
    {
        public string A;
        public string B;

        public MapColorGradient(string a, string b)
        {
            A = a;
            B = b;
        }
    }

    [Imported]
    [ScriptName("HeatMapLayerOptions")]
    public class HeatMapLayerOptions
    {
        #region Public Properties

        //public Dictionary<string, string> ColorGradient;
        public MapColorGradient[] ColorGradient;
        public Number Intensity;
        public Number Opacity;
        public Number Radius;
        public string Unit;
        public bool Visible;

        #endregion Public Properties

        #region Constructor

        public HeatMapLayerOptions() { }

        #endregion Constructore
    }
}