using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Cell
    /// </summary>
    [DataContract]
    public partial class Cell
    {
        /// <summary>
        /// The background color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        [DataMember(Name = "background", EmitDefaultValue = false)]
        public string Background { get; set; }

        /// <summary>
        /// The font color of the cell.Many standard CSS formats are supported, but the canonical form is "#ccff00".
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// The font family for the cell.
        /// </summary>
        [DataMember(Name = "fontFamily", EmitDefaultValue = false)]
        public string FontFamily { get; set; }

        /// <summary>
        /// The font size of the cell in pixels.
        /// </summary>
        [DataMember(Name = "fontSize", EmitDefaultValue = false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Sets the cell font to italic, if set to true.
        /// </summary>
        [DataMember(Name = "italic", EmitDefaultValue = false)]
        public bool? Italic { get; set; }

        /// <summary>
        /// Sets the cell font to bold, if set to true.
        /// </summary>
        [DataMember(Name = "bold", EmitDefaultValue = false)]
        public bool? Bold { get; set; }

        /// <summary>
        /// Disables the cell, if set to false.
        /// </summary>
        [DataMember(Name = "enable", EmitDefaultValue = false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The format of the cell text.See Create or delete a custom number format on MS Office.
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// The cell formula without the leading equals sign, e.g. A1 * 10.
        /// </summary>
        [DataMember(Name = "formula", EmitDefaultValue = false)]
        public string Formula { get; set; }

        /// <summary>
        /// The zero-based index of the cell. Required to ensure correct positioning.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int? Index { get; set; }

        /// <summary>
        /// The text align setting for the cell content.Available options are:
		/// * left
		/// * center
		/// * right
		/// * justify
        /// </summary>
        [DataMember(Name = "textAlign", EmitDefaultValue = false)]
        public string TextAlign { get; set; }

        /// <summary>
        /// Sets the cell font to underline, if set to true.
        /// </summary>
        [DataMember(Name = "underline", EmitDefaultValue = false)]
        public bool? Underline { get; set; }

        /// <summary>
        /// The cell value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public object Value { get; set; }

        /// <summary>
        /// The vertical align setting for the cell content.Available options are:
		/// * left
		/// * center
		/// * right
		/// * justify
        /// </summary>
        [DataMember(Name = "verticalAlign", EmitDefaultValue = false)]
        public string VerticalAlign { get; set; }

        /// <summary>
        /// Will wrap the cell content if set to true.
        /// </summary>
        [DataMember(Name = "wrap", EmitDefaultValue = false)]
        public bool? Wrap { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Background != null)
            {
                settings["background"] = Background;
            }

            if (Color != null)
            {
                settings["color"] = Color;
            }

            if (FontFamily != null)
            {
                settings["fontFamily"] = FontFamily;
            }

            if (FontSize != null)
            {
                settings["fontSize"] = FontSize;
            }

            if (Italic != null)
            {
                settings["italic"] = Italic;
            }

            if (Bold != null)
            {
                settings["bold"] = Bold;
            }

            if (Enable != null)
            {
                settings["enable"] = Enable;
            }

            if (Format != null)
            {
                settings["format"] = Format;
            }

            if (Formula != null)
            {
                settings["formula"] = Formula;
            }

            if (Index != null)
            {
                settings["index"] = Index;
            }

            if (TextAlign != null)
            {
                settings["textAlign"] = TextAlign;
            }

            if (Underline != null)
            {
                settings["underline"] = Underline;
            }

            if (Value != null)
            {
                settings["value"] = Value;
            }

            if (VerticalAlign != null)
            {
                settings["verticalAlign"] = VerticalAlign;
            }

            if (Wrap != null)
            {
                settings["wrap"] = Wrap;
            }

            return settings;
        }
    }
}
