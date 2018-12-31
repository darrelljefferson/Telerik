namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetToolbarSettings settings.
    /// </summary>
    public class SpreadsheetToolbarSettingsBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetToolbarSettings container;

        public SpreadsheetToolbarSettingsBuilder(SpreadsheetToolbarSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// A boolean value indicating if the "home" tab should be displayed or a collection of tools that will be shown in the "home" tab.The available tools are:Those tools which are part of a tool group are defined as array. For example ["bold", "italic", "underline"]
        /// </summary>
        /// <param name="value">The value that configures the home.</param>
        public SpreadsheetToolbarSettingsBuilder Home(bool value)
        {
            container.Home = value;

            return this;
        }
        
        /// <summary>
        /// A boolean value indicating if the "insert" tab should be displayed or a collection of tools that will be shown in the "insert" tab.The available tools are:Those tools which are part of a tool group are defined as array. For example ["deleteColumn", "deleteRow"]
        /// </summary>
        /// <param name="value">The value that configures the insert.</param>
        public SpreadsheetToolbarSettingsBuilder Insert(bool value)
        {
            container.Insert = value;

            return this;
        }
        
        /// <summary>
        /// A boolean value indicating if the "insert" tab should be displayed or a collection of tools that will be shown in the "insert" tab.The available tools are:
        /// </summary>
        /// <param name="value">The value that configures the data.</param>
        public SpreadsheetToolbarSettingsBuilder Data(bool value)
        {
            container.Data = value;

            return this;
        }
        
        //<< Fields
    }
}

