namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramConnectionDefaultsSettings : JsonObject
    {
        public DiagramConnectionDefaultsSettings()
        {
            //>> Initialization
        
            Content = new DiagramConnectionDefaultsContentSettings();
                
            Editable = new DiagramConnectionDefaultsEditableSettings();
                
            EndCap = new DiagramConnectionDefaultsEndCapSettings();
                
            Hover = new DiagramConnectionDefaultsHoverSettings();
                
            Selection = new DiagramConnectionDefaultsSelectionSettings();
                
            StartCap = new DiagramConnectionDefaultsStartCapSettings();
                
            Stroke = new DiagramConnectionDefaultsStrokeSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public DiagramConnectionDefaultsContentSettings Content
        {
            get;
            set;
        }
        
        public DiagramConnectionDefaultsEditableSettings Editable
        {
            get;
            set;
        }
        
        public DiagramConnectionDefaultsEndCapSettings EndCap
        {
            get;
            set;
        }
        
        public DiagramConnectionDefaultsHoverSettings Hover
        {
            get;
            set;
        }
        
        public bool? Selectable { get; set; }
        
        public DiagramConnectionDefaultsSelectionSettings Selection
        {
            get;
            set;
        }
        
        public DiagramConnectionDefaultsStartCapSettings StartCap
        {
            get;
            set;
        }
        
        public DiagramConnectionDefaultsStrokeSettings Stroke
        {
            get;
            set;
        }
        
        public DiagramConnectionType? Type { get; set; }

        public string FromConnector { get; set; }

        public string ToConnector { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var content = Content.ToJson();
            if (content.Any())
            {
                json["content"] = content;
            }
            var editable = Editable.ToJson();
            if (editable.Any())
            {
                json["editable"] = editable;
            } else if (Editable.Enabled != true) {
                json["editable"] = Editable.Enabled;
            }

            var endCap = EndCap.ToJson();
            if (endCap.Any())
            {
                json["endCap"] = endCap;
            }
            var hover = Hover.ToJson();
            if (hover.Any())
            {
                json["hover"] = hover;
            }
            if (Selectable.HasValue)
            {
                json["selectable"] = Selectable;
            }
                
            var selection = Selection.ToJson();
            if (selection.Any())
            {
                json["selection"] = selection;
            }
            var startCap = StartCap.ToJson();
            if (startCap.Any())
            {
                json["startCap"] = startCap;
            }
            var stroke = Stroke.ToJson();
            if (stroke.Any())
            {
                json["stroke"] = stroke;
            }
            if (Type.HasValue)
            {
                json["type"] = Type;
            }

            if (!string.IsNullOrEmpty(FromConnector))
            {
                json["fromConnector"] = FromConnector;
            }

            if (!string.IsNullOrEmpty(ToConnector))
            {
                json["toConnector"] = ToConnector;
            }
                
        //<< Serialization
        }
    }
}
