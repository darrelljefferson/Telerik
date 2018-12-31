namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.UI;
    using Kendo.Mvc.Infrastructure;
    using Kendo.Mvc.Extensions;

    public class ResponsivePanel : WidgetBase
    {
        private readonly IUrlGenerator urlGenerator;

        public ResponsivePanel(ViewContext viewContext, IJavaScriptInitializer initializer, IUrlGenerator urlGenerator)
            : base(viewContext, initializer)
        {
            this.urlGenerator = urlGenerator;

            Template = new HtmlTemplate();
//>> Initialization
        
        //<< Initialization
        }

//>> Fields
        
        public bool? AutoClose { get; set; }
        
        public double? Breakpoint { get; set; }
        
        public string Orientation { get; set; }
        
        public string ToggleButton { get; set; }
        
        //<< Fields

        public HtmlTemplate Template
        {
            get;
            private set;
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var json = new Dictionary<string, object>(Events);

//>> Serialization
        
            if (AutoClose.HasValue)
            {
                json["autoClose"] = AutoClose;
            }
                
            if (Breakpoint.HasValue)
            {
                json["breakpoint"] = Breakpoint;
            }
                
            if (Orientation.HasValue())
            {
                json["orientation"] = Orientation;
            }
            
            if (ToggleButton.HasValue())
            {
                json["toggleButton"] = ToggleButton;
            }
            
        //<< Serialization

            writer.Write(Initializer.Initialize(Selector, "ResponsivePanel", json));

            base.WriteInitializationScript(writer);
        }

        protected override void WriteHtml(HtmlTextWriter writer)
        {
            var html = new ResponsivePanelHtmlBuilder(this).Build();

            html.WriteTo(writer);

            base.WriteHtml(writer);
        }
    }
}

