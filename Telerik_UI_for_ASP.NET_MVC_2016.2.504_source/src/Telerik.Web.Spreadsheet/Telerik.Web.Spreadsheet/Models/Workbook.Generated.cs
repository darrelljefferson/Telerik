using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Workbook
    /// </summary>
    [DataContract]
    public partial class Workbook
    {
        /// <summary>
        /// The name of the currently active sheet.Must match one of the (sheet names)[#configuration-sheets.name] exactly.
        /// </summary>
        [DataMember(Name = "activeSheet", EmitDefaultValue = false)]
        public string ActiveSheet { get; set; }

        /// <summary>
        /// An array defining the document sheets and their content.
        /// </summary>
        [DataMember(Name = "sheets", EmitDefaultValue = false)]
        public List<Worksheet> Sheets
        {
            get;
            set;
        }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (ActiveSheet != null)
            {
                settings["activeSheet"] = ActiveSheet;
            }

            if (Sheets != null)
            {
                settings["sheets"] = Sheets.Select(item => item.Serialize());
            }

            return settings;
        }
    }
}
