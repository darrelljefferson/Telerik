namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections;


    public class ListBuilderBase<TDropDown, TDropDownBuilder> : WidgetBuilderBase<TDropDown, TDropDownBuilder>, IHideObjectMembers
        where TDropDown : ListBase
        where TDropDownBuilder : WidgetBuilderBase<TDropDown, TDropDownBuilder>
    {
        public ListBuilderBase(TDropDown component)
            : base(component)
        {
        }

        /// <summary>
        /// Use to enable or disable animation of the popup element.
        /// </summary>
        /// <param name="enable">The boolean value.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().DropDownList()
        ///	           .Name("DropDownList")
        ///	           .Animation(false) //toggle effect
        ///	%&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Configures the animation effects of the widget.
        /// </summary>
        /// <param name="animationAction">The action which configures the animation effects.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().DropDownList()
        ///	           .Name("DropDownList")
        ///	           .Animation(animation =>
        ///	           {
        ///		            animation.Open(open =>
        ///		            {
        ///		                open.SlideIn(SlideDirection.Down);
        ///		            }
        ///	           })
        ///	%&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {

            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Binds the widget to an IEnumerable list.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .DataTextField("CompanyName")
        ///             .DataValueField("CompanyID")
        ///             .BindTo(new List<Company>
        ///             {
        ///                 new Company {
        ///                     CompanyName = "Text1",
        ///                     CompanyID = "Value1"
        ///                 },
        ///                 new Company {
        ///                     CompanyName = "Text2",
        ///                     CompanyID = "Value2"
        ///                 }
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder BindTo(IEnumerable data)
        {
            Component.DataSource.Data = data;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .DataTextField("Text")
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder DataTextField(string field)
        {
            Component.DataTextField = field;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Configures the DataSource options.
        /// </summary>
        /// <param name="configurator">The DataSource configurator action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .DataSource(source =>
        ///             {
        ///                 source.Read(read =>
        ///                 {
        ///                     read.Action("GetProducts", "Home");
        ///                 }
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
        {
            configurator(new ReadOnlyDataSourceBuilder(Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));

            return this as TDropDownBuilder;
        }

        public TDropDownBuilder DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Specifies the delay in ms after which the widget will start filtering the dataSource.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .Delay(300)
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder Delay(int delay)
        {
            Component.Delay = delay;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Enables or disables the combobox.
        /// </summary>
        public TDropDownBuilder Enable(bool value)
        {
            Component.Enabled = value;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Fixed group template which will be rendered as a static group header of the popup element.
        /// </summary>
        public TDropDownBuilder FixedGroupTemplate(string fixedGroupTemplate)
        {
            Component.FixedGroupTemplate = fixedGroupTemplate;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// FixedGroupTemplateId to be used for rendering the static header of the popup element.
        /// </summary>
        public TDropDownBuilder FixedGroupTemplateId(string fixedGroupTemplateId)
        {
            Component.FixedGroupTemplateId = fixedGroupTemplateId;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Group template which will be rendered as a group header of each new group in the popup.
        /// </summary>
        public TDropDownBuilder GroupTemplate(string groupTemplate)
        {
            Component.GroupTemplate = groupTemplate;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// GroupTemplateId to be used for rendering the static header of the popup element.
        /// </summary>
        public TDropDownBuilder GroupTemplateId(string groupTemplateId)
        {
            Component.GroupTemplateId = groupTemplateId;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Use it to enable case insensitive bahavior of the combobox. If true the combobox will select the first matching item ignoring its casing.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ComboBox()
        ///             .Name("ComboBox")
        ///             .IgnoreCase(true)
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder IgnoreCase(bool ignoreCase)
        {
            Component.IgnoreCase = ignoreCase;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Sets the height of the drop-down list in pixels.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .Height(300)
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder Height(int height)
        {
            Component.Height = height;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Header template which will be rendered as a static header of the popup element.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .HeaderTemplate("<div><h2>Customers</h2></div>")
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder HeaderTemplate(string headerTemplate)
        {
            Component.HeaderTemplate = headerTemplate;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// HeaderTemplateId to be used for rendering the static header of the popup element.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .HeaderTemplateId("widgetHeaderTemplateId")
        /// %&gt;
        /// </code>
        /// </example>
        public TDropDownBuilder HeaderTemplateId(string headerTemplateId)
        {
            Component.HeaderTemplateId = headerTemplateId;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Configures the popup settings of the widget.
        /// </summary>
        public TDropDownBuilder Popup(Action<PopupSettingsBuilder> popupAction)
        {
            popupAction(new PopupSettingsBuilder(Component.PopupSettings));

            return this as TDropDownBuilder;
        }

        public TDropDownBuilder ValuePrimitive(bool valuePrimitive)
        {
            Component.ValuePrimitive = valuePrimitive;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Configures the virtualization settings of the widget.
        /// </summary>
        public TDropDownBuilder Virtual(bool enable)
        {
            Component.VirtualSettings.Enable = enable;

            return this as TDropDownBuilder;
        }

        /// <summary>
        /// Configures the virtualization settings of the widget.
        /// </summary>
        public TDropDownBuilder Virtual(Action<VirtualSettingsBuilder> virtualizationAction)
        {
            virtualizationAction(new VirtualSettingsBuilder(Component.VirtualSettings));

            return this as TDropDownBuilder;
        }
    }
}
