namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the EditorDeserializationSettings settings.
    /// </summary>
    public class EditorDeserializationSettingsBuilder: IHideObjectMembers
    {
        private readonly EditorDeserializationSettings container;

        public EditorDeserializationSettingsBuilder(EditorDeserializationSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Callback that allows custom deserialization to be plugged in. The method accepts string as the only parameter and is expected to return the modified content as string as well.
        /// </summary>
        /// <param name="value">The value that configures the custom.</param>
        public EditorDeserializationSettingsBuilder Custom(string value)
        {
            container.Custom = value;

            return this;
        }
        
        //<< Fields
    }
}

