namespace Kendo.Mvc.UI.Fluent
{
    //Mono build requires this line
    using System;
    using System.Collections.Generic;
    using System.Web.Routing;
    using Kendo.Mvc.UI;

    public class PopupSettingsBuilder : IHideObjectMembers
    {
        private PopupSettings settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupSettingsBuilder"/> class.
        /// </summary>
        /// <param name="settings">The popup settings.</param>
        public PopupSettingsBuilder(PopupSettings settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Defines a jQuery selector that will be used to find a container element, where the popup will be appended to.
        /// </summary>
        public PopupSettingsBuilder AppendTo(string selector)
        {
            settings.AppendTo = selector;

            return this;
        }

        /// <summary>
        /// Specifies how to position the popup element based on achor point.
        /// </summary>
        public PopupSettingsBuilder Origin(string origin)
        {
            settings.Origin = origin;

            return this;
        }

        /// <summary>
        /// Specifies which point of the popup element to attach to the anchor's origin point.
        /// </summary>
        public PopupSettingsBuilder Position(string position)
        {
            settings.Position = position;

            return this;
        }
    }
}