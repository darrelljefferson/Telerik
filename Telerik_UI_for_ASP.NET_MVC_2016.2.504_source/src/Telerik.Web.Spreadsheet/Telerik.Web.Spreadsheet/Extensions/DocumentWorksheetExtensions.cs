using System;
using System.Linq;
using System.Collections.Generic;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.PropertySystem;
using Telerik.Windows.Documents.Spreadsheet.Theming;
using Telerik.Windows.Documents.Spreadsheet.Utilities;
using Document = Telerik.Windows.Documents.Spreadsheet.Model.Workbook;
using DocumentWorksheet = Telerik.Windows.Documents.Spreadsheet.Model.Worksheet;

namespace Telerik.Web.Spreadsheet
{
    /// <summary>
    /// Extensions for the DocumentWorksheet class
    /// </summary>
    public static class DocumentWorksheetExtensions
    {                
        /// <summary>
        /// Gather all rows with changed properties.
        /// </summary>
        /// <param name="worksheet">DocumentWorksheet from which to import rows</param>
        /// <returns>A collection of rows with changed properties</returns>
        public static IEnumerable<Row> ImportRows(this DocumentWorksheet worksheet)
        {
            var rows = GetRowsWithHeight(worksheet);

            var cells = GetCellsWithProperties(worksheet);

            foreach (var cell in cells)
            {
                var rowIndex = cell.Key;
                var rowCells = cell.Value.Select(i => i.Value).ToList();

                if (rows.ContainsKey(rowIndex))
                {
                    rows[rowIndex].AddCells(rowCells);
                }
                else
                {
                    rows.Add(rowIndex, new Row
                    {
                        Index = rowIndex,
                        Cells = rowCells
                    });
                }
            }

            return rows.Values;
        }

        private static SortedDictionary<int, Row> GetRowsWithHeight(DocumentWorksheet worksheet)
        {
            var result = new SortedDictionary<int, Row>();

            var ranges = worksheet.Rows.PropertyBag.GetPropertyValueCollection(RowsPropertyBag.HeightProperty).GetNonDefaultRanges();

            foreach (var range in ranges)
            {
                var height = range.Value.Value;
                for (var i = range.Start; i <= range.End; i++)
                {
                    var rowIndex = (int)i;

                    result.Add(rowIndex, new Row
                    {
                        Index = rowIndex,
                        Height = height
                    });
                }
            }

            return result;
        }

        private static SortedDictionary<int, SortedDictionary<int, Cell>> GetCellsWithProperties(DocumentWorksheet worksheet)
        {
            var state = new SortedDictionary<int, SortedDictionary<int, Cell>>();
            
            GetCellProperty(worksheet, CellPropertyDefinitions.ForeColorProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.FormatProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.ValueProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.FillProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.IsBoldProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.IsItalicProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.IsWrappedProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.UnderlineProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.VerticalAlignmentProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.HorizontalAlignmentProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.FontSizeProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.FontFamilyProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.BottomBorderProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.TopBorderProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.LeftBorderProperty, state);

            GetCellProperty(worksheet, CellPropertyDefinitions.RightBorderProperty, state);

            return state;
        }

        private static void GetCellProperty<T>(DocumentWorksheet worksheet, IPropertyDefinition<T> propertyDefinition, SortedDictionary<int, SortedDictionary<int, Cell>> state)
        {
            var nonDefaultRanges = worksheet.Cells.PropertyBag.GetPropertyValueCollection(propertyDefinition).GetNonDefaultRanges();
            var setter = CellSetters[propertyDefinition];

            foreach (var nonDefaultRange in nonDefaultRanges)
            {
                var cellRange = CellsPropertyBag.ConvertLongCellRangeToCellRange(nonDefaultRange.Start, nonDefaultRange.End);

                for (var rowIndex = cellRange.FromIndex.RowIndex; rowIndex <= cellRange.ToIndex.RowIndex; rowIndex++)
                {
                    for (var columnIndex = cellRange.FromIndex.ColumnIndex; columnIndex <= cellRange.ToIndex.ColumnIndex; columnIndex++)
                    {
                        Cell cell;
                        if (state.ContainsKey(rowIndex))
                        {
                            var row = state[rowIndex];
                            if (row.ContainsKey(columnIndex))
                            {
                                cell = row[columnIndex];
                            }
                            else
                            {
                                cell = new Cell { Index = columnIndex };
                                row.Add(columnIndex, cell);
                            }
                        }
                        else
                        {
                            cell = new Cell { Index = columnIndex };
                            state.Add(rowIndex, new SortedDictionary<int, Cell> { { columnIndex, cell } });
                        }

                        setter(cell, worksheet.Workbook.Theme, nonDefaultRange.Value);
                    }
                }
            }
        }

        private static void SetColor(Cell cell, DocumentTheme theme, object value)
        {
            cell.Color = ((ThemableColor)value).GetActualValue(theme.ColorScheme).ToHex();
        }

