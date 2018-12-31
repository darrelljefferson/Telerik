using System.Globalization;

namespace Kendo.Mvc.UI.Html
{
    class GridPagerPageSizeSection : IGridPagerPageSizeSection
    {
        public IHtmlNode Create(GridPagerData section)
        {
            var span = new HtmlElement("span")
                .AddClass("k-pager-sizes", "k-label");

            var select = new HtmlElement("select")
                .AppendTo(span);

            foreach (var pageSize in section.PageSizes)
            {
                var pageSizeText = pageSize.ToString().ToLowerInvariant();
                var pageSizeValue = pageSizeText;

                if (pageSizeText == "all")
                {
                    pageSizeText = section.Messages.AllPages;
                }

                new HtmlElement("option").Attribute("value", pageSizeValue).Text(pageSizeText).AppendTo(select);
            }

            new LiteralNode(section.Messages.ItemsPerPage).AppendTo(span);

            return span;
        }
    }
}