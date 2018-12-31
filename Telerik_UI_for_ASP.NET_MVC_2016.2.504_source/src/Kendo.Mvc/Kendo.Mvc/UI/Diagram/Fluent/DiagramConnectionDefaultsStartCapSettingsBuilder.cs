namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionDefaultsStartCapSettings settings.
    /// </summary>
    public class DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionDefaultsStartCapSettings container;

        public DiagramConnectionDefaultsStartCapSettingsBuilder(DiagramConnectionDefaultsStartCapSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection start cap fill options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the fill.</param>
        public DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel,TConnectionModel> Fill(Action<DiagramConnectionDefaultsStartCapFillSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionDefaultsStartCapFillSettingsBuilder<TShapeModel,TConnectionModel>(container.Fill));
            return this;
        }
        
        /// <summary>
        /// The connection start cap stroke options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel,TConnectionModel> Stroke(Action<DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>(container.Stroke));
            return this;
        }
        
        /// <summary>
        /// The connection start cap type.The supported values are:
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramConnectionDefaultsStartCapSettingsBuilder<TShapeModel,TConnectionModel> Type(string value)
        {
            container.Type = value;

            return this;
        }
        
        //<< Fields
    }
}

