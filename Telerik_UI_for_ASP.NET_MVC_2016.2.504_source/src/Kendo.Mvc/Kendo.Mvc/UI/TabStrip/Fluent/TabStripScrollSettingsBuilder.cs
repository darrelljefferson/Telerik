namespace Kendo.Mvc.UI.Fluent
{
    using Infrastructure;

    /// <summary>
    /// Defines the fluent interface for configuring <see cref="Grid{T}.Scrollable"/>
    /// </summary>
    public class TabStripScrollableSettingsBuilder : IHideObjectMembers
    {
        private readonly TabStripScrollableSettings settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabStripScrollableSettingsBuilder"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public TabStripScrollableSettingsBuilder(TabStripScrollableSettings settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Enables or disables scrolling. By default scrolling is enabled.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TabStrip()
        ///             .Name("TabStrip")
        ///             .Scrollable(s => s.Enabled(false))
        /// %&gt;
        /// </code>
        /// </example>
        /// <remarks>
        /// The Enabled method is useful when you need to enable scrolling based on certain conditions.
        /// </remarks>
        public virtual TabStripScrollableSettingsBuilder Enabled(bool value)
        {
            settings.Enabled = value;

            return this;
        }

        /// <summary>
        /// Sets the scroll amount applied when the user clicks on a scroll button.
        /// </summary>
        /// <param name="pixels">The scroll distance in pixels.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TabStrip(Model)
        ///             .Name("TabStrip")
        ///             .Scrollable(s => s.Distance(200))
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TabStripScrollableSettingsBuilder Distance(int pixels)
        {

            settings.Distance = pixels;

            return this;
        }
    }
}