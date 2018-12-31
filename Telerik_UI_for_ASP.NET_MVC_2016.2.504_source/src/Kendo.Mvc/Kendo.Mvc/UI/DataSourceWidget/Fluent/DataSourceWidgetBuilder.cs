using System;
using System.IO;
using System.Threading.Tasks;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DataSource
    /// </summary>
    ///

    public class DataSourceWidgetBuilder<T> : WidgetBuilderBase<DataSourceWidget<T>, DataSourceWidgetBuilder<T>>, IHideObjectMembers where T : class
    {
        /// <summary>
        /// Gets the view component.
        /// </summary>
        /// <value>The component.</value>
        public DataSourceWidgetBuilder(DataSourceWidget<T> component)
            : base(component)
        {
        }

        protected readonly IUrlGenerator urlGenerator;

        /// <summary>
        /// Use it to configure Ajax binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> Ajax(Action<AjaxDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.Ajax;
            configurator(new AjaxDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Use it to configure WebApi binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> WebApi(Action<WebApiDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.WebApi;
            configurator(new WebApiDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Use it to configure Custom binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> Custom(Action<CustomDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.Custom;
            configurator(new CustomDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Use it to configure SignalR binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> SignalR(Action<SignalRDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.Custom;
            configurator(new SignalRDataSourceBuilder<T>(Component.DataSource));
            return this;
        }

        public DataSourceWidgetBuilder<T> Gantt(Action<GanttDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "GanttDataSource";
            configurator(new GanttDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> GanttDependency(Action<GanttDependenciesDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "GanttDependencyDataSource";
            configurator(new GanttDependenciesDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> Pivot(Action<PivotDataSourceBuilder<T>> configurator)
        {
            Component.PivotDataSource = new PivotDataSource();
            Component.ClassName = "PivotDataSource";
            configurator(new PivotDataSourceBuilder<T>(Component.PivotDataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> Hierarchical(Action<HierarchicalDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "HierarchicalDataSource";
            Component.DataSource.Schema.Model = new TreeListModelDescriptor(typeof(object));
            configurator(new HierarchicalDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> TreeList(Action<TreeListAjaxDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "TreeListDataSource";
            Component.DataSource.Schema.Model = new TreeListModelDescriptor(typeof(object));
            configurator(new TreeListAjaxDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }
    }
}

