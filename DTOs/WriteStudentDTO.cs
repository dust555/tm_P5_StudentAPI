using System;
using System.ComponentModel.DataAnnotations;

namespace StudentenAPI.DTOs
{
    public class WriteStudentDTO
    {
        [Required]
        public String FName { get; set; }
        [Required]
        
        [MaxLength(10)]
        public String LName { get; set; }
    }
}