namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo MobileApplication for ASP.NET MVC.
    /// </summary>
    public class MobileApplicationBuilder: WidgetBuilderBase<MobileApplication, MobileApplicationBuilder>, IHideObjectMembers
    {
        private readonly MobileApplication container;
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileApplication"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public MobileApplicationBuilder(MobileApplication component)
            : base(component)
        {
            container = component;
        }

        //>> Fields
        
        /// <summary>
        /// Introduced in the 2014 Q3 release. If set to false, the navigation will not update or read the browser location fragment.
        /// </summary>
        /// <param name="value">The value that configures the browserhistory.</param>
        public MobileApplicationBuilder BrowserHistory(bool value)
        {
            container.BrowserHistory = value;

            return this;
        }
        
        /// <summary>
        /// Introduced in the 2014 Q1 Service Pack 1 release. If set to true, the navigation will parse and prefix the url fragment value with !,
		/// which should be SEO friendly.
        /// </summary>
        /// <param name="value">The value that configures the hashbang.</param>
        public MobileApplicationBuilder HashBang(bool value)
        {
            container.HashBang = value;

            return this;
        }
        
        /// <summary>
        /// Whether to hide the browser address bar. Supported only in iPhone and iPod. Doesn't affect standalone mode as there the address bar is always hidden.
        /// </summary>
        /// <param name="value">The value that configures the hideaddressbar.</param>
        public MobileApplicationBuilder HideAddressBar(bool value)
        {
            container.HideAddressBar = value;

            return this;
        }
        
        /// <summary>
        /// The id of the initial mobile View to display.
        /// </summary>
        /// <param name="value">The value that configures the initial.</param>
        public MobileApplicationBuilder Initial(string value)
        {
            container.Initial = value;

            return this;
        }
        
        /// <summary>
        /// The id of the default Application layout.
        /// </summary>
        /// <param name="value">The value that configures the layout.</param>
        public MobileApplicationBuilder Layout(string value)
        {
            container.Layout = value;

            return this;
        }
        
        /// <summary>
        /// The text displayed in the loading popup. Setting this value to false will disable the loading popup.Note: The text should be wrapped inside &lt;h1&gt; tag.
        /// </summary>
        /// <param name="value">The value that configures the loading.</param>
        public MobileApplicationBuilder Loading(string value)
        {
            container.Loading = value;

            return this;
        }
        
        /// <summary>
        /// The view model scope. By default, the views will try to resolve their models from the global scope (window).
        /// </summary>
        /// <param name="value">The value that configures the modelscope.</param>
        public MobileApplicationBuilder ModelScope(object value)
        {
            container.ModelScope = value;

            return this;
        }
        
        /// <summary>
        /// Which platform look to force on the application. Supported values are "ios" (meaning iOS 6 look), "ios7","android", "blackberry" and "wp".
		/// You can also set platform variants with it ("android-light" or "android-dark"), but keep in mind that it will still override the platform. If this is not desired, use the skin option.
        /// </summary>
        /// <param name="value">The value that configures the platform.</param>
        public MobileApplicationBuilder Platform(string value)
        {
            container.Platform = value;

            return this;
        }
        
        /// <summary>
        /// Applicable if pushState is used and the application is deployed to a path different than /. If the application start page is hosted on http://foo.com/myapp/, the root option should be set to /myapp/.
        /// </summary>
        /// <param name="value">The value that configures the root.</param>
        public MobileApplicationBuilder Root(string value)
        {
            container.Root = value;

            return this;
        }
        
        /// <summary>
        /// If set to true, the application will set the meta viewport tag scale value according to the device pixel ratio, and re-scale the app by setting root element font size to the respective value.
		/// This will result in the widget borders/separators being real 1px  wide.
		/// For example, in iPhone 4/5, the device pixel ratio is 2, which means that the scale will be set to 0.5, while the app root will receive a font-size: 2 * 0.92 inline style set.
        /// </summary>
        /// <param name="value">The value that configures the retina.</param>
        public MobileApplicationBuilder Retina(bool value)
        {
            container.Retina = value;

            return this;
        }
        
        /// <summary>
        /// If set to true, the application will not use AJAX to load remote views.
        /// </summary>
        /// <param name="value">The value that configures the servernavigation.</param>
        public MobileApplicationBuilder ServerNavigation(bool value)
        {
            container.ServerNavigation = value;

            return this;
        }
        
        /// <summary>
        /// The skin to apply to the application. Currently, Kendo UI Mobile ships with nova, flat, material-light and material-dark skins in addition to the native looking ones.
		/// You can also set platform variants with it ("android-light" or "android-dark").Note: The Material themes were renamed to material-light and material-dark in 2014 Q3 SP1. With 2014 Q3 (v2014.3.1119) and older Kendo UI versions,
		/// material and materialblack skin names should be used.
        /// </summary>
        /// <param name="value">The value that configures the skin.</param>
        public MobileApplicationBuilder Skin(string value)
        {
            container.Skin = value;

            return this;
        }
        
        /// <summary>
        /// Set the status bar style meta tag in iOS used to control the styling of the status bar in a pinned to the Home Screen app. Available as of Q2 2013 SP.
        /// </summary>
        /// <param name="value">The value that configures the statusbarstyle.</param>
        public MobileApplicationBuilder StatusBarStyle(string value)
        {
            container.StatusBarStyle = value;

            return this;
        }
        
        /// <summary>
        /// The default View transition. For a list of supported transitions, check the Getting Started help topic.
        /// </summary>
        /// <param name="value">The value that configures the transition.</param>
        public MobileApplicationBuilder Transition(string value)
        {
            container.Transition = value;

            return this;
        }
        
        /// <summary>
        /// Whether to update the document title.
        /// </summary>
        /// <param name="value">The value that configures the updatedocumenttitle.</param>
        public MobileApplicationBuilder UpdateDocumentTitle(bool value)
        {
            container.UpdateDocumentTitle = value;

            return this;
        }
        
        /// <summary>
        /// By default, the mobile application uses flexbox for the mobile views layout. The content element is made scrollable, either by initializing a mobile scroller or with the browser supported overflow: auto and -webkit-overflow-scrolling: touch CSS declarations.
		/// When the useNativeScrolling configuration option is set to true, the view header and footer are positioned using position: fixed CSS declaration. The view content vertical padding is adjusted to match the header and footer height; The default browser scroller is utilized for the content scrolling.For more information regarding native scrolling check this article.
        /// </summary>
        /// <param name="value">The value that configures the usenativescrolling.</param>
        public MobileApplicationBuilder UseNativeScrolling(bool value)
        {
            container.UseNativeScrolling = value;

            return this;
        }
        
        /// <summary>
        /// Disables the default behavior of Kendo UI Mobile apps to be web app capable (open in a chromeless browser). Introduced in Q2 2013.
        /// </summary>
        /// <param name="value">The value that configures the webappcapable.</param>
        public MobileApplicationBuilder WebAppCapable(bool value)
        {
            container.WebAppCapable = value;

            return this;
        }
        
        /// <summary>
        /// Specifies how history should be handled
        /// </summary>
        /// <param name="value">The value that configures the pushstate.</param>
        public MobileApplicationBuilder PushState(bool value)
        {
            container.PushState = value;

            return this;
        }
        
        //<< Fields

        /// <summary>
        /// Specify default icon url
        /// </summary>
        /// <param name="url">The icon url</param>        
        public MobileApplicationBuilder Icon(string url)
        {
            Component.Icon.Add("", url);

            return this;
        }

        /// <summary>
        /// Specify icon url per dimension
        /// </summary>
        /// <param name="configurator">Configurator for icon url per dimension</param>        
        public MobileApplicationBuilder Icon(Action<MobileApplicationIconBuilder> configurator)
        {
            configurator(new MobileApplicationIconBuilder(Component.Icon));

            return this;
        }

        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MobileApplication()        
        ///             .Events(events => events
        ///                 .Init("onInit")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public MobileApplicationBuilder Events(Action<MobileApplicationEventBuilder> configurator)
        {

            configurator(new MobileApplicationEventBuilder(Component.Events));

            return this;
        }
        
    }
}

