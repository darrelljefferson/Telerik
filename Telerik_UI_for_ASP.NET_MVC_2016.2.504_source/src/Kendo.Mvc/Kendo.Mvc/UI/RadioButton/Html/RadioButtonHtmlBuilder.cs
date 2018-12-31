namespace Kendo.Mvc.UI
{
    using Kendo.Mvc.Extensions;
    using System.Web.Mvc;

    public class RadioButtonHtmlBuilder
    {
        public RadioButtonHtmlBuilder(RadioButton radioButton)
        {
            Component = radioButton;
        }

        public RadioButton Component
        {
            get;
            private set;
        }

        public IHtmlNode Build()
        {
            var fragment = new HtmlFragment();

            RadioButton().AppendTo(fragment);
            Label().AppendTo(fragment);

            return fragment;
        }

        public IHtmlNode RadioButton()
        {
            string checkedValue = "";
            string value = "";
            ModelState state;

            if (Component.Value != null)
            {
                value = Component.Value.ToString();
            }

            if (Component.ViewData.ModelState.TryGetValue(Component.Name, out state) && state.Value != null)
            {
                checkedValue = state.Value.ConvertTo(typeof(string), null) as string;
            }
            else
            {
                checkedValue = Component.GetValue<string>(Component.Name, null);
            }

            bool modelChecked = checkedValue.HasValue() && checkedValue == value;

            return new HtmlElement("input", TagRenderMode.SelfClosing)
                .Attributes(new {
                    name = Component.Name,
                    id = RenderId(),
                    type = "radio",
                    value = value,
                    @class = "k-radio"
                })
                .ToggleAttribute("checked", "checked", Component.Checked || modelChecked)
                .Attributes(Component.GetUnobtrusiveValidationAttributes())
                .ToggleAttribute("disabled", "disabled", !Component.Enabled)
                .Attributes(Component.HtmlAttributes)
                .ToggleClass("input-validation-error", !Component.IsValid())
                .PrependClass("k-radio");
        }

        public IHtmlNode Label()
        {
            var defaultLabel = Component.ModelMetadata != null ? Component.ModelMetadata.DisplayName : "";
            return new HtmlElement("label")
                .Attributes(new
                {
                    @for = RenderId(),
                    @class = "k-radio-label"
                })
                .Text(Component.Label ?? defaultLabel);
        }

        private string RenderId()
        {
            return Component.Id + "_" + Component.Value;
        }
    }
}