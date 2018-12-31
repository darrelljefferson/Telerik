namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramConnectionEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramConnectionEditableSettingsToolMenuButton> container;

        public DiagramConnectionEditableSettingsToolMenuButtonFactory(List<DiagramConnectionEditableSettingsToolMenuButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramConnectionEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramConnectionEditableSettingsToolMenuButton();

            container.Add(item);

            return new DiagramConnectionEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

