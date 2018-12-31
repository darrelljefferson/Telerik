namespace Kendo.Mvc.UI.Fluent
{
    using System;

    public class ChartAxisLabelsRotationBuilder : IHideObjectMembers
    {
        private readonly ChartAxisLabelsRotation axisLabelsRotation;

        public ChartAxisLabelsRotationBuilder(ChartAxisLabelsRotation rotation)
        {
            this.axisLabelsRotation = rotation;
        }

        public ChartAxisLabelsRotationBuilder Angle(string rotation)
        {
            axisLabelsRotation.Angle = rotation;

            return this;
        }

        public ChartAxisLabelsRotationBuilder Angle(int rotation)
        {
            axisLabelsRotation.Angle = rotation;

            return this;
        }

        public ChartAxisLabelsRotationBuilder Align(ChartAxisLabelRotationAlignment align)
        {
            axisLabelsRotation.Align = align;

            return this;
        }
    }
}
