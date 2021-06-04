using ASPdotNetCore.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPdotNetCore.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }

        public DbSet<ServiceItem> ServiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "12345678-9012-3456-7890-12345678912",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
               Id= "12345678-9012-3456-dsfs-12345678912",
               UserName="admin",
               NormalizedUserName="ADMIN",
               Email="a.khimin@yandex.ru",
               NormalizedEmail="A.KHIMIN@YANDEX.RU",
               EmailConfirmed=true,
               PasswordHash=new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
               SecurityStamp=string.Empty
            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
               RoleId= "12345678-9012-3456-7890-12345678912",
               UserId= "12345678-9012-3456-dsfs-12345678912",
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("sd345678 - 9012 - 3456 - dsfs - 12345678912"),
                CodeWord="PageIndex",
                Title="Главная"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("sd345678 - 9012 - 3456 - dsfs - 12345678912"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("sd345678 - 9012 - 3456 - dsfs - 12345678912"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });







        }


    }
}
