using System;
using System.Collections.Generic;
using System.Linq;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI
{
    public class StringOperators : JsonObject
    {
        public StringOperators()
        {
            Operators = new Dictionary<string, string>()
            {
                { "eq", Messages.Filter_StringIsEqualTo },
                { "neq", Messages.Filter_StringIsNotEqualTo },
                { "startswith", Messages.Filter_StringStartsWith },
                { "endswith", Messages.Filter_StringEndsWith },
                { "contains", Messages.Filter_StringContains },
                { "doesnotcontain", Messages.Filter_StringDoesNotContain },
                { "isnull", Messages.Filter_StringIsNull },
                { "isnotnull", Messages.Filter_StringIsNotNull },
                { "isempty", Messages.Filter_StringIsEmpty },
                { "isnotempty", Messages.Filter_StringIsNotEmpty }
            };
        }

        private const string DefaultIsEqualTo = "Is equal to";
        private const string DefaultIsNotEqualTo = "Is not equal to";
        private const string DefaultStartsWith = "Starts with";
        private const string DefaultEndsWith = "Ends with";
        private const string DefaultContains = "Contains";
        private const string DefaultDoesNotContain = "Does not contain";
        private const string DefaultIsNull = "Is null";
        private const string DefaultIsNotNull = "Is not null";
        private const string DefaultIsEmpty = "Is empty";
        private const string DefaultIsNotEmpty = "Is not empty";

        private const int DefaultNumberOfFilters = 10;

        protected override void Serialize(IDictionary<string, object> json)
        {
            bool dirty = false;

            if (Operators.Count != DefaultNumberOfFilters)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("eq") && Operators["eq"] != DefaultIsEqualTo)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("neq") && Operators["neq"] != DefaultIsNotEqualTo)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("startswith") && Operators["startswith"] != DefaultStartsWith)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("endswith") && Operators["endswith"] != DefaultEndsWith)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("contains") && Operators["contains"] != DefaultContains)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("doesnotcontain") && Operators["doesnotcontain"] != DefaultDoesNotContain)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("isnull") && Operators["isnull"] != DefaultIsNull)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("isnotnull") && Operators["isnotnull"] != DefaultIsNotNull)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("isempty") && Operators["isempty"] != DefaultIsEmpty)
            {
                dirty = true;
            }

            if (Operators.ContainsKey("isnotempty") && Operators["isnotempty"] != DefaultIsNotEmpty)
            {
                dirty = true;
            }

            if (dirty)
            {
                foreach (var keyValue in Operators)
                {
                    json[keyValue.Key] = keyValue.Value;
                }
            }
        }

        public IDictionary<string, string> Operators { get; private set; }
    }
}
