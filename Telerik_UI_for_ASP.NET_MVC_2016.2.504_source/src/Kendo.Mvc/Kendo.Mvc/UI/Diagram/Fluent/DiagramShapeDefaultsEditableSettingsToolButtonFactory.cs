namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramShapeDefaultsEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramShapeDefaultsEditableSettingsToolButton> container;

        public DiagramShapeDefaultsEditableSettingsToolButtonFactory(List<DiagramShapeDefaultsEditableSettingsToolButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramShapeDefaultsEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramShapeDefaultsEditableSettingsToolButton();

            container.Add(item);

            return new DiagramShapeDefaultsEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

