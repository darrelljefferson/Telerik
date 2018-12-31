namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionStartCapSettings settings.
    /// </summary>
    public class DiagramConnectionStartCapSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionStartCapSettings container;

        public DiagramConnectionStartCapSettingsBuilder(DiagramConnectionStartCapSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection start cap fill options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the fill.</param>
        public DiagramConnectionStartCapSettingsBuilder<TShapeModel,TConnectionModel> Fill(Action<DiagramConnectionStartCapFillSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionStartCapFillSettingsBuilder<TShapeModel,TConnectionModel>(container.Fill));
            return this;
        }
        
        /// <summary>
        /// The connection start cap stroke options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramConnectionStartCapSettingsBuilder<TShapeModel,TConnectionModel> Stroke(Action<DiagramConnectionStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>(container.Stroke));
            return this;
        }
        
        /// <summary>
        /// The connection start cap type.The supported values are:
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramConnectionStartCapSettingsBuilder<TShapeModel,TConnectionModel> Type(string value)
        {
            container.Type = value;

            return this;
        }
        
        //<< Fields
    }
}

