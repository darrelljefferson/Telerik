namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionStartCapFillSettings settings.
    /// </summary>
    public class DiagramConnectionStartCapFillSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramConnectionStartCapFillSettings container;

        public DiagramConnectionStartCapFillSettingsBuilder(DiagramConnectionStartCapFillSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The connection start cap fill color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramConnectionStartCapFillSettingsBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        //<< Fields
    }
}

