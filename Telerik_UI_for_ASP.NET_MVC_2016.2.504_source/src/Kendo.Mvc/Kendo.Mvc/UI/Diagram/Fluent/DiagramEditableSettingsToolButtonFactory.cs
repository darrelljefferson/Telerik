namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramEditableSettingsToolButton> container;

        public DiagramEditableSettingsToolButtonFactory(List<DiagramEditableSettingsToolButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramEditableSettingsToolButton();

            container.Add(item);

            return new DiagramEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

