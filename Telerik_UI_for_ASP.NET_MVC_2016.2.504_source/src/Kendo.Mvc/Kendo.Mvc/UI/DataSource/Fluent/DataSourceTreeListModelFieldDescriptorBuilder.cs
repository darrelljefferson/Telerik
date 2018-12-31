namespace Kendo.Mvc.UI.Fluent
{
    using System;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="ModelFieldDescriptor"/>.
    /// </summary>
    public class DataSourceTreeListModelFieldDescriptorBuilder<T> : DataSourceModelFieldDescriptorBuilderBase<T, DataSourceTreeListModelFieldDescriptorBuilder<T>>
    {
        public DataSourceTreeListModelFieldDescriptorBuilder(ModelFieldDescriptor descriptor)
            : base(descriptor)
        {
        }

        /// <summary>
        /// Specifies if the defaultValue setting should be used. The default is false.
        /// </summary>
        /// <param name="value">The value</param>        
        public virtual DataSourceTreeListModelFieldDescriptorBuilder<T> Nullable(bool value = true)
        {
            descriptor.IsNullable = value;

            return this;
        }
    }
}
