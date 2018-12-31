namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerFooterSettings
    /// </summary>
    public class SchedulerFooterBuilder : IHideObjectMembers
    {
        private readonly SchedulerFooterSettings settings;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerFooterBuilder{TModel}"/> class.
        /// </summary>
        /// <param name="container">The container</param>
        public SchedulerFooterBuilder(SchedulerFooterSettings settings)
        {
            this.settings = settings;
        }

        /// <summary>
        /// Sets the command which will be displayed in the scheduler footer. Currently only "workDay" option is supported. If the option is set to false, the "workDay" button will be removed from the footer.
        /// </summary>
        /// <param name="value">The value for Command</param>
        public SchedulerFooterBuilder Command(string value)
        {
            settings.Command = value;

            return this;
        }

    }
}
