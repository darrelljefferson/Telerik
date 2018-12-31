namespace Kendo.Mvc.UI
{
    public class ChartPannable
    {
        public ChartAxisLock? Lock { get; set; }
        public ChartActivationKey? Key { get; set; }
        public bool Enabled { get; set; }

        public IChartSerializer CreateSerializer()
        {
            return new ChartPannableSerializer(this);
        }
    }
}
