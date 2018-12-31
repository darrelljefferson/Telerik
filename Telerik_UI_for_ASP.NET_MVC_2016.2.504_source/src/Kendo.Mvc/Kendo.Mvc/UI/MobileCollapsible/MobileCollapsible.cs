namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.UI;
    using Kendo.Mvc.Infrastructure;

    public class MobileCollapsible : WidgetBase
    {
        private readonly IUrlGenerator urlGenerator;

        public MobileCollapsible(ViewContext viewContext, IJavaScriptInitializer initializer, IUrlGenerator urlGenerator)
            : base(viewContext, initializer)
        {
            this.urlGenerator = urlGenerator;

            Collapsed = true;
            Animation = true;
            Inset = false;

            Header = new HtmlTemplate();
            Content = new HtmlTemplate();
//>> Initialization
        
        //<< Initialization
        }

//>> Fields
        
        public bool Animation { get; set; }
        
        public bool Collapsed { get; set; }
        
        public string ExpandIcon { get; set; }
        
        public bool Inset { get; set; }
        
        //<< Fields

        public string CollapseIcon { get; set; }

        public IconPosition? IconPosition { get; set; }

        public HtmlTemplate Header
        {
            get;
            private set;
        }

        public HtmlTemplate Content
        {
            get;
            private set;
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            //no initializtion scripts for mobile widgets
        }

        
        protected override void WriteHtml(HtmlTextWriter writer)
        {
            var html = new MobileCollapsibleHtmlBuilder(this).Build();

            html.WriteTo(writer);

            //prevent rendering empty script tag
            //base.WriteHtml(writer);
        }
        
    }
}

