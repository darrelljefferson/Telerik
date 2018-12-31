using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Telerik.Windows.Documents.Spreadsheet.Core;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.Model.Filtering;
using Telerik.Windows.Documents.Spreadsheet.Model.Sorting;
using Telerik.Windows.Documents.Spreadsheet.PropertySystem;
using Telerik.Windows.Documents.Spreadsheet.Utilities;
using Document = Telerik.Windows.Documents.Spreadsheet.Model.Workbook;
using DocumentWorksheet = Telerik.Windows.Documents.Spreadsheet.Model.Worksheet;

namespace Telerik.Web.Spreadsheet
{
    public partial class Workbook
    {
        /// <summary>
        /// Converts the Workbook to a <see cref="Telerik.Windows.Documents.Spreadsheet.Model.Workbook">Telerik DPL Workbook Document</see>.
        /// </summary>
        /// <returns></returns>
        public Document ToDocument()
        {
            var document = new Document();
            document.History.IsEnabled = false;

            using (new UpdateScope(document.SuspendLayoutUpdate, document.ResumeLayoutUpdate))
            {
                foreach (var sheet in Sheets.GetOrDefault())
                {
                    var documentSheet = document.Worksheets.Add();

                    if (!string.IsNullOrEmpty(sheet.Name))
                    {
                        documentSheet.Name = sheet.Name;
                    }

                    if (sheet.Name == ActiveSheet)
                    {
                        document.ActiveWorksheet = documentSheet;
                    }

                    documentSheet.ViewState.SelectionState = CreateSelectionState(sheet, documentSheet);

                    foreach (var row in sheet.Rows.GetOrDefault())
                    {
                        SetCells(row, documentSheet);

                        if (row.Height > 0)
                        {
                            documentSheet.Rows[row.Index.Value].SetHeight(new RowHeight(row.Height.Value, true));
                        }
                    }

                    foreach (var column in sheet.Columns.GetOrDefault())
                    {
                        if (ColumnsPropertyBag.WidthProperty.DefaultValue.Value != column.Width)
                        {
                            documentSheet.Columns[column.Index.Value].SetWidth(new ColumnWidth(column.Width.Value, true));
                        }
                    }

                    foreach (var mergedRange in sheet.MergedCells.GetOrDefault())
                    {
                        documentSheet.Cells.GetCellSelection(mergedRange).Merge();
                    }

                    if (sheet.FrozenColumns.GetValueOrDefault() > 0 || sheet.FrozenRows.GetValueOrDefault() > 0)
                    {
                        documentSheet.ViewState.FreezePanes(sheet.FrozenRows.GetValueOrDefault(), sheet.FrozenColumns.GetValueOrDefault());
                    }

                    SetSortState(documentSheet, sheet.Sort);

                    SetFilterState(documentSheet, sheet.Filter);
                }

                if (document.Worksheets.Count > 0)
                {
                    document.ActiveWorksheet = document.Worksheets[0];
                }
            }

            document.History.IsEnabled = true;

            return document;
        }

        private SelectionState CreateSelectionState(Worksheet sheet, DocumentWorksheet documentSheet)
        {
            if (sheet.Selection != null)
            {
                return new SelectionState(sheet.Selection.ToCellRange(), sheet.ActiveCell.ToCellIndex(), documentSheet.ViewState.SelectionState.Pane);
            }
            else
            {
                return new SelectionState();
            }
        }

        private void SetCells(Row srcRow, DocumentWorksheet documentSheet)
        {
            foreach (var cell in srcRow.Cells.GetOrDefault())
            {
                var stringValue = cell.Value == null ? null : cell.Value.ToString();
                var selection = documentSheet.Cells[srcRow.Index.Value, cell.Index.Value];
                double numericValue;

                var formula = cell.Formula;
                if (!string.IsNullOrEmpty(formula))
                {
                    selection.SetValueAsFormula("=" + formula);
                }
                else if (double.TryParse(stringValue, out numericValue))
                {
                    selection.SetValue(numericValue);
                }
                else if (!string.IsNullOrEmpty(stringValue))
                {
                    selection.SetValueAsText(stringValue);
                }

                if (!string.IsNullOrEmpty(cell.Format))
                {
                    selection.SetFormat(new CellValueFormat(cell.Format));
                }

                if (!string.IsNullOrEmpty(cell.Color))
                {
                    selection.SetForeColor(new ThemableColor(cell.Color.ToColor()));
                }

                if (!string.IsNullOrEmpty(cell.Background))
                {
                    var fill = PatternFill.CreateSolidFill(cell.Background.ToColor());
                    selection.SetFill(fill);
                }

                if (cell.Bold.HasValue)
                {
                    selection.SetIsBold(cell.Bold.Value);
                }

                if (cell.Italic.HasValue)
                {
                    selection.SetIsItalic(cell.Italic.Value);
                }

                if (cell.Wrap.HasValue)
                {
                    selection.SetIsWrapped(cell.Wrap.Value);
                }

                if (cell.Underline.HasValue)
                {
                    selection.SetUnderline(UnderlineType.Single);
                }

                selection.SetBorders(CreateCellBorders(cell));

                if (!string.IsNullOrEmpty(cell.VerticalAlign))
                {
                    selection.SetVerticalAlignment(cell.VerticalAlign.ToVerticalAlignment());
                }

                if (!string.IsNullOrEmpty(cell.TextAlign))
                {
                    selection.SetHorizontalAlignment(ConvertToHorizontalAlignment(cell.TextAlign));
                }

                if (!string.IsNullOrEmpty(cell.FontFamily))
                {
                    selection.SetFontFamily(new ThemableFontFamily(cell.FontFamily));
                }

                if (cell.FontSize.HasValue)
                {
                    selection.SetFontSize(UnitHelper.PointToDip(cell.FontSize.Value));
                }
            }
        }

