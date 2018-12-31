namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramEditableDragSettings settings.
    /// </summary>
    public class DiagramEditableDragSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramEditableDragSettings container;

        public DiagramEditableDragSettingsBuilder(DiagramEditableDragSettings settings)
        {
            container = settings;
        }

        //>> Fields
        

        /// <summary>
        /// Specifies the shapes drag snap options.
        /// </summary>
        /// <param name="enabled">Enables or disables the snap option.</param>
        public DiagramEditableDragSettingsBuilder<TShapeModel,TConnectionModel> Snap(bool enabled)
        {
            container.Snap.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// Specifies the shapes drag snap options.
        /// </summary>
        /// <param name="configurator">The action that configures the snap.</param>
        public DiagramEditableDragSettingsBuilder<TShapeModel,TConnectionModel> Snap(Action<DiagramEditableDragSnapSettingsBuilder<TShapeModel,TConnectionModel>> configurator)
        {
            container.Snap.Enabled = true;
            
            configurator(new DiagramEditableDragSnapSettingsBuilder<TShapeModel,TConnectionModel>(container.Snap));
            return this;
        }
        
        //<< Fields
    }
}

