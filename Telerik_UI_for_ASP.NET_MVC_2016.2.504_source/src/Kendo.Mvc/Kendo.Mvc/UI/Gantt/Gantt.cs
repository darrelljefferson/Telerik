namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.UI;
    using Kendo.Mvc.Infrastructure;
    using Kendo.Mvc.Extensions;

    /// <summary>
    /// The server side wrapper for Kendo UI Gantt
    /// </summary>
    /// <typeparam name="TTaskModel">Type of the Task model</typeparam>
    /// <typeparam name="TDependenciesModel">Type of the Dependencies model</typeparam>
    public class Gantt<TTaskModel, TDependenciesModel> : WidgetBase
        where TTaskModel : class, IGanttTask
        where TDependenciesModel : class, IGanttDependency
    {
        public readonly IUrlGenerator UrlGenerator;

        public Gantt(ViewContext viewContext, IJavaScriptInitializer initializer, IUrlGenerator urlGenerator)
            : base(viewContext, initializer)
        {
            this.UrlGenerator = urlGenerator;

            DataSource = new DataSource();
            DataSource.Type = DataSourceType.Ajax;
            DataSource.Schema.Model = new GanttModelDescriptor(typeof(TTaskModel));

            DependenciesDataSource = new DataSource();
            DependenciesDataSource.Type = DataSourceType.Ajax;
            DependenciesDataSource.Schema.Model = new GanttDependenciesModelDescriptor(typeof(TDependenciesModel));

            Columns = new List<GanttColumnBase<TTaskModel>>();

            Assignments = new GanttAssignmentsSettings();

            CurrentTimeMarker = new GanttCurrentTimeMarkerSettings();

            Resources = new GanttResourcesSettings();

//>> Initialization
        
            Editable = new GanttEditableSettings();
                
            Messages = new GanttMessagesSettings();
                
            Pdf = new GanttPdfSettings();
                
            Toolbar = new List<GanttToolbar>();
                
            Tooltip = new GanttTooltipSettings();
                
            Views = new List<GanttView>();
                
        //<< Initialization
        }

        public DataSource DataSource
        {
            get;
            private set;
        }

        public string DataSourceId
        {
            get;
            set;
        }

        public DataSource DependenciesDataSource
        {
            get;
            private set;
        }
        public string DependenciesDataSourceId
        {
            get;
            set;
        }

        public List<GanttColumnBase<TTaskModel>> Columns
        {
            get;
            set;
        }

        public GanttAssignmentsSettings Assignments
        {
            get;
            set;
        }

        public GanttCurrentTimeMarkerSettings CurrentTimeMarker
        {
            get;
            set;
        }

        public GanttResourcesSettings Resources
        {
            get;
            set;
        }


//>> Fields
        
        public bool? AutoBind { get; set; }
        
        public double? ColumnResizeHandleWidth { get; set; }
        
        public GanttEditableSettings Editable
        {
            get;
            set;
        }
        
        public bool? Navigatable { get; set; }
        
        public DateTime? WorkDayStart { get; set; }
        
        public DateTime? WorkDayEnd { get; set; }
        
        public double? WorkWeekStart { get; set; }
        
        public double? WorkWeekEnd { get; set; }
        
        public double? HourSpan { get; set; }
        
        public bool? Snap { get; set; }
        
        public double? Height { get; set; }
        
        public string ListWidth { get; set; }
        
        public GanttMessagesSettings Messages
        {
            get;
            set;
        }
        
        public GanttPdfSettings Pdf
        {
            get;
            set;
        }
        
        public bool? Resizable { get; set; }
        
        public bool? Selectable { get; set; }
        
        public bool? ShowWorkDays { get; set; }
        
        public bool? ShowWorkHours { get; set; }
        
        public string TaskTemplate { get; set; }

        public string TaskTemplateId { get; set; }
        
        public List<GanttToolbar> Toolbar
        {
            get;
            set;
        }
        
        public GanttTooltipSettings Tooltip
        {
            get;
            set;
        }
        
        public List<GanttView> Views
        {
            get;
            set;
        }
        
        public double? RowHeight { get; set; }
        
        //<< Fields

        public override void WriteInitializationScript(TextWriter writer)
        {
            var json = new Dictionary<string, object>(Events);

            var columns = Columns.ToJson();
            if (columns.Any())
            {
                json["columns"] = columns;
            }

            var assignments = Assignments.ToJson();
            if (assignments.Any())
            {
                json["assignments"] = assignments;
            }

            if (CurrentTimeMarker.Enabled == false)
            {
                json["currentTimeMarker"] = false;
            }
            else
            {
                IDictionary<string, object> currentTimeMarker = CurrentTimeMarker.ToJson();
                if (currentTimeMarker.Count > 0)
                {
                    json["currentTimeMarker"] = currentTimeMarker;
                }
            }

			if (Editable.Enabled == false) {
                json["editable"] = false;
            }
			else
			{
		        var editable = Editable.ToJson();
		        if (editable.Any())
		        {
		            json["editable"] = editable;
		        }
			}

//>> Serialization
        
            if (AutoBind.HasValue)
            {
                json["autoBind"] = AutoBind;
            }
                
            if (ColumnResizeHandleWidth.HasValue)
            {
                json["columnResizeHandleWidth"] = ColumnResizeHandleWidth;
            }
                
            if (Navigatable.HasValue)
            {
                json["navigatable"] = Navigatable;
            }
                
            if (WorkDayStart.HasValue)
            {
                json["workDayStart"] = WorkDayStart;
            }
                
            if (WorkDayEnd.HasValue)
            {
                json["workDayEnd"] = WorkDayEnd;
            }
                
            if (WorkWeekStart.HasValue)
            {
                json["workWeekStart"] = WorkWeekStart;
            }
                
            if (WorkWeekEnd.HasValue)
            {
                json["workWeekEnd"] = WorkWeekEnd;
            }
                
            if (HourSpan.HasValue)
            {
                json["hourSpan"] = HourSpan;
            }
                
            if (Snap.HasValue)
            {
                json["snap"] = Snap;
            }
                
            if (Height.HasValue)
            {
                json["height"] = Height;
            }
                
            if (ListWidth.HasValue())
            {
                json["listWidth"] = ListWidth;
            }
            
            var messages = Messages.ToJson();
            if (messages.Any())
            {
                json["messages"] = messages;
            }
            var pdf = Pdf.ToJson();
            if (pdf.Any())
            {
                json["pdf"] = pdf;
            }
            if (Resizable.HasValue)
            {
                json["resizable"] = Resizable;
            }
                
            if (Selectable.HasValue)
            {
                json["selectable"] = Selectable;
            }
                
            if (ShowWorkDays.HasValue)
            {
                json["showWorkDays"] = ShowWorkDays;
            }
                
            if (ShowWorkHours.HasValue)
            {
                json["showWorkHours"] = ShowWorkHours;
            }
                
            if (!string.IsNullOrEmpty(TaskTemplateId))
            {
                json["taskTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('#{0}').html()",
                        TaskTemplateId
                    )
                };
            }
            else if (!string.IsNullOrEmpty(TaskTemplate))
            {
                json["taskTemplate"] = TaskTemplate;
            }
                
            var toolbar = Toolbar.ToJson();
            if (toolbar.Any())
            {
                json["toolbar"] = toolbar;
            }
            var tooltip = Tooltip.ToJson();
            if (tooltip.Any())
            {
                json["tooltip"] = tooltip;
            }
            var views = Views.ToJson();
            if (views.Any())
            {
                json["views"] = views;
            }
            if (RowHeight.HasValue)
            {
                json["rowHeight"] = RowHeight;
            }
                
        //<< Serialization

            var resources = Resources.ToJson();
            if (resources.Any())
            {
                json["resources"] = resources;
            }

            if (DataSourceId.HasValue())
            {
                json["dataSourceId"] = DataSourceId;
            }
            else
            {
                ProcessDataSource(DataSource);
                json["dataSource"] = (Dictionary<string, object>)DataSource.ToJson();
            }
            if (DependenciesDataSourceId.HasValue())
            {
                json["dependenciesId"] = DependenciesDataSourceId;
            }
            else
            {
                ProcessDataSource(DependenciesDataSource);
                json["dependencies"] = (Dictionary<string, object>)DependenciesDataSource.ToJson();
            }
            writer.Write(Initializer.Initialize(Selector, "Gantt", json));

            base.WriteInitializationScript(writer);
        }

        private void ProcessDataSource(DataSource dataSource)
        {
            if (DependenciesDataSource.Type != DataSourceType.Custom || DependenciesDataSource.CustomType == "aspnetmvc-ajax")
            {
                if (DependenciesDataSource.IsClientOperationMode)
                {
                    DataSourceRequest request = new DataSourceRequest();

                    dataSource.Process(request, true);
                }
            }
        }

        protected override void WriteHtml(HtmlTextWriter writer)
        {
            var html = new GanttHtmlBuilder<TTaskModel, TDependenciesModel>(this).Build();

            html.WriteTo(writer);

            base.WriteHtml(writer);
        }
    }
}

