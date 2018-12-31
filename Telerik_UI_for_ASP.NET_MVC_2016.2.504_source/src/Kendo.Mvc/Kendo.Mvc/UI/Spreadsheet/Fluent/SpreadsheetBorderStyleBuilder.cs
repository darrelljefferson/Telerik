namespace Kendo.Mvc.UI.Fluent
{    
    /// <summary>
    /// Defines the fluent API for configuring the Kendo Spreadsheet border style for ASP.NET MVC.
    /// </summary>
    public class SpreadsheetBorderStyleBuilder : IHideObjectMembers
    {
        private readonly SpreadsheetBorderStyle container;

        public SpreadsheetBorderStyleBuilder(SpreadsheetBorderStyle settings)
        {
            container = settings;
        }

        /// <summary>
        /// Configure cell border color
        /// </summary>
        /// <param name="value">The color of the border</param>        
        public SpreadsheetBorderStyleBuilder Color(string value)
        {
            container.Color = value;

            return this;
        }

        /// <summary>
        /// Configure cell border size
        /// </summary>
        /// <param name="value">The size of the border</param>        
        public SpreadsheetBorderStyleBuilder Size(string value)
        {
            container.Size = value;

            return this;
        }
    }
}
