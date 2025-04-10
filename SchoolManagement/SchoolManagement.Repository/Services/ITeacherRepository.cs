using SchoolManagement.DataAccess.Entities;

namespace SchoolManagement.Repository.Services;

public interface ITeacherRepository
{
    Task<int> AddTeacherAsync(Teacher teacher);
    Task<Teacher> GetTeacherByIdAsync(int teacherId);
    Task<List<Teacher>> GetAllTeachersAsync(bool includeStudents = false, bool includeClasses = false);
    Task UpdateTeacherAsync(Teacher teacher);
    Task DeleteTeacherAsync(int teacherId);
}