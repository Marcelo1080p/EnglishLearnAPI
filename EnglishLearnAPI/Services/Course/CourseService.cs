using EnglishLearnAPI.Data;
using EnglishLearnAPI.Dto.CourseDto;
using EnglishLearnAPI.Models.Course;
using EnglishLearnAPI.Models.ResponseModel;
using Microsoft.EntityFrameworkCore;

namespace EnglishLearnAPI.Services.Course
{
    public class CourseService : ICourseService
    {
        private readonly AppDbContext _context;
        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<CourseModel>> CreateCourse(CreateCourseDto courseDto)
        {
            ResponseModel<CourseModel> response = new ResponseModel<CourseModel>();
            try
            {
                var newCourse = new CourseModel
                {
                    Title = courseDto.Title,
                    Description = courseDto.Description,
                    Level = courseDto.Level,
                    CreationDate = courseDto.CreationDate,
                };

                _context.Courses.Add(newCourse);
                await _context.SaveChangesAsync();

                response.Data = await _context.Courses.ToListAsync();
                response.Message = "course created successfully";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;

                return response;
            }
        }

        public async Task<ResponseModel<List<CourseModel>>> GetAllCourse()
        {
            ResponseModel<List<CourseModel>> response = new ResponseModel<List<CourseModel>>();
            try
            {
                var courses = await _context.Courses.ToListAsync();

                response.Data = courses;
                response.Message = "All Courses List";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;

                return response;
            }
        }

        public async Task<ResponseModel<List<CourseModel>>> UpdateCourse(UpdateCourseDto courseDto)
        {
            ResponseModel<List<CourseModel>> response = new ResponseModel<List<CourseModel>>();
            try
            {
                var course = await _context.Courses
                    .FirstOrDefaultAsync(responseCourse => responseCourse.CourseId == courseDto.CourseId);
                if(course == null)
                {
                    response.Message = "course not found";
                    return response;
                }
                course.Title = courseDto.Title;
                course.Description = courseDto.Description;
                course.Level = courseDto.Level;

                _context.Update(course);
                await _context.SaveChangesAsync();

                response.Data = await _context.Courses.ToListAsync();
                response.Message = "course updated successfully";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

    }
}
