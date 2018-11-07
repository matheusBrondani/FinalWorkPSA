using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalWorkPSA.Models.Entities
{
    public class Requirement
    {
        public string IdSubject { get; set; }
        public List<string> Requirements { get; set; }
    }
}
