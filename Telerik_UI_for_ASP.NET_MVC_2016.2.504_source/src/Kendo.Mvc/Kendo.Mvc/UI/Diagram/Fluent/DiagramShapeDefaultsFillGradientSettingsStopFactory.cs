namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Gradient for ASP.NET MVC
    /// </summary>
    public class DiagramShapeDefaultsFillGradientSettingsStopFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramShapeDefaultsFillGradientSettingsStop> container;

        public DiagramShapeDefaultsFillGradientSettingsStopFactory(List<DiagramShapeDefaultsFillGradientSettingsStop> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramShapeDefaultsFillGradientSettingsStop();

            container.Add(item);

            return new DiagramShapeDefaultsFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

