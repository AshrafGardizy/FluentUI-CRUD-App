using FluentUICRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FluentUICRUDApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee { Id =1, Name="Ashraf Gardizy",Email="ashraf@gmail.com",Age="30"}
        //        );
        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<Employee> Employees { get; set; }

    }
}
