namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the EditorPdfSettings settings.
    /// </summary>
    public class EditorPdfSettingsBuilder: IHideObjectMembers
    {
        private readonly EditorPdfSettings container;

        public EditorPdfSettingsBuilder(EditorPdfSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value that configures the author.</param>
        public EditorPdfSettingsBuilder Author(string value)
        {
            container.Author = value;

            return this;
        }
        
        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value that configures the creator.</param>
        public EditorPdfSettingsBuilder Creator(string value)
        {
            container.Creator = value;

            return this;
        }
        
        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value that configures the date.</param>
        public EditorPdfSettingsBuilder Date(DateTime value)
        {
            container.Date = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value that configures the filename.</param>
        public EditorPdfSettingsBuilder FileName(string value)
        {
            container.FileName = value;

            return this;
        }
        
        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value that configures the forceproxy.</param>
        public EditorPdfSettingsBuilder ForceProxy(bool value)
        {
            container.ForceProxy = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value that configures the keywords.</param>
        public EditorPdfSettingsBuilder Keywords(string value)
        {
            container.Keywords = value;

            return this;
        }
        
        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value that configures the landscape.</param>
        public EditorPdfSettingsBuilder Landscape(bool value)
        {
            container.Landscape = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the margins of the page (numbers or strings with units). Supported
		/// units are "mm", "cm", "in" and "pt" (default).
        /// </summary>
        /// <param name="configurator">The action that configures the margin.</param>
        public EditorPdfSettingsBuilder Margin(Action<EditorPdfMarginSettingsBuilder> configurator)
        {
            configurator(new EditorPdfMarginSettingsBuilder(container.Margin));
            return this;
        }
        
        /// <summary>
        /// Specifies the paper size of the PDF document.
		/// The default "auto" means paper size is determined by content.Supported values:
        /// </summary>
        /// <param name="value">The value that configures the papersize.</param>
        public EditorPdfSettingsBuilder PaperSize(string value)
        {
            container.PaperSize = value;

            return this;
        }
        
        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally e.g. Internet Explorer 9 and Safari. PDF export is not supported in Internet Explorer 8 and below.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value that configures the proxyurl.</param>
        public EditorPdfSettingsBuilder ProxyURL(string value)
        {
            container.ProxyURL = value;

            return this;
        }
        
        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value that configures the proxytarget.</param>
        public EditorPdfSettingsBuilder ProxyTarget(string value)
        {
            container.ProxyTarget = value;

            return this;
        }
        
        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value that configures the subject.</param>
        public EditorPdfSettingsBuilder Subject(string value)
        {
            container.Subject = value;

            return this;
        }
        
        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value that configures the title.</param>
        public EditorPdfSettingsBuilder Title(string value)
        {
            container.Title = value;

            return this;
        }
        
        //<< Fields
    }
}