        private CellBorders CreateCellBorders(Cell cell)
        {
            var borders = new CellBorders();

            if (cell.BorderTop != null)
            {
                borders.Top = new CellBorder(CellBorderStyle.Thin, new ThemableColor(cell.BorderTop.Color.ToColor()));
            }

            if (cell.BorderBottom != null)
            {
                borders.Bottom = new CellBorder(CellBorderStyle.Thin, new ThemableColor(cell.BorderBottom.Color.ToColor()));
            }

            if (cell.BorderLeft != null)
            {
                borders.Left = new CellBorder(CellBorderStyle.Thin, new ThemableColor(cell.BorderLeft.Color.ToColor()));
            }

            if (cell.BorderRight != null)
            {
                borders.Right = new CellBorder(CellBorderStyle.Thin, new ThemableColor(cell.BorderRight.Color.ToColor()));
            }

            return borders;
        }

        private RadHorizontalAlignment ConvertToHorizontalAlignment(string alignment)
        {
            switch (alignment)
            {
                case "left":
                    return RadHorizontalAlignment.Left;
                case "center":
                    return RadHorizontalAlignment.Center;
                case "right":
                    return RadHorizontalAlignment.Right;
                case "justify":
                    return RadHorizontalAlignment.Justify;
                default:
                    return RadHorizontalAlignment.General;
            }
        }

        private void SetSortState(DocumentWorksheet documentWorksheet, Sort sort)
        {
            if (sort == null)
            {
                return;
            }

            var conditions = sort.Columns.Select(column => new ValuesSortCondition((int)column.Index, column.Ascending.Value ? SortOrder.Ascending : SortOrder.Descending)).ToArray();
            var range = sort.Ref.ToCellRange().First();

            documentWorksheet.SortState.Set(range, conditions);
        }

        private T ToEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        private void SetFilterState(DocumentWorksheet documentWorksheet, Filter filter)
        {
            if (filter == null)
            {
                return;
            }
            
            documentWorksheet.Filter.FilterRange = filter.Ref.ToCellRange().First();
            documentWorksheet.Filter.SetFilters(filter.Columns.Select(column =>
            {
                IFilter result = null;

                if (column.Filter == "top")
                {                    
                    result = new TopFilter((int)column.Index, column.Type.ToEnum(TopFilterType.TopNumber), column.Value.GetValueOrDefault());
                }
                else if (column.Filter == "dynamic")
                {
                    result = new DynamicFilter((int)column.Index, column.Type.ToEnum(DynamicFilterType.AboveAverage));
                }
                else if (column.Filter == "value")
                {                    
                    result = new ValuesCollectionFilter(
                        (int)column.Index, 
                        column.Values.GetOrDefault().Select(value => Convert.ToString(value, CultureInfo.InvariantCulture)),
                        column.Dates.GetOrDefault().Select(item => new DateGroupItem(item.Year, item.Month + 1, item.Day, item.Hours, item.Minutes, item.Seconds)), 
                        column.Blanks.GetValueOrDefault());
                }
                else if (column.Filter == "custom")
                {                    
                    var criterias = column.Criteria
                        .GetOrDefault()
                        .Select(criteria => FromCriteria(criteria));

                    var criteria1 = criterias.Count() > 0 ? criterias.First() : null;
                    var criteria2 = criterias.Count() > 1 ? criterias.Last() : null;

                    result = new CustomFilter((int)column.Index, criteria1, column.Logic.ToEnum(LogicalOperator.Or), criteria2);
                }

                return result;
            })
            .SkipWhile(item => item == null));
        }

        private CustomFilterCriteria FromCriteria(Criteria criteria)
        {
            var @operator = criteria.Operator;
            var filterValue = Convert.ToString(criteria.Value, CultureInfo.InvariantCulture);

            if (criteria.Value is string)
            {
                switch(@operator) 
                {
                    case "startswith":                        
                            @operator = "eq";
                            filterValue += "*";
                            break;                        
                    case "endswith":                        
                            @operator = "eq";
                            filterValue = "*" + filterValue;
                            break;                        
                    case "contains":                        
                            @operator = "eq";
                            filterValue = "*" + filterValue + "*";
                            break;                        
                    case "doesnotcontain":                        
                            @operator = "neq";
                            filterValue = "*" + filterValue + "*";
                            break;                        
                }
            }

            @operator = ComparisonOperators.ContainsKey(@operator) ? ComparisonOperators[@operator] : "eq";

            return new CustomFilterCriteria(@operator.ToEnum(ComparisonOperator.EqualsTo), filterValue);
        }

        private readonly Dictionary<string, string> ComparisonOperators = new Dictionary<string, string>
        {           
            { "eq", "equalsto" },
            { "neq", "notequalsto" },
            { "lt", "lessthan" },
            { "gt", "greaterthan" },
            { "gte", "greaterthanorequalsto" },
            { "lte", "lessthanorequalsto" }   
        };
    }
}
