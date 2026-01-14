using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
    }
}
