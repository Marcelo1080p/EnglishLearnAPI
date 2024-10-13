using EnglishLearnAPI.Dto.CourseDto;
using EnglishLearnAPI.Models.Course;
using EnglishLearnAPI.Models.ResponseModel;

namespace EnglishLearnAPI.Services.Course
{
    public interface ICourseService
    {
        Task<ResponseModel<List<CourseModel>>> GetAllCourse();
        Task<ResponseModel<CourseModel>> CreateCourse(CreateCourseDto courseDto);
        Task<ResponseModel<List<CourseModel>>> UpdateCourse(UpdateCourseDto courseDto);
    }
}
