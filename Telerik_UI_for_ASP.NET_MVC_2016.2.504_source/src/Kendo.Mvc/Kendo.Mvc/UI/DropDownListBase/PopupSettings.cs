namespace Kendo.Mvc.UI
{    
    using System.Collections.Generic;
    using System.Web.Script.Serialization;

    public class PopupSettings
    {
        public string AppendTo { get; set; }
        public string Origin { get; set; }
        public string Position { get; set; }

        public IDictionary<string, object> SeriailzeOptions()
        {
            var options = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(AppendTo))
            {
                options["appendTo"] = AppendTo;
            }

            if (!string.IsNullOrEmpty(Origin))
            {
                options["origin"] = Origin;
            }

            if (!string.IsNullOrEmpty(Position))
            {
                options["position"] = Position;
            }

            return options;
        }
    }
}