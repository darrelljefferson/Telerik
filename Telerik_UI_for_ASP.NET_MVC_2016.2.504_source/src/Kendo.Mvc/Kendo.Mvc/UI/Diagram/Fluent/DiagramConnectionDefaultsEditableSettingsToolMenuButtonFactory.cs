namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramConnectionDefaultsEditableSettingsToolMenuButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramConnectionDefaultsEditableSettingsToolMenuButton> container;

        public DiagramConnectionDefaultsEditableSettingsToolMenuButtonFactory(List<DiagramConnectionDefaultsEditableSettingsToolMenuButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramConnectionDefaultsEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramConnectionDefaultsEditableSettingsToolMenuButton();

            container.Add(item);

            return new DiagramConnectionDefaultsEditableSettingsToolMenuButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

