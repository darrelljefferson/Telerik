namespace Kendo.Mvc.UI.Fluent
{
    using Infrastructure;
    using Kendo.Mvc.Extensions;
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="Window"/> component.
    /// </summary>
    public class WindowContentBuilder : CustomCrudOperationBuilder
    {
        private readonly WindowContentSettings settings;

        public WindowContentBuilder(WindowContentSettings settings, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(settings, viewContext, urlGenerator)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Explicitly specifies whether the content will be rendered as an iframe or in-line
        /// </summary>
        public WindowContentBuilder Iframe(bool value)
        {
            settings.Iframe = value;

            return this;
        }

        /// <summary>
        /// Template to be used for rendering the items in the treeview.
        /// </summary>
        public WindowContentBuilder Template(string template)
        {
            settings.Template = template;

            return this;
        }

        /// <summary>
        /// Id of the template element to be used for rendering the items in the treeview.
        /// </summary>
        public WindowContentBuilder TemplateId(string templateId)
        {
            settings.TemplateId = templateId;

            return this;
        }
    }
}
