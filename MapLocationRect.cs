// LocationRect.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps
{
    [Imported]
    [ScriptName("LocationRect")]
    public sealed class MapLocationRect
    {
        #region Constructor

        public MapLocationRect(MapLocation center, int width, int height) { }

        #endregion Constructor

        #region Properties

        public MapLocation Center;
        public int Height;
        public int Width;

        #endregion Properties

        #region Static Methods

        public static MapLocationRect FromCorners(MapLocation northwest, MapLocation southeast) { return null; }
        public static MapLocationRect FromEdges(double north, double west, double south, double east) { return null; }
        public static MapLocationRect FromLocation(MapLocation[] locations) { return null; }
        public static MapLocationRect FromString(string northWestSoutEast) { return null; }

        #endregion Static Methods

        #region Methods

        public void Buffer(double percentage) { }

        public MapLocationRect Clone() { return null; }

        public bool Contains(MapLocation location) { return false; }

        public bool CrossesInternationalDateLine() { return false; }

        public double GetEast() { return 0; }

        public double GetNorth() { return 0; }

        public MapLocation GetNorthwest() { return null; }

        public double GetSouth() { return 0; }

        public MapLocation GetSoutheast() { return null; }

        public double GetWest() { return 0; }

        public bool Intersects(MapLocationRect locationRect) { return false; }

        public MapLocationRect[] SplitByInternationalDateLine() { return null; }

        #endregion Methods

    }
}
