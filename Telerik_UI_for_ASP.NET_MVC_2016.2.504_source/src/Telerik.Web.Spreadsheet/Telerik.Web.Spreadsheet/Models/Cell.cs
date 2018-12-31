using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Cell
    /// </summary>
    public partial class Cell
    {        
        /// <summary>
        /// The style information for the bottom border of the cell.
        /// </summary>
        [DataMember(Name = "borderBottom", EmitDefaultValue = false)]
        public BorderStyle BorderBottom { get; set; }

        /// <summary>
        /// The style information for the left border of the cell.
        /// </summary>
        [DataMember(Name = "borderLeft", EmitDefaultValue = false)]
        public BorderStyle BorderLeft { get; set; }

        /// <summary>
        /// The style information for the top border of the cell.
        /// </summary>
        [DataMember(Name = "borderTop", EmitDefaultValue = false)]
        public BorderStyle BorderTop { get; set; }

        /// <summary>
        /// The style information for the right border of the cell.
        /// </summary>
        [DataMember(Name = "borderRight", EmitDefaultValue = false)]
        public BorderStyle BorderRight { get; set; }

        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (BorderBottom != null)
            {
                settings["borderBottom"] = BorderBottom.Serialize();
            }

            if (BorderLeft != null)
            {
                settings["borderLeft"] = BorderLeft.Serialize();
            }

            if (BorderTop != null)
            {
                settings["borderTop"] = BorderTop.Serialize();
            }

            if (BorderRight != null)
            {
                settings["borderRight"] = BorderRight.Serialize();
            }

            return settings;
        }
    }
}

