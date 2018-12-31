namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramEditableDragSettings : JsonObject
    {
        public DiagramEditableDragSettings()
        {
            Enabled = true;
        
            //>> Initialization
        
            Snap = new DiagramEditableDragSnapSettings();
                
        //<< Initialization
        }

        public bool Enabled { get; set; }

        //>> Fields
        
        public DiagramEditableDragSnapSettings Snap
        {
            get;
            set;
        }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            var snap = Snap.ToJson();
            if (snap.Any())
            {
                json["snap"] = snap;
            } else if (Snap.Enabled != true) {
                json["snap"] = Snap.Enabled;
            }

        //<< Serialization
        }
    }
}
