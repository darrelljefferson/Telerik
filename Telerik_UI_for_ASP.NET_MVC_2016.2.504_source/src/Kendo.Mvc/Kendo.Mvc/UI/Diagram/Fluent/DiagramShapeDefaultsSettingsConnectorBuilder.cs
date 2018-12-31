namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramShapeDefaultsSettingsConnector settings.
    /// </summary>
    public class DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramShapeDefaultsSettingsConnector container;

        public DiagramShapeDefaultsSettingsConnectorBuilder(DiagramShapeDefaultsSettingsConnector settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connector name.
        /// </summary>
        /// <param name="value">The value that configures the name.</param>
        public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel,TConnectionModel> Name(string value)
        {
            container.Name = value;

            return this;
        }
        
        /// <summary>
        /// Defines the name of the JavaScript function that positions the connector.
        /// </summary>
        /// <param name="value">The name of the function that positions the connector.</param>
        public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel,TConnectionModel> Position(string value)
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
        public DiagramShapeDefaultsSettingsConnectorBuilder<TShapeModel, TConnectionModel> Position(Func<object, object> handler)
        {
            container.Position = new ClientHandlerDescriptor
            {
                TemplateDelegate = handler
            };

            return this;
        }
        
        //<< Fields
    }
}

