using EnglishLearnAPI.Dto.CourseDto;
using EnglishLearnAPI.Models.Course;
using EnglishLearnAPI.Models.ResponseModel;
using EnglishLearnAPI.Services.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnglishLearnAPI.Controllers.CourseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("GetAllCourse")]
        public async Task<ActionResult<ResponseModel<List<CourseModel>>>> GetAllCourse()
        {
            var course = await _courseService.GetAllCourse();
            return Ok(course);
        }

        [HttpPost("CreateCourse")]
        public async Task<ActionResult<ResponseModel<List<CourseModel>>>> CreateCourse(CreateCourseDto courseDto)
        {
            var course = await _courseService.CreateCourse(courseDto);
            return Ok(course);
        }

        [HttpPut("UpdateCourse")]
        public async Task<ActionResult<ResponseModel<List<CourseModel>>>> UpdateCourse(UpdateCourseDto courseDto)
        {
            var course = await _courseService.UpdateCourse(courseDto);
            return Ok(course);
        }
    }

}
