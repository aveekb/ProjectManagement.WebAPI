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
    public class ProjectsController : ControllerBase
    {
        private IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _projectService.GetAllAsync());
        }


        [HttpGet("{Id}")]        
        public async Task<IActionResult> Get(int Id)
        {
            return Ok(await _projectService.GetByIdAsync(Id));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] D_Project project)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _projectService.SaveAsync(project);
                return Ok("project created");
            }
            catch(Exception)
            {
                return BadRequest();
            }
            
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] D_Project project)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _projectService.UpdateAsync(project);
                return Ok("project updated");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] D_Project project)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                await _projectService.DeleteAsync(project);
                return Ok("project deleted");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
