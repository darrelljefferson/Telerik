namespace Kendo.Mvc.UI.Fluent
{
    public class DiagramFillSettingsBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramFillSettings container;

        public DiagramFillSettingsBuilder(DiagramFillSettings settings)
        {
            container = settings;
        }
        
        /// <summary>
        /// Defines the fill color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramFillSettingsBuilder<TShapeModel, TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }

        /// <summary>
        /// Defines the fill opacity.
        /// </summary>
        /// <param name="value">The value that configures the opacity.</param>
        public DiagramFillSettingsBuilder<TShapeModel, TConnectionModel> Opacity(double value)
        {
            container.Opacity = value;

            return this;
        }
    }
}
