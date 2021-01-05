using System;
using System.ComponentModel.DataAnnotations;

namespace StudentenAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public String FName { get; set; }
        [Required]
        [MaxLength(10)]
        public String LName { get; set; }
    }
}