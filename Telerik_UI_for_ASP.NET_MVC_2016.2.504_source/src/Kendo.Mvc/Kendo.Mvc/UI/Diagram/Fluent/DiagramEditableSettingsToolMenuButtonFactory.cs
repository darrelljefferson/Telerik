namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramEditableSettingsToolMenuButton> container;

        public DiagramEditableSettingsToolMenuButtonFactory(List<DiagramEditableSettingsToolMenuButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramEditableSettingsToolMenuButton();

            container.Add(item);

            return new DiagramEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

