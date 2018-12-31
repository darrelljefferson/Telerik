namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;

    public class DiagramStrokeSettings : JsonObject
    {        
        public string Color { get; set; }
        
        public string DashType { get; set; }
        
        public double? Width { get; set; }
                

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Color.HasValue())
            {
                json["color"] = Color;
            }
            
            if (DashType.HasValue())
            {
                json["dashType"] = DashType;
            }
            
            if (Width.HasValue)
            {
                json["width"] = Width;
            }
                
        //<< Serialization
        }
    }
}
