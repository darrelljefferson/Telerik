namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramShapeEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramShapeEditableSettingsToolButton> container;

        public DiagramShapeEditableSettingsToolButtonFactory(List<DiagramShapeEditableSettingsToolButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramShapeEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramShapeEditableSettingsToolButton();

            container.Add(item);

            return new DiagramShapeEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

