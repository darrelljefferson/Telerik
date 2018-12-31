namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionEndCapStrokeSettings settings.
    /// </summary>
    public class DiagramConnectionEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionEndCapStrokeSettings container;

        public DiagramConnectionEndCapStrokeSettingsBuilder(DiagramConnectionEndCapStrokeSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection end cap stroke color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        /// <summary>
        /// The connection end cap stroke dash type.
        /// </summary>
        /// <param name="value">The value that configures the dashtype.</param>
        public DiagramConnectionEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> DashType(string value)
        {
            container.DashType = value;

            return this;
        }
        
        /// <summary>
        /// The connection end cap stroke width.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public DiagramConnectionEndCapStrokeSettingsBuilder<TShapeModel,TConnectionModel> Width(double value)
        {
            container.Width = value;

            return this;
        }
        
        //<< Fields
    }
}

