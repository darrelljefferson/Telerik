namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the EditorSerializationSettings settings.
    /// </summary>
    public class EditorSerializationSettingsBuilder: IHideObjectMembers
    {
        private readonly EditorSerializationSettings container;

        public EditorSerializationSettingsBuilder(EditorSerializationSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Define custom serialization for the editable content. The method accepts a single parameter as a string and is expected to return a string.
        /// </summary>
        /// <param name="value">The value that configures the custom.</param>
        public EditorSerializationSettingsBuilder Custom(string value)
        {
            container.Custom = value;

            return this;
        }
        
        /// <summary>
        /// Indicates whether the characters outside the ASCII range will be encoded as HTML entities. By default, they are encoded.
        /// </summary>
        /// <param name="value">The value that configures the entities.</param>
        public EditorSerializationSettingsBuilder Entities(bool value)
        {
            container.Entities = value;

            return this;
        }
        
        /// <summary>
        /// Indicates whether inline scripts will be serialized and posted to the server.
        /// </summary>
        /// <param name="value">The value that configures the scripts.</param>
        public EditorSerializationSettingsBuilder Scripts(bool value)
        {
            container.Scripts = value;

            return this;
        }
        
        /// <summary>
        /// Indicates whether the font styles will be saved as semantic (strong / em / span) tags,
		/// or as presentational (b / i / u / font) tags. Used for outputting content for legacy systems.
        /// </summary>
        /// <param name="value">The value that configures the semantic.</param>
        public EditorSerializationSettingsBuilder Semantic(bool value)
        {
            container.Semantic = value;

            return this;
        }
        
        //<< Fields
    }
}

