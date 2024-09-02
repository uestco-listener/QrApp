using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QrApp.Model;
using QrApp.Repository;

namespace QrApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UserRepository userRepository = new UserRepository();

        [HttpGet("getAll")]
        public async Task<IActionResult> getAll()
        {
            try
            {
                var list = userRepository.GetAllList();
                var model = new List<UserModel>();

                foreach (var item in list)
                {
                    model.Add(new UserModel(item));
                }

                return Ok(JsonConvert.SerializeObject(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> deleteUser(Guid id)
        {
            try
            {
                var user = userRepository.GetById(id);
                userRepository.Delete(user);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> getById(Guid id)
        {
            try
            {
                var user = userRepository.GetById(id);
                return user == null ? NotFound() : Ok(JsonConvert.SerializeObject(new UserModel(user)));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> addUser([FromBody] UserModel model)
        {
            try
            {
                var user = model.getValuesLikeDbType();
                user.Id = Guid.NewGuid();
                userRepository.Insert(user);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
