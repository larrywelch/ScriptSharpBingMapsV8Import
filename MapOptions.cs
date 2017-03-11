// MapOptions.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapOptions {

        #region Properties

        public bool AllowHidingLabelsOfRoad;

        public MapColor BackgroundColor;

        public string Credentials;

        public bool DisablePanning;

        public bool DisableScrollWheelZoom;

        public bool DisableStreetside;

        public bool DisableStreetsideAutoCoverage;

        public bool DisableZooming;

        public bool EnableClickableLogo;

        public bool EnableInertia;

        public bool LiteMode;

        public MapLocationRect maxBounds;

        public int MaxZoom;

        public int MinZoom;

        public MapNavigationBarMode NavigationBareMode;

        public MapNavigationBarOrientation NavigationBarOrientation;

        public bool ShowBreadcrumb;

        public bool ShowDashboard;

        public bool ShoLocateMeButton;

        public bool ShowMapTypeSelector;

        public bool ShowScalebar;

        public bool ShowTrafficButton;

        public bool ShowTermsLink;

        public bool ShowZoomButtons;

        public MapStreetsideOptions StreetSideOptions;

        #endregion Properties
    }
}
