using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using VNext.BienEtreAuTravail.DAL.Models.Database;
using VNext.BienEtreAuTravail.DAL.Models.Settings;
using VNext.BienEtreAuTravail.DAL.Repositories;

namespace VNext.BienEtreAuTravail.DAL.Context
{
    class WorkContext : DbContext
    {


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Commentaire> Commentaire { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<HumeurEmployee> HumeurEmp { get; set; }

        public DbSet<Departement> Departement { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString
            // optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString.);
            optionsBuilder.UseSqlServer("Server=tcp:mg-sql-server.database.windows.net,1433;Initial Catalog=vnext;Persist Security Info=False;User ID=ad-min;Password=Vnext#14;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(a => a.Commentaire)
                .WithOne(b => b.Employee)
                .HasForeignKey<Commentaire>(b => b.CommentOfEmployee);

            modelBuilder.Entity<HumeurEmployee>()
           .HasKey(sc => new { sc.IdEmployee, sc.IdHumeur });

            modelBuilder.Entity<Departement>()
                 .HasOne(a => a.Employee)
                 .WithOne(b => b.Departement)
                 .HasForeignKey<Employee>(b => b.IdDepartement);
        }
    }
}
