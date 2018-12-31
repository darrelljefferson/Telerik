namespace Kendo.Mvc.UI.Fluent
{
    //Mono build requires this line
    using System;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.UI;

    public class VirtualSettingsBuilder : IHideObjectMembers
    {
        private VirtualSettings settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualSettingsBuilder"/> class.
        /// </summary>
        /// <param name="settings">The virtualization settings.</param>
        public VirtualSettingsBuilder(VirtualSettings settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Defines the item height.
        /// </summary>
        public VirtualSettingsBuilder Enable(bool enable)
        {
            settings.Enable = enable;

            return this;
        }

        /// <summary>
        /// Defines the item height.
        /// </summary>
        public VirtualSettingsBuilder ItemHeight(int itemHeight)
        {
            settings.ItemHeight = itemHeight;

            return this;
        }

        /// <summary>
        /// Defines a value mapper. This function will return the indices matching the passed values.
        /// </summary>
        public VirtualSettingsBuilder ValueMapper(Func<object, object> handler)
        {
            settings.Enable = true;
            settings.ValueMapper = new ClientHandlerDescriptor { TemplateDelegate = handler };

            return this;
        }

        /// <summary>
        /// Defines a value mapper. This function will return the indices matching the passed values.
        /// </summary>
        public VirtualSettingsBuilder ValueMapper(string handler)
        {
            settings.Enable = true;
            settings.ValueMapper = new ClientHandlerDescriptor { HandlerName = handler };

            return this;
        }
    }
}