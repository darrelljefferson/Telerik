using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a BorderStyle
    /// </summary>
    public partial class BorderStyle
    {
        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }
    }
}

