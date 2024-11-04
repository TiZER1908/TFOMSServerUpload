using Telerik.SvgIcons;

namespace TFOMSServerUpload.Ui.Lists
{
    public class DrawerItem
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public ISvgIcon Icon { get; set; }
        public static DrawerItem None() => new();
    }
}
