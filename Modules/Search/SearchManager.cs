// Search.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps.Search
{

    [ScriptName("SearchManager")]
    public class SearchManager
    {
        #region Constructor

        public SearchManager(Map map) { }

        #endregion

        #region Methods

        public void Geocode(GeocodeRequestOptions options)
        { }

        public static void reverseGeocode(ReverseGeocodeRequestOptions options)
        { }
        #endregion Methods
    }


    [Imported]
    [IgnoreNamespace]
    public class Address
    {
        public string AddressLine;
        public string AdminDistrict;
        public string CountryRegion;
        public string CountryRegionISO2;
        public string District;
        public string FormattedAddress;
        public string Locality;
        public string PostalCode;
    }

    [Imported]
    [IgnoreNamespace]
    public class PlaceResult
    {
        public Address Address;
        public MapLocationRect BestView;
        public MapLocation Location;
    }

    [Imported]
    [IgnoreNamespace]
    public class GeocodeResult
    {
        public PlaceResult[] Results;
    }

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class GeocodeRequestOptions
    {
        public MapLocationRect Bounds;
        public Action<GeocodeResult, object> Callback; //(GeocodeResult results, object userData) { return null; }
        public int Number;
        public Action<GeocodeRequestOptions> ErrorCallback; //(GeocodeRequestOptions request) { return null; }
        public bool IncludeCountryIso2;
        public bool IncludeNeighborhood;
        public int Timeout;
        public object UserData;
        public string Where;
    }

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class ReverseGeocodeRequestOptions
    {
        public Action<GeocodeResult, object> Callback;
        public Action<GeocodeRequestOptions> ErrorCallback;
        public bool IncludeCountryIso2;
        public List<string> IncludeEntityTypes;
        public bool IncludeNeighborhood;
        public MapLocation Location;
        public Number Timeout;
        public object UserData;
    }
}

