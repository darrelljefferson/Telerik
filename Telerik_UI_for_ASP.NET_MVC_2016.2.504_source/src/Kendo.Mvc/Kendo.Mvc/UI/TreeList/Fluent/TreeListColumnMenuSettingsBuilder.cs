namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the TreeListColumnMenuSettings settings.
    /// </summary>
    public class TreeListColumnMenuSettingsBuilder<T>: IHideObjectMembers where T : class
    {
        private readonly TreeListColumnMenuSettings container;

        public TreeListColumnMenuSettingsBuilder(TreeListColumnMenuSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// If set to true the column menu would allow the user to select (show and hide) treelist columns. By default the column menu allows column selection.
        /// </summary>
        /// <param name="value">The value that configures the columns.</param>
        public TreeListColumnMenuSettingsBuilder<T> Columns(bool value)
        {
            container.Columns = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the column menu would allow the user to filter the treelist. By default the column menu allows the user to filter if filtering is enabled via the filterable.
        /// </summary>
        /// <param name="value">The value that configures the filterable.</param>
        public TreeListColumnMenuSettingsBuilder<T> Filterable(bool value)
        {
            container.Filterable = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the column menu would allow the user to sort the treelist by the column field. By default the column menu allows the user to sort if sorting is enabled via the sortable option.
        /// </summary>
        /// <param name="value">The value that configures the sortable.</param>
        public TreeListColumnMenuSettingsBuilder<T> Sortable(bool value)
        {
            container.Sortable = value;

            return this;
        }
        
        /// <summary>
        /// The text messages displayed in the column menu. Use it to customize or localize the column menu messages.
        /// </summary>
        /// <param name="configurator">The action that configures the messages.</param>
        public TreeListColumnMenuSettingsBuilder<T> Messages(Action<TreeListColumnMenuMessagesSettingsBuilder<T>> configurator)
        {
            configurator(new TreeListColumnMenuMessagesSettingsBuilder<T>(container.Messages));
            return this;
        }
        
        //<< Fields
    }
}

