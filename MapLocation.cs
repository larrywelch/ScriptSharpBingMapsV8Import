// MapLocation.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Location")]
    public sealed class MapLocation
    {

        #region Constructors

        public MapLocation(double latitude, double longitude) {
        }

        #endregion Constructors

        #region Properties

        public double Latitude;
        public double Longitude;

        #endregion Properties

        #region Static Methods

        public static bool AreEqual(MapLocation location1, MapLocation location2) {
            return false;
        }

        public static double NormalizeLongitude(double longitude)
        {
            return 0;
        }


        public static MapLocation ParseLatLon(string str) { return null; }

        #endregion Static Methods

        #region Methods

        public MapLocation Clone() { return null; }

        #endregion Methods
    }
}
