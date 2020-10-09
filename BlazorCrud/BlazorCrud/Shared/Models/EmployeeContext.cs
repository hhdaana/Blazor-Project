using BlazorCrud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Server.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public virtual DbSet<Contact> Contacttbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=MSI\HADI;Initial Catalog=EmployeeDb;Integrated Security=True;");
            }
        }
    }
}
