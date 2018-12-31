using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a FilterColumn
    /// </summary>
    [DataContract]
    public partial class FilterColumn
    {
        /// <summary>
        /// An array of filter criteria for custom filters.
        /// </summary>
        [DataMember(Name = "criteria", EmitDefaultValue = false)]
        public List<Criteria> Criteria
        {
            get;
            set;
        }

        /// <summary>
        /// The filter to apply to this column.The supported filters are:
		///   * value - filters based on unique values
		///   * custom - applies custom filtering criteria
		///   * top - filters the top or bottom records
		///   * dynamic - filters based on dynamic criteria
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public string Filter { get; set; }

        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public double? Index { get; set; }

        /// <summary>
        /// The logical operator to apply to filter criteria.Possible values are and, or.
        /// </summary>
        [DataMember(Name = "logic", EmitDefaultValue = false)]
        public string Logic { get; set; }

        /// <summary>
        /// The filter sub-type, if any.Applicable types according to the main filter.
		/// * top
		///     * topNumber
		///     * topPercent
		///     * bottomNumber
		///     * bottomPercent
		/// * dynamic
		///     * aboveAverage
		///     * belowAverage
		///     * tomorrow
		///     * today
		///     * yesterday
		///     * nextWeek
		///     * thisWeek
		///     * lastWeek
		///     * nextMonth
		///     * thisMonth
		///     * lastMonth
		///     * nextQuarter
		///     * thisQuarter
		///     * lastQuarter
		///     * nextYear
		///     * thisYear
		///     * lastYear
		///     * yearToDate
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The filter value for filters that require a single value, e.g. "top".
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<object> Values
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates whether to include blank values
        /// </summary>
        [DataMember(Name = "blanks", EmitDefaultValue = false)]
        public bool? Blanks { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Criteria != null)
            {
                settings["criteria"] = Criteria.Select(item => item.Serialize());
            }

            if (Filter != null)
            {
                settings["filter"] = Filter;
            }

            if (Index != null)
            {
                settings["index"] = Index;
            }

            if (Logic != null)
            {
                settings["logic"] = Logic;
            }

            if (Type != null)
            {
                settings["type"] = Type;
            }

            if (Value != null)
            {
                settings["value"] = Value;
            }

            if (Values != null)
            {
                settings["values"] = Values;
            }

            if (Blanks != null)
            {
                settings["blanks"] = Blanks;
            }

            return settings;
        }
    }
}
