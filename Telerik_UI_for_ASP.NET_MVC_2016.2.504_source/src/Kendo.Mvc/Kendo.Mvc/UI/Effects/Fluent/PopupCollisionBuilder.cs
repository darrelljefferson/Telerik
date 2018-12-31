namespace Kendo.Mvc.UI.Fluent
{
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the <see cref="PopupCollision"/> object.
    /// </summary>
    public class PopupCollisionBuilder
    {
        public PopupCollisionBuilder(PopupCollision popupCollision)
        {
            PopupCollision = popupCollision;
        }

        protected PopupCollision PopupCollision 
        { 
            get; 
            private set; 
        }

        public void Enable(bool enable)
        {
            PopupCollision.Enabled = enable;
        }

        public PopupCollisionBuilder Collision(string collision)
        {
            PopupCollision.Collision = collision;

            return this;
        }
    }
}
