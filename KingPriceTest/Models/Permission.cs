namespace KingPriceTest.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
