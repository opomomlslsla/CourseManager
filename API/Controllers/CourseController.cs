using Application.DTO;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(CourseService service) : ControllerBase
    {
        private readonly CourseService _service = service;
        [HttpGet("GetCourseById/{id}")]
        public async Task<IActionResult> Get(Guid Id)
        {
            return Ok(await _service.GetAsync(Id));
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpPost("AddCourse")]
        public async Task<IActionResult> Add(CourseDTO dto)
        {
            return Ok(_service.AddAsync(dto));
        }
    }
}
