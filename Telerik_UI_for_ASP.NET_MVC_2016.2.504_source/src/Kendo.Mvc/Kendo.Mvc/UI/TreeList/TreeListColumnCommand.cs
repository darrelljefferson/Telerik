namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class TreeListColumnCommand : JsonObject
    {
        public TreeListColumnCommand()
        {
            //>> Initialization
        
        //<< Initialization

            Click = new ClientHandlerDescriptor();
        }

        //>> Fields
        
        public string ClassName { get; set; }
        
        public ClientHandlerDescriptor Click { get; set; }
        
        public string Name { get; set; }
        
        public string Text { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (ClassName.HasValue())
            {
                json["className"] = ClassName;
            }
            
            if (Click.HasValue())
            {
                json["click"] = Click;
            }
            
            if (Name.HasValue())
            {
                json["name"] = Name;
            }
            
            if (Text.HasValue())
            {
                json["text"] = Text;
            }
            
        //<< Serialization
        }
    }
}
