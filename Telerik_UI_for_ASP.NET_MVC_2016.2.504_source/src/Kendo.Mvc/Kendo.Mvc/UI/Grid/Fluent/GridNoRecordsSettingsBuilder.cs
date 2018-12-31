namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring grid noRecords option.
    /// </summary>
    public class GridNoRecordsSettingsBuilder : IHideObjectMembers
    {
        private readonly GridNoRecordsSettings settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="GridNoRecordsSettingsBuilder"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public GridNoRecordsSettingsBuilder(GridNoRecordsSettings settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// The template used for noRecords option.
        /// </summary>
        /// <param name="template">The template.</param>
        public GridNoRecordsSettingsBuilder Template(string template)
        {
            settings.Template = template;
            settings.Enabled = true;

            return this;
        }

        /// <summary>
        /// The Id of the template used for noRecords option.
        /// </summary>
        /// <param name="templateId">The templateId</param>
        public GridNoRecordsSettingsBuilder TemplateId(string templateId)
        {
            settings.TemplateId = templateId;
            settings.Enabled = true;

            return this;
        }
    }
}
