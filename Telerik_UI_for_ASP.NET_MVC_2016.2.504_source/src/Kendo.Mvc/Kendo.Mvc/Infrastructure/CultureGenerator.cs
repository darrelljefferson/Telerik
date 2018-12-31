using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace Kendo.Mvc.Infrastructure
{
    public static class CultureGenerator
    {
        private const string CULTURE_FORMAT = "kendo.cultures[\"{{Name}}\"]={name:\"{{Name}}\",numberFormat:{pattern:{{NumberPattern}},decimals:{{NumberDecimalDigits}},\",\":\"{{NumberGroupSeparator}}\",\".\":\"{{NumberDecimalSeparator}}\",groupSize:{{NumberGroupSizes}},percent:{pattern:{{PercentPattern}},decimals:{{PercentDecimalDigits}},\",\":\"{{PercentGroupSeparator}}\",\".\":\"{{PercentDecimalSeparator}}\",groupSize:{{PercentGroupSizes}},symbol:\"{{PercentSymbol}}\"},currency:{pattern:{{CurrencyPattern}},decimals:{{CurrencyDecimalDigits}},\",\":\"{{CurrencyGroupSeparator}}\",\".\":\"{{CurrencyDecimalSeparator}}\",groupSize:{{CurrencyGroupSizes}},symbol:\"{{CurrencySymbol}}\"}},calendars:{standard:{days:{names:{{DayNames}},namesAbbr:{{AbbreviatedDayNames}},namesShort:{{ShortestDayNames}}},months:{names:{{MonthNames}},namesAbbr:{{AbbreviatedMonthNames}}},AM:{{AM}},PM:{{PM}},patterns:{d:\"{{d}}\",D:\"{{D}}\",F:\"{{F}}\",g:\"{{g}}\",G:\"{{G}}\",m:\"{{m}}\",M:\"{{M}}\",s:\"{{s}}\",t:\"{{t}}\",T:\"{{T}}\",u:\"{{u}}\",y:\"{{y}}\",Y:\"{{Y}}\"},\"/\":\"{{DateSeparator}}\",\":\":\"{{TimeSeparator}}\",firstDay:{{FirstDayOfWeek}}}}};";

        private static string[] numberNegativePatterns = new string[] { "(n)", "-n", "- n", "n-", "n -" };

        private static string[] currencyPositivePatterns = new string[] { "$n", "n$", "$ n", "n $" };
        private static string[] currencyNegativePatterns = new string[] { "($n)", "-$n", "$-n", "$n-", "(n$)", "-n$", "n-$", "n$-", "-n $", "-$ n", "n $-", "$ n-", "$ -n", "n- $", "($ n)", "(n $)" };

        private static string[] percentPositivePatterns = new string[] { "n %", "n%", "%n", "% n" };
        private static string[] percentNegativePatterns = new string[] { "-n %", "-n%", "-%n", "%-n", "%n-", "n-%", "n%-", "-% n", "n %-", "% n-", "% -n", "n- %" };

        public static string Generate(string name = null)
        {            
            CultureInfo culture;
            if (!string.IsNullOrEmpty(name))
            {
                culture = new CultureInfo(name);
            }
            else
            {
                culture = CultureInfo.CurrentCulture;
            }

            return Format(culture, string.Copy(CULTURE_FORMAT));
        }

        private static string Format(CultureInfo cultureInfo, string culturePattern)
        {
            var serializer = new JavaScriptSerializer();
            var cultureDictionary = BuildFlatDictionary(cultureInfo);

            foreach (KeyValuePair<string, object> pair in cultureDictionary)
            {
                var key = pair.Key;
                var value = pair.Value;

                culturePattern = culturePattern.Replace("{{" + key + "}}", value is System.Array ? serializer.Serialize(value) : System.Convert.ToString(value, cultureInfo));
            }

            return culturePattern;
        }

        private static IDictionary<string, object> BuildFlatDictionary(CultureInfo cultureInfo)
        {
            NumberFormatInfo numberFormats = cultureInfo.NumberFormat;            
            IDictionary<string, object> globalization = new Dictionary<string, object>();

            globalization["Name"] = cultureInfo.Name;

            AddNumberFormats(globalization, cultureInfo);
            AddDateTimeFormats(globalization, cultureInfo);

            return globalization;
        }

        private static void AddNumberFormats(IDictionary<string, object> globalization, CultureInfo cultureInfo)
        {
            NumberFormatInfo numberFormats = cultureInfo.NumberFormat;

            //number info
            globalization["NumberPattern"] = new string[] { numberNegativePatterns[numberFormats.NumberNegativePattern] };
            globalization["NumberDecimalDigits"] = numberFormats.NumberDecimalDigits;
            globalization["NumberGroupSeparator"] = numberFormats.NumberGroupSeparator;
            globalization["NumberDecimalSeparator"] = numberFormats.NumberDecimalSeparator;
            globalization["NumberGroupSizes"] = numberFormats.NumberGroupSizes;

            //percent info
            globalization["PercentPattern"] = new string[] { percentNegativePatterns[numberFormats.PercentNegativePattern], percentPositivePatterns[numberFormats.PercentPositivePattern] };
            globalization["PercentDecimalDigits"] = numberFormats.PercentDecimalDigits;
            globalization["PercentGroupSeparator"] = numberFormats.PercentGroupSeparator;
            globalization["PercentDecimalSeparator"] = numberFormats.PercentDecimalSeparator;
            globalization["PercentGroupSizes"] = numberFormats.PercentGroupSizes;
            globalization["PercentSymbol"] = numberFormats.PercentSymbol;

            //currency info
            globalization["CurrencyPattern"] = new string[] { currencyNegativePatterns[numberFormats.CurrencyNegativePattern], currencyPositivePatterns[numberFormats.CurrencyPositivePattern] };
            globalization["CurrencyDecimalDigits"] = numberFormats.CurrencyDecimalDigits;
            globalization["CurrencyGroupSeparator"] = numberFormats.CurrencyGroupSeparator;
            globalization["CurrencyDecimalSeparator"] = numberFormats.CurrencyDecimalSeparator;
            globalization["CurrencyGroupSizes"] = numberFormats.CurrencyGroupSizes;
            globalization["CurrencySymbol"] = numberFormats.CurrencySymbol;
        }

        private static void AddDateTimeFormats(IDictionary<string, object> globalization, CultureInfo cultureInfo)
        {
            DateTimeFormatInfo dateTimeFormats = cultureInfo.DateTimeFormat;
            
            globalization["DayNames"] = dateTimeFormats.DayNames;
            globalization["AbbreviatedDayNames"] = dateTimeFormats.AbbreviatedDayNames;
            globalization["ShortestDayNames"] = dateTimeFormats.ShortestDayNames;

            globalization["MonthNames"] = dateTimeFormats.MonthNames.Take(12).ToArray();
            globalization["AbbreviatedMonthNames"] = dateTimeFormats.AbbreviatedMonthNames.Take(12).ToArray();

            globalization["d"] = dateTimeFormats.ShortDatePattern;
            globalization["D"] = dateTimeFormats.LongDatePattern;
            globalization["F"] = dateTimeFormats.FullDateTimePattern;
            globalization["g"] = dateTimeFormats.ShortDatePattern + " " + dateTimeFormats.ShortTimePattern;
            globalization["G"] = dateTimeFormats.ShortDatePattern + " " + dateTimeFormats.LongTimePattern;
            globalization["m"] = dateTimeFormats.MonthDayPattern;
            globalization["M"] = dateTimeFormats.MonthDayPattern;
            globalization["s"] = dateTimeFormats.SortableDateTimePattern;
            globalization["t"] = dateTimeFormats.ShortTimePattern;
            globalization["T"] = dateTimeFormats.LongTimePattern;
            globalization["u"] = dateTimeFormats.UniversalSortableDateTimePattern;
            globalization["y"] = dateTimeFormats.YearMonthPattern;
            globalization["Y"] = dateTimeFormats.YearMonthPattern;

            var am = dateTimeFormats.AMDesignator;
            var pm = dateTimeFormats.PMDesignator;

            globalization["AM"] = GetDesignators(am, cultureInfo);
            globalization["PM"] = GetDesignators(pm, cultureInfo);
            globalization["DateSeparator"] = dateTimeFormats.DateSeparator;
            globalization["TimeSeparator"] = dateTimeFormats.TimeSeparator;
            globalization["FirstDayOfWeek"] = (int)dateTimeFormats.FirstDayOfWeek;
        }

        private static string[] GetDesignators(string designator, CultureInfo cultureInfo)
        {
            if (string.IsNullOrEmpty(designator))
            {
                return new string[] { designator };
            }
            else
            {
                return new string[] { designator, designator.ToLower(cultureInfo), designator.ToUpper(cultureInfo) };
            }
        }
    }
}
