namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetExcelSettings settings.
    /// </summary>
    public class SpreadsheetExcelSettingsBuilder: IHideObjectMembers
    {
        private readonly SpreadsheetExcelSettings container;

        public SpreadsheetExcelSettingsBuilder(SpreadsheetExcelSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Specifies the file name of the exported Excel file.
        /// </summary>
        /// <param name="value">The value that configures the filename.</param>
        public SpreadsheetExcelSettingsBuilder FileName(string value)
        {
            container.FileName = value;

            return this;
        }
        
        /// <summary>
        /// If set to true, the content will be forwarded to proxyURL even if the browser supports saving files locally.
        /// </summary>
        /// <param name="value">The value that configures the forceproxy.</param>
        public SpreadsheetExcelSettingsBuilder ForceProxy(bool value)
        {
            container.ForceProxy = value;

            return this;
        }
        
        /// <summary>
        /// The URL of the server side proxy which will stream the file to the end user.A proxy will be used when the browser isn't capable of saving files locally.
		/// Such browsers are IE version 9 and lower and Safari.The developer is responsible for implementing the server-side proxy.The proxy will receive a POST request with the following parameters in the request body:The proxy should return the decoded file with the "Content-Disposition" header set to
		/// attachment; filename="&lt;fileName.xslx&gt;".
        /// </summary>
        /// <param name="value">The value that configures the proxyurl.</param>
        public SpreadsheetExcelSettingsBuilder ProxyURL(string value)
        {
            container.ProxyURL = value;

            return this;
        }
        
        //<< Fields
    }
}

