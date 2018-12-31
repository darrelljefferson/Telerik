namespace Kendo.Mvc.UI
{
    public class WindowContentSettings : CrudOperation
    {
        public WindowContentSettings()
        {
        }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool Iframe { get; set; }
    }
}