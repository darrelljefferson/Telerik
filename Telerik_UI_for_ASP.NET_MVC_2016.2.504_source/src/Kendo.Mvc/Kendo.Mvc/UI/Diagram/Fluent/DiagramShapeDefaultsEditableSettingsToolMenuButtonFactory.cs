namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramShapeDefaultsEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramShapeDefaultsEditableSettingsToolMenuButton> container;

        public DiagramShapeDefaultsEditableSettingsToolMenuButtonFactory(List<DiagramShapeDefaultsEditableSettingsToolMenuButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramShapeDefaultsEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramShapeDefaultsEditableSettingsToolMenuButton();

            container.Add(item);

            return new DiagramShapeDefaultsEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

