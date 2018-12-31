using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Column
    /// </summary>
    public partial class Column
    {
        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }
    }
}

