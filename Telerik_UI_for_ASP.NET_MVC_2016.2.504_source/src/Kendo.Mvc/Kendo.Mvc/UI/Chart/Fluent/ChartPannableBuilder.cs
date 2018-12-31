namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the chart pannable options.
    /// </summary>
    public class ChartPannableBuilder : IHideObjectMembers
    {
        private readonly ChartPannable pannable;

        public ChartPannableBuilder(ChartPannable pannable)
        {
            this.pannable = pannable;
        }

        /// <summary>
        /// Lock the specified axis during panning.
        /// </summary>
        public ChartPannableBuilder Lock(ChartAxisLock axisLock)
        {
            pannable.Lock = axisLock;

            return this;
        }

        /// <summary>
        /// Set the key that shuold be pressed to activate panning.
        /// </summary>
        public ChartPannableBuilder Key(ChartActivationKey key)
        {
            pannable.Key = key;

            return this;
        }
    }
}
