using System;
using System.Collections.Generic;
using System.Linq;


namespace Kendo.Mvc.UI
{
    public class GridBoundColumnFilterableSettings : GridFilterableSettings
    {
        public GridBoundColumnFilterableSettings()
        {
            Enabled = true;
            FilterUIHandler = new ClientHandlerDescriptor();
            ItemTemplate = new ClientHandlerDescriptor();
            CellSettings = new GridColumnFilterableCellSettings();

            DataSource = new DataSource();
            DataSource.Transport.SerializeEmptyPrefix = false;
            DataSource.Schema.Data = "";
            DataSource.Schema.Total = "";
            DataSource.Schema.Errors = "";

            CheckAll = true;
        }

        public GridFilterUIRole FilterUIRole { get; set; }
        public ClientHandlerDescriptor FilterUIHandler { get; set; }

        public ClientHandlerDescriptor ItemTemplate { get; set; }
        public DataSource DataSource { get; set; }
        public bool Multi { get; set; }
        public bool CheckAll { get; set; }
        public bool? Search { get; set; }
        public bool? IgnoreCase { get; set; }

        public GridColumnFilterableCellSettings CellSettings { get; set; }

        protected override void Serialize(System.Collections.Generic.IDictionary<string, object> json)
        {
            base.Serialize(json);

            if (FilterUIHandler.HasValue())
            {
                json["ui"] = FilterUIHandler;
            }
            else if (FilterUIRole != GridFilterUIRole.Default)
            {
                json["ui"] = Enum.GetName(typeof(GridFilterUIRole), FilterUIRole).ToLowerInvariant();
            }

            if (Multi)
            {
                json["multi"] = Multi;
            }

            if (Search.HasValue)
            {
                json["search"] = Search;
            }

            if (IgnoreCase.HasValue)
            {
                json["ignoreCase"] = IgnoreCase;
            }

            if (ItemTemplate.HasValue())
            {
                json["itemTemplate"] = ItemTemplate;
            }
            if (CheckAll == false)
            {
                json["checkAll"] = CheckAll;
            }

            if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url))
            {
                json["dataSource"] = DataSource.ToJson();
            }
            else if (DataSource.Data != null)
            {
                json["dataSource"] = DataSource.Data;
            }

            var cellSettings = CellSettings.ToJson();
            if (cellSettings.Any())
            {
                json["cell"] = cellSettings;
            }

        }
    }
}