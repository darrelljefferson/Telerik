namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the DiagramShapeDefaultsFillGradientSettingsStop settings.
    /// </summary>
    public class DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel>: IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly DiagramShapeDefaultsFillGradientSettingsStop container;

        public DiagramShapeDefaultsFillGradientSettingsStopBuilder(DiagramShapeDefaultsFillGradientSettingsStop settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The stop offset from the start of the element.
		/// Ranges from 0 (start of gradient) to 1 (end of gradient).
        /// </summary>
        /// <param name="value">The value that configures the offset.</param>
        public DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel> Offset(double value)
        {
            container.Offset = value;

            return this;
        }
        
        /// <summary>
        /// The color in any of the following formats.| Format         | Description
		/// | ---            | --- | ---
		/// | red            | Basic or Extended CSS Color name
		/// | #ff0000        | Hex RGB value
		/// | rgb(255, 0, 0) | RGB valueSpecifying 'none', 'transparent' or '' (empty string) will clear the fill.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        /// <summary>
        /// The fill opacity.
		/// Ranges from 0 (completely transparent) to 1 (completely opaque).
        /// </summary>
        /// <param name="value">The value that configures the opacity.</param>
        public DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel> Opacity(double value)
        {
            container.Opacity = value;

            return this;
        }
        
        //<< Fields
    }
}

