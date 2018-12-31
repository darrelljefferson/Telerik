namespace Kendo.Mvc.UI
{
    public class ChartMousewheelZoom
    {
        public ChartMousewheelZoom()
        {
            Enabled = true;
        }

        public ChartAxisLock? Lock { get; set; }
        public bool Enabled { get; set; }

        public IChartSerializer CreateSerializer()
        {
            return new ChartMousewheelZoomSerializer(this);
        }
    }
}