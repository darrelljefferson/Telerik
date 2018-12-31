namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class TreeListColumnMenuSettings : JsonObject
    {
        public TreeListColumnMenuSettings()
        {
            Enabled = false;
        
            //>> Initialization
        
            Messages = new TreeListColumnMenuMessagesSettings();
                
        //<< Initialization
        }

        public bool Enabled { get; set; }

        //>> Fields
        
        public bool? Columns { get; set; }
        
        public bool? Filterable { get; set; }
        
        public bool? Sortable { get; set; }
        
        public TreeListColumnMenuMessagesSettings Messages
        {
            get;
            set;
        }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Columns.HasValue)
            {
                json["columns"] = Columns;
            }
                
            if (Filterable.HasValue)
            {
                json["filterable"] = Filterable;
            }
                
            if (Sortable.HasValue)
            {
                json["sortable"] = Sortable;
            }
                
            var messages = Messages.ToJson();
            if (messages.Any())
            {
                json["messages"] = messages;
            }
        //<< Serialization
        }
    }
}
