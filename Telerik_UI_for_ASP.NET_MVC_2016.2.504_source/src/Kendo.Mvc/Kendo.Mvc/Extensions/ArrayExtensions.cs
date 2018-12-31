using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.Extensions
{
    internal static class ArrayExtensions
    {
        public static IEnumerable<string> ToAbbrev(this DayOfWeek[] days)
        {
            return days.Select(date => date.ToString().ToLowerInvariant().Substring(0, 2)).ToArray();
        }
    }
}
