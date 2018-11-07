using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalWorkPSA.Models.Entities
{
    public class Student
    {
        [Key]
        public int Identifier { get; set; }
        public string Email { get; set; }
    }
}
