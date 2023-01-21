using Microsoft.AspNetCore.Mvc;
using Web_Admin.Infra.Repositories;
using Web_Admin_Domain.Domain.Interfaces;
using Web_Admin_Domain.Entities;
using Web_Admin_Domain.Interface;
using Web_Admin_Infra.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _repository;
     
        public UserController(IUserRepository repository)
        {
            this._repository = repository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var UserLevel = new UserLevel() { Id = 1, Name= "Admin" };

            var Users = _repository.GetAll();

            foreach(User user in Users)
            {
                user.UserLevel = UserLevel;
            }

            return Users;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post(User User)
        {
            _repository.ToSave(User);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, User User)
        {
            var user = _repository.GetById(id);
            if(user != null)
            {
                user = User;
                _repository.ToUpdate(user);
            }
                
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = _repository.GetById(id);
            if (user != null)
            {
                _repository.ToDelete(user);
            }
        }
    }
}
