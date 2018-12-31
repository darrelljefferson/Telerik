namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;

    internal class ChartSelectionZoomSerializer : IChartSerializer    
    {
        private readonly ChartSelectionZoom selectionZoom;

        public ChartSelectionZoomSerializer(ChartSelectionZoom selectionZoom)
        {
            this.selectionZoom = selectionZoom;
        }

        public IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();
            if (selectionZoom.Lock.HasValue)
            {
                result["lock"] = selectionZoom.Lock.ToString().ToLowerInvariant();
            }

            if (selectionZoom.Key.HasValue)
            {
                result["key"] = selectionZoom.Key.ToString().ToLowerInvariant();
            }

            return result;
        }
    }
}
