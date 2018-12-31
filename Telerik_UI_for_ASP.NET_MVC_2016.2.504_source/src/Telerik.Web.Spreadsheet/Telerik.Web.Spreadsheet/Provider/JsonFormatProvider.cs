using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;

using Document = Telerik.Windows.Documents.Spreadsheet.Model.Workbook;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// A format provider that converts JSON streams to Telerik DPL Workbooks and vice versa
    /// </summary>
    public class JsonFormatProvider : WorkbookFormatProviderBase
    {
        /// <summary>
        /// Creates a new instance of the JSON Format Provider
        /// </summary>
        public JsonFormatProvider()
        {
            ImportSettings = new JsonImportSettings();
            ExportSettings = new JsonExportSettings();
        }

        /// <summary>
        /// Gets the name of the provider
        /// </summary>
        public override string Name
        {
            get
            {
                return "Json";
            }
        }

        /// <summary>
        /// Gets a list of supported file extensions
        /// </summary>
        public override IEnumerable<string> SupportedExtensions
        {
            get
            {
                return new string[] { ".json" };
            }
        }

        /// <summary>
        /// Gets a value indicating whether can import.
        /// </summary>
        /// <value>The value indicating whether can import.</value>
        public override bool CanImport
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets a value indicating whether can export.
        /// </summary>
        /// <value>The value indicating whether can export.</value>
        public override bool CanExport
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// The settings to use during export
        /// </summary>
        public JsonExportSettings ExportSettings { get; private set; }

        /// <summary>
        /// The settings to use during import
        /// </summary>
        public JsonImportSettings ImportSettings { get; private set; }

        /// <summary>
        /// Reads an input stream with JSON data and produces a Telerik DPL Workbook.
        /// </summary>
        /// <param name="input">An input stream containing JSON data</param>
        /// <returns>A Telerik DPL Workbook</returns>
        protected override Document ImportOverride(Stream input)
        {
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(input, ImportSettings.Encoding, true, ImportSettings.BufferSize))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var workbook = serializer.Deserialize<Workbook>(jsonReader);
                return workbook.ToDocument();
            }
        }

        /// <summary>
        /// Writes a Telerik DPL Workbook to an output stream in JSON format
        /// </summary>
        /// <param name="document">A Telerik DPL Workbook</param>
        /// <param name="output">The stream to write to</param>
        protected override void ExportOverride(Document document, Stream output)
        {
            var workbook = Workbook.FromDocument(document);

            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(output, ExportSettings.Encoding, ExportSettings.BufferSize))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, workbook);
            }
        }
    }
}
