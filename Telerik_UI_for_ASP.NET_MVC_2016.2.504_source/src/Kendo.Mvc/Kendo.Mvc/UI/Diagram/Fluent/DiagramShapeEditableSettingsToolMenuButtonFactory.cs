namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramShapeEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramShapeEditableSettingsToolMenuButton> container;

        public DiagramShapeEditableSettingsToolMenuButtonFactory(List<DiagramShapeEditableSettingsToolMenuButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramShapeEditableSettingsToolMenuButton();

            container.Add(item);

            return new DiagramShapeEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

