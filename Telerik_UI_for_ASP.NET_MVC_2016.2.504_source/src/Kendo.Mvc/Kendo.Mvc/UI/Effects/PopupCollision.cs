namespace Kendo.Mvc.UI
{
    using Kendo.Mvc.Extensions;
    using System.Collections.Generic;
    using System.Linq;

    public class PopupCollision : JsonObject
    {
        public PopupCollision()
        {
            Enabled = true;
            Collision = "";
        }

        public bool Enabled
        { 
            get; 
            set; 
        }

        public string Collision
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (!Enabled)
            {
                json["popupCollision"] = false;
            }
            else if (!string.IsNullOrEmpty(Collision))
            {
                json["popupCollision"] = Collision;
            }
        }
    }
}
