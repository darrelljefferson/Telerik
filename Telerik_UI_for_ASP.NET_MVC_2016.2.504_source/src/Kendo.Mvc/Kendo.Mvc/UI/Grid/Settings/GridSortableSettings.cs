namespace Kendo.Mvc.UI
{    
    public class AllowCopySettings : JsonObject
    {
        public AllowCopySettings()
        {
            Enabled = false;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public string Delimeter
        {
            get;
            set;
        }

        protected override void Serialize(System.Collections.Generic.IDictionary<string, object> json)
        {
            if (Delimeter != "\t")
            {
                json["delimeter"] = Delimeter;                
            }
        }
    }
}