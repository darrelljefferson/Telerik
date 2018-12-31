namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class TreeListColumnMenuMessagesSettings : JsonObject
    {
        public TreeListColumnMenuMessagesSettings()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public string Columns { get; set; }
        
        public string Filter { get; set; }
        
        public string SortAscending { get; set; }
        
        public string SortDescending { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Columns.HasValue())
            {
                json["columns"] = Columns;
            }
            
            if (Filter.HasValue())
            {
                json["filter"] = Filter;
            }
            
            if (SortAscending.HasValue())
            {
                json["sortAscending"] = SortAscending;
            }
            
            if (SortDescending.HasValue())
            {
                json["sortDescending"] = SortDescending;
            }
            
        //<< Serialization
        }
    }
}
