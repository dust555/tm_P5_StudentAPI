using System.Collections.Generic;
using StudentenAPI.Models;

namespace StudentenAPI.Repos
{
    public interface IRepo
    {

        List<Student> GetAllStudents();
        Student GetStudentById(int id);

        void CreateStudent(Student s);

        void SaveChanges();

        void UpdateStudent(Student s);

        void DeleteStudent(Student s);

    }
}