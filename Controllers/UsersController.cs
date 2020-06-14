using Microsoft.AspNetCore.Mvc;
using ProjectManagement.WebAPI.Contracts;
using ProjectManagement.WebAPI.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.GetAllAsync());
        }


        [HttpGet("{Id}")]        
        public async Task<IActionResult> Get(int Id)
        {
            return Ok(await _userService.GetByIdAsync(Id));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] M_User user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _userService.SaveAsync(user);
                return Ok("user created");
            }
            catch(Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] M_User user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _userService.UpdateAsync(user);
                return Ok("user updated");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] M_User user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _userService.DeleteAsync(user);
                return Ok("user deleted");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
