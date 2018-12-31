namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the chart mouse wheel zoom options.
    /// </summary>
    public class ChartMousewheelZoomBuilder : IHideObjectMembers
    {
        private readonly ChartMousewheelZoom mousewheelZoom;

        public ChartMousewheelZoomBuilder(ChartMousewheelZoom mousewheelZoom)
        {
            this.mousewheelZoom = mousewheelZoom;
        }

        /// <summary>
        /// Lock the specified axis during zooming.
        /// </summary>
        public ChartMousewheelZoomBuilder Lock(ChartAxisLock axisLock)
        {
            mousewheelZoom.Lock = axisLock;

            return this;
        }
    }
}
