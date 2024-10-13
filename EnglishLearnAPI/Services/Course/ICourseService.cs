using EnglishLearnAPI.Models.Course;
using EnglishLearnAPI.Models.ResponseModel;

namespace EnglishLearnAPI.Services.Course
{
    public interface ICourseService
    {
        Task<ResponseModel<List<CourseModel>>> GetAllCourse();
        Task<ResponseModel<CourseModel>> CreateCourse(CourseModel course);
    }
}
