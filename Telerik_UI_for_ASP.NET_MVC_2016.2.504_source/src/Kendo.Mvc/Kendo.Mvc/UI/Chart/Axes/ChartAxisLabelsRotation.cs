namespace Kendo.Mvc.UI
{
    public class ChartAxisLabelsRotation
    {
        /// <summary>
        /// Gets or sets the rotation angle.
        /// </summary>
        /// <value>
        /// The rotation angle.
        /// </value>
        public object Angle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the rotation alignment.
        /// </summary>
        /// <value>
        /// The rotation alignment.
        /// </value>
        public ChartAxisLabelRotationAlignment? Align
        {
            get;
            set;
        }

        public IChartSerializer CreateSerializer()
        {
            return new ChartLabelRotationSerializer(this);
        }
    }
}
