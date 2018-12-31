using System.Linq;
using System.Collections.Generic;
using Telerik.Windows.Documents.Spreadsheet.Model.Filtering;
using System;
using Telerik.Windows.Documents.Spreadsheet.Model;

namespace Telerik.Web.Spreadsheet
{     
    enum StringFilterOpperators 
    {
        EqualsTo = 0,
        StartsWith = 1,
        EndsWith = 2,
        Contains = EqualsTo | StartsWith | EndsWith,
        NotEqualsTo = 5,
        DoesNotContain = NotEqualsTo | StartsWith | EndsWith
    }

    /// <summary>
    /// Extensions methods for DPL filters
    /// </summary>
    public static class FilterExtensions
    {
        /// <summary>
        /// Converts DPL filter expressions to Telerik.Web.Spreadsheet.FilterColumn
        /// </summary>        
        public static FilterColumn ToFilterColumn(this IFilter filter)
        {
            if (filter is TopFilter)
            {
                return ToFilterColumn((TopFilter)filter);
            }

            if (filter is ValuesCollectionFilter)
            {
                return ToFilterColumn((ValuesCollectionFilter)filter);
            }

            if (filter is DynamicFilter)
            {
                return ToFilterColumn((DynamicFilter)filter);
            }

            if (filter is CustomFilter)
            {
                return ToFilterColumn((CustomFilter)filter);
            }

            return null;
        }

        private static FilterColumn ToFilterColumn(TopFilter filter)
        {
            return new FilterColumn
            {
                Index = filter.RelativeColumnIndex,
                Filter = "top",
                Type = filter.TopFilterType.ToString().ToCamelCase(),
                Value = filter.Value
            };
        }

        private static FilterColumn ToFilterColumn(DynamicFilter filter)
        {
            return new FilterColumn
            {
                Filter = "dynamic",
                Index = filter.RelativeColumnIndex,
                Type = filter.DynamicFilterType.ToString().ToCamelCase()
            };
        }

        private static FilterColumn ToFilterColumn(ValuesCollectionFilter filter)
        {            
            return new FilterColumn
            {
                Index = filter.RelativeColumnIndex,
                Filter = "value",
                Blanks = filter.Blank,
                Dates = filter.DateItems.Select(item => new ValueFilterDate {
                    Year = item.Year,
                    Month = item.Month == 0 ? item.Month : item.Month - 1,
                    Day = item.Day,
                    Hours = item.Hour,
                    Minutes = item.Minute,
                    Seconds = item.Second
                }).ToList(),
                Values = filter.StringValues.Select(value => ParseValue(value)).ToList()
            };
        }      

        private static FilterColumn ToFilterColumn(CustomFilter filter)
        {
            return new FilterColumn
            {
                Filter = "custom",
                Index = filter.RelativeColumnIndex,
                Logic = filter.LogicalOperator.ToString().ToLowerInvariant(),
                Criteria = CreateFilterCriteria(filter)
            };
        }

        private static List<Criteria> CreateFilterCriteria(CustomFilter filter)
        {
            var criterias = new List<Criteria>();

            if (filter.Criteria1 != null)
            {
                criterias.Add(ToCriteria(filter.Criteria1));
            }

            if (filter.Criteria2 != null)
            {
                criterias.Add(ToCriteria(filter.Criteria2));
            }

            return criterias;
        }

        private static Criteria ToCriteria(CustomFilterCriteria source)
        {
            var @operator = ComparisonOperators[source.ComparisonOperator.ToString().ToLowerInvariant()];
            var value = ParseValue(source.FilterValue);

            if (value is string && (source.ComparisonOperator == ComparisonOperator.EqualsTo || source.ComparisonOperator == ComparisonOperator.NotEqualsTo))
            {
                var startsWith = value.ToString().EndsWith("*") ? StringFilterOpperators.StartsWith : StringFilterOpperators.EqualsTo;
                var endsWith = value.ToString().StartsWith("*") ? StringFilterOpperators.EndsWith : StringFilterOpperators.EqualsTo;

                var flags = (int)source.ComparisonOperator | (int)startsWith | (int)endsWith;
                
                @operator = ComparisonOperators[Enum.GetName(typeof(StringFilterOpperators), flags).ToLowerInvariant()];

                value = value.ToString().TrimStart('*').TrimEnd('*');
            }            

            return new Criteria {
                Operator = @operator,
                Value = value
            };
        }

        private static object ParseValue(string value)
        {
            double number;
            bool boolean;

            if (double.TryParse(value, out number))
            {
                return (object)number;
            }
            else if (bool.TryParse(value, out boolean))
            {
                return (object)boolean;
            }
            
            return value;            
        }

        private static readonly Dictionary<string, string> ComparisonOperators = new Dictionary<string, string>
        {
            { "contains", "contains" },
            { "doesnotcontain", "doesnotcontain" },
            { "startswith", "startswith" },
            { "endswith", "endswith" },
            { "equalsto", "eq" },
            { "notequalsto", "neq" },
            { "lessthan", "lt" },
            { "greaterthan", "gt" },
            { "greaterthanorequalsto", "gte" },
            { "lessthanorequalsto", "lte" }   
        };
    }
}
