using System;
namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the hover settings.
    /// </summary>
    public class DiagramHoverSettingsBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramHoverSettings container;

        public DiagramHoverSettingsBuilder(DiagramHoverSettings settings)
        {
            container = settings;
        }

        /// <summary>
        /// Hover's fill options.
        /// </summary>
        /// <param name="configurator">The action that configures the fill.</param>
        public DiagramHoverSettingsBuilder<TShapeModel, TConnectionModel> Fill(Action<DiagramFillSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
        {
            configurator(new DiagramFillSettingsBuilder<TShapeModel, TConnectionModel>(container.Fill));
            return this;
        }

        /// <summary>
        /// Hover's stroke options.
        /// </summary>
        /// <param name="configurator">The action that configures the stroke.</param>
        public DiagramHoverSettingsBuilder<TShapeModel, TConnectionModel> Stroke(Action<DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
        {
            configurator(new DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel>(container.Stroke));
            return this;
        }

    }
}

