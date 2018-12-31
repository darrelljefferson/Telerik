using Kendo.Mvc.Infrastructure;
using System.IO;
using System.Web.Mvc;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DataSource component
    /// </summary>
    public partial class DataSourceWidget<T> : WidgetBase where T : class
    {
        public DataSourceWidget(ViewContext viewContext, IJavaScriptInitializer initializer, IUrlGenerator urlGenerator)
            : base(viewContext, initializer)
        {
            UrlGenerator = urlGenerator;

            DataSource = new DataSource()
            {
                Type = DataSourceType.Ajax,
                ServerAggregates = true,
                ServerFiltering = true,
                ServerGrouping = true,
                ServerPaging = true,
                ServerSorting = true
            };

            ClassName = "DataSource";

            DataSource.ModelType(typeof(T));
        }

        public DataSource DataSource
        {
            get;
            private set;
        }

        public PivotDataSource PivotDataSource
        {
            get;
            internal set;
        }

        public IUrlGenerator UrlGenerator
        {
            get;
            private set;
        }

        internal string ClassName
        {
            get;
            set;
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            if (DataSource.Type != DataSourceType.Custom || DataSource.CustomType == "aspnetmvc-ajax")
            {
                ProcessDataSource();
            }

            if (PivotDataSource != null)
            {
                writer.Write(this.Name + "= new kendo.data." + ClassName + "(" + Initializer.Serialize(PivotDataSource.ToJson()) + ")");
            }
            else {
                writer.Write(this.Name + "= new kendo.data." + ClassName + "(" + Initializer.Serialize(DataSource.ToJson()) + ")");
            }
        }

        private void ProcessDataSource()
        {
            var binder = new DataSourceRequestModelBinder();

            var controller = ViewContext.Controller;
            var bindingContext = new ModelBindingContext() { ValueProvider = controller.ValueProvider };

            var request = (DataSourceRequest)binder.BindModel(controller.ControllerContext, bindingContext);

            DataSource.Process(request, true/*!EnableCustomBinding*/);
        }
    }
}
