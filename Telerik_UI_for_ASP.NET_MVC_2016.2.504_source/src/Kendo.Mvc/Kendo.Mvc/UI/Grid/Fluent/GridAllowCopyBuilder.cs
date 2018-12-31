namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    ///  Defines the fluent interface for configuring <see cref="Grid{T}.Selectable"/>
    /// </summary>
    public class GridAllowCopyBuilder : IHideObjectMembers
    {
        private readonly AllowCopySettings settings;

        public GridAllowCopyBuilder(AllowCopySettings settings)
        {
            settings.Enabled = true;
            this.settings = settings;
        }

        /// <summary>
        /// Enables or disables AllowCopy.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .AllowCopy(config => config.Enabled((bool)ViewData["allowCopy"]))
        /// %&gt;
        /// </code>
        /// </example>
        /// <remarks>
        /// The Enabled method is useful when you need to enable scrolling based on certain conditions.
        /// </remarks>
        public GridAllowCopyBuilder Enabled(bool value)
        {
            settings.Enabled = value;

            return this;
        }

        /// <summary>
        /// Specifies whether multiple or single selection is allowed.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Selectable(selection => selection.Delimeter((bool)ViewData["selectionMode"]))
        /// %&gt;
        /// </code>
        /// </example>
        /// <remarks>
        /// The Mode method is useful to switch between different selection modes.
        /// </remarks>
        public GridAllowCopyBuilder Delimeter(string value)
        {
            settings.Delimeter = value;

            return this;
        }
      
    }
}
