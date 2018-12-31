namespace Kendo.Mvc.UI.Fluent
{
    public class DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel> : IHideObjectMembers
        where TShapeModel : class
        where TConnectionModel : class
    {
        private readonly DiagramStrokeSettings container;

        public DiagramStrokeSettingsBuilder(DiagramStrokeSettings settings)
        {
            container = settings;
        }

        /// <summary>
        /// Defines the stroke color.
        /// </summary>
        /// <param name="value">The value that configures the color.</param>
        public DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel> Color(string value)
        {
            container.Color = value;

            return this;
        }
        
        /// <summary>
        /// The stroke dash type.
        /// </summary>
        /// <param name="value">The value that configures the dashtype.</param>
        public DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel> DashType(string value)
        {
            container.DashType = value;

            return this;
        }
        
        /// <summary>
        /// Defines the stroke stroke.
        /// </summary>
        /// <param name="value">The value that configures the width.</param>
        public DiagramStrokeSettingsBuilder<TShapeModel, TConnectionModel> Width(double value)
        {
            container.Width = value;

            return this;
        }
    }
}
