using Newtonsoft.Json;
using System.IO;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using Document = Telerik.Windows.Documents.Spreadsheet.Model.Workbook;

namespace Telerik.Web.Spreadsheet
{
    public partial class Workbook
    {
        /// <summary>
        /// Creates a Workbook instance and populates it with data from JSON
        /// </summary>
        /// <param name="json">The source JSON</param>
        /// <returns>The populated Workbook</returns>
        public static Workbook FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Workbook>(json);
        }

        /// <summary>
        /// Converts this Workbook to JSON
        /// </summary>
        /// <returns>The JSON string</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
