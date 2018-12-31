namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramEditableResizeSettings : JsonObject
    {
        public DiagramEditableResizeSettings()
        {
            Enabled = true;
        
            //>> Initialization
        
            Handles = new DiagramEditableResizeHandlesSettings();
                
        //<< Initialization
        }

        public bool Enabled { get; set; }

        //>> Fields
        
        public DiagramEditableResizeHandlesSettings Handles
        {
            get;
            set;
        }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var handles = Handles.ToJson();
            if (handles.Any())
            {
                json["handles"] = handles;
            }
        //<< Serialization
        }
    }
}
