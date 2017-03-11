// MapEvents.cs
// Script#/Libraries/Microsoft/BingMapsV8
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Collections;
using System.Html;
using System.Runtime.CompilerServices;

namespace Microsoft.Maps {

    public delegate void MapEventHandler(MapEventArgs e);

    [Imported]
    [ScriptName("Events")]
    public static class MapEvents {

        #region Methods

        #region AddHandlers
        public static object AddHandler(Map map, string eventName, MapEventHandler handler) {
            return null;
        }

        public static object AddHandler(MapEntity entity, string eventName, MapEventHandler handler) {
            return null;
        }

        public static object AddHandler(MapEntityCollection entities, string eventName, MapEventHandler handler) {
            return null;
        }

        public static object AddHandler(MapLayer layer, string eventName, MapEventHandler handler)
        {
            return null;
        }

        #endregion AddHandlers

        #region AddOnes

        public static void AddOne(Map map, string eventName, MapEventHandler handler) { }

        public static void AddOne(MapEntity entity, string eventName, MapEventHandler handler) { }

        public static void AddOne(MapEntityCollection entities, string eventName, MapEventHandler handler) { }

        public static void AddOne(MapLayer layer, string eventName, MapEventHandler handler) { }

        #endregion AddOnes

        #region AddThrottles

        public static object AddThrottledHandler(Map map, string eventName, MapEventHandler handler, int interval) {
            return null;
        }

        public static object AddThrottledHandler(MapEntity entity, string eventName, MapEventHandler handler, int interval) {
            return null;
        }

        public static object AddThrottledHandler(MapEntityCollection entities, string eventName, MapEventHandler handler, int interval) {
            return null;
        }

        public static object AddThrottledHandler(MapLayer layer, string eventName, MapEventHandler handler, int interval)
        {
            return null;
        }
        #endregion AddThrottles

        #region Has

        public static bool HasHandler(Map map, string eventName) { return false; }

        public static bool HasHandler(MapEntity entity, string eventName) { return false; }

        public static bool HasHandler(MapEntityCollection entities, string eventName) { return false; }

        public static bool HasHandler(MapLayer layer, string eventName) { return false; }

        #endregion Has

        #region Invookes

        public static void Invoke(Map map, string eventName, object args) { }

        public static void Invoke(MapEntity entity, string eventName, object args) { }

        public static void Invoke(MapEntityCollection entities, string eventName, object args) { }

        public static void Invoke(MapLayer layer, string eventName, object args) { }

        #endregion Invokes

        #region Remove

        public static void RemoveHandler(object handlerID) {
        }

        #endregion Remove

        #endregion Methods
    }
}
