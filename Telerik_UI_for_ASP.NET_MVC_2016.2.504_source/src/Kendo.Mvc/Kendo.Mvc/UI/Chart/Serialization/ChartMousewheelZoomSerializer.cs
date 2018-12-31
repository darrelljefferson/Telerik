namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;

    internal class ChartMousewheelZoomSerializer : IChartSerializer
    {
        private readonly ChartMousewheelZoom mousewheelZoom;

        public ChartMousewheelZoomSerializer(ChartMousewheelZoom mousewheelZoom)
        {
            this.mousewheelZoom = mousewheelZoom;
        }

        public IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();
            if (mousewheelZoom.Lock.HasValue)
            {
                result["lock"] = mousewheelZoom.Lock.ToString().ToLowerInvariant();
            }

            return result;
        }
    }
}
