
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{       [Route("api/users")]
        [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext applicationDBContext)
        {
            _context = applicationDBContext;
        }
        [HttpGet]
        public ActionResult GetAll(){
            var users = _context.Users.ToList();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetByUser( [FromRoute]int id){

            var user = _context.Users.Find(id.ToString());
            if (user==null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}