namespace Kendo.Mvc.UI
{    
    using System.Collections.Generic;
using System.Web.Script.Serialization;

    public class VirtualSettings
    {
        public bool Enable{ get; set; }
        public int ItemHeight { get; set; }
        public ClientHandlerDescriptor ValueMapper { get; set; }

        public IDictionary<string, object> SeriailzeOptions()
        {
            var options = new Dictionary<string, object>();

            if (ValueMapper != null)
            {
                options["valueMapper"] = ValueMapper;

                if (ItemHeight > 0)
                {
                    options["itemHeight"] = ItemHeight;
                }
            }

            return options;
        }
    }
}