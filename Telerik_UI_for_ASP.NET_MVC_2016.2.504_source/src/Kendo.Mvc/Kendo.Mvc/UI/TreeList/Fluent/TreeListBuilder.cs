namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo TreeList for ASP.NET MVC.
    /// </summary>
    public class TreeListBuilder<T>: WidgetBuilderBase<TreeList<T>, TreeListBuilder<T>> where T : class
    {
        private readonly TreeList<T> container;
        /// <summary>
        /// Initializes a new instance of the <see cref="TreeList"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public TreeListBuilder(TreeList<T> component)
            : base(component)
        {
            container = component;
        }

        //>> Fields
        
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value that configures the autobind.</param>
        public TreeListBuilder<T> AutoBind(bool value)
        {
            container.AutoBind = value;

            return this;
        }
        
        /// <summary>
        /// The configuration of the treelist columns. An array of JavaScript objects or strings. JavaScript objects are interpreted as column configurations. Strings are interpreted as the
		/// field to which the column is bound. The treelist will create a column for every item of the array.
        /// </summary>
        /// <param name="configurator">The action that configures the columns.</param>
        public TreeListBuilder<T> Columns(Action<TreeListColumnFactory<T>> configurator)
        {
            configurator(new TreeListColumnFactory<T>(container.Columns));
            return this;
        }
        
        /// <summary>
        /// If set to true allows users to resize columns by dragging their header borders. By default resizing is disabled.
        /// </summary>
        /// <param name="value">The value that configures the resizable.</param>
        public TreeListBuilder<T> Resizable(bool value)
        {
            container.Resizable = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the user could reorder the columns by dragging their header cells. By default reordering is disabled.
        /// </summary>
        /// <param name="value">The value that configures the reorderable.</param>
        public TreeListBuilder<T> Reorderable(bool value)
        {
            container.Reorderable = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the treelist will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        public TreeListBuilder<T> ColumnMenu()
        {
            return ColumnMenu(true);
        }

        /// <summary>
        /// If set to true the treelist will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the columnmenu option.</param>
        public TreeListBuilder<T> ColumnMenu(bool enabled)
        {
            container.ColumnMenu.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// If set to true the treelist will display the column menu when the user clicks the chevron icon in the column headers. The column menu allows the user to show and hide columns, filter and sort (if filtering and sorting are enabled).
		/// By default the column menu is not enabled.Can be set to a JavaScript object which represents the column menu configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the columnmenu.</param>
        public TreeListBuilder<T> ColumnMenu(Action<TreeListColumnMenuSettingsBuilder<T>> configurator)
        {
            container.ColumnMenu.Enabled = true;
            
            configurator(new TreeListColumnMenuSettingsBuilder<T>(container.ColumnMenu));
            return this;
        }
        
        /// <summary>
        /// If set to true the user would be able to edit the data to which the treelist is bound. By default editing is disabled.Can be set to a string ("inline" or "popup") to specify the editing mode. The default editing mode is "inline".Can be set to a JavaScript object which represents the editing configuration.
        /// </summary>
        public TreeListBuilder<T> Editable()
        {
            return Editable(true);
        }

        /// <summary>
        /// If set to true the user would be able to edit the data to which the treelist is bound. By default editing is disabled.Can be set to a string ("inline" or "popup") to specify the editing mode. The default editing mode is "inline".Can be set to a JavaScript object which represents the editing configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the editable option.</param>
        public TreeListBuilder<T> Editable(bool enabled)
        {
            container.Editable.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// If set to true the user would be able to edit the data to which the treelist is bound. By default editing is disabled.Can be set to a string ("inline" or "popup") to specify the editing mode. The default editing mode is "inline".Can be set to a JavaScript object which represents the editing configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the editable.</param>
        public TreeListBuilder<T> Editable(Action<TreeListEditableSettingsBuilder<T>> configurator)
        {
            container.Editable.Enabled = true;
            
            configurator(new TreeListEditableSettingsBuilder<T>(container.Editable));
            return this;
        }
        
        /// <summary>
        /// Configures the Kendo UI TreeList Excel export settings.
        /// </summary>
        /// <param name="configurator">The action that configures the excel.</param>
        public TreeListBuilder<T> Excel(Action<TreeListExcelSettingsBuilder<T>> configurator)
        {
            configurator(new TreeListExcelSettingsBuilder<T>(container.Excel));
            return this;
        }
        
        /// <summary>
        /// If set to true the user can filter the data source using the treelist filter menu. Filtering is disabled by default.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        public TreeListBuilder<T> Filterable()
        {
            return Filterable(true);
        }

        /// <summary>
        /// If set to true the user can filter the data source using the treelist filter menu. Filtering is disabled by default.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the filterable option.</param>
        public TreeListBuilder<T> Filterable(bool enabled)
        {
            container.Filterable.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// If set to true the user can filter the data source using the treelist filter menu. Filtering is disabled by default.Can be set to a JavaScript object which represents the filter menu configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the filterable.</param>
        public TreeListBuilder<T> Filterable(Action<TreeListFilterableSettingsBuilder<T>> configurator)
        {
            container.Filterable.Enabled = true;
            
            configurator(new TreeListFilterableSettingsBuilder<T>(container.Filterable));
            return this;
        }
        
        /// <summary>
        /// The height of the treelist. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value that configures the height.</param>
        public TreeListBuilder<T> Height(double value)
        {
            container.Height = value;

            return this;
        }
        
        /// <summary>
        /// Defines the text of the command buttons that are shown within the TreeList. Used primarily for localization.
        /// </summary>
        /// <param name="configurator">The action that configures the messages.</param>
        public TreeListBuilder<T> Messages(Action<TreeListMessagesSettingsBuilder<T>> configurator)
        {
            configurator(new TreeListMessagesSettingsBuilder<T>(container.Messages));
            return this;
        }
        
        /// <summary>
        /// Configures the Kendo UI TreeList PDF export settings.
        /// </summary>
        /// <param name="configurator">The action that configures the pdf.</param>
        public TreeListBuilder<T> Pdf(Action<TreeListPdfSettingsBuilder<T>> configurator)
        {
            configurator(new TreeListPdfSettingsBuilder<T>(container.Pdf));
            return this;
        }
        
        /// <summary>
        /// If set to true the TreeList will display a scrollbar when the total row height (or width) exceeds the TreeList height (or width). By default scrolling is enabled.Scrolling renders separate tables for the header and data area. For accessibility-conscious applications, disable scrolling.
        /// </summary>
        /// <param name="value">The value that configures the scrollable.</param>
        public TreeListBuilder<T> Scrollable(bool value)
        {
            container.Scrollable = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the user would be able to select treelist rows. By default selection is disabled.Can also be set to the following string values:
        /// </summary>
        /// <param name="value">The value that configures the selectable.</param>
        public TreeListBuilder<T> Selectable(bool value)
        {
            container.Selectable = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the user could sort the treelist by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        public TreeListBuilder<T> Sortable()
        {
            return Sortable(true);
        }

        /// <summary>
        /// If set to true the user could sort the treelist by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the sortable option.</param>
        public TreeListBuilder<T> Sortable(bool enabled)
        {
            container.Sortable.Enabled = enabled;
            return this;
        }

        
        /// <summary>
        /// If set to true the user could sort the treelist by clicking the column header cells. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="configurator">The action that configures the sortable.</param>
        public TreeListBuilder<T> Sortable(Action<TreeListSortableSettingsBuilder<T>> configurator)
        {
            container.Sortable.Enabled = true;
            
            configurator(new TreeListSortableSettingsBuilder<T>(container.Sortable));
            return this;
        }
        
        /// <summary>
        /// If a String value is assigned to the toolbar configuration option, it will be treated as a single string template for the whole treelist Toolbar,
		/// and the string value will be passed as an argument to a kendo.template() function.If a Function value is assigned (it may be a kendo.template() function call or a generic function reference), then the return value of the function will be used to render the treelist Toolbar contents.If an Array value is assigned, it will be treated as the list of commands displayed in the treelist Toolbar. Commands can be custom or built-in ("create", "excel", "pdf").
        /// </summary>
        /// <param name="configurator">The action that configures the toolbar.</param>
        public TreeListBuilder<T> Toolbar(Action<TreeListToolbarFactory<T>> configurator)
        {
            configurator(new TreeListToolbarFactory<T>(container.Toolbar));
            return this;
        }
        
        //<< Fields

        /// <summary>
        /// Configure the DataSource of the component
        /// </summary>
        /// <param name="configurator">The action that configures the <see cref="DataSource"/>.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeMap()
        ///     .Name("treeMap")
        ///     .DataSource(dataSource => dataSource
        ///         .Read(read => read
        ///             .Action("_PopulationUS", "TreeMap")
        ///         )
        ///     )
        ///  %&gt;
        /// </code>
        /// </example>
        public TreeListBuilder<T> DataSource(Action<TreeListAjaxDataSourceBuilder<T>> configurator)
        {
            configurator(new TreeListAjaxDataSourceBuilder<T>(Component.DataSource, this.Component.ViewContext, this.Component.urlGenerator));

            return this;
        }

        public TreeListBuilder<T> DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;

            return this;
        }

        /// <summary>
        /// Binds the grid to a list of objects
        /// </summary>
        /// <param name="dataSource">The data source.</param>        
        public TreeListBuilder<T> BindTo(IEnumerable<T> dataSource)
        {
            Component.DataSource.Data = dataSource;

            return this;
        }        
        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TreeList()
        ///             .Name("TreeList")
        ///             .Events(events => events
        ///                 .DataBinding("onDataBinding")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public TreeListBuilder<T> Events(Action<TreeListEventBuilder> configurator)
        {

            configurator(new TreeListEventBuilder(Component.Events));

            return this;
        }
        
    }
}

