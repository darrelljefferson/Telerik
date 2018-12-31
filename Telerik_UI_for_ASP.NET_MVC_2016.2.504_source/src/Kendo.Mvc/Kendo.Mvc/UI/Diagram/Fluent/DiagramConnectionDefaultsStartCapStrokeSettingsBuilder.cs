namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionDefaultsStartCapStrokeSettings settings.
    /// </summary>
    public class DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionDefaultsStartCapStrokeSettings container;

        public DiagramConnectionDefaultsStartCapStrokeSettingsBuilder(DiagramConnectionDefaultsStartCapStrokeSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection start cap stroke color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        /// <summary>
        /// The connection start cap stroke dash type.
        /// </summary>
        /// <param name="value">The value that configures the dashtype.</param>
        public DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> DashType(string value)
        {
            container.DashType = value;

            return this;
        }
        
        /// <summary>
        /// The connection start cap stroke width.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public DiagramConnectionDefaultsStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> Width(double value)
        {
            container.Width = value;

            return this;
        }
        
        //<< Fields
    }
}

