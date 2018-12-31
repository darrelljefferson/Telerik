namespace Kendo.Mvc.UI
{
    public class ChartZoomable
    {
        public ChartZoomable()
        {
            Selection = new ChartSelectionZoom();
            Mousewheel = new ChartMousewheelZoom();
        }

        public ChartSelectionZoom Selection { get; set; }
        public ChartMousewheelZoom Mousewheel { get; set; }

        public bool Enabled { get; set; }

        public IChartSerializer CreateSerializer()
        {
            return new ChartZoomableSerializer(this);
        }
    }
}