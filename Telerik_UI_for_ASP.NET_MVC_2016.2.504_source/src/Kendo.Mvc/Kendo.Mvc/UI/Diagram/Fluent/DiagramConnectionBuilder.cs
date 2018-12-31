namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnection settings.
    /// </summary>
    public class DiagramConnectionBuilder<TShapeModel, TConnectionModel>: IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramConnection container;

        public DiagramConnectionBuilder(DiagramConnection settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Defines the shapes content settings.
        /// </summary>
        /// <param name="configurator">The action that configures the content.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Content(Action<DiagramConnectionContentSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionContentSettingsBuilder<TShapeModel,TConnectionModel>(container.Content));
            return this;
        }
        

        /// <summary>
        /// Defines the shape editable options.
        /// </summary>
        /// <param name="enabled">Enables or disables the editable option.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Editable(bool enabled)
        {
            container.Editable.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// Defines the shape editable options.
        /// </summary>
        /// <param name="configurator">The action that configures the editable.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Editable(Action<DiagramConnectionEditableSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            container.Editable.Enabled = true;
            
            configurator(new DiagramConnectionEditableSettingsBuilder<TShapeModel,TConnectionModel>(container.Editable));
            return this;
        }

        /// <summary>
        /// The connection end cap type.
        /// </summary>
        /// <param name="type">The end cap type.</param>
        public DiagramConnectionBuilder<TShapeModel, TConnectionModel> EndCap(string type)
        {
            container.EndCap.Type = type;
            return this;
        }

        /// <summary>
        /// The connection end cap configuration or type name.
        /// </summary>
        /// <param name="configurator">The action that configures the endcap.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> EndCap(Action<DiagramConnectionEndCapSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionEndCapSettingsBuilder<TShapeModel,TConnectionModel>(container.EndCap));
            return this;
        }
        
        /// <summary>
        /// Defines the source of the connection.
        /// </summary>
        /// <param name="configurator">The action that configures the from.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> From(Action<DiagramConnectionFromSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionFromSettingsBuilder<TShapeModel,TConnectionModel>(container.From));
            return this;
        }
        
        /// <summary>
        /// Defines the hover configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the hover.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Hover(Action<DiagramConnectionHoverSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionHoverSettingsBuilder<TShapeModel,TConnectionModel>(container.Hover));
            return this;
        }
        
        /// <summary>
        /// Sets the intermediate points (in global coordinates) of the connection. It's important to note that currently these points cannot be manipulated in the interface.
        /// </summary>
        /// <param name="configurator">The action that configures the points.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Points(Action<DiagramConnectionPointFactory<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionPointFactory<TShapeModel,TConnectionModel>(container.Points));
            return this;
        }
        
        /// <summary>
        /// Defines the connection selection configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the selection.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Selection(Action<DiagramConnectionSelectionSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionSelectionSettingsBuilder<TShapeModel,TConnectionModel>(container.Selection));
            return this;
        }

        /// <summary>
        /// The connection start cap type.
        /// </summary>
        /// <param name="type">The start cap type.</param>
        public DiagramConnectionBuilder<TShapeModel, TConnectionModel> StartCap(string type)
        {
            container.StartCap.Type = type;
            return this;
        }
        
        /// <summary>
        /// The connection start cap configuration or type name.
        /// </summary>
        /// <param name="configurator">The action that configures the startcap.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> StartCap(Action<DiagramConnectionStartCapSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionStartCapSettingsBuilder<TShapeModel,TConnectionModel>(container.StartCap));
            return this;
        }
        
        /// <summary>
        /// Defines the stroke configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> Stroke(Action<DiagramConnectionStrokeSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionStrokeSettingsBuilder<TShapeModel,TConnectionModel>(container.Stroke));
            return this;
        }
        
        /// <summary>
        /// Defines the connection to.
        /// </summary>
        /// <param name="configurator">The action that configures the to.</param>
        public DiagramConnectionBuilder<TShapeModel,TConnectionModel> To(Action<DiagramConnectionToSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionToSettingsBuilder<TShapeModel,TConnectionModel>(container.To));
            return this;
        }

        /// <summary>
        /// The connection type.
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramConnectionBuilder<TShapeModel, TConnectionModel> Type(DiagramConnectionType value)
        {
            container.Type = value;

            return this;
        }

        /// <summary>
        /// The default source connector.
        /// </summary>
        /// <param name="value">The value that configures the default source connector.</param>
        public DiagramConnectionBuilder<TShapeModel, TConnectionModel> FromConnector(string value)
        {
            container.FromConnector = value;

            return this;
        }

        /// <summary>
        /// The default target connector.
        /// </summary>
        /// <param name="value">The value that configures the default target connector.</param>
        public DiagramConnectionBuilder<TShapeModel, TConnectionModel> ToConnector(string value)
        {
            container.ToConnector = value;

            return this;
        }
        
        //<< Fields
    }
}

