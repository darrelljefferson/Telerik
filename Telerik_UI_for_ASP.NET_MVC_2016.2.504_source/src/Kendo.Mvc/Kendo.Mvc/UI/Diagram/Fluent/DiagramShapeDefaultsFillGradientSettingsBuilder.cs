namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramShapeDefaultsFillGradientSettings settings.
    /// </summary>
    public class DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramShapeDefaultsFillGradientSettings container;

        public DiagramShapeDefaultsFillGradientSettingsBuilder(DiagramShapeDefaultsFillGradientSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The type of the gradient. Supported values are:Note that support for radial gradients in VML (IE8 and below) is limited.
		/// Not all configurations are guaranteed to work.
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel> Type(string value)
        {
            container.Type = value;

            return this;
        }
        
        /// <summary>
        /// The center of the radial gradient.Coordinates are relative to the shape bounding box.
		/// For example [0, 0] is top left and [1, 1] is bottom right.
        /// </summary>
        /// <param name="value">The value that configures the center.</param>
        public DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel> Center(params double[] value)
        {
            container.Center = value;

            return this;
        }
        
        /// <summary>
        /// The radius of the radial gradient relative to the shape bounding box.
        /// </summary>
        /// <param name="value">The value that configures the radius.</param>
        public DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel> Radius(double value)
        {
            container.Radius = value;

            return this;
        }
        
        /// <summary>
        /// The start point of the linear gradient.Coordinates are relative to the shape bounding box.
		/// For example [0, 0] is top left and [1, 1] is bottom right.
        /// </summary>
        /// <param name="value">The value that configures the start.</param>
        public DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel> Start(params double[] value)
        {
            container.Start = value;

            return this;
        }
        
        /// <summary>
        /// The end point of the linear gradient.Coordinates are relative to the shape bounding box.
		/// For example [0, 0] is top left and [1, 1] is bottom right.
        /// </summary>
        /// <param name="value">The value that configures the end.</param>
        public DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel> End(params double[] value)
        {
            container.End = value;

            return this;
        }
        
        /// <summary>
        /// The array of gradient color stops.
        /// </summary>
        /// <param name="configurator">The action that configures the stops.</param>
        public DiagramShapeDefaultsFillGradientSettingsBuilder<TShapeModel,TConnectionModel> Stops(Action<DiagramShapeDefaultsFillGradientSettingsStopFactory<TShapeModel,TConnectionModel>> configurator)
        {
            configurator(new DiagramShapeDefaultsFillGradientSettingsStopFactory<TShapeModel,TConnectionModel>(container.Stops));
            return this;
        }
        
        //<< Fields
    }
}

