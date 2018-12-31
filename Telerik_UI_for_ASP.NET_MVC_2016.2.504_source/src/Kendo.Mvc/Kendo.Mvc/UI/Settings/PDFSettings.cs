using Kendo.Mvc.Extensions;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{    
    public class PDFSettings : JsonObject
    {
        public bool? AllPages { get; set; }

        public string ProxyURL { get; set; }

        public object AvoidLinks { get; set; }

        public string ProxyTarget { get; set; }

        public object PaperSize { get; set; }

        public string FileName { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Subject { get; set; }

        public string Keywords { get; set; }

        public string Creator { get; set; }

        public DateTime? Date { get; set; }

        public bool Landscape { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? RepeatHeaders { get; set; }

        public double? Scale { get; set; }

        public IDictionary<string, object> Margin { get; set; }

        public bool ForceProxy
        {
            get;
            set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (AllPages.HasValue)
            {
                json["allPages"] = AllPages;
            }

            if (AvoidLinks != null)
            {
                json["avoidLinks"] = AvoidLinks;
            }

            if (ProxyURL.HasValue())
            {
                json["proxyURL"] = ProxyURL;
            }

            if (ProxyTarget.HasValue())
            {
                json["proxyTarget"] = ProxyTarget;
            }

            if (FileName.HasValue())
            {
                json["fileName"] = FileName;
            }

            if (PaperSize != null)
            {
                json["paperSize"] = PaperSize;
            }

            if (Landscape)
            {
                json["landscape"] = Landscape;
            }

            if (Margin != null && Margin.Any())
            {
                json["margin"] = Margin;
            }

            if (Title.HasValue())
            {
                json["title"] = Title;
            }

            if (Author.HasValue())
            {
                json["author"] = Author;
            }

            if (Subject.HasValue())
            {
                json["subject"] = Subject;
            }

            if (Keywords.HasValue())
            {
                json["keywords"] = Keywords;
            }

            if (Creator.HasValue())
            {
                json["creator"] = Creator;
            }

            if (Date != null)
            {
                json["date"] = Date;
            }

            if (TemplateId.HasValue())
            {
                json["template"] = new ClientHandlerDescriptor
                {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()", TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                json["template"] = Template;
            }

            if (RepeatHeaders.HasValue)
            {
                json["repeatHeaders"] = RepeatHeaders;
            }

            if (Scale.HasValue)
            {
                json["scale"] = Scale;
            }

            if (ForceProxy)
            {
                json["forceProxy"] = true;
            }
        }
    }
}