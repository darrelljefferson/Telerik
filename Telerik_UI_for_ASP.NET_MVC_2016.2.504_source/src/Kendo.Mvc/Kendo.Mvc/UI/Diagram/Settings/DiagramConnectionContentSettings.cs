namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramConnectionContentSettings : JsonObject
    {
        public DiagramConnectionContentSettings()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public string Template { get; set; }

        public string TemplateId { get; set; }
        
        public string Text { get; set; }

        public string Color { get; set; }

        public string FontFamily { get; set; }

        public double? FontSize { get; set; }

        public string FontStyle { get; set; }

        public string FontWeight { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (!string.IsNullOrEmpty(TemplateId))
            {
                json["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()",
                        TemplateId
                    )
                };
            }
            else if (!string.IsNullOrEmpty(Template))
            {
                json["template"] = Template;
            }
                
            if (Text.HasValue())
            {
                json["text"] = Text;
            }

            if (Visual != null)
            {
                json["visual"] = Visual;
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

            if (FontStyle.HasValue())
            {
                json["fontStyle"] = FontStyle;
            }

            if (FontWeight.HasValue())
            {
                json["fontWeight"] = FontWeight;
            }
            
        //<< Serialization
        }
    }
}
