// MapStreetsideOptions.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    public delegate void MapStreetsideOptionsEventHandler();

    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public sealed class MapStreetsideOptions {

        #region Properties

        public bool DisablePanoramaNavigation;

        public MapLocation LocationToLookAt;

        public MapStreetsideOptionsEventHandler onErrorLoading;

        public MapStreetsideOptionsEventHandler onSuccessLoading;

        public MapOverviewMapMode OverviewMapMode;

        public double PanoramaLookupRadius;

        public bool ShowCurrentAddress;

        public bool ShowExitButton;

        public bool ShowHeadingCompass;

        public bool ShowProblemReporting;

        public bool showZoomButtons;

        #endregion Properties
    }
}
