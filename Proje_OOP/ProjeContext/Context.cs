using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LENOVO\\SQLEXPRESS;database=DbNewOopCore;integrated security=true;");
        }
        //aslında  burda yaptığımız entity oluşturduğumuz  classları db tanımladık yani veri bağlantıs yaptığımız yerde
        //ilk kısım c# class adı,ikinci kısım ise sql de karışılığı..

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
