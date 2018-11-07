using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalWorkPSA.Models.Entities
{
    public class Subject
    {
        [Key]
        public string Identifier { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
    }
}
