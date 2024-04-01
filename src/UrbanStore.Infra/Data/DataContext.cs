using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UrbanStore.Domain.Model;

namespace UrbanStore.Infra.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Brand>()
                .Property(b => b.Image)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30);
            
            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(500);

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Stock)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(p => p.Image)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(p => p.BrandId)
                .WithMany()
                .HasForeignKey(p => p.BrandId);
            
            modelBuilder.Entity<Product>()
                .HasOne(p => p.CategoryId)
                .WithMany()
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<User>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.PhoneNumber)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.BirthDate)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.CPF)
                .IsRequired();
        }
    }
}