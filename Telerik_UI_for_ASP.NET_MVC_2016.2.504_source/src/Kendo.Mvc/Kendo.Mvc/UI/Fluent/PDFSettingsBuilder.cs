using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// The fluent API for configuring the grid PDF export.
    /// </summary>
    public class PDFSettingsBuilder
    {
        private readonly PDFSettings pdf;

        public PDFSettingsBuilder(PDFSettings pdf)
        {
            this.pdf = pdf;
        }

        /// <summary>
        /// Exports all pages. Applicable only for the Grid. Ajax binding or server binding with ServerOperation(false) is required.
        /// </summary>
        public PDFSettingsBuilder AllPages()
        {
            pdf.AllPages = true;

            return this;
        }

        /// <summary>
        /// Does not create clickable hyperlinks in the exported PDF file.
        /// </summary>
        public PDFSettingsBuilder AvoidLinks()
        {
            pdf.AvoidLinks = true;

            return this;
        }

        /// <summary>
        /// A flag indicating whether to produce clickable hyperlinks in the exported PDF file.
        /// </summary>
        public PDFSettingsBuilder AvoidLinks(bool avoidLinks)
        {
            pdf.AvoidLinks = avoidLinks;

            return this;
        }

        /// <summary>
        /// A CSS selector for the links to ignore. All matching links will not be clickable in the exported PDF file.
        /// </summary>
        public PDFSettingsBuilder AvoidLinks(string avoidLinks)
        {
            pdf.AvoidLinks = avoidLinks;

            return this;
        }

        /// <summary>
        /// Turns the page in landscape orientation.
        /// </summary>
        public PDFSettingsBuilder Landscape()
        {
            pdf.Landscape = true;

            return this;
        }

        /// <summary>
        /// Sets the file name of the PDF file.
        /// </summary>
        public PDFSettingsBuilder FileName(string fileName)
        {
            pdf.FileName = fileName;

            return this;
        }

        /// <summary>
        /// Specifies a predefiend paper size e.g. "A3", "A4" or "auto" (default).
        /// </summary>
        public PDFSettingsBuilder PaperSize(string paperSize)
        {
            pdf.PaperSize = paperSize;

            return this;
        }

        /// <summary>
        /// Specifies custom paper size in "pt" units.
        /// </summary>
        public PDFSettingsBuilder PaperSize(double width, double height)
        {
            pdf.PaperSize = new[] { width, height };
            return this;
        }

        /// <summary>
        /// Specifies custom paper size in custom units ("in", "mm", "pt", "cm")
        /// </summary>
        public PDFSettingsBuilder PaperSize(string width, string height)
        {
            pdf.PaperSize = new[] { width, height };
            return this;
        }

        /// <summary>
        /// Set the url of the server side proxy. The proxy is responsible for returning the PDF to the end user. Used in browsers that don't support saving files from JavaScript.
        /// </summary>
        /// <param name="url"></param>
        public PDFSettingsBuilder ProxyURL(string url)
        {
            pdf.ProxyURL = url;

            return this;
        }

        /// <summary>
        /// Set the a name or keyword indicating where to display the document returned from the proxy.
        /// The default is "_self".
        /// </summary>
        /// <param name="target">The proxy target</param>
        public PDFSettingsBuilder ProxyTarget(string target)
        {
            pdf.ProxyTarget = target;

            return this;
        }

        /// <summary>
        /// Specifies the margins in "pt" units.
        /// </summary>
        public PDFSettingsBuilder Margin(double top, double right, double bottom, double left)
        {
            pdf.Margin = new Dictionary<string, object>
            {
               { "top", top },
               { "right", right },
               { "bottom", bottom },
               { "left", left }
            };

            return this;
        }

        /// <summary>
        /// Specifies the margins in units ("in", "mm", "pt", "cm")
        /// </summary>
        public PDFSettingsBuilder Margin(string top, string right, string bottom, string left)
        {
            pdf.Margin = new Dictionary<string, object>
            {
               { "top", top },
               { "right", right },
               { "bottom", bottom },
               { "left", left }
            };

            return this;
        }

        /// <summary>
        /// Sets the title of the PDF document.
        /// </summary>
        public PDFSettingsBuilder Title(string title)
        {
            pdf.Title = title;

            return this;
        }

        /// <summary>
        /// Sets the author of the PDF document.
        /// </summary>
        public PDFSettingsBuilder Author(string author)
        {
            pdf.Author = author;

            return this;
        }

        /// <summary>
        /// Sets the subject of the PDF document.
        /// </summary>
        public PDFSettingsBuilder Subject(string subject)
        {
            pdf.Subject = subject;

            return this;
        }

        /// <summary>
        /// Sets the keywords of the PDF document.
        /// </summary>
        public PDFSettingsBuilder Keywords(string keywords)
        {
            pdf.Keywords = keywords;

            return this;
        }
        
        /// <summary>
        /// Set this to true to repeat the grid headers on each page.
        /// </summary>
        /// <param name="value">The value for RepeatHeaders</param>
        public PDFSettingsBuilder RepeatHeaders(bool value)
        {
            pdf.RepeatHeaders = value;
            return this;
        }

        /// <summary>
        /// Set this to true to repeat the grid headers on each page.
        /// </summary>
        public PDFSettingsBuilder RepeatHeaders()
        {
            pdf.RepeatHeaders = true;
            return this;
        }

        /// <summary>
        /// A scale factor. In many cases, text size on screen will be too big for print, so you can use this option to scale down the output in PDF.
        /// </summary>
        public PDFSettingsBuilder Scale(double scale)
        {
            pdf.Scale = scale;
            return this;
        }

        /// <summary>
        /// A piece of HTML to be included in each page.  Can be used to display headers and footers.  See the documentation in drawDOM.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public PDFSettingsBuilder Template(string value)
        {
            pdf.Template = value;
            return this;
        }

        /// <summary>
        /// A piece of HTML to be included in each page.  Can be used to display headers and footers.  See the documentation in drawDOM.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public PDFSettingsBuilder TemplateId(string templateId)
        {
            pdf.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Sets the creator of the PDF document.
        /// </summary>
        public PDFSettingsBuilder Creator(string creator)
        {
            pdf.Creator = creator;

            return this;
        }

        /// <summary>
        /// Sets the date of the PDF document.
        /// </summary>
        public PDFSettingsBuilder Date(DateTime date)
        {
            pdf.Date = date;

            return this;
        }

        /// <summary>
        /// Forces the use of server-side proxy even if the browser supports local saving.
        /// </summary>
        /// <param name="forceProxy">true if the server proxy should be used always; false for automatic detection</param>
        public PDFSettingsBuilder ForceProxy(bool forceProxy)
        {
            pdf.ForceProxy = forceProxy;
            return this;
        }
    }
}
