using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetTraining.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "Please input your class.")]
        [MaxLength(100)]
        public string Class { get; set; }
    }
}
