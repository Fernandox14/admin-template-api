using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Admin_Domain.Entities;
using Web_Admin_Domain.Interface;

namespace Web_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserRepository _repository;

        public LoginController(IUserRepository repository)
        {
            this._repository = repository;
        }

        // GET api/<UserController>/5
        [HttpPost]
        public User Post(User user)
        {
            return _repository
                        .GetAll().Where(x => x.Login == user.Login && x.Password == user.Password)
                        .FirstOrDefault() ;
        }
    }
}
