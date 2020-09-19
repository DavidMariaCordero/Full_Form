using Full_Form.Entidades;
using Microsoft.EntityFrameworkCore;
namespace Full_Form.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source = DATA/Employees.db");
        }
    }
}