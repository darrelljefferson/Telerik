namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// Defines the fluent API for configuring the TreeListFilterableSettings settings.
    /// </summary>
    public class TreeListFilterableSettingsBuilder<T>: IHideObjectMembers where T : class
    {
        private readonly TreeListFilterableSettings container;

        public TreeListFilterableSettingsBuilder(TreeListFilterableSettings settings)
        {
            container = settings;
        }

        /// <summary>
        /// Configures Filter menu messages.
        /// </summary>
        /// <param name="configurator"></param>
        /// <returns></returns>
        public TreeListFilterableSettingsBuilder<T> Messages(Action<FilterableMessagesBuilder> configurator)
        {
            configurator(new FilterableMessagesBuilder(container.Messages));

            return this;
        }

        //>> Fields
        
        /// <summary>
        /// If set to true the filter menu allows the user to input a second criteria.
        /// </summary>
        /// <param name="value">The value that configures the extra.</param>
        public TreeListFilterableSettingsBuilder<T> Extra(bool value)
        {
            container.Extra = value;

            return this;
        }
        
        //<< Fields
    }
}

