using Microsoft.EntityFrameworkCore;
using OOP_lab3.Models;

namespace OOP_lab3.Data
{
    public class ApplicationDB: DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<GPUToVendor> GPUToVendors { get; set; }
    }
}
