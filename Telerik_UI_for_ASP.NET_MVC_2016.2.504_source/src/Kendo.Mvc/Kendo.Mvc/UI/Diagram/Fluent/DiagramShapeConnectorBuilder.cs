namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramShapeConnector settings.
    /// </summary>
    public class DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramShapeConnector container;

        public DiagramShapeConnectorBuilder(DiagramShapeConnector settings)
        {
            container = settings;
        }

        /// <summary>
        /// The connector description.
        /// </summary>
        /// <param name="value">The value that configures the description.</param>
        public DiagramShapeConnectorBuilder<TShapeModel,TConnectionModel> Description(string value)
        {
            container.Description = value;

            return this;
        }
        
        /// <summary>
        /// The connector name. Predefined names include:
        /// </summary>
        /// <param name="value">The value that configures the name.</param>
        public DiagramShapeConnectorBuilder<TShapeModel,TConnectionModel> Name(string value)
        {
            container.Name = value;

            return this;
        }

        /// <summary>
        /// Defines the name of the JavaScript function that positions the connector.
        /// </summary>
        /// <param name="value">The name of the function that positions the connector.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Position(string value)
        {
            container.Position = new ClientHandlerDescriptor
            {
                HandlerName = value
            };

            return this;
        }
        
        /// <summary>
        /// Defines the inline handler that positions the connector.
        /// </summary>
        /// <param name="handler">The inline handler that positions the connector.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Position(Func<object, object> handler)
        {
            container.Position = new ClientHandlerDescriptor
            {
                TemplateDelegate = handler
            };

            return this;
        }

        /// <summary>
        /// The connector width.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Width(double value)
        {
            container.Width = value;

            return this;
        }

        /// <summary>
        /// The connector height.
        /// </summary>
        /// <param name="value">The value that configures the height.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Height(double value)
        {
            container.Height = value;

            return this;
        }

        /// <summary>
        /// Connector's fill options.
        /// </summary>
        /// <param name="configurator">The action that configures the fill.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Fill(Action<DiagramFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
        {
            configurator(new DiagramFillSettingsBuilder<TShapeModel, TConnectionModel>(container.Fill));
            return this;
        }

        /// <summary>
        /// Connector's stroke options.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Stroke(Action<DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
        {
            configurator(new DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel>(container.Stroke));
            return this;
        }

        /// <summary>
        /// Connector's hover options.
        /// </summary>
        /// <param name="configurator">The action that configures the hover.</param>
        public DiagramShapeConnectorBuilder<TShapeModel, TConnectionModel> Hover(Action<DiagramHoverSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
        {
            configurator(new DiagramHoverSettingsBuilder<TShapeModel, TConnectionModel>(container.Hover));
            return this;
        }
    }
}

