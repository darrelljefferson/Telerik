namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;

    internal class ChartPannableSerializer : IChartSerializer
    {
        private readonly ChartPannable pannable;

        public ChartPannableSerializer(ChartPannable pannable)
        {
            this.pannable = pannable;
        }

        public IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();
            if (pannable.Lock.HasValue)
            {
                result["lock"] = pannable.Lock.ToString().ToLowerInvariant();
            }

            if (pannable.Key.HasValue)
            {
                result["key"] = pannable.Key.ToString().ToLowerInvariant();
            }

            return result;
        }
    }
}
