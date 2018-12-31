using System.IO;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;

using Document = Telerik.Windows.Documents.Spreadsheet.Model.Workbook;

namespace Telerik.Web.Spreadsheet
{
    public partial class Workbook
    {
        static Workbook()
        {
            WorkbookFormatProvidersManager.RegisterFormatProvider(new XlsxFormatProvider());
            WorkbookFormatProvidersManager.RegisterFormatProvider(new JsonFormatProvider());
        }

        /// <summary>
        /// Creates a Workbook instance and populates it with data from the specified file.
        /// 
        /// Supported file formats are XLSX, CSV, TXT (Tab-separated) and JSON.
        /// </summary>
        /// <param name="path">The fully-qualified path to the file</param>
        /// <returns>The populated Workbook</returns>
        public static Workbook Load(string path)
        {
            Document document;
            using (var file = File.OpenRead(path))
            {
                var extension = Path.GetExtension(path);
                document = WorkbookFormatProvidersManager.Import(extension, file);
            }

            return Workbook.FromDocument(document);
        }

        /// <summary>
        /// Creates a Workbook instance and populates it with data from the provided stream.
        /// The stream will be closed after completion.
        /// </summary>
        /// <param name="input">The input stream</param>
        /// <param name="extension">The file extension. Supported extensions are ".xlsx", ".csv", ".txt" and ".json"</param>
        /// <returns>The populated Workbook</returns>
        public static Workbook Load(Stream input, string extension)
        {
            var document = WorkbookFormatProvidersManager.Import(extension, input);

            return Workbook.FromDocument(document);
        }

        /// <summary>
        /// Stores the data from the Workbook in the specified file.
        /// 
        /// Supported file formats are XLSX, CSV, TXT (Tab-separated) and JSON.
        /// </summary>
        /// <param name="path">The fully-qualified path to the output file</param>
        public void Save(string path)
        {
            var document = this.ToDocument();

            using (var file = File.OpenWrite(path))
            {
                var extension = Path.GetExtension(path);
                WorkbookFormatProvidersManager.Export(document, extension, file);
            }
        }

        /// <summary>
        /// Stores the data from the Workbook in the provided stream.
        /// The stream will be closed after completion.
        /// </summary>
        /// <param name="output">The output stream</param>
        /// <param name="extension">The file extension. Supported extensions are ".xlsx", ".csv", ".txt" and ".json"</param>
        public void Save(Stream output, string extension)
        {
            WorkbookFormatProvidersManager.Export(this.ToDocument(), extension, output);
        }
    }
}
