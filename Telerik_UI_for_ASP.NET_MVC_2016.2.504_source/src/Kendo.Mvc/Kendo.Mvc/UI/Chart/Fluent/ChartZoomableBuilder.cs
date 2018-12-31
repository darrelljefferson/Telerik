namespace Kendo.Mvc.UI.Fluent
{
    using System;
    /// <summary>
    /// Defines the fluent interface for configuring the chart zoomable options.
    /// </summary>
    public class ChartZoomableBuilder : IHideObjectMembers
    {
        private readonly ChartZoomable zoomable;

        public ChartZoomableBuilder(ChartZoomable zoomable)
        {
            this.zoomable = zoomable;
        }

        /// <summary>
        /// Enable or disable mouse wheel zooming.
        /// </summary>
        public ChartZoomableBuilder Mousewheel(bool enabled)
        {
            zoomable.Mousewheel.Enabled = enabled;

            return this;
        }

        /// <summary>
        /// Configure mouse wheel zooming.
        /// </summary>
        public ChartZoomableBuilder Mousewheel(Action<ChartMousewheelZoomBuilder> configurator)
        {
            configurator(new ChartMousewheelZoomBuilder(zoomable.Mousewheel));

            return this;
        }

        /// <summary>
        /// Enable or disable selection zooming.
        /// </summary>
        public ChartZoomableBuilder Selection(bool enabled)
        {
            zoomable.Selection.Enabled = enabled;

            return this;
        }

        /// <summary>
        /// Configure selection zooming.
        /// </summary>
        public ChartZoomableBuilder Selection(Action<ChartSelectionZoomBuilder> configurator)
        {
            configurator(new ChartSelectionZoomBuilder(zoomable.Selection));

            return this;
        }
    }
}
