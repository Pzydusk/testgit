using System.Text.RegularExpressions;

namespace KingPriceTest.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
