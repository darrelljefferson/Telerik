namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class SpreadsheetSheetRowCellValidationSettings : JsonObject
    {
        public SpreadsheetSheetRowCellValidationSettings()
        {
            //>> Initialization
        
        //<< Initialization
        }

        //>> Fields
        
        public string Type { get; set; }
        
        public string ComparerType { get; set; }
        
        public string DataType { get; set; }
        
        public string From { get; set; }
        
        public string To { get; set; }
        
        public bool? AllowNulls { get; set; }
        
        public string MessageTemplate { get; set; }

        public string MessageTemplateId { get; set; }
        
        public string TitleTemplate { get; set; }

        public string TitleTemplateId { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Type.HasValue())
            {
                json["type"] = Type;
            }
            
            if (ComparerType.HasValue())
            {
                json["comparerType"] = ComparerType;
            }
            
            if (DataType.HasValue())
            {
                json["dataType"] = DataType;
            }
            
            if (From.HasValue())
            {
                json["from"] = From;
            }
            
            if (To.HasValue())
            {
                json["to"] = To;
            }
            
            if (AllowNulls.HasValue)
            {
                json["allowNulls"] = AllowNulls;
            }
                
            if (!string.IsNullOrEmpty(MessageTemplateId))
            {
                json["messageTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()",
                        MessageTemplateId
                    )
                };
            }
            else if (!string.IsNullOrEmpty(MessageTemplate))
            {
                json["messageTemplate"] = MessageTemplate;
            }
                
            if (!string.IsNullOrEmpty(TitleTemplateId))
            {
                json["titleTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()",
                        TitleTemplateId
                    )
                };
            }
            else if (!string.IsNullOrEmpty(TitleTemplate))
            {
                json["titleTemplate"] = TitleTemplate;
            }
                
        //<< Serialization
        }
    }
}
