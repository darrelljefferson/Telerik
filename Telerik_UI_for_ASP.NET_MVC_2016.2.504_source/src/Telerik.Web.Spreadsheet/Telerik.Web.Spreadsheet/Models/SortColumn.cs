using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a SortColumn
    /// </summary>
    public partial class SortColumn
    {
        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }
    }
}

