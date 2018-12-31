namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo TreeList for ASP.NET MVC events.
    /// </summary>
    public class TreeListEventBuilder: EventBuilder
    {
        public TreeListEventBuilder(IDictionary<string, object> events)
            : base(events)
        {
        }

        //>> Handlers
        
        /// <summary>
        /// Fired when the user clicks the "cancel" button (in inline or popup editing mode) or closes the popup window.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the cancel event.</param>
        public TreeListEventBuilder Cancel(string handler)
        {
            Handler("cancel", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user selects a table row or cell in the treelist.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the change event.</param>
        public TreeListEventBuilder Change(string handler)
        {
            Handler("change", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when an item is about to be collapsed.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the collapse event.</param>
        public TreeListEventBuilder Collapse(string handler)
        {
            Handler("collapse", handler);

            return this;
        }
        
        /// <summary>
        /// Fired before the widget binds to its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBinding event.</param>
        public TreeListEventBuilder DataBinding(string handler)
        {
            Handler("dataBinding", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the widget is bound to data from its data source.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dataBound event.</param>
        public TreeListEventBuilder DataBound(string handler)
        {
            Handler("dataBound", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user attempts to drag an item. If prevented, the item is not allowed to move.The event handler function context (available via the this keyword) will be set to the widget instance.Available in builds 2015.3.1014 and later.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragstart event.</param>
        public TreeListEventBuilder DragStart(string handler)
        {
            Handler("dragstart", handler);

            return this;
        }
        
        /// <summary>
        /// Fired while the user drags and item. This event is triggered on every mouse move.The event handler function context (available via the this keyword) will be set to the widget instance.Available in builds 2015.3.1014 and later.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drag event.</param>
        public TreeListEventBuilder Drag(string handler)
        {
            Handler("drag", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user has finished dragging an item and the model has been updated.The event handler function context (available via the this keyword) will be set to the widget instance.Available in builds 2015.3.1014 and later.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the dragend event.</param>
        public TreeListEventBuilder DragEnd(string handler)
        {
            Handler("dragend", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user drops an item. If prevented, the source row will not be moved.The event handler function context (available via the this keyword) will be set to the widget instance.Available in builds 2015.3.1014 and later.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the drop event.</param>
        public TreeListEventBuilder Drop(string handler)
        {
            Handler("drop", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user edits or creates a data item.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the edit event.</param>
        public TreeListEventBuilder Edit(string handler)
        {
            Handler("edit", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user clicks the "Export to Excel" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the excelExport event.</param>
        public TreeListEventBuilder ExcelExport(string handler)
        {
            Handler("excelExport", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when an item is about to be expanded.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the expand event.</param>
        public TreeListEventBuilder Expand(string handler)
        {
            Handler("expand", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the treelist filter menu is initialized.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the filterMenuInit event.</param>
        public TreeListEventBuilder FilterMenuInit(string handler)
        {
            Handler("filterMenuInit", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user clicks the "Export to PDF" toolbar button.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the pdfExport event.</param>
        public TreeListEventBuilder PdfExport(string handler)
        {
            Handler("pdfExport", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user clicks the "destroy" command button.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the remove event.</param>
        public TreeListEventBuilder Remove(string handler)
        {
            Handler("remove", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when a data item is saved.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the save event.</param>
        public TreeListEventBuilder Save(string handler)
        {
            Handler("save", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user shows a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnShow event.</param>
        public TreeListEventBuilder ColumnShow(string handler)
        {
            Handler("columnShow", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user hides a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnHide event.</param>
        public TreeListEventBuilder ColumnHide(string handler)
        {
            Handler("columnHide", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user changes the order of a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnReorder event.</param>
        public TreeListEventBuilder ColumnReorder(string handler)
        {
            Handler("columnReorder", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user resizes a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnResize event.</param>
        public TreeListEventBuilder ColumnResize(string handler)
        {
            Handler("columnResize", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the column menu is initialized.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnMenuInit event.</param>
        public TreeListEventBuilder ColumnMenuInit(string handler)
        {
            Handler("columnMenuInit", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user lock a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnLock event.</param>
        public TreeListEventBuilder ColumnLock(string handler)
        {
            Handler("columnLock", handler);

            return this;
        }
        
        /// <summary>
        /// Fired when the user unlock a column.The event handler function context (available via the this keyword) will be set to the widget instance.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will handle the columnUnlock event.</param>
        public TreeListEventBuilder ColumnUnlock(string handler)
        {
            Handler("columnUnlock", handler);

            return this;
        }
        
        //<< Handlers
    }
}

