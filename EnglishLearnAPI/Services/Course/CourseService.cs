using EnglishLearnAPI.Models.Course;
using EnglishLearnAPI.Models.ResponseModel;

namespace EnglishLearnAPI.Services.Course
{
    public class CourseService : ICourseService
    {
        public Task<ResponseModel<CourseModel>> CreateCourse(CourseModel course)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<CourseModel>>> GetAllCourse()
        {
            throw new NotImplementedException();
        }
    }
}
