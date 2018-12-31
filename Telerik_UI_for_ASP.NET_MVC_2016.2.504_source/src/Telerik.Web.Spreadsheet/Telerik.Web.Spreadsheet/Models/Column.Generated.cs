using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Column
    /// </summary>
    [DataContract]
    public partial class Column
    {
        /// <summary>
        /// The zero-based index of the column. Required to ensure correct positioning.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int? Index { get; set; }

        /// <summary>
        /// The width of the column in pixels. Defaults to columnWidth.
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public double? Width { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Index != null)
            {
                settings["index"] = Index;
            }

            if (Width != null)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
