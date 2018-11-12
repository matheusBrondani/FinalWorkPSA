using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWorkPSA.Models.Entities
{
    public class Historic
    {
        [Key]
        public int IdStudent { get; set; }
        public string IdSubject { get; set; }
        public string Status { get; set; }
        public int IdClass { get; set; }
    }
}
