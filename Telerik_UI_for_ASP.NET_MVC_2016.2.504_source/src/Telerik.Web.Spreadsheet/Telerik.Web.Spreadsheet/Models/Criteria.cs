using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Criteria
    /// </summary>
    public partial class Criteria
    {
        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }
    }
}

