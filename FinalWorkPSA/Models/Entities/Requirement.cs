using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWorkPSA.Models.Entities
{
    public class Requirement
    {
        [Key]
        public string IdSubject { get; set; }
        public List<string> Requirements { get; set; }
    }
}
