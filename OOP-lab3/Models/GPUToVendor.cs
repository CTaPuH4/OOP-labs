using System.ComponentModel.DataAnnotations.Schema;

namespace OOP_lab3.Models
{
    public class GPUToVendor
    {
        public int ID { get; set; }

        public int GPUID { get; set; }
        [ForeignKey("GPUID")]
        public GPU? GPU { get; set; }

        public int VendorID { get; set; }
        [ForeignKey("VendorID")]
        public Vendor? Vendor { get; set; }
    }
}
