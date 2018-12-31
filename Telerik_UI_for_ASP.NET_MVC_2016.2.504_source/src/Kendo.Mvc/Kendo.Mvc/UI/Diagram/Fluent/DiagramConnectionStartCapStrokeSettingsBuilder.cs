namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionStartCapStrokeSettings settings.
    /// </summary>
    public class DiagramConnectionStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionStartCapStrokeSettings container;

        public DiagramConnectionStartCapStrokeSettingsBuilder(DiagramConnectionStartCapStrokeSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection start cap stroke color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        /// <summary>
        /// The connection start cap stroke dash type.
        /// </summary>
        /// <param name="value">The value that configures the dashtype.</param>
        public DiagramConnectionStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> DashType(string value)
        {
            container.DashType = value;

            return this;
        }
        
        /// <summary>
        /// The connection start cap stroke width.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public DiagramConnectionStartCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> Width(double value)
        {
            container.Width = value;

            return this;
        }
        
        //<< Fields
    }
}

