namespace Kendo.Mvc.UI.Fluent
{
    using System;
using System.ComponentModel;
using Kendo.Mvc.Infrastructure;

    /// <summary>
    /// Defines the fluent interface for configuring series.
    /// </summary>
    /// <typeparam name="TSeries"></typeparam>
    /// <typeparam name="TSeriesBuilder">The type of the series builder.</typeparam>
    public abstract class ChartSeriesBuilderBase<TSeries, TSeriesBuilder> : IHideObjectMembers
        where TSeriesBuilder : ChartSeriesBuilderBase<TSeries, TSeriesBuilder>
        where TSeries : IChartSeries
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeriesBuilderBase{TSeries, TSeriesBuilder}"/> class.
        /// </summary>
        /// <param name="series">The series.</param>
        protected ChartSeriesBuilderBase(TSeries series)
        {

            Series = series;
        }

        /// <summary>
        /// Gets or sets the series.
        /// </summary>
        /// <value>The series.</value>
        public TSeries Series
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the series title displayed in the legend.
        /// </summary>
        /// <param name="text">The title.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Chart(Model)
        ///            .Name("Chart")
        ///            .Series(series => series.Bar(s => s.Sales).Name("Sales"))
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Name(string text)
        {
            Series.Name = text;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the name template for auto-generated series when binding to grouped data.
        /// </summary>
        /// <param name="groupNameTemplate">
        /// The name template for auto-generated series when binding to grouped data.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .DataSource(dataSource => dataSource
        ///                .Read(read => read.Action("_StockData", "Scatter_Charts"))
        ///                .Group(group => group.Add(model => model.Symbol))
        ///            )
        ///            .Series(series => series.Bar(s => s.Sales)
        ///                 .Name("Sales")
        ///                 .GroupNameTemplate("#= series.name # for #= group.field # #= group.value #")
        ///            )
        ///            .Render();
        /// %&gt;
        /// </code>
        /// </example>
        [Obsolete("GroupNameTemplate is obsolete. Please specify the template as Name.")]
        public TSeriesBuilder GroupNameTemplate(string groupNameTemplate)
        {
            Series.GroupNameTemplate = groupNameTemplate;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the series opacity.
        /// </summary>
        /// <param name="opacity">
        /// The series opacity in the range from 0 (transparent) to 1 (opaque).
        /// The default value is 1.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Chart(Model)
        ///            .Name("Chart")
        ///            .Series(series => series.Bar(s => s.Sales).Opacity(0.5))
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Opacity(double opacity)
        {
            Series.Opacity = opacity;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the bar fill color
        /// </summary>
        /// <param name="color">The bar fill color (CSS syntax).</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series.Bar(s => s.Sales).Color("Red"))
        ///            .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Color(string color)
        {
            Series.Color = color;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the function used to retrieve point color.
        /// </summary>
        /// <param name="colorFunction">
        ///     The JavaScript function that will be executed
        ///     to retrieve the color of each point.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series
        ///                .Bar(s => s.Sales)
        ///                .Color(
        ///                    @&lt;text&gt;
        ///                    function(point) {
        ///                        return point.value > 5 ? "red" : "green";
        ///                    }
        ///                    &lt;/text&gt;
        ///                )
        ///             )
        ///            .Render();
        /// %&gt;
        /// </code>
        /// </example>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public TSeriesBuilder Color(Func<object, object> colorFunction)
        {
            Series.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = colorFunction };

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the function used to retrieve point color.
        /// </summary>
        /// <param name="colorFunction">
        ///     The JavaScript function that will be executed
        ///     to retrieve the color of each point.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series
        ///                .Bar(s => s.Sales)
        ///                .ColorHandler(
        ///                    @&lt;text&gt;
        ///                    function(point) {
        ///                        return point.value > 5 ? "red" : "green";
        ///                    }
        ///                    &lt;/text&gt;
        ///                )
        ///             )
        ///            .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder ColorHandler(Func<object, object> colorFunction)
        {
            Series.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = colorFunction };

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the function used to retrieve point color.
        /// </summary>
        /// <param name="colorFunction">
        ///     The JavaScript function that will be executed
        ///     to retrieve the color of each point.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series
        ///                .Bar(s => s.Sales)
        ///                .ColorHandler("pointColor")
        ///             )
        ///            .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder ColorHandler(string colorFunction)
        {
            Series.ColorHandler = new ClientHandlerDescriptor { HandlerName = colorFunction };

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Configure the data point tooltip for the series.
        /// </summary>
        /// <param name="configurator">Use the configurator to set data tooltip options.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series.Bar(s => s.Sales)
        ///                .Tooltip(tooltip =>
        ///                {
        ///                    tooltip.Visible(true).Format("{0:C}");
        ///                })
        ///            )
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Tooltip(Action<ChartTooltipBuilder> configurator)
        {

            configurator(new ChartTooltipBuilder(Series.Tooltip));

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the data point tooltip visibility.
        /// </summary>
        /// <param name="visible">
        /// A value indicating if the data point tooltip should be displayed.
        /// The tooltip is not visible by default.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series.Bar(s => s.Sales).Tooltip(true))
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Tooltip(bool visible)
        {
            Series.Tooltip.Visible = visible;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the axis name to use for this series.
        /// </summary>
        /// <param name="axis">The axis name for this series.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Chart(Model)
        ///            .Name("Chart")
        ///            .Series(series => series.Bar(s => s.Sales).Name("Sales").Axis("secondary"))
        ///            .ValueAxis(axis => axis.Numeric())
        ///            .ValueAxis(axis => axis.Numeric("secondary"))
        ///            .CategoryAxis(axis => axis.AxisCrossingValue(0, 10))
        /// %&gt;
        /// </code>
        /// </example>
        public virtual TSeriesBuilder Axis(string axis)
        {
            Series.Axis = axis;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the axis name to use for this series.
        /// </summary>
        /// <param name="categoryAxis">The category axis name for this series.</param>
        public virtual TSeriesBuilder CategoryAxis(string categoryAxis)
        {
            Series.CategoryAxis = categoryAxis;

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Configures the series highlight
        /// </summary>
        /// <param name="configurator">The configuration action.</param>
        public TSeriesBuilder Highlight(Action<ChartSeriesHighlightBuilder> configurator)
        {
            configurator(new ChartSeriesHighlightBuilder(Series.Highlight));
            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Configures the highlight visibility
        /// </summary>
        /// <param name="configurator">The highlight visibility.</param>
        public TSeriesBuilder Highlight(bool visible)
        {
            Series.Highlight.Visible = visible;
            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the labels visibility
        /// </summary>
        /// <param name="visible">The labels visibility.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///           .Name("Chart")
        ///           .Series(series => series.Bar(s => s.Sales).Visible(false))
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>        
        public TSeriesBuilder Visible(bool visible)
        {
            Series.Visible = visible;
            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the labels visibility in the legend
        /// </summary>
        /// <param name="visible">The series visibility in the legend.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///           .Name("Chart")
        ///           .Series(series => series.Bar(s => s.Sales).VisibleInLegend(false))
        ///           .Render();
        /// %&gt;
        /// </code>
        /// </example>        
        public TSeriesBuilder VisibleInLegend(bool visible)
        {
            Series.VisibleInLegend = visible;
            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Configures the series notes
        /// </summary>
        /// <param name="configurator">The configuration action.</param>
        public TSeriesBuilder Notes(Action<ChartNoteBuilder> configurator)
        {
            configurator(new ChartNoteBuilder(Series.Notes));
            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the function used to retrieve point color.
        /// </summary>
        /// <param name="aggregateFunction">
        ///     The JavaScript function that will be executed
        ///     to retrieve the value of each aggregated point.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series
        ///                .Bar(s => s.Sales)
        ///                .Aggregate(
        ///                    @&lt;text&gt;
        ///                    function(values) {
        ///                        return values[0];
        ///                    }
        ///                    &lt;/text&gt;
        ///                )
        ///             )
        ///            .Render();
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Aggregate(Func<object, object> aggregateFunction)
        {
            Series.AggregateHandler = new ClientHandlerDescriptor { TemplateDelegate = aggregateFunction };

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the function used to retrieve point color.
        /// </summary>
        /// <param name="aggregateFunction">
        ///     The JavaScript function that will be executed
        ///     to retrieve the value of each aggregated point.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;% Html.Kendo().Chart()
        ///            .Name("Chart")
        ///            .Series(series => series
        ///                .Bar(s => s.Sales)
        ///                .Aggregate("myAggregate")
        ///             )
        ///            .Render();
        /// %&gt;
        /// &lt;script&gt;
        /// function myAggregate(values) {
        ///     return values[0];
        /// }
        /// &lt;/script&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder Aggregate(string aggregateFunction)
        {
            Series.AggregateHandler = new ClientHandlerDescriptor { HandlerName = aggregateFunction };

            return this as TSeriesBuilder;
        }

        /// <summary>
        /// Sets the series stacking order relative to other series.
        /// </summary>
        /// <param name="zIndex">
        /// The stacking order of series, relative to other series.
        /// The series with the highest Z-index will be placed on top.
        /// 
        /// Series with no Z-index will use the default stacking order based on series type.
        /// For example line series will be on top with bar and area following below.
        /// </param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Chart(Model)
        ///            .Name("Chart")
        ///            .Series(series => {
        ///                 series.Area(s => s.Sales).ZIndex(2);
        ///                 series.Column(s => s.Price).ZIndex(1);
        ///            })
        /// %&gt;
        /// </code>
        /// </example>
        public TSeriesBuilder ZIndex(double zIndex)
        {
            Series.ZIndex = zIndex;

            return this as TSeriesBuilder;
        }
    }
}