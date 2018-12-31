namespace Kendo.Mvc.UI
{
    using Kendo.Mvc.Resources;
    using System;
    using System.Collections.Generic;

    public class GridNoRecordsSettings : JsonObject
    {
        private const string DefaultNoRecords = "Delete event";

        public GridNoRecordsSettings() 
        {
            NoRecordsMessage = Messages.Grid_NoRecords;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public bool IsNoRecordsMessageModified 
        {
            get
            {
                return NoRecordsMessage != DefaultNoRecords ? true : false;
            }
        }

        public string NoRecordsMessage { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        protected override void Serialize(IDictionary<string, object> json)
        {
            var idPrefix = "#";
            if (!string.IsNullOrEmpty(Template))
            {
                json["template"] = Template;
            }

            if (!string.IsNullOrEmpty(TemplateId))
            {
                json["template"] = new ClientHandlerDescriptor { HandlerName = String.Format("kendo.template(jQuery('{0}{1}').html())", idPrefix, TemplateId) };
            }
        }
    }
}
