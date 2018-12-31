namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramConnectionToSettings settings.
    /// </summary>
    public class DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramConnectionToSettings container;

        public DiagramConnectionToSettingsBuilder(DiagramConnectionToSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// Defines the point x value.
        /// </summary>
        /// <param name="value">The value that configures the x.</param>
        public DiagramConnectionToSettingsBuilder<TShapeModel,TConnectionModel> X(double value)
        {
            container.X = value;

            return this;
        }
        
        /// <summary>
        /// Defines the point y value.
        /// </summary>
        /// <param name="value">The value that configures the y.</param>
        public DiagramConnectionToSettingsBuilder<TShapeModel,TConnectionModel> Y(double value)
        {
            container.Y = value;

            return this;
        }

        /// <summary>
        /// Defines the target shape Id.
        /// </summary>
        /// <param name="value">The value that configures the target shape id.</param>
        public DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel> Id(object value)
        {
            container.Id = value;

            return this;
        }

        /// <summary>
        /// Defines the name of the target shape connector.
        /// </summary>
        /// <param name="value">The value that configures the target shape connector name.</param>
        public DiagramConnectionToSettingsBuilder<TShapeModel, TConnectionModel> Connector(string value)
        {
            container.Connector = value;

            return this;
        }
        
        //<< Fields
    }
}

