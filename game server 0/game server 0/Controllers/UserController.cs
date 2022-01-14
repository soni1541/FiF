using game_server_0.EF;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace game_server_0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private gameContext _gameContext;

        public UserController(gameContext gameContext)
        {
            _gameContext = gameContext;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _gameContext.Users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            User user = _gameContext.Users.FirstOrDefault(s => s.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            User user = new User();
            user.Email = value.Email;
            user.Password = BCrypt.Net.BCrypt.HashPassword(value.Password);
            user.Nuts = 0;
            user.Level = 1;
            _gameContext.Users.Add(user);
            _gameContext.SaveChanges();
        }


        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            dynamic value1 = JObject.Parse(value);
            User user = _gameContext.Users.FirstOrDefault(s => s.UserId == id);
            if (user == null)
            {
                return NotFound();
            }
            user.Nuts = value1.Nuts;
            user.Level = value1.Level;
            _gameContext.SaveChanges();
            return Ok(user);
        }
    }
}
