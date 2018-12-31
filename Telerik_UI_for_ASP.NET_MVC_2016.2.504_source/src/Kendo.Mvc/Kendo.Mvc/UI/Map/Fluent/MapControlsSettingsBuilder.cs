namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the MapControlsSettings settings.
    /// </summary>
    public class MapControlsSettingsBuilder: IHideObjectMembers
    {
        private readonly MapControlsSettings container;

        public MapControlsSettingsBuilder(MapControlsSettings settings)
        {
            container = settings;
        }

        //>> Fields
        

        /// <summary>
        /// Configures or disables the built-in attribution control.
        /// </summary>
        /// <param name="enabled">Enables or disables the attribution option.</param>
        public MapControlsSettingsBuilder Attribution(bool enabled)
        {
            container.Attribution.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// Configures or disables the built-in attribution control.
        /// </summary>
        /// <param name="configurator">The action that configures the attribution.</param>
        public MapControlsSettingsBuilder Attribution(Action<MapControlsAttributionSettingsBuilder> configurator)
        {
            container.Attribution.Enabled = true;
            
            configurator(new MapControlsAttributionSettingsBuilder(container.Attribution));
            return this;
        }
        

        /// <summary>
        /// Configures or disables the built-in navigator control (directional pad).
        /// </summary>
        /// <param name="enabled">Enables or disables the navigator option.</param>
        public MapControlsSettingsBuilder Navigator(bool enabled)
        {
            container.Navigator.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// Configures or disables the built-in navigator control (directional pad).
        /// </summary>
        /// <param name="configurator">The action that configures the navigator.</param>
        public MapControlsSettingsBuilder Navigator(Action<MapControlsNavigatorSettingsBuilder> configurator)
        {
            container.Navigator.Enabled = true;
            
            configurator(new MapControlsNavigatorSettingsBuilder(container.Navigator));
            return this;
        }
        

        /// <summary>
        /// Configures or disables the built-in zoom control (+/- button).
        /// </summary>
        /// <param name="enabled">Enables or disables the zoom option.</param>
        public MapControlsSettingsBuilder Zoom(bool enabled)
        {
            container.Zoom.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// Configures or disables the built-in zoom control (+/- button).
        /// </summary>
        /// <param name="configurator">The action that configures the zoom.</param>
        public MapControlsSettingsBuilder Zoom(Action<MapControlsZoomSettingsBuilder> configurator)
        {
            container.Zoom.Enabled = true;
            
            configurator(new MapControlsZoomSettingsBuilder(container.Zoom));
            return this;
        }
        
        //<< Fields
    }
}

