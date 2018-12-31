using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Utilities;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// General purpose extension methods
    /// </summary>
    public static class CommonExtensions
    {             
        /// <summary>
        /// Converts the value to pixels string, i.e 10.0 to "10px"
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <returns>Converted value</returns>
        public static string ToPixels(this double value)
        {
            return Math.Round(value).ToString() + "px";
        }

        /// <summary>
        /// Converts cell reference to CellIndex structure
        /// </summary>
        /// <param name="cellRef">Cell reference, i.e A7</param>
        /// <returns>Structure representing cell index</returns>
        public static CellIndex ToCellIndex(this string cellRef)
        {
            CellRange cellRange;

            if (NameConverter.TryConvertCellNameToCellRange(cellRef, out cellRange))
            {
                return cellRange.FromIndex;
            }

            return new CellIndex(0, 0);
        }

        /// <summary>
        /// Converts cell reference to list of cell ranges
        /// </summary>
        /// <param name="refs">Cell reference, i.e A7:B5 or A7:A7</param>
        /// <returns>Collection of cell ranges</returns>
        public static IEnumerable<CellRange> ToCellRange(this string refs)
        {
            var result = new List<CellRange>();
            CellRange cellRange = null;

            foreach (var cellRef in refs.Split(new [] { ',' }))
            {
                if (NameConverter.TryConvertCellNameToCellRange(cellRef.Trim(), out cellRange))
                {
                    result.Add(cellRange);
                }
            }

            return result;        
        }

        /// <summary>
        /// Returns the collection, if not null, or a new collection.
        /// </summary>
        /// <typeparam name="T">The collection item type</typeparam>
        /// <param name="collection">A collection</param>
        /// <returns>The collection, if not null, or a new collection.</returns>
        public static List<T> GetOrDefault<T>(this List<T> collection)
        {            
            return collection ?? new List<T>();
        }

        /// <summary>
        /// Converts string to camel-case string
        /// </summary>
        /// <param name="instance"></param>        
        public static string ToCamelCase(this string instance)
        {
            return instance[0].ToString().ToLowerInvariant() + instance.Substring(1);
        }

        /// <summary>
        /// Check string value for empty string or null
        /// </summary>        
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Converts string to enum
        /// </summary>
        /// <typeparam name="T">The type of enum</typeparam>
        /// <param name="value">The value to convert</param>
        /// <param name="defaultValue">Default value if convertion fails</param>
        /// <returns>The result enum</returns>
        public static T ToEnum<T>(this string value, T defaultValue)
        {
            if (!value.HasValue())
            {
                return defaultValue;
            }

            try
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch (ArgumentException)
            {
                return defaultValue;
            }
        }
    }
}
