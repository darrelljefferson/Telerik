using System.Collections.Generic;
namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Border style of the Spreadsheet widget
    /// </summary>
    public class SpreadsheetBorderStyle : JsonObject
    {
        /// <summary>
        /// The size of the border
        /// </summary>
        public string Size { get; set; }
        
        /// <summary>
        /// The color of the border
        /// </summary>
        public string Color { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (!string.IsNullOrEmpty(Size))
            {
                json["size"] = Size;
            }

            if (!string.IsNullOrEmpty(Color))
            {
                json["color"] = Color;
            }
        }
    }
}
