namespace Kendo.Mvc.UI.Fluent
{
    using System.Web.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for adding items to Kendo Tool for ASP.NET MVC
    /// </summary>
    public class DiagramConnectionDefaultsEditableSettingsToolButtonFactory<TShapeModel,TConnectionModel> : IHideObjectMembers where TShapeModel : class  where TConnectionModel : class
    {
        private readonly List<DiagramConnectionDefaultsEditableSettingsToolButton> container;

        public DiagramConnectionDefaultsEditableSettingsToolButtonFactory(List<DiagramConnectionDefaultsEditableSettingsToolButton> container)
        {
            this.container = container;
        }

        //>> Factory methods
        
        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel> Add()
        {
            var item = new DiagramConnectionDefaultsEditableSettingsToolButton();

            container.Add(item);

            return new DiagramConnectionDefaultsEditableSettingsToolButtonBuilder<TShapeModel,TConnectionModel>(item);
        }
        //<< Factory methods
    }
}

