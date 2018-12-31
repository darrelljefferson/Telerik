namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;

    public class SchedulerFooterSettings : JsonObject
    {
        public SchedulerFooterSettings()
        {

        }

        public string Command { get; set; }

        public bool Enabled { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (!string.IsNullOrEmpty(Command))
            {
                json["command"] = Command;
            }
        }
    }
}
