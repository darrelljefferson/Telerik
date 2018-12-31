using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Extensions for System.Windows.Media.Color class
    /// </summary>
    public static class ColorExtensions
    {        
        /// <summary>
        /// Converts to CSS style color, i.e #ff00ff
        /// </summary>
        /// <param name="color">The color to be converted</param>
        /// <returns>String representing the CSS style color.</returns>
        public static string ToHex(this Color color)
        {            
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        /// <summary>
        /// Converts CSS style color to System.Windows.Media.Color
        /// </summary>
        /// <param name="hex">Hex color code to convert</param>
        /// <returns>System.Windows.Media.Color instance</returns>
        public static Color ToColor(this string hex)
        {            
            return (Color)ColorConverter.ConvertFromString(hex);
        }
    }
}
