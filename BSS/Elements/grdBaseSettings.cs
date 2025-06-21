using System.Collections.Generic;
using System.Configuration;

namespace BssBase
{
    internal sealed class grdBaseSettings : ApplicationSettingsBase
    {
        private grdBaseSettings _defaultInstace = (grdBaseSettings)Synchronized(new grdBaseSettings());

        public grdBaseSettings Default => _defaultInstace;

        [UserScopedSetting]
        [DefaultSettingValue("")]
        public Dictionary<string, List<ColumnOrderItem>> ColumnOrder
        {
            get => this["ColumnOrder"] as Dictionary<string, List<ColumnOrderItem>>;
            set => this["ColumnOrder"] = value;
        }
    }
}