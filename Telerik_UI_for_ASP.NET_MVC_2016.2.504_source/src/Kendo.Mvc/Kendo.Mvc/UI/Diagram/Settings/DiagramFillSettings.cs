namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;

    public class DiagramFillSettings : JsonObject
    {
        public string Color { get; set; }

        public double? Opacity { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (Color.HasValue())
            {
                json["color"] = Color;
            }

            if (Opacity.HasValue)
            {
                json["opacity"] = Opacity;
            }
        }
    }
}
