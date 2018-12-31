using System.Collections.Generic;
using System.Runtime.Serialization;
namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Describes an item used by the value filter to filter date values.
    /// </summary>
    [DataContract]
    public class ValueFilterDate
    {        
        /// <summary>
        /// Gets or sets or sets the year.
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the month.
        /// </summary>        
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public int Month
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the day.
        /// </summary>        
        [DataMember(Name = "day", EmitDefaultValue = false)]
        public int Day
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the hour.
        /// </summary>        
        [DataMember(Name = "hours", EmitDefaultValue = false)]
        public int Hours
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the minute.
        /// </summary>
        [DataMember(Name = "minutes", EmitDefaultValue = false)]
        public int Minutes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the second.
        /// </summary> 
        [DataMember(Name = "seconds", EmitDefaultValue = false)]
        public int Seconds
        {
            get;
            set;
        }

        internal Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            settings["year"] = Year;
            settings["month"] = Month;
            settings["day"] = Day;
            settings["hours"] = Hours;
            settings["minutes"] = Minutes;
            settings["seconds"] = Seconds;

            return settings;
        }
    }
}
