namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionEndCapFillSettings settings.
    /// </summary>
    public class DiagramConnectionEndCapFillSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionEndCapFillSettings container;

        public DiagramConnectionEndCapFillSettingsBuilder(DiagramConnectionEndCapFillSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection end cap fill color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionEndCapFillSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        //<< Fields
    }
}

