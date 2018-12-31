namespace Kendo.Mvc.UI.Fluent
{
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.Resources;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="DatePicker"/> component.
    /// </summary>
    public class DatePickerBuilder: DatePickerBuilderBase<DatePicker, DatePickerBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatePickerBuilder"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public DatePickerBuilder(DatePicker component)
            : base(component)
        {
        }

        /// <summary>
        /// Specifies a template used to populate aria-label attribute.
        /// </summary>
        /// <param name="template">The string template.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .ARIATemplate("Date: #=kendo.toString(data.current, 'd')#")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder ARIATemplate(string template)
        {
            Component.ARIATemplate = template;

            return this;
        }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        /// <param name="dates">The dates.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .BindTo(new List<DateTime>
        ///             {
        ///                 DateTime.Now
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder BindTo(List<DateTime> dates)
        {
            Component.Dates = dates;

            return this;
        }

        /// <summary>
        /// FooterId to be used for rendering the footer of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .FooterId("widgetFooterId")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder FooterId(string id)
        {
            Component.FooterId = id;

            return this;
        }

        /// <summary>
        /// Footer template to be used for rendering the footer of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .Footer("#= kendo.toString(data, "G") #")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder Footer(string footer)
        {
            Component.Footer = footer;

            return this;
        }

        /// <summary>
        /// Enables/disables footer of the calendar popup.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .Footer(false)
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder Footer(bool footer)
        {
            Component.EnableFooter = footer;

            return this;
        }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .Depth(CalendarView.Month)
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder Depth(CalendarView depth)
        {

            Component.Depth = depth.ToString().ToLower();

            return this;
        }

        /// <summary>
        /// Specifies the start view.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .Start(CalendarView.Month)
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder Start(CalendarView start)
        {

            Component.Start = start.ToString().ToLower();

            return this;
        }

        /// <summary>
        /// MonthTemplateId to be used for rendering the cells of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .MonthTemplateId("widgetMonthTemplateId")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder MonthTemplateId(string id)
        {
            Component.MonthTemplate.ContentId = id;

            return this;
        }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .MonthTemplate("#= data.value #")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder MonthTemplate(string content)
        {
            Component.MonthTemplate.Content = content;

            return this;
        }

        /// <summary>
        /// Configures the content of cells of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .MonthTemplate(month => month.Content("#= data.value #"))
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder MonthTemplate(Action<MonthTemplateBuilder> monthTemplateAction)
        {

            monthTemplateAction(new MonthTemplateBuilder(Component.MonthTemplate));

            return this;
        }
                       
        /// <summary>
        /// Sets the minimal date, which can be selected in DatePicker.
        /// </summary>
        public DatePickerBuilder Min(string date)
        {

            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Min = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }

        /// <summary>
        /// Sets the maximal date, which can be selected in DatePicker.
        /// </summary>
        public DatePickerBuilder Max(string date)
        {

            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Max = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public DatePickerBuilder DisableDates(IEnumerable<string> disableDates)
        {
            Component.DisableDates = disableDates;

            return this;
        }
        
        /// <summary>
        /// Specifies the disabled dates in the DatePicker widget.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().DatePicker()
        ///             .Name("datePicker")
        ///             .DisableDates(DayofWeek.Saturday, DayOfWeek.Sunday)
        /// )
        /// </code>
        /// </example>
        public DatePickerBuilder DisableDates(params DayOfWeek[] days)
        {
            Component.DisableDates = days.ToAbbrev();

            return this;
        }

        /// <summary>
        /// Specifies the disabled dates in the DatePicker widget using a function.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DatePicker()
        ///             .Name("DatePicker")
        ///             .DisableDates("disableDates")
        /// %&gt;
        /// </code>
        /// </example>
        public DatePickerBuilder DisableDates(string handler)
        {
            var handlerDescription = new ClientHandlerDescriptor { HandlerName = handler };

            Component.DisableDatesHandler = handlerDescription;

            return this;
        }
    }
}