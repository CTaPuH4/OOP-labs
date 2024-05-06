using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_lab3.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GPUID { get; set; }
        [ForeignKey("GPUID")]
        public GPU? GPU { get; set; }
    }
}
