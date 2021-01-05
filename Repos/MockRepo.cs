using System.Collections.Generic;
using StudentenAPI.Models;

namespace StudentenAPI.Repos
{
    public class MockRepo : IRepo
    {
        public void CreateStudent(Student s)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteStudent(Student s)
        {
            throw new System.NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            List<Student> studenten = new List<Student>();
            studenten.Add(new Student(){Id=1, FName="Eveline", LName="Test"});
            studenten.Add(new Student(){Id=2, FName="Rachid", LName="Test"});

            return studenten;
        }

        public Student GetStudentById(int id)
        {
            return new Student(){Id=2, FName="Rachid", LName="Test"};
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateStudent(Student s)
        {
            throw new System.NotImplementedException();
        }
    }
}