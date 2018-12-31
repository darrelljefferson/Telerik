namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the EditorPasteCleanupSettings settings.
    /// </summary>
    public class EditorPasteCleanupSettingsBuilder: IHideObjectMembers
    {
        private readonly EditorPasteCleanupSettings container;

        public EditorPasteCleanupSettingsBuilder(EditorPasteCleanupSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// All HTML tags are stripped leaving only the text in the content.
        /// </summary>
        /// <param name="value">The value that configures the all.</param>
        public EditorPasteCleanupSettingsBuilder All(bool value)
        {
            container.All = value;

            return this;
        }
        
        /// <summary>
        /// Remove style and class attributes from the pasting content.
        /// </summary>
        /// <param name="value">The value that configures the css.</param>
        public EditorPasteCleanupSettingsBuilder Css(bool value)
        {
            container.Css = value;

            return this;
        }
        
        /// <summary>
        /// Use a callback function to integrate a custom implementation for cleaning up the paste content. Make sure the callback function always returns the result.
        /// </summary>
        /// <param name="value">The value that configures the custom.</param>
        public EditorPasteCleanupSettingsBuilder Custom(string value)
        {
            container.Custom = value;

            return this;
        }
        
        /// <summary>
        /// Strip all HTML tags but keep new lines in the pasted content.
        /// </summary>
        /// <param name="value">The value that configures the keepnewlines.</param>
        public EditorPasteCleanupSettingsBuilder KeepNewLines(bool value)
        {
            container.KeepNewLines = value;

            return this;
        }
        
        /// <summary>
        /// Remove all special formatting from MS Word content like font-name, font-size and MS Word specific tags.
        /// </summary>
        /// <param name="value">The value that configures the msallformatting.</param>
        public EditorPasteCleanupSettingsBuilder MsAllFormatting(bool value)
        {
            container.MsAllFormatting = value;

            return this;
        }
        
        /// <summary>
        /// Converts MS Word pasted content into HTML lists.
        /// </summary>
        /// <param name="value">The value that configures the msconvertlists.</param>
        public EditorPasteCleanupSettingsBuilder MsConvertLists(bool value)
        {
            container.MsConvertLists = value;

            return this;
        }
        
        /// <summary>
        /// Removes all MS Word specific tags and cleans up the extra metadata.
        /// </summary>
        /// <param name="value">The value that configures the mstags.</param>
        public EditorPasteCleanupSettingsBuilder MsTags(bool value)
        {
            container.MsTags = value;

            return this;
        }
        
        /// <summary>
        /// Prevent any cleaning up of the content.
        /// </summary>
        /// <param name="value">The value that configures the none.</param>
        public EditorPasteCleanupSettingsBuilder None(bool value)
        {
            container.None = value;

            return this;
        }
        
        /// <summary>
        /// Remove all span elements from the content, ensuring much of the inline formatting is removed.
        /// </summary>
        /// <param name="value">The value that configures the span.</param>
        public EditorPasteCleanupSettingsBuilder Span(bool value)
        {
            container.Span = value;

            return this;
        }
        
        //<< Fields
    }
}

