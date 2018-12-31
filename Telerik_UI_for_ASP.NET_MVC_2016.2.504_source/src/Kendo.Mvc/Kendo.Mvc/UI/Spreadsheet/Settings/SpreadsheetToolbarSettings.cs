namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetToolbarSettings : JsonObject
    {
        public SpreadsheetToolbarSettings()
        {
            Enabled = true;
        
            //>> Initialization
        
        //<< Initialization
        }

        public bool Enabled { get; set; }

        //>> Fields
        
        public bool? Home { get; set; }
        
        public bool? Insert { get; set; }
        
        public bool? Data { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Home.HasValue)
            {
                json["home"] = Home;
            }
                
            if (Insert.HasValue)
            {
                json["insert"] = Insert;
            }
                
            if (Data.HasValue)
            {
                json["data"] = Data;
            }
                
        //<< Serialization
        }
    }
}
