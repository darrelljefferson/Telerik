namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class EditorPasteCleanupSettings : JsonObject
    {
        public EditorPasteCleanupSettings()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public bool? All { get; set; }
        
        public bool? Css { get; set; }
        
        public string Custom { get; set; }
        
        public bool? KeepNewLines { get; set; }
        
        public bool? MsAllFormatting { get; set; }
        
        public bool? MsConvertLists { get; set; }
        
        public bool? MsTags { get; set; }
        
        public bool? None { get; set; }
        
        public bool? Span { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (All.HasValue)
            {
                json["all"] = All;
            }
                
            if (Css.HasValue)
            {
                json["css"] = Css;
            }
                
            if (Custom.HasValue())
            {
                json["custom"] = Custom;
            }
            
            if (KeepNewLines.HasValue)
            {
                json["keepNewLines"] = KeepNewLines;
            }
                
            if (MsAllFormatting.HasValue)
            {
                json["msAllFormatting"] = MsAllFormatting;
            }
                
            if (MsConvertLists.HasValue)
            {
                json["msConvertLists"] = MsConvertLists;
            }
                
            if (MsTags.HasValue)
            {
                json["msTags"] = MsTags;
            }
                
            if (None.HasValue)
            {
                json["none"] = None;
            }
                
            if (Span.HasValue)
            {
                json["span"] = Span;
            }
                
        //<< Serialization
        }
    }
}
