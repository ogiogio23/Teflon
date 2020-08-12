using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teflon.Models
{
    public class Student
    {
        public int Id { get; set; }

        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        [Required]
        public string StudentName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}