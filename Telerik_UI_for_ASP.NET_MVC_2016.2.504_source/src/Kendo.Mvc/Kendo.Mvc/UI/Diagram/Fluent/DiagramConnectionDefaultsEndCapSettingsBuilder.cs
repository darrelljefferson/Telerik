namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionDefaultsEndCapSettings settings.
    /// </summary>
    public class DiagramConnectionDefaultsEndCapSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionDefaultsEndCapSettings container;

        public DiagramConnectionDefaultsEndCapSettingsBuilder(DiagramConnectionDefaultsEndCapSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection end cap fill options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the fill.</param>
        public DiagramConnectionDefaultsEndCapSettingsBuilder<TShapeModel,TConnectionModel> Fill(Action<DiagramConnectionDefaultsEndCapFillSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionDefaultsEndCapFillSettingsBuilder<TShapeModel,TConnectionModel>(container.Fill));
            return this;
        }
        
        /// <summary>
        /// The connection end cap stroke options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramConnectionDefaultsEndCapSettingsBuilder<TShapeModel,TConnectionModel> Stroke(Action<DiagramConnectionDefaultsEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionDefaultsEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>(container.Stroke));
            return this;
        }
        
        /// <summary>
        /// The connection end cap type.The supported values are:
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramConnectionDefaultsEndCapSettingsBuilder<TShapeModel,TConnectionModel> Type(string value)
        {
            container.Type = value;

            return this;
        }
        
        //<< Fields
    }
}

