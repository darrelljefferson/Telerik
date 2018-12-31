namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;

    public class ReadOnlyCustomDataSourceGroupDescriptorFactory : DataSourceGroupDescriptorFactoryBase<ReadOnlyCustomDataSourceGroupDescriptorFactory>, IHideObjectMembers
    {
        public ReadOnlyCustomDataSourceGroupDescriptorFactory(IList<GroupDescriptor> descriptors)
            : base(descriptors)
        {
        }
    }
}