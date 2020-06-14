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
    public class TaskController : ControllerBase
    {
        private ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _taskService.GetAllAsync());
        }


        [HttpGet("{Id}")]        
        public async Task<IActionResult> Get(int Id)
        {
            return Ok(await _taskService.GetByIdAsync(Id));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] D_Task task)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _taskService.SaveAsync(task);
                return Ok("task created");
            }
            catch(Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]  D_Task task)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _taskService.UpdateAsync(task);
                return Ok("task updated");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]  D_Task task)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _taskService.DeleteAsync(task);
                return Ok("task deleted");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
