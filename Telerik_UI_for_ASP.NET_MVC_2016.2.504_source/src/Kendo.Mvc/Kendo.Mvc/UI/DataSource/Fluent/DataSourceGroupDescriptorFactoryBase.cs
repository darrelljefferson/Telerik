namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Defines the fluent interface for configuring group.
    /// </summary>    
    public abstract class DataSourceGroupDescriptorFactoryBase<TDataSourceGroupDescriptorFactory> : IHideObjectMembers
        where TDataSourceGroupDescriptorFactory : DataSourceGroupDescriptorFactoryBase<TDataSourceGroupDescriptorFactory>
    {
        private readonly IList<GroupDescriptor> descriptors;

        public DataSourceGroupDescriptorFactoryBase(IList<GroupDescriptor> descriptors)
        {
            this.descriptors = descriptors;
        }

        /// <summary>
        /// Specifies the member by which the data should be grouped.
        /// </summary>
        /// <param name="memberName">Member name</param>
        /// <param name="memberType">Member type</param>        
        public DataSourceGroupDescriptorBuilder Add(string memberName, Type memberType)
        {
            return AddDescriptor(memberName, memberType, ListSortDirection.Ascending);
        }

        /// <summary>
        /// Specifies the member by which the data should be grouped.
        /// </summary>
        /// <param name="memberName">Member name</param>
        /// <param name="memberType">Member type</param>
        /// <param name="sortDirection">Sort order</param>        
        public DataSourceGroupDescriptorBuilder Add(string memberName, Type memberType, ListSortDirection sortDirection)
        {
            return AddDescriptor(memberName, memberType, sortDirection);
        }

        /// <summary>
        /// Specifies the member by which the data should be sorted in descending order and grouped.
        /// </summary>        
        /// <param name="memberName">Member name</param>
        /// /// <param name="memberType">Member type</param>
        public DataSourceGroupDescriptorBuilder AddDescending(string memberName, Type memberType)
        {
            return AddDescriptor(memberName, memberType, ListSortDirection.Descending);
        }

        protected DataSourceGroupDescriptorBuilder AddDescriptor(string memberName, Type memberType, ListSortDirection sortDirection)
        {
            var descriptor = new GroupDescriptor();
            descriptor.Member = memberName;
            descriptor.SortDirection = sortDirection;
            descriptor.MemberType = memberType;

            descriptors.Add(descriptor);

            return new DataSourceGroupDescriptorBuilder(descriptor);
        }
    }
}