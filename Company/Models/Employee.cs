﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string Name { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Surname cannot exceed 30 characters")]
        public string Surname { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Department? Department { get; set; }
        public string PhotoPath { get; set; }
    }
}
