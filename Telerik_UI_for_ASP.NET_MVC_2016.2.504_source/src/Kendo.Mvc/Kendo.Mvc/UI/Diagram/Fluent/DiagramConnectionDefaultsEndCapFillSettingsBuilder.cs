namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionDefaultsEndCapFillSettings settings.
    /// </summary>
    public class DiagramConnectionDefaultsEndCapFillSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionDefaultsEndCapFillSettings container;

        public DiagramConnectionDefaultsEndCapFillSettingsBuilder(DiagramConnectionDefaultsEndCapFillSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection end cap fill color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionDefaultsEndCapFillSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        //<< Fields
    }
}

