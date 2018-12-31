namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the EditorResizableSettings settings.
    /// </summary>
    public class EditorResizableSettingsBuilder: IHideObjectMembers
    {
        private readonly EditorResizableSettings container;

        public EditorResizableSettingsBuilder(EditorResizableSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// If enabled, the editor renders a resize handle to allow users to resize it.
        /// </summary>
        /// <param name="value">The value that configures the content.</param>
        public EditorResizableSettingsBuilder Content(bool value)
        {
            container.Content = value;

            return this;
        }
        
        /// <summary>
        /// The minimum height that the editor can be resized to.
        /// </summary>
        /// <param name="value">The value that configures the min.</param>
        public EditorResizableSettingsBuilder Min(double value)
        {
            container.Min = value;

            return this;
        }
        
        /// <summary>
        /// The maximum height that the editor can be resized to.
        /// </summary>
        /// <param name="value">The value that configures the max.</param>
        public EditorResizableSettingsBuilder Max(double value)
        {
            container.Max = value;

            return this;
        }
        
        /// <summary>
        /// If resizable is set to true the widget will detect changes in the viewport width and will hide the overflowing controls in the tool overflow popup.
        /// </summary>
        /// <param name="value">The value that configures the toolbar.</param>
        public EditorResizableSettingsBuilder Toolbar(bool value)
        {
            container.Toolbar = value;

            return this;
        }
        
        //<< Fields
    }
}

