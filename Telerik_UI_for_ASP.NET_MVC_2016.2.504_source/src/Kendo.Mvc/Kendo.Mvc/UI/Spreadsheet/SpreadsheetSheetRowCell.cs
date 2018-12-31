namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetRowCell : JsonObject
    {
        public SpreadsheetSheetRowCell()
        {
            //>> Initialization
        
            Validation = new SpreadsheetSheetRowCellValidationSettings();
                
        //<< Initialization
            BorderBottom = new SpreadsheetBorderStyle();

            BorderLeft = new SpreadsheetBorderStyle();

            BorderRight = new SpreadsheetBorderStyle();

            BorderTop = new SpreadsheetBorderStyle();
        }

        //>> Fields
        
        public string Background { get; set; }
        
        public string Color { get; set; }
        
        public string FontFamily { get; set; }
        
        public double? FontSize { get; set; }
        
        public bool? Italic { get; set; }
        
        public bool? Bold { get; set; }
        
        public bool? Enable { get; set; }
        
        public string Format { get; set; }
        
        public string Formula { get; set; }
        
        public int? Index { get; set; }
        
        public string Link { get; set; }
        
        public bool? Underline { get; set; }
        
        public SpreadsheetSheetRowCellValidationSettings Validation
        {
            get;
            set;
        }
        
        public bool? Wrap { get; set; }
        
        public SpreadsheetTextAlign? TextAlign { get; set; }
        
        public SpreadsheetVerticalAlign? VerticalAlign { get; set; }
        
        //<< Fields

        public object Value { get; set; }

        public SpreadsheetBorderStyle BorderBottom { get; set; }

        public SpreadsheetBorderStyle BorderLeft { get; set; }

        public SpreadsheetBorderStyle BorderTop { get; set; }

        public SpreadsheetBorderStyle BorderRight { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Background.HasValue())
            {
                json["background"] = Background;
            }
            
            if (Color.HasValue())
            {
                json["color"] = Color;
            }
            
            if (FontFamily.HasValue())
            {
                json["fontFamily"] = FontFamily;
            }
            
            if (FontSize.HasValue)
            {
                json["fontSize"] = FontSize;
            }
                
            if (Italic.HasValue)
            {
                json["italic"] = Italic;
            }
                
            if (Bold.HasValue)
            {
                json["bold"] = Bold;
            }
                
            if (Enable.HasValue)
            {
                json["enable"] = Enable;
            }
                
            if (Format.HasValue())
            {
                json["format"] = Format;
            }
            
            if (Formula.HasValue())
            {
                json["formula"] = Formula;
            }
            
            if (Index.HasValue)
            {
                json["index"] = Index;
            }
                
            if (Link.HasValue())
            {
                json["link"] = Link;
            }
            
            if (Underline.HasValue)
            {
                json["underline"] = Underline;
            }
                
            var validation = Validation.ToJson();
            if (validation.Any())
            {
                json["validation"] = validation;
            }
            if (Wrap.HasValue)
            {
                json["wrap"] = Wrap;
            }
                
            if (TextAlign.HasValue)
            {
                json["textAlign"] = TextAlign;
            }
                
            if (VerticalAlign.HasValue)
            {
                json["verticalAlign"] = VerticalAlign;
            }
                
        //<< Serialization

            if (Value != null)
            {
                json["value"] = Value;
            }

            var borderBottom = BorderBottom.ToJson();
            if (borderBottom.Any())
            {
                json["borderBottom"] = borderBottom;
            }

            var borderTop = BorderTop.ToJson();
            if (borderTop.Any())
            {
                json["borderTop"] = borderTop;
            }

            var borderLeft = BorderLeft.ToJson();
            if (borderLeft.Any())
            {
                json["borderLeft"] = borderLeft;
            }

            var borderRight = BorderRight.ToJson();
            if (borderRight.Any())
            {
                json["borderRight"] = borderRight;
            }
        }
    }
}
