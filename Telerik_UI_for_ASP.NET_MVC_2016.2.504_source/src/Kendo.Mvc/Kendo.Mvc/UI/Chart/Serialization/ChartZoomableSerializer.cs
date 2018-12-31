namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;

    internal class ChartZoomableSerializer : IChartSerializer        
    {
        private readonly ChartZoomable zoomable;

        public ChartZoomableSerializer(ChartZoomable zoomable)
        {
            this.zoomable = zoomable;
        }

        public IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();                       

            if (zoomable.Mousewheel.Enabled)
            {
                var mousewheel = zoomable.Mousewheel.CreateSerializer().Serialize();
                if (mousewheel.Count > 0)
	            {
		            result["mousewheel"] = mousewheel;
	            }                
            }
            else
            {
                result["mousewheel"] = false;
            }

            if (zoomable.Selection.Enabled)
            {
                var selection = zoomable.Selection.CreateSerializer().Serialize();
                if (selection.Count > 0)
                {
                    result["selection"] = selection;
                }                
            }
            else
            {
                result["selection"] = false;
            }

            return result;
        }
    }
}
