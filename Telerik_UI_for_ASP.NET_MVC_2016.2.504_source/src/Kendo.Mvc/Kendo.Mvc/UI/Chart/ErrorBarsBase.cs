namespace Kendo.Mvc.UI
{
    public abstract class ErrorBarsBase
    {
        public ErrorBarsBase()
        {
            Line = new ChartLine();
        }

        /// <summary>
        /// Gets or sets the error bars color.
        /// </summary>
        public string Color
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating if the end caps are visible
        /// </summary>
        public bool? EndCaps
        {
            get;
            set;
        }

        /// <summary>
        /// The error bars line
        /// </summary>
        public ChartLine Line
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the error bar visual handler.
        /// </summary>
        /// <value>
        /// The error bar visual handler.
        /// </value>
        public ClientHandlerDescriptor Visual
        {
            get;
            set;
        }

        public abstract IChartSerializer CreateSerializer();
    }
}
