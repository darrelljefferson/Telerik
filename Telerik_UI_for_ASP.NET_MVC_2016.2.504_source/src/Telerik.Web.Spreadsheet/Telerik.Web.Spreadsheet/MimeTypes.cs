using System;
using System.Collections.Generic;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Defines common MIME types supported file types
    /// </summary>
    public static class MimeTypes
    {
        /// <summary>
        /// MIME type for CSV files
        /// </summary>
        public const string CSV = "text/csv";

        /// <summary>
        /// MIME type for JSON files
        /// </summary>
        public const string JSON = "application/json";

        /// <summary>
        /// MIME type for PDF files
        /// </summary>
        public const string PDF = "application/pdf";

        /// <summary>
        /// MIME type for Tab-delimited text file
        /// </summary>
        public const string TXT = "text/tab-separated-values";

        /// <summary>
        /// MIME type for Office Open XML Workbook
        /// </summary>
        public const string XLSX = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        /// <summary>
        /// List of all supported MIME types by extension
        /// </summary>
        public static readonly IDictionary<String, String> ByExtension =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {                
                { ".csv", MimeTypes.CSV },
                { ".json", MimeTypes.JSON },
                { ".pdf", MimeTypes.PDF },
                { ".txt", MimeTypes.TXT },
                { ".xlsx", MimeTypes.XLSX }
            };
    }
}
