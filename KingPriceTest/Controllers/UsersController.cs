using KingPriceTest.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace KingPriceTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController
    {
        private readonly DataContext _dataContext;

        public UsersController(DataContext dataContext)
        {
            DataContext dataContext1 = new DataContext();
            _dataContext = dataContext;
        }

        // Implement CRUD operations

        [HttpGet("usercount")]
        public ActionResult<int> GetUserCount()
        {
            return _dataContext.Users.Count();
        }

        [HttpGet("groupusercount/{groupId}")]
        public ActionResult<int> GetGroupUserCount(int groupId)
        {
            return _dataContext.Groups.Include(g => g.Users).FirstOrDefault(g => g.GroupId == groupId)?.Users.Count ?? 0;
        }
    }
}
