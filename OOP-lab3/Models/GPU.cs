using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.SymbolStore;

namespace OOP_lab3.Models
{
    public class GPU
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Memory { get; set; }
        public int GPU_Clock { get; set; }
    }
}
