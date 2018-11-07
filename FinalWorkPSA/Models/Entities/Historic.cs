using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWorkPSA.Models.Entities
{
    public class Historic
    {
        public int IdStudent { get; set; }
        public string IdSubject { get; set; }
        public string Status { get; set; }
        public int IdClass { get; set; }
    }
}
