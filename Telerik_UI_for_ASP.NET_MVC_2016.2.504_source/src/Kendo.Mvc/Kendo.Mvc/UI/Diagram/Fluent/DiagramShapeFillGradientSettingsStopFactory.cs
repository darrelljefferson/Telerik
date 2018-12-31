namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Gradient for ASP.NET MVC
    /// </summary>
    public class DiagramShapeFillGradientSettingsStopFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramShapeFillGradientSettingsStop> container;

        public DiagramShapeFillGradientSettingsStopFactory(List<DiagramShapeFillGradientSettingsStop> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramShapeFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramShapeFillGradientSettingsStop();

            container.Add(item);

            return new DiagramShapeFillGradientSettingsStopBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

