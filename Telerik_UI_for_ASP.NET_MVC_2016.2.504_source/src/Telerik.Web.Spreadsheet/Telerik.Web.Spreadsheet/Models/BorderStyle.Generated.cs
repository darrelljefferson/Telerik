using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a BorderStyle
    /// </summary>
    [DataContract]
    public partial class BorderStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public double? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Size != null)
            {
                settings["size"] = Size;
            }

            if (Color != null)
            {
                settings["color"] = Color;
            }

            return settings;
        }
    }
}
