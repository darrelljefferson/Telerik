namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionDefaultsStartCapFillSettings settings.
    /// </summary>
    public class DiagramConnectionDefaultsStartCapFillSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionDefaultsStartCapFillSettings container;

        public DiagramConnectionDefaultsStartCapFillSettingsBuilder(DiagramConnectionDefaultsStartCapFillSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection start cap fill color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionDefaultsStartCapFillSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        //<< Fields
    }
}

