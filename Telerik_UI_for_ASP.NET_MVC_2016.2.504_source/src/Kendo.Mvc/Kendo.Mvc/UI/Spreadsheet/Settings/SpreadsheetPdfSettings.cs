namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetPdfSettings : JsonObject
    {
        public SpreadsheetPdfSettings()
        {
            //>> Initialization
        
            Margin = new SpreadsheetPdfMarginSettings();
                
        //<< Initialization
        }

        //>> Fields
        
        public string Area { get; set; }
        
        public string Author { get; set; }
        
        public string Creator { get; set; }
        
        public DateTime? Date { get; set; }
        
        public string FileName { get; set; }
        
        public bool? FitWidth { get; set; }
        
        public bool? ForceProxy { get; set; }
        
        public bool? Guidelines { get; set; }
        
        public bool? HCenter { get; set; }
        
        public string Keywords { get; set; }
        
        public bool? Landscape { get; set; }
        
        public SpreadsheetPdfMarginSettings Margin
        {
            get;
            set;
        }
        
        public string PaperSize { get; set; }
        
        public string ProxyURL { get; set; }
        
        public string ProxyTarget { get; set; }
        
        public string Subject { get; set; }
        
        public string Title { get; set; }
        
        public bool? VCenter { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Area.HasValue())
            {
                json["area"] = Area;
            }
            
            if (Author.HasValue())
            {
                json["author"] = Author;
            }
            
            if (Creator.HasValue())
            {
                json["creator"] = Creator;
            }
            
            if (Date.HasValue)
            {
                json["date"] = Date;
            }
                
            if (FileName.HasValue())
            {
                json["fileName"] = FileName;
            }
            
            if (FitWidth.HasValue)
            {
                json["fitWidth"] = FitWidth;
            }
                
            if (ForceProxy.HasValue)
            {
                json["forceProxy"] = ForceProxy;
            }
                
            if (Guidelines.HasValue)
            {
                json["guidelines"] = Guidelines;
            }
                
            if (HCenter.HasValue)
            {
                json["hCenter"] = HCenter;
            }
                
            if (Keywords.HasValue())
            {
                json["keywords"] = Keywords;
            }
            
            if (Landscape.HasValue)
            {
                json["landscape"] = Landscape;
            }
                
            var margin = Margin.ToJson();
            if (margin.Any())
            {
                json["margin"] = margin;
            }
            if (PaperSize.HasValue())
            {
                json["paperSize"] = PaperSize;
            }
            
            if (ProxyURL.HasValue())
            {
                json["proxyURL"] = ProxyURL;
            }
            
            if (ProxyTarget.HasValue())
            {
                json["proxyTarget"] = ProxyTarget;
            }
            
            if (Subject.HasValue())
            {
                json["subject"] = Subject;
            }
            
            if (Title.HasValue())
            {
                json["title"] = Title;
            }
            
            if (VCenter.HasValue)
            {
                json["vCenter"] = VCenter;
            }
                
        //<< Serialization
        }
    }
}
