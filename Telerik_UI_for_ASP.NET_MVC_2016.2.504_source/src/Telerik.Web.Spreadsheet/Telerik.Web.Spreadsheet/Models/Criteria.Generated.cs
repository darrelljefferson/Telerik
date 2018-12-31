using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Represents a Criteria
    /// </summary>
    [DataContract]
    public partial class Criteria
    {
        /// <summary>
        /// The criterion operator type.Supported types vary based on the inferred column data type (inferred):
		/// * Text
		///     * contains - the text contains the value
		///     * doesnotcontain - text does not contain the value
		///     * startswith - text starts with the value
		///     * endswith - text ends with the value
		/// * Date
		///     * eq -  date is the same as the value
		///     * neq - date is not the same as the value
		///     * lt -  date is before the value
		///     * gt -  date is after the value
		/// * Number
		///     * eq - is equal to the value
		///     * neq - is not equal to the value
		///     * gte - is greater than or equal to the value
		///     * gt - is greater than the value
		///     * lte - is less than or equal to the value
		///     * lt - is less than the value
        /// </summary>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public object Value { get; set; }


        /// <summary>
        /// Serialize current instance to Dictionary
        /// </summary>
        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Operator != null)
            {
                settings["operator"] = Operator;
            }

            if (Value != null)
            {
                settings["value"] = Value;
            }

            return settings;
        }
    }
}
