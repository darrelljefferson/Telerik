namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionContentSettings settings.
    /// </summary>
    public class DiagramConnectionContentSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionContentSettings container;

        public DiagramConnectionContentSettingsBuilder(DiagramConnectionContentSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value that configures the template.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel,TConnectionModel> Template(string value)
        {
            container.Template = value;

            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value that configures the template.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel,TConnectionModel> TemplateId(string value)
        {
            container.TemplateId = value;

            return this;
        }
        
        /// <summary>
        /// The text displayed for the connection.
        /// </summary>
        /// <param name="value">The value that configures the text.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel,TConnectionModel> Text(string value)
        {
            container.Text = value;

            return this;
        }

        /// <summary>
        /// The name of the function that will create the content visual.
        /// </summary>
        /// <param name="name">The function name.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Visual(string name)
        {
            container.Visual = new ClientHandlerDescriptor
                {
                    HandlerName = name
                };

            return this;
        }

        /// <summary>
        /// The function that will create the content visual.
        /// </summary>
        /// <param name="function">The function.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Visual(Func<object, object> function)
        {
            container.Visual = new ClientHandlerDescriptor
            {
                TemplateDelegate = function
            };

            return this;
        }

        /// <summary>
        /// The color of the connection content text.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }

        /// <summary>
        /// The font family of the connection content text.
        /// </summary>
        /// <param name="value">The value that configures the fontfamily.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontFamily(string value)
        {
            container.FontFamily = value;

            return this;
        }

        /// <summary>
        /// The font size of the connection content text.
        /// </summary>
        /// <param name="value">The value that configures the fontsize.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontSize(double value)
        {
            container.FontSize = value;

            return this;
        }

        /// <summary>
        /// The font style of the connection content text.
        /// </summary>
        /// <param name="value">The value that configures the font style.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontStyle(string value)
        {
            container.FontStyle = value;

            return this;
        }

        /// <summary>
        /// The font weight of the connection content text.
        /// </summary>
        /// <param name="value">The value that configures the font weight.</param>
        public DiagramConnectionContentSettingsBuilder<TShapeModel, TConnectionModel> FontWeight(string value)
        {
            container.FontWeight = value;

            return this;
        }

        
        //<< Fields
    }
}

