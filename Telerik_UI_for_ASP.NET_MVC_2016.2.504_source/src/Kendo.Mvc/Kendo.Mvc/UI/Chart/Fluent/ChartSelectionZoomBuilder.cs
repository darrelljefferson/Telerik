namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the chart selection zoom options.
    /// </summary>
    public class ChartSelectionZoomBuilder : IHideObjectMembers
    {
        private readonly ChartSelectionZoom selectionZoom;

        public ChartSelectionZoomBuilder(ChartSelectionZoom selectionZoom)
        {
            this.selectionZoom = selectionZoom;
        }

        /// <summary>
        /// Lock the specified axis during zooming.
        /// </summary>
        public ChartSelectionZoomBuilder Lock(ChartAxisLock axisLock)
        {
            selectionZoom.Lock = axisLock;

            return this;
        }

        /// <summary>
        /// Set the key that shuold be pressed to activate selection zooming.
        /// </summary>
        public ChartSelectionZoomBuilder Key(ChartActivationKey key)
        {
            selectionZoom.Key = key;

            return this;
        }
    }
}
