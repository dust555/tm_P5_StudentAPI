using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentenAPI.DTOs;
using StudentenAPI.Models;
using StudentenAPI.Repos;

namespace StudentenAPI.Controllers
{

    [ApiController]
    [Route("api/student")]
    public class StudentController:ControllerBase
    {


        IRepo _repo;
        IMapper _mapper;

        public StudentController(IRepo repo, IMapper mapper){
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAllStudents(){
            return Ok(_mapper.Map<List<ReadStudentDTO>>(_repo.GetAllStudents()));
        }


        [HttpGet("{id}")]
        public ActionResult GetStudentById(int id){

            Student s = _repo.GetStudentById(id);
            if(s == null){
                return NotFound();
            }

            return Ok(_mapper.Map<ReadStudentDTO>(s));
        }

        [HttpPost]
        public ActionResult CreateNewStudent(WriteStudentDTO student){
            Student s = _mapper.Map<Student>(student);
            _repo.CreateStudent(s);
            _repo.SaveChanges();
            return Ok(s);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, UpdateStudentDTO student){

            Student s = _repo.GetStudentById(id);
            if(s == null){
                return NotFound();
            }

            _mapper.Map(student,s);

            _repo.UpdateStudent(s);
            _repo.SaveChanges();

            return NoContent();


        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id){
            Student s = _repo.GetStudentById(id);
            if(s == null){
                return NotFound();
            }

            _repo.DeleteStudent(s);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}