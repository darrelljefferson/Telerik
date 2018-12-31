namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionEndCapSettings settings.
    /// </summary>
    public class DiagramConnectionEndCapSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionEndCapSettings container;

        public DiagramConnectionEndCapSettingsBuilder(DiagramConnectionEndCapSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection end cap fill options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the fill.</param>
        public DiagramConnectionEndCapSettingsBuilder<TShapeModel,TConnectionModel> Fill(Action<DiagramConnectionEndCapFillSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionEndCapFillSettingsBuilder<TShapeModel,TConnectionModel>(container.Fill));
            return this;
        }
        
        /// <summary>
        /// The connection end cap stroke options or color.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramConnectionEndCapSettingsBuilder<TShapeModel,TConnectionModel> Stroke(Action<DiagramConnectionEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramConnectionEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>(container.Stroke));
            return this;
        }
        
        /// <summary>
        /// The connection end cap type.The supported values are:Note that you can also use the "ArrowStart" for the endCap but its direction will be inversed.
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramConnectionEndCapSettingsBuilder<TShapeModel,TConnectionModel> Type(string value)
        {
            container.Type = value;

            return this;
        }
        
        //<< Fields
    }
}

