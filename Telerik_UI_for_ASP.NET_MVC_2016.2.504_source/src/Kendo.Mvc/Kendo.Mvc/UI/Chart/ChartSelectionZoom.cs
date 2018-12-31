namespace Kendo.Mvc.UI
{
    public class ChartSelectionZoom
    {
        public ChartSelectionZoom()
        {
            Enabled = true;
        }

        public ChartAxisLock? Lock { get; set; }
        public ChartActivationKey? Key { get; set; }
        public bool Enabled { get; set; }

        public IChartSerializer CreateSerializer()
        {
            return new ChartSelectionZoomSerializer(this);
        }
    }
}