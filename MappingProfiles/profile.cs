using AutoMapper;
using StudentenAPI.DTOs;
using StudentenAPI.Models;

namespace StudentenAPI.MappingProfiles
{
    public class StudentProfile:Profile
    {

        public StudentProfile(){
            CreateMap<Student, ReadStudentDTO>();
            CreateMap<WriteStudentDTO, Student>();
            CreateMap<UpdateStudentDTO, Student>();
        }
        
    }
}