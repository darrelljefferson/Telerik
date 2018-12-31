namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionDefaultsEditableSettingsTool settings.
    /// </summary>
    public class DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramConnectionDefaultsEditableSettingsTool container;

        public DiagramConnectionDefaultsEditableSettingsToolBuilder(DiagramConnectionDefaultsEditableSettingsTool settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The name of the tool. The built-in tools are "edit" and "delete".
        /// </summary>
        /// <param name="value">The value that configures the name.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Name(string value)
        {
            container.Name = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the HTML attributes of a button.
        /// </summary>
        /// <param name="value">The value that configures the htmlattributes.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> HtmlAttributes(object value)
        {
            return this.HtmlAttributes(value.ToDictionary());
        }
        
        /// <summary>
        /// Specifies the HTML attributes of a button.
        /// </summary>
        /// <param name="value">The value that configures the htmlattributes.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> HtmlAttributes(IDictionary<string,object> value)
        {
            container.HtmlAttributes = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the buttons of ButtonGroup.
        /// </summary>
        /// <param name="configurator">The action that configures the buttons.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Buttons(Action<DiagramConnectionDefaultsEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionDefaultsEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel>(container.Buttons));
            return this;
        }
        
        /// <summary>
        /// Specifies the click event handler of the button. Applicable only for commands of type `button` and `splitButton`.
        /// </summary>
        /// <param name="value">The value that configures the click.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Click(string value)
        {
            container.Click = new ClientHandlerDescriptor
            {
                HandlerName = value
            };

            return this;
        }
        
        /// <summary>
        /// Specifies whether the control is initially enabled or disabled. Default value is "true".
        /// </summary>
        /// <param name="value">The value that configures the enable.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Enable(bool value)
        {
            container.Enable = value;

            return this;
        }
        
        /// <summary>
        /// Assigns the button to a group. Applicable only for buttons with togglable set to true.
        /// </summary>
        /// <param name="value">The value that configures the group.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Group(string value)
        {
            container.Group = value;

            return this;
        }
        
        /// <summary>
        /// Sets icon for the item. The icon should be one of the existing in the Kendo UI theme sprite.
        /// </summary>
        /// <param name="value">The value that configures the icon.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Icon(string value)
        {
            container.Icon = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the ID of the button.
        /// </summary>
        /// <param name="value">The value that configures the id.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Id(string value)
        {
            container.Id = value;

            return this;
        }
        
        /// <summary>
        /// If set, the ToolBar will render an image with the specified URL in the button.
        /// </summary>
        /// <param name="value">The value that configures the imageurl.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> ImageUrl(string value)
        {
            container.ImageUrl = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the menu buttons of a SplitButton.
        /// </summary>
        /// <param name="configurator">The action that configures the menubuttons.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> MenuButtons(Action<DiagramConnectionDefaultsEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionDefaultsEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel>(container.MenuButtons));
            return this;
        }
        
        /// <summary>
        /// Specifies how the button behaves when the ToolBar is resized. Possible values are "always", "never" or "auto" (default).
        /// </summary>
        /// <param name="value">The value that configures the overflow.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Overflow(string value)
        {
            container.Overflow = value;

            return this;
        }
        
        /// <summary>
        /// Specifies what element will be added in the command overflow popup. Applicable only for items that have a template.
        /// </summary>
        /// <param name="value">The value that configures the overflowtemplate.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> OverflowTemplate(string value)
        {
            container.OverflowTemplate = value;

            return this;
        }

        /// <summary>
        /// Specifies what element will be added in the command overflow popup. Applicable only for items that have a template.
        /// </summary>
        /// <param name="value">The value that configures the overflowtemplate.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> OverflowTemplateId(string value)
        {
            container.OverflowTemplateId = value;

            return this;
        }
        
        /// <summary>
        /// Specifies whether the button is primary. Primary buttons receive different styling.
        /// </summary>
        /// <param name="value">The value that configures the primary.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Primary(bool value)
        {
            container.Primary = value;

            return this;
        }
        
        /// <summary>
        /// Specifies if the toggle button is initially selected. Applicable only for buttons with togglable set to true.
        /// </summary>
        /// <param name="value">The value that configures the selected.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Selected(bool value)
        {
            container.Selected = value;

            return this;
        }
        
        /// <summary>
        /// Specifies where the button icon will be displayed. Possible values are "toolbar", "overflow" or "both" (default).
        /// </summary>
        /// <param name="value">The value that configures the showicon.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> ShowIcon(string value)
        {
            container.ShowIcon = value;

            return this;
        }
        
        /// <summary>
        /// Specifies where the text will be displayed. Possible values are "toolbar", "overflow" or "both" (default).
        /// </summary>
        /// <param name="value">The value that configures the showtext.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> ShowText(string value)
        {
            container.ShowText = value;

            return this;
        }
        
        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces) which will be used for button icon.
        /// </summary>
        /// <param name="value">The value that configures the spritecssclass.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> SpriteCssClass(string value)
        {
            container.SpriteCssClass = value;

            return this;
        }
        
        /// <summary>
        /// Specifies what element will be added in the ToolBar wrapper. Items with template does not have a type.
        /// </summary>
        /// <param name="value">The value that configures the template.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Template(string value)
        {
            container.Template = value;

            return this;
        }

        /// <summary>
        /// Specifies what element will be added in the ToolBar wrapper. Items with template does not have a type.
        /// </summary>
        /// <param name="value">The value that configures the template.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> TemplateId(string value)
        {
            container.TemplateId = value;

            return this;
        }
        
        /// <summary>
        /// Sets the text of the button.
        /// </summary>
        /// <param name="value">The value that configures the text.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Text(string value)
        {
            container.Text = value;

            return this;
        }
        
        /// <summary>
        /// Specifies if the button is togglable, e.g. has a selected and unselected state.
        /// </summary>
        /// <param name="value">The value that configures the togglable.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Togglable(bool value)
        {
            container.Togglable = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the toggle event handler of the button. Applicable only for commands of type `button` and togglable set to true.
        /// </summary>
        /// <param name="value">The value that configures the toggle.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Toggle(string value)
        {
            container.Toggle = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the command type. Supported types are "button", "splitButton", "buttonGroup", "separator".
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Type(string value)
        {
            container.Type = value;

            return this;
        }
        
        /// <summary>
        /// Specifies the url to navigate to.
        /// </summary>
        /// <param name="value">The value that configures the url.</param>
        public DiagramConnectionDefaultsEditableSettingsToolBuilder<TShapeModel,TConnectionModel> Url(string value)
        {
            container.Url = value;

            return this;
        }
        
        //<< Fields
    }
}

