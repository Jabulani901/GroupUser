namespace GroupUser.Models
{
    public class NavigationMenuView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentMenuId { get; set; }
        public string Area { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public bool IsExternal { get; set; }
        public string ExternalUrl { get; set; }
        public bool Permitted { get; set; }
        public int DisplayOrder { get; set; }
        public bool Visible { get; set; }

    }
}