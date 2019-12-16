using DomainModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public class BlueContext:DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Room> rooms { get; set; }

        public BlueContext()
            : base()
        {

        }

        public BlueContext(DbContextOptions options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog= BlueDb; Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel);

            modelBuilder.Entity<Room>()
                .HasMany(c => c.BookingRooms)
                .WithOne(b => b.Rooms);

            modelBuilder.Entity<Booking>()
             .HasMany(b => b.BookingRooms)
             .WithOne(bk => bk.Booking);

            modelBuilder.Entity<Customer>()
           .HasMany(c => c.Booking)
           .WithOne(bk => bk.Customer);

            modelBuilder.Entity<Customer>()
            .HasOne(c =>c.Address)
            .WithOne(a => a.Customer);

            modelBuilder.Entity<Hotel>()
            .HasOne(h => h.address)
            .WithOne(a => a.Hotel);

            base.OnModelCreating(modelBuilder);
        }
    }
}
