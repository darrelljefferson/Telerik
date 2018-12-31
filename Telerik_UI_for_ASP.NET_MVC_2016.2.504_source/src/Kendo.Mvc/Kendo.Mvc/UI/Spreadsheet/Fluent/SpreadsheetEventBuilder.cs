namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo Spreadsheet for ASP.NET MVC events.
    /// </summary>
    public class SpreadsheetEventBuilder: EventBuilder
    {
        public SpreadsheetEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        //>> Handlers
        
        /// <summary>
        /// Triggered when a value in the spreadsheet has been changed. Introduced in 2016.Q1.SP1.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public SpreadsheetEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }
        
        /// <summary>
        /// Triggered after the widget has completed rendering.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the render event.</param>
        public SpreadsheetEventBuilder Render(string handler)
        {
            Handler("render", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user clicks the "Export to Excel" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelExport event.</param>
        public SpreadsheetEventBuilder ExcelExport(string handler)
        {
            Handler("excelExport", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user clicks the "Open" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelImport event.</param>
        public SpreadsheetEventBuilder ExcelImport(string handler)
        {
            Handler("excelImport", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user initiates PDF export.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public SpreadsheetEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }
        
        //<< Handlers
    }
}

