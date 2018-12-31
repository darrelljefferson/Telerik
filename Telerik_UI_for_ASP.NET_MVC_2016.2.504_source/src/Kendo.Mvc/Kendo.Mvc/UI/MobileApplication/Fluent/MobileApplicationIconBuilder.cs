namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo MobileApplication Icon.
    /// </summary>
    public class MobileApplicationIconBuilder
    {
        protected IDictionary<string, string> Icon { get; private set; }

        public MobileApplicationIconBuilder(IDictionary<string, string> icon)            
        {
            Icon = icon;
        }

        /// <summary>
        /// Add icon url per dimension
        /// </summary>
        /// <param name="dimension">The dimension in format 72x72</param>
        /// <param name="url">The dimension url</param>        
        public MobileApplicationIconBuilder Add(string dimension, string url)
        {
            Icon.Add(dimension, url);

            return this;
        }

        /// <summary>
        /// Default dimension icon url
        /// </summary>
        /// <param name="url">The icon url</param>        
        public MobileApplicationIconBuilder DefaultIcon(string url)
        {
            Icon.Add("", url);

            return this;
        }
    }
}
