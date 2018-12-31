namespace Kendo.Mvc.UI.Fluent
{
    using System;

    public abstract class DataSourceFilterEqualityDescriptorBuilderBase<TValue, TCompositeBuilder> : DataSourceFilterDescriptorBuilderBase where TCompositeBuilder : DataSourceFilterCompositeBuilderBase
    {
        protected DataSourceFilterEqualityDescriptorBuilderBase(CompositeFilterDescriptor descriptor) : base(descriptor)
        {
        }

        public TCompositeBuilder IsEqualTo(TValue value)
        {
            SetOperatorAndValue(FilterOperator.IsEqualTo, value);

            return CreateBuilder();
        }

        public TCompositeBuilder IsNotEqualTo(TValue value)
        {
            SetOperatorAndValue(FilterOperator.IsNotEqualTo, value);

            return CreateBuilder();
        }

        public TCompositeBuilder IsNull()
        {
            SetOperatorAndValue(FilterOperator.IsNull, null);

            return CreateBuilder();
        }

        public TCompositeBuilder IsNotNull()
        {
            SetOperatorAndValue(FilterOperator.IsNotNull, null);

            return CreateBuilder();
        }

        protected TCompositeBuilder CreateBuilder()
        {
            return (TCompositeBuilder) Activator.CreateInstance(typeof(TCompositeBuilder), new object[] { Descriptor });
        }
    }
}