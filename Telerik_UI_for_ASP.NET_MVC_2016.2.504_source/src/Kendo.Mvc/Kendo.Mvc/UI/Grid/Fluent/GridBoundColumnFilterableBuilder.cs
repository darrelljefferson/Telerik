namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Web;
    using Kendo.Mvc.Infrastructure;

    /// <summary>
    /// Defines the fluent interface for configuring bound columns filterable options
    /// </summary>
    /// <typeparam name="T">The type of the data item</typeparam>
    public class GridBoundColumnFilterableBuilder : GridFilterableSettingsBuilderBase<GridBoundColumnFilterableBuilder>
    {
        private readonly GridBoundColumnFilterableSettings settings;
        private System.Web.Mvc.ViewContext viewContext;
        private IUrlGenerator urlGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="GridBoundColumnFilterableBuilder"/> class.
        /// </summary>
        /// <param name="column">The column.</param>
        public GridBoundColumnFilterableBuilder(GridBoundColumnFilterableSettings settings, System.Web.Mvc.ViewContext viewContext, IUrlGenerator urlGenerator) : base(settings)
        {
            this.viewContext = viewContext;
            this.urlGenerator = urlGenerator;
            this.settings = settings;
        }

        /// <summary>
        /// Sets the type of the input element of the filter menu
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns =>
        ///                 columns.Bound(o => o.OrderDate)
        ///                        .Filterable(filterable =>
        ///                             filterable.UI(GridFilterUIRole.DatePicker)
        ///                        )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public GridBoundColumnFilterableBuilder UI(GridFilterUIRole role)
        {
            settings.FilterUIRole = role;
            return this;
        }

        public GridBoundColumnFilterableBuilder Cell(Action<GridColumnFilterableCellSettingsBuilder> configurator)
        {
            configurator(new GridColumnFilterableCellSettingsBuilder(settings.CellSettings, this.viewContext, this.urlGenerator));
            
            return this;
        }

        /// <summary>
        /// Sets JavaScript function which to modify the UI of the filter input.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns =>
        ///                 columns.Bound(o => o.OrderDate)
        ///                        .Filterable(filterable =>
        ///                             filterable.UI(@&lt;text&gt;
        ///                                 JavaScript function goes here
        ///                                 &lt;/text&gt;)
        ///                         )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public GridBoundColumnFilterableBuilder UI(Func<object, object> handler)
        {
            settings.FilterUIHandler.TemplateDelegate = handler;
            return this;
        }

        /// <summary>
        /// Sets JavaScript function which to modify the UI of the filter input.
        /// </summary>
        /// <param name="handler">JavaScript function name</param>
        public GridBoundColumnFilterableBuilder UI(string handler)
        {
            settings.FilterUIHandler.HandlerName = handler;
            return this;
        }

        /// <summary>
        /// Sets the template for the checkbox rendering when Multi checkbox filtering is enabled
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns =>
        ///                 columns.Bound(o => o.OrderDate)
        ///                        .Filterable(filterable =>
        ///                             filterable.ItemTemplate("nameOfJavaScriptFunction")
        ///                        )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public GridBoundColumnFilterableBuilder ItemTemplate(string handler)
        {
            settings.ItemTemplate.HandlerName = handler;
            return this;
        }

        /// <summary>
        /// Enables / disabled the Multi Checkbox filtering support for this column.
        /// </summary>
        public GridBoundColumnFilterableBuilder Multi(bool value)
        {
            settings.Multi = value;
            return this;
        }

        /// <summary>
        /// Controls whether to show a search box when checkbox filtering is enabled.
        /// </summary>
        public GridBoundColumnFilterableBuilder Search(bool value)
        {
            settings.Search = value;
            return this;
        }

        /// <summary>
        /// Toggles between case-insensitive (default) and case-sensitive searching.
        /// </summary>
        public GridBoundColumnFilterableBuilder IgnoreCase(bool value)
        {
            settings.IgnoreCase = value;
            return this;
        }

        /// <summary>
        /// Provide IEnumerable that will be used as DataSource for Multi CheckBox filtering on this column
        /// </summary>
        public GridBoundColumnFilterableBuilder BindTo(System.Collections.IEnumerable dataSource)
        {
            settings.DataSource.Data = dataSource;

            return this;
        }

        /// <summary>
        /// Enables / disabled the CheclAll checkboxes when Multi Checkbox filtering is enabled.
        /// </summary>
        public GridBoundColumnFilterableBuilder CheckAll(bool value)
        {
            settings.CheckAll = value;
            return this;
        }

        /// <summary>
        /// Configures the DataSource options.
        /// </summary>
        /// <param name="configurator">The DataSource configurator action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        ///             .Columns(columns =>
        ///                 columns.Bound(o => o.OrderDate)
        ///                        .Filterable(filterable =>
        ///                             filterable.Cell(cell =>
        ///                                     cell.DataSource(ds =>
        ///                                         ds.Read("someAction", "someController")
        ///                                     )
        ///                                 )
        ///                         )
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public GridBoundColumnFilterableBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
        {
            configurator(new ReadOnlyDataSourceBuilder(settings.DataSource, this.viewContext, this.urlGenerator));

            return this;
        }
    }
}
