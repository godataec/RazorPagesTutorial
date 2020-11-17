using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorPagesTutorial.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es requerido"), MinLength(3,ErrorMessage ="Nombre debe contener al menos 3 caracteres")]
        public string Name { get; set; }
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        [Required]
        public Dept? Department { get; set; }
    }
}
