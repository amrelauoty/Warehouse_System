using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Warehouse_System.Model
{
    public partial class WarehouseSystem : DbContext
    {
        public WarehouseSystem()
            : base("name=WarehouseSystem")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Demand> Demands { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Items_Measureunits> Items_Measureunits { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Warehouse_items> Warehouse_items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Cust_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Cust_Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Cust_Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Cust_Website)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Cust_Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Demands)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Demands)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Items_Measureunits)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Supplies)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.Warehouse_items)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Supplies)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Demands)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.Warehouse_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Supplies)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.Warehouse_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Warehouse>()
                .HasMany(e => e.Warehouse_items)
                .WithRequired(e => e.Warehouse)
                .HasForeignKey(e => e.Warehouse_Name)
                .WillCascadeOnDelete(false);
        }
    }
}
