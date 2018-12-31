namespace Kendo.Mvc.UI.Fluent
{
    using Extensions;
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="DataSource"/> Model definition.
    /// </summary>
    /// <typeparam name="TModel">Type of the model</typeparam>
    public class DataSourceTreeListModelDescriptorFactory<TModel> : DataSourceModelDescriptorFactoryBase<TModel>, IHideObjectMembers
        where TModel : class
    {
        private TreeListModelDescriptor treelistModel;

        public DataSourceTreeListModelDescriptorFactory(TreeListModelDescriptor model)
          : base(model)
        {
            treelistModel = model;
        }

        /// <summary>
        /// Specify the member used to identify an unique Model instance.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        public new void Id(string fieldName)
        {
            base.Id(fieldName);
        }

        /// <summary>
        /// Specify the member used to identify an unique Model instance.
        /// </summary>
        /// <typeparam name="TValue">Type of the field</typeparam>
        /// <param name="expression">Member access expression which describes the member</param>
        public virtual void Id<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var dataKey = new GridDataKey<TModel, TValue>(expression);
            dataKey.RouteKey = dataKey.Name;

            model.Id = dataKey;
        }

        /// <summary>
        /// Specify the member used for the parentId field.
        /// </summary>
        /// <param name="expression">Member access expression which describes the member</param>
        public DataSourceTreeListModelFieldDescriptorBuilder<TValue> ParentId<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            treelistModel.ParentId = expression.MemberWithoutInstance();

            return AddFieldDescriptor<TValue>(treelistModel.ParentId, typeof(TValue));
        }

        /// <summary>
        /// Specify the member used for the parentId field.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        /// <typeparam name="TValue">Type of the field</typeparam>
        public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> ParentId<TValue>(string memberName)
        {
            treelistModel.ParentId = memberName;

            return AddFieldDescriptor<TValue>(memberName, typeof(TValue));
        }

        /// <summary>
        /// Specify the member used for the expanded field.
        /// </summary>
        /// <param name="expression">Member access expression which describes the member</param>
        public DataSourceTreeListModelFieldDescriptorBuilder<TValue> Expanded<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            treelistModel.Expanded = expression.MemberWithoutInstance();

            return AddFieldDescriptor<TValue>((string)treelistModel.Expanded, typeof(TValue));
        }

        /// <summary>
        /// Specify the member used for the expanded field.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        /// <typeparam name="TValue">Type of the field</typeparam>
        public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> Expanded<TValue>(string memberName)
        {
            treelistModel.Expanded = memberName;

            return AddFieldDescriptor<TValue>(memberName, typeof(TValue));
        }

        /// <summary>
        /// Specify the default value of the expanded field.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        /// <typeparam name="TValue">Type of the field</typeparam>
        public virtual DataSourceTreeListModelDescriptorFactory<TModel> Expanded(bool defaultValue)
        {
            treelistModel.Expanded = defaultValue;

            return this;
        }

        /// <summary>
        /// Describes a Model field
        /// </summary>
        /// <typeparam name="TValue">Field type</typeparam>
        /// <param name="expression">Member access expression which describes the field</param>        
        public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> Field<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            return AddFieldDescriptor<TValue>(expression.MemberWithoutInstance(), typeof(TValue));
        }

        /// <summary>
        /// Describes a Model field
        /// </summary>
        /// <param name="memberName">Field name</param>
        /// <param name="memberType">Field type</param>        
        public virtual DataSourceTreeListModelFieldDescriptorBuilder<object> Field(string memberName, Type memberType)
        {
            return AddFieldDescriptor<object>(memberName, memberType);
        }

        /// <summary>
        /// Describes a Model field
        /// </summary>
        /// <typeparam name="TValue">Field type</typeparam>
        /// <param name="memberName">Member name</param>        
        public virtual DataSourceTreeListModelFieldDescriptorBuilder<TValue> Field<TValue>(string memberName)
        {
            return AddFieldDescriptor<TValue>(memberName, typeof(TValue));
        }

        private DataSourceTreeListModelFieldDescriptorBuilder<TValue> AddFieldDescriptor<TValue>(string memberName, Type memberType)
        {
            var descriptor = model.AddDescriptor(memberName);

            descriptor.MemberType = memberType;

            return new DataSourceTreeListModelFieldDescriptorBuilder<TValue>(descriptor);
        }
    }
}
