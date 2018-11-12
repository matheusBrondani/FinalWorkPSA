using System.ComponentModel.DataAnnotations;

namespace FinalWorkPSA.Models.Entities
{
    public class Class
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Turma { get; set; }
        public string NSei { get; set; }
        public string Shift { get; set; }
    }
}
