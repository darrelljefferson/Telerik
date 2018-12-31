namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using Kendo.Mvc.Infrastructure;

    internal class ChartLabelRotationSerializer : IChartSerializer
    {
        private readonly ChartAxisLabelsRotation labelRotation;

        public ChartLabelRotationSerializer(ChartAxisLabelsRotation labelRotation)
        {
            this.labelRotation = labelRotation;
        }

        public IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();

            FluentDictionary.For(result)
               .Add("align", labelRotation.Align.ToString().ToLowerInvariant(), () => labelRotation.Align.HasValue)
               .Add("angle", labelRotation.Angle, () => labelRotation.Angle != null);

            return result;
        }
    }
}
