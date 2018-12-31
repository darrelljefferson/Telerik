using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a SortColumn
    /// </summary>
    [DataContract]
    public partial class SortColumn
    {
        /// <summary>
        /// Indicates if the data in the cell should be sorted ascending (true) or descending or (false).
        /// </summary>
        [DataMember(Name = "ascending", EmitDefaultValue = false)]
        public bool? Ascending { get; set; }

        /// <summary>
        /// The index of the column within the sheet.For example, column C will have index 2.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public double? Index { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Ascending != null)
            {
                settings["ascending"] = Ascending;
            }

            if (Index != null)
            {
                settings["index"] = Index;
            }

            return settings;
        }
    }
}