        private static void SetBackground(Cell cell, DocumentTheme theme, object value)
        {
            cell.Background = ((PatternFill)value).PatternColor.GetActualValue(theme.ColorScheme).ToHex();
        }

        private static void SetBold(Cell cell, DocumentTheme theme, object value)
        {
            cell.Bold = (bool)value;
        }

        private static void SetItalic(Cell cell, DocumentTheme theme, object value)
        {
            cell.Italic = (bool)value;
        }

        private static void SetWrap(Cell cell, DocumentTheme theme, object value)
        {
            cell.Wrap = (bool)value;
        }

        private static void SetUnderline(Cell cell, DocumentTheme theme, object value)
        {
            cell.Underline = ((UnderlineType)value) != UnderlineType.None;
        }

        private static void SetVerticalAlign(Cell cell, DocumentTheme theme, object value)
        {
            cell.VerticalAlign = ((RadVerticalAlignment)value).AsString();
        }

        private static void SetHorizontalAlign(Cell cell, DocumentTheme theme, object value)
        {
            cell.TextAlign = ((RadHorizontalAlignment)value).ToString().ToLower();
        }

        private static void SetFontSize(Cell cell, DocumentTheme theme, object value)
        {
            cell.FontSize = UnitHelper.DipToPoint((double)value);
        }

        private static void SetFontFamily(Cell cell, DocumentTheme theme, object value)
        {
            cell.FontFamily = ((ThemableFontFamily)value).GetActualValue(theme).FamilyNames.Values.First();
        }

        private static void SetBorderBottom(Cell cell, DocumentTheme theme, object value)
        {
            cell.BorderBottom = ((CellBorder)value).ToBorderStyle(theme);
        }

        private static void SetBorderTop(Cell cell, DocumentTheme theme, object value)
        {
            cell.BorderTop = ((CellBorder)value).ToBorderStyle(theme);
        }

        private static void SetBorderLeft(Cell cell, DocumentTheme theme, object value)
        {
            cell.BorderLeft = ((CellBorder)value).ToBorderStyle(theme);
        }

        private static void SetBorderRight(Cell cell, DocumentTheme theme, object value)
        {
            cell.BorderRight = ((CellBorder)value).ToBorderStyle(theme);
        }

        private static void SetFormat(Cell cell, DocumentTheme theme, object value)
        {
            cell.Format = ((CellValueFormat)value).FormatString;
        }

        private static void SetValue(Cell cell, DocumentTheme theme, object value)
        {
            var cellValue = (ICellValue)value;
            string formula = null;

            var formulaCellValue = cellValue as FormulaCellValue;
            if (formulaCellValue != null)
            {
                cellValue = formulaCellValue.GetResultValueAsCellValue();
                formula = formulaCellValue.RawValue.Substring(1);
            }

            value = cellValue.RawValue;
            if (cellValue.ValueType == CellValueType.Number)
            {
                int intValue;
                double doubleValue;

                if (int.TryParse(cellValue.RawValue, out intValue))
                {
                    value = intValue;
                }

                else if (double.TryParse(cellValue.RawValue, out doubleValue))
                {
                    value = doubleValue;
                }
            }

            if (cellValue.ValueType == CellValueType.Boolean)
            {
                bool booleanValue;
                if (bool.TryParse(cellValue.RawValue, out booleanValue))
                {
                    value = booleanValue;
                }
            }

            cell.Value = value;
            cell.Formula = formula;
        }

        private static Dictionary<IPropertyDefinition, Action<Cell, DocumentTheme, object>> CellSetters = new Dictionary<IPropertyDefinition, Action<Cell, DocumentTheme, object>> {
            {
                CellPropertyDefinitions.ForeColorProperty,
                SetColor
            },
            {
                CellPropertyDefinitions.FillProperty,
                SetBackground
            },
            {
                CellPropertyDefinitions.IsBoldProperty,
                SetBold
            },
            {
                CellPropertyDefinitions.IsItalicProperty,
                SetItalic
            },
            {
                CellPropertyDefinitions.IsWrappedProperty,
                SetWrap
            },
            {
                CellPropertyDefinitions.UnderlineProperty,
                SetUnderline
            },
            {
                CellPropertyDefinitions.VerticalAlignmentProperty,
                SetVerticalAlign
            },
            {
                CellPropertyDefinitions.HorizontalAlignmentProperty,
                SetHorizontalAlign
            },
            {
                CellPropertyDefinitions.FontSizeProperty,
                SetFontSize
            },
            {
                CellPropertyDefinitions.FontFamilyProperty,
                SetFontFamily
            },
            {
                CellPropertyDefinitions.BottomBorderProperty,
                SetBorderBottom
            },
            {
                CellPropertyDefinitions.TopBorderProperty,
                SetBorderTop
            },
            {
                CellPropertyDefinitions.LeftBorderProperty,
                SetBorderLeft
            },
            {
                CellPropertyDefinitions.RightBorderProperty,
                SetBorderRight
            },
            {
                CellPropertyDefinitions.FormatProperty,
                SetFormat
            },
            {
                CellPropertyDefinitions.ValueProperty,
                SetValue
            }
        };        
    }
}
