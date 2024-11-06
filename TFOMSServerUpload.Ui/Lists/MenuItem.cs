using Telerik.SvgIcons;

namespace TFOMSServerUpload.Ui.Lists
{
    public class MenuItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public ISvgIcon Icon { get; set; }
        public List<MenuItem> Items { get; set; }
    }
}
