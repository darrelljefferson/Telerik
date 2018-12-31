namespace Kendo.Mvc.UI.Fluent
{
    using Extensions;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the fluent interface for configuring group.
    /// </summary>
    public class DataSourceGroupDescriptorFactory<TModel> : DataSourceGroupDescriptorFactoryBase<DataSourceGroupDescriptorFactory<TModel>>, IHideObjectMembers
        where TModel : class
    {
        public DataSourceGroupDescriptorFactory(IList<GroupDescriptor> descriptors)
            : base(descriptors)
        {
        }

        /// <summary>
        /// Specifies the member by which the data should be grouped.
        /// </summary>
        /// <param name="expression">Member access expression which describes the member</param>     
        public DataSourceGroupDescriptorBuilder Add<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            return AddDescriptor<TValue>(expression.MemberWithoutInstance(), ListSortDirection.Ascending);
        }

        /// <summary>
        /// Specifies the member by which the data should be grouped.
        /// </summary>
        /// <typeparam name="TValue">Member type</typeparam>
        /// <param name="memberName">Member name</param>        
        public DataSourceGroupDescriptorBuilder Add<TValue>(string memberName)
        {
            return AddDescriptor<TValue>(memberName, ListSortDirection.Ascending);
        }

        /// <summary>
        /// Specifies the member by which the data should be grouped.
        /// </summary>
        /// <typeparam name="TValue">Member type</typeparam>
        /// <param name="memberName">Member type</param>
        /// <param name="sortDirection">Sort order</param>
        /// <returns></returns>
        public DataSourceGroupDescriptorBuilder Add<TValue>(string memberName, ListSortDirection sortDirection)
        {
            return AddDescriptor<TValue>(memberName, sortDirection);
        }

        /// <summary>
        /// Specifies the member by which the data should be sorted in descending order and grouped.
        /// </summary>
        /// <typeparam name="TValue">Member type</typeparam>
        /// <param name="expression">Member access expression which describes the member</param>        
        public DataSourceGroupDescriptorBuilder AddDescending<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            return AddDescriptor<TValue>(expression.MemberWithoutInstance(), ListSortDirection.Descending);
        }

        /// <summary>
        /// Specifies the member by which the data should be sorted in descending order and grouped.
        /// </summary>
        /// <typeparam name="TValue">Member type</typeparam>
        /// <param name="memberName">Member name</param>
        public DataSourceGroupDescriptorBuilder AddDescending<TValue>(string memberName)
        {
            return AddDescriptor<TValue>(memberName, ListSortDirection.Descending);
        }
        
        private DataSourceGroupDescriptorBuilder AddDescriptor<TValue>(string memberName, ListSortDirection sortDirection)
        {
            return AddDescriptor(memberName, typeof(TValue), sortDirection);
        }
    }
}
