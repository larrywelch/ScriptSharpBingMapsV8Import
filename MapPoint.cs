// MapPoint.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [ScriptName("Point")]
    public sealed class MapPoint {

        public MapPoint(double x, double y) {
        }

        public double X;
        public double Y;

        public static MapPoint Add(MapPoint p1, MapPoint p2) {
            return null;
        }
        public MapPoint Clone()
        {
            return null;
        }

        public static bool Equals(MapPoint p1) {
            return false;
        }

        public static bool Equals(MapPoint p1, double tolerance)
        {
            return false;
        }

        public static MapPoint Subtract(MapPoint p1) {
            return null;
        }
    }
}
