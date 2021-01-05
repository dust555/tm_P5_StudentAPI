using System.Collections.Generic;
using System.Linq;
using StudentenAPI.Models;
using StudentenAPI.Services;

namespace StudentenAPI.Repos
{
    public class MySqlRepo : IRepo
    {


        APIDbContext _context;
        public MySqlRepo(APIDbContext context){
            _context = context;
        }

        public void CreateStudent(Student s)
        {
            _context.Students.Add(s);
        }

        public void SaveChanges(){
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {





            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateStudent(Student s)
        {
        }

        public void DeleteStudent(Student s)
        {
            _context.Students.Remove(s);
        }
    }
}