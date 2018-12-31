namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetPdfSettings settings.
    /// </summary>
    public class SpreadsheetPdfSettingsBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetPdfSettings container;

        public SpreadsheetPdfSettingsBuilder(SpreadsheetPdfSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The area to export. Possible values:
        /// </summary>
        /// <param name="value">The value that configures the area.</param>
        public SpreadsheetPdfSettingsBuilder Area(string value)
        {
            container.Area = value;

            return this;
        }
        
        /// <summary>
        /// The author of the PDF document.
        /// </summary>
        /// <param name="value">The value that configures the author.</param>
        public SpreadsheetPdfSettingsBuilder Author(string value)
        {
            container.Author = value;

            return this;
        }
        
        /// <summary>
        /// The creator of the PDF document.
        /// </summary>
        /// <param name="value">The value that configures the creator.</param>
        public SpreadsheetPdfSettingsBuilder Creator(string value)
        {
            container.Creator = value;

            return this;
        }
        
        /// <summary>
        /// The date when the PDF document is created. Defaults to new Date().
        /// </summary>
        /// <param name="value">The value that configures the date.</param>
        public SpreadsheetPdfSettingsBuilder Date(DateTime value)
        {
            container.Date = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the file name of the exported PDF file.
        /// </summary>
        /// <param name="value">The value that configures the filename.</param>
        public SpreadsheetPdfSettingsBuilder FileName(string value)
        {
            container.FileName = value;

            return this;
        }
        
        /// <summary>
        /// An option indicating whether to fit the spreadsheet content to page width.
        /// </summary>
        /// <param name="value">The value that configures the fitwidth.</param>
        public SpreadsheetPdfSettingsBuilder FitWidth(bool value)
        {
            container.FitWidth = value;

            return this;
        }
        
        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value that configures the forceproxy.</param>
        public SpreadsheetPdfSettingsBuilder ForceProxy(bool value)
        {
            container.ForceProxy = value;

            return this;
        }
        
        /// <summary>
        /// An option indicating whether to export the cell guidelines.
        /// </summary>
        /// <param name="value">The value that configures the guidelines.</param>
        public SpreadsheetPdfSettingsBuilder Guidelines(bool value)
        {
            container.Guidelines = value;

            return this;
        }
        
        /// <summary>
        /// An option indicating whether to center the content horizontally.See also vCenter.
        /// </summary>
        /// <param name="value">The value that configures the hcenter.</param>
        public SpreadsheetPdfSettingsBuilder HCenter(bool value)
        {
            container.HCenter = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the keywords of the exported PDF file.
        /// </summary>
        /// <param name="value">The value that configures the keywords.</param>
        public SpreadsheetPdfSettingsBuilder Keywords(string value)
        {
            container.Keywords = value;

            return this;
        }
        
        /// <summary>
        /// Set to true to reverse the paper dimensions if needed such that width is the larger edge.
        /// </summary>
        /// <param name="value">The value that configures the landscape.</param>
        public SpreadsheetPdfSettingsBuilder Landscape(bool value)
        {
            container.Landscape = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the margins of the page (numbers or strings with units). Supported
		/// units are "mm", "cm", "in" and "pt" (default).
        /// </summary>
        /// <param name="configurator">The action that configures the margin.</param>
        public SpreadsheetPdfSettingsBuilder Margin(Action<SpreadsheetPdfMarginSettingsBuilder> configurator)
        {
            configurator(new SpreadsheetPdfMarginSettingsBuilder(container.Margin));
            return this;
        }
        
        /// <summary>
        /// Specifies the paper size of the PDF document.
		/// The default "auto" means paper size is determined by content.Supported values:
        /// </summary>
        /// <param name="value">The value that configures the papersize.</param>
        public SpreadsheetPdfSettingsBuilder PaperSize(string value)
        {
            container.PaperSize = value;

            return this;
        }
        
        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally e.g. Internet Explorer 9 and Safari. PDF export is not supported in Internet Explorer 8 and below.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value that configures the proxyurl.</param>
        public SpreadsheetPdfSettingsBuilder ProxyURL(string value)
        {
            container.ProxyURL = value;

            return this;
        }
        
        /// <summary>
        /// A name or keyword indicating where to display the document returned from the proxy.If you want to display the document in a new window or iframe,
		/// the proxy should set the "Content-Disposition" header to inline; filename="&lt;fileName.pdf&gt;".
        /// </summary>
        /// <param name="value">The value that configures the proxytarget.</param>
        public SpreadsheetPdfSettingsBuilder ProxyTarget(string value)
        {
            container.ProxyTarget = value;

            return this;
        }
        
        /// <summary>
        /// Sets the subject of the PDF file.
        /// </summary>
        /// <param name="value">The value that configures the subject.</param>
        public SpreadsheetPdfSettingsBuilder Subject(string value)
        {
            container.Subject = value;

            return this;
        }
        
        /// <summary>
        /// Sets the title of the PDF file.
        /// </summary>
        /// <param name="value">The value that configures the title.</param>
        public SpreadsheetPdfSettingsBuilder Title(string value)
        {
            container.Title = value;

            return this;
        }
        
        /// <summary>
        /// An option indicating whether to center the content vertically.See also hCenter.
        /// </summary>
        /// <param name="value">The value that configures the vcenter.</param>
        public SpreadsheetPdfSettingsBuilder VCenter(bool value)
        {
            container.VCenter = value;

            return this;
        }
        
        //<< Fields
    }
}

