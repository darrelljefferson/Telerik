namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the TreeListColumnMenuMessagesSettings settings.
    /// </summary>
    public class TreeListColumnMenuMessagesSettingsBuilder<T>: IHideObjectMembers where T : class
    {
        private readonly TreeListColumnMenuMessagesSettings container;

        public TreeListColumnMenuMessagesSettingsBuilder(TreeListColumnMenuMessagesSettings settings)
        {
            container = settings;
        }

        //>> Fields
        
        /// <summary>
        /// The text message displayed for the column selection menu item.
        /// </summary>
        /// <param name="value">The value that configures the columns.</param>
        public TreeListColumnMenuMessagesSettingsBuilder<T> Columns(string value)
        {
            container.Columns = value;

            return this;
        }
        
        /// <summary>
        /// The text message displayed for the filter menu item.
        /// </summary>
        /// <param name="value">The value that configures the filter.</param>
        public TreeListColumnMenuMessagesSettingsBuilder<T> Filter(string value)
        {
            container.Filter = value;

            return this;
        }
        
        /// <summary>
        /// The text message displayed for the menu item which performs ascending sort.
        /// </summary>
        /// <param name="value">The value that configures the sortascending.</param>
        public TreeListColumnMenuMessagesSettingsBuilder<T> SortAscending(string value)
        {
            container.SortAscending = value;

            return this;
        }
        
        /// <summary>
        /// The text message displayed for the menu item which performs descending sort.
        /// </summary>
        /// <param name="value">The value that configures the sortdescending.</param>
        public TreeListColumnMenuMessagesSettingsBuilder<T> SortDescending(string value)
        {
            container.SortDescending = value;

            return this;
        }
        
        //<< Fields
    }
}

