
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Theming;
namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Extensions for CellBorder class
    /// </summary>
    public static class CellBorderExtensions
    {        
        /// <summary>
        /// Converts CellBorder to BorderStyle
        /// </summary>
        /// <param name="border">The document border style</param>
        /// <param name="theme">Document theme</param>
        /// <returns>Converted BorderStyle instances</returns>
        public static BorderStyle ToBorderStyle(this CellBorder border, DocumentTheme theme)
        {
            return new BorderStyle
            {
                Color = border.Color.GetActualValue(theme).ToHex(),
                Size = border.Thickness
            };
        }      
    }
}
