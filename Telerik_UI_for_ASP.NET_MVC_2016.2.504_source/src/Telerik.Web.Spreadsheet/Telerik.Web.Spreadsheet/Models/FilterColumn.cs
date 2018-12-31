using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a FilterColumn
    /// </summary>
    public partial class FilterColumn
    {
        /// <summary>
        /// An array of dates to filter.
        /// </summary>
        [DataMember(Name = "dates", EmitDefaultValue = false)]
        public List<ValueFilterDate> Dates
        {
            get;
            set;
        }

        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (Dates != null)
            {
                settings["dates"] = Dates.Select(item => item.Serialize()); ;
            }

            return settings;
        }
    }
}

