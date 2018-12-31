using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Workbook
    /// </summary>
    public partial class Workbook
    {
        /// <summary>
        /// Adds an empty sheet
        /// </summary>
        /// <returns>The new sheet</returns>
        public Worksheet AddSheet()
        {
            if (Sheets == null)
            {
                Sheets = new List<Worksheet>();
            }

            var sheet = new Worksheet();

            Sheets.Add(sheet);

            return sheet;
        }

        internal Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            return settings;
        }

        /// <summary>
        /// Implicit Workbook conversion to Dictionary
        /// </summary>
        /// <param name="instance">Workbook instance</param>        
        public static implicit operator Dictionary<string, object>(Workbook instance)
        {
            return instance.Serialize();
        }  
    }
}

