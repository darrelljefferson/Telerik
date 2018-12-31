namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramConnectionEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramConnectionEditableSettingsToolButton> container;

        public DiagramConnectionEditableSettingsToolButtonFactory(List<DiagramConnectionEditableSettingsToolButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramConnectionEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramConnectionEditableSettingsToolButton();

            container.Add(item);

            return new DiagramConnectionEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

