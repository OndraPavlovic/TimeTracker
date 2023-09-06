using Microsoft.AspNetCore.Mvc;
using TimeTracker.Shared.DTOs.Project;

namespace TimeTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            return Ok(await _projectService.GetAllProjects());
        }

        [HttpPost]
        public async Task<ActionResult<List<Project>>> CreateProject(ProjectCreateRequest project)
        {
            return Ok(await _projectService.CreateProject(project));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Project>>> GetProjectById(int id)
        {
            var result = await _projectService.GetProjectById(id);
            if (result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Project>>> UpdateProject(int id, ProjectUpdateRequest project)
        {
            var result = await _projectService.UpdateProject(id, project);            
            if (result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }            
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Project>>> DeleteProject(int id)
        {
            var result = await _projectService.DeleteProject(id);
            if (result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }
            return Ok(result);
        }
        /*
        [HttpGet("{id}")]
        public async Task<ActionResult<List<TimeEntry>>> GetAllTimeEntriesForProject(int id)
        {
            var result = await _projectService.GetProjectById(id);
            if (result is null)
            {
                return NotFound("TimeEntry with the given ID was not found.");
            }
            return Ok(result);
        }
        */
    }
}
