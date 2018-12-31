namespace Kendo.Mvc.UI
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.Extensions;

    public class DiagramShapeDefaultsEditableSettingsTool : JsonObject
    {
        public DiagramShapeDefaultsEditableSettingsTool()
        {
            HtmlAttributes = new Dictionary<string, object>();
            //>> Initialization
        
            Buttons = new List<DiagramShapeDefaultsEditableSettingsToolButton>();
                
            MenuButtons = new List<DiagramShapeDefaultsEditableSettingsToolMenuButton>();
                
        //<< Initialization
        }

        //>> Fields
        
        public string Name { get; set; }
        
        public double? Step { get; set; }
        
        public IDictionary<string,object> HtmlAttributes { get; set; }
        
        public List<DiagramShapeDefaultsEditableSettingsToolButton> Buttons
        {
            get;
            set;
        }

        public ClientHandlerDescriptor Click { get; set; }
        
        public bool? Enable { get; set; }
        
        public string Group { get; set; }
        
        public string Icon { get; set; }
        
        public string Id { get; set; }
        
        public string ImageUrl { get; set; }
        
        public List<DiagramShapeDefaultsEditableSettingsToolMenuButton> MenuButtons
        {
            get;
            set;
        }
        
        public string Overflow { get; set; }
        
        public string OverflowTemplate { get; set; }

        public string OverflowTemplateId { get; set; }
        
        public bool? Primary { get; set; }
        
        public bool? Selected { get; set; }
        
        public string ShowIcon { get; set; }
        
        public string ShowText { get; set; }
        
        public string SpriteCssClass { get; set; }
        
        public string Template { get; set; }

        public string TemplateId { get; set; }
        
        public string Text { get; set; }
        
        public bool? Togglable { get; set; }
        
        public string Toggle { get; set; }
        
        public string Type { get; set; }
        
        public string Url { get; set; }
        
        //<< Fields

        protected override void Serialize(IDictionary<string, object> json)
        {
            //>> Serialization
        
            if (Name.HasValue())
            {
                json["name"] = Name;
            }
            
            if (Step.HasValue)
            {
                json["step"] = Step;
            }
                
            if (HtmlAttributes.Any())
            {
                json["attributes"] = HtmlAttributes;
            }
            
            var buttons = Buttons.ToJson();
            if (buttons.Any())
            {
                json["buttons"] = buttons;
            }
            if (Click != null)
            {
                json["click"] = Click;
            }
            
            if (Enable.HasValue)
            {
                json["enable"] = Enable;
            }
                
            if (Group.HasValue())
            {
                json["group"] = Group;
            }
            
            if (Icon.HasValue())
            {
                json["icon"] = Icon;
            }
            
            if (Id.HasValue())
            {
                json["id"] = Id;
            }
            
            if (ImageUrl.HasValue())
            {
                json["imageUrl"] = ImageUrl;
            }
            
            var menuButtons = MenuButtons.ToJson();
            if (menuButtons.Any())
            {
                json["menuButtons"] = menuButtons;
            }
            if (Overflow.HasValue())
            {
                json["overflow"] = Overflow;
            }
            
            if (!string.IsNullOrEmpty(OverflowTemplateId))
            {
                json["overflowTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()",
                        OverflowTemplateId
                    )
                };
            }
            else if (!string.IsNullOrEmpty(OverflowTemplate))
            {
                json["overflowTemplate"] = OverflowTemplate;
            }
                
            if (Primary.HasValue)
            {
                json["primary"] = Primary;
            }
                
            if (Selected.HasValue)
            {
                json["selected"] = Selected;
            }
                
            if (ShowIcon.HasValue())
            {
                json["showIcon"] = ShowIcon;
            }
            
            if (ShowText.HasValue())
            {
                json["showText"] = ShowText;
            }
            
            if (SpriteCssClass.HasValue())
            {
                json["spriteCssClass"] = SpriteCssClass;
            }
            
            if (!string.IsNullOrEmpty(TemplateId))
            {
                json["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()",
                        TemplateId
                    )
                };
            }
            else if (!string.IsNullOrEmpty(Template))
            {
                json["template"] = Template;
            }
                
            if (Text.HasValue())
            {
                json["text"] = Text;
            }
            
            if (Togglable.HasValue)
            {
                json["togglable"] = Togglable;
            }
                
            if (Toggle.HasValue())
            {
                json["toggle"] = Toggle;
            }
            
            if (Type.HasValue())
            {
                json["type"] = Type;
            }
            
            if (Url.HasValue())
            {
                json["url"] = Url;
            }
            
        //<< Serialization
        }
    }
}
