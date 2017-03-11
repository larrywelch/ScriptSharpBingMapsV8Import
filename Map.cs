// Map.cs
// Script#/Libraries/Microsoft/BingMaps
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    [Imported]
    public sealed class Map
    {

        #region Constructors

        public Map(Element element, MapOptions options) {}
        public Map(Element element, MapViewOptions options) {}
        public Map(string elementName, MapOptions options) { }
        public Map(string elementName, MapViewOptions options) { }

        #endregion Constructors

        #region Properties

        public MapEntityCollection Entities;

        public MapLayerCollection Layers { get { return null; } }

        #endregion Properties

        #region Methods

        public void Dispose(){}

        public MapLocationRect GetBounds() { return null; }

        public MapLocation GetCenter() { return null; }

        public void GetCopyrights(Action<string []> callback) {}

        public void GetCredentials(Action<string> callBack) {}

        public string GetCulture() { return string.Empty; }

        public int GetHeading() { return 0; }

        public int GetHeight() { return 0; }

        public string GetImageryId() { return null; }

        [ScriptName("getMapTypeId")]
        public MapType GetMapType()
        {
            return MapType.Aerial;
        }

        public double GetMetersPerPixel() { return 0;}

        public MapOptions GetOptions() {return null; }

        public int GetPageX() { return 0; }

        public int GetPageY() { return 0; }

        public Element GetRootElement() { return null; }

        public string GetUserRegion() { return string.Empty; }

        public int GetWidth() { return 0; }

        public int GetZoom() { return 0; }

        public MapRange GetZoomRange() { return null; }

        public bool IsMercator() { return false; }

        public bool IsRotationEnabled() { return false; }

        public void SetMapType(MapType mapType) { }

        public void SetMapOptions(MapOptions options) { }

        public void SetViewOptions(MapViewOptions options) { }

        public MapPoint TryLocationToPixel(MapLocation location) { return null; }

        public MapPoint[] TryLocationToPixel(MapLocation[] locations) { return null; }

        public MapPoint TryLocationToPixel(MapLocation location, MapPointReference pointReference) { return null; }

        public MapPoint[] TryLocationToPixel(MapLocation[] locations, MapPointReference pointReference) { return null; }

        public MapLocation TryPixelToLocation(MapPoint p) { return null; }

        public MapLocation[] TryPixelToLocation(MapPoint[] points) { return null; }

        public MapLocation TryPixelToLocation(MapPoint p, MapPointReference pointReference) { return null; }

        public MapLocation[] TryPixelToLocation(MapPoint[] points, MapPointReference pointReference) { return null; }

        #endregion Methods
    }
}
