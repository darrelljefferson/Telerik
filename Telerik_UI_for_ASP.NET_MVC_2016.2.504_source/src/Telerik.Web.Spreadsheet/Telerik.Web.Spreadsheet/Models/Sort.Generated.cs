using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Sort
    /// </summary>
    [DataContract]
    public partial class Sort
    {
        /// <summary>
        /// Specifies the sort options for individual columns.
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = false)]
        public List<SortColumn> Columns
        {
            get;
            set;
        }

        /// <summary>
        /// The sorted range, e.g. "A1:D5".
        /// </summary>
        [DataMember(Name = "ref", EmitDefaultValue = false)]
        public string Ref { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Columns != null)
            {
                settings["columns"] = Columns.Select(item => item.Serialize());
            }

            if (Ref != null)
            {
                settings["ref"] = Ref;
            }

            return settings;
        }
    }
}
