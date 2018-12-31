using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI
{
    public class ChartLegendItemSerializer : IChartSerializer
    {
        private readonly ChartLegendItem legendItem;

        public ChartLegendItemSerializer(ChartLegendItem legendItem)
        {
            this.legendItem = legendItem;
        }

        public System.Collections.Generic.IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();
            if (legendItem.Visual != null)
            {
                result["visual"] = legendItem.Visual;
            }

            if (legendItem.Cursor.HasValue())
            {
                result["cursor"] = legendItem.Cursor;
            }

            return result;
        }
    }
}
