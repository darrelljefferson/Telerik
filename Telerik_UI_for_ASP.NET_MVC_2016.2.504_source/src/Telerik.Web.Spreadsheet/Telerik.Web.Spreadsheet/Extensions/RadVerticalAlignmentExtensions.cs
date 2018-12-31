using System.Windows.Media;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Extensions for RadVerticalAlignment class
    /// </summary>
    public static class RadVerticalAlignmentExtensions
    {
        /// <summary>
        /// Convert RadVerticalAlignment to string
        /// </summary>
        /// <param name="alignment">Current alignment</param>
        /// <returns>Spreadsheet friendly alignment. Possible values "center", "top" and "bottom".</returns>
        public static string AsString(this RadVerticalAlignment alignment)
        {            
            switch(alignment)
            {
                case RadVerticalAlignment.Top:
                    return "top";
                case RadVerticalAlignment.Bottom:
                    return "bottom";
                default:
                    return "center";
            }
        }

        /// <summary>
        /// Convert string to RadVerticalAlignment
        /// </summary>
        /// <param name="alignment">Current alignment. Possible values "center", "top" and "bottom".</param>
        /// <returns>RadVerticalAlignment value for the string</returns>
        public static RadVerticalAlignment ToVerticalAlignment(this string alignment)
        {
            switch (alignment)
            {
                case "top":
                    return RadVerticalAlignment.Top;
                case "bottom":
                    return RadVerticalAlignment.Bottom;
                default:
                    return RadVerticalAlignment.Center;
            }
        }
    }
}
