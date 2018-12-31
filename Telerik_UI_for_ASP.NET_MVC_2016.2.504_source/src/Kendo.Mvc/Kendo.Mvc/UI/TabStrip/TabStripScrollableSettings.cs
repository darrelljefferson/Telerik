namespace Kendo.Mvc.UI
{    
    public class TabStripScrollableSettings : JsonObject
    {        
        public TabStripScrollableSettings()
        {
            Distance = 200;
            Enabled = true;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public int Distance
        {
            get;
            set;
        }

        protected override void Serialize(System.Collections.Generic.IDictionary<string, object> json)
        {
            json["enabled"] = Enabled;
            if (Distance > 0 && Distance != 200)
            {
                json["distance"] = Distance;
            }
        }
    }
}