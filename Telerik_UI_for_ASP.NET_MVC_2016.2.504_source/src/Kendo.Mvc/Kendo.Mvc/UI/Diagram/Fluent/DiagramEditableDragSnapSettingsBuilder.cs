namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramEditableDragSnapSettings settings.
    /// </summary>
    public class DiagramEditableDragSnapSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramEditableDragSnapSettings container;

        public DiagramEditableDragSnapSettingsBuilder(DiagramEditableDragSnapSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Specifies the shapes drag snap size.
        /// </summary>
        /// <param name="value">The value that configures the size.</param>
        public DiagramEditableDragSnapSettingsBuilder<TShapeModel,TConnectionModel> Size(double value)
        {
            container.Size = value;

            return this;
        }
        
        //<< Fields
    }
}

