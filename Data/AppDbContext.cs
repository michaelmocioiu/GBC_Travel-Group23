using GBC_Travel_Group23.Models;
using Microsoft.EntityFrameworkCore;

namespace GBC_Travel_Group23.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CarRental> CarRental { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Config
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Flight)
                .WithMany(f => f.Bookings)
                .HasForeignKey(b => b.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.HotelRoom)
                .WithMany(h => h.Bookings)
                .HasForeignKey(b => b.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.CarRental)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<HotelRoom>()
                .HasOne(hr => hr.Hotel)
                .WithMany(h => h.Rooms)
                .HasForeignKey(hr => hr.HotelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Client)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
            
            

            //Seed Data
            modelBuilder.Entity<Client>().HasData(
                    new Client { Id = 10000, FullName = "Michael Mocioiu", Email = "michmoc@gmail.com", Phone = "+1 (647) 102-9392"},
                    new Client { Id = 10001, FullName = "Frederica Cottem", Email = "fcottem0@linkedin.com", Phone = "+7 (375) 654-3590" },
                    new Client { Id = 10002, FullName = "Annabella Comellini", Email = "acomellini1@cnet.com", Phone = "+93 (923) 606-7690" },
                    new Client { Id = 10003, FullName = "Redd Daniel", Email = "rdaniel2@sfgate.com", Phone = "+86 (422) 538-4788" },
                    new Client { Id = 10004, FullName = "Tana Bister", Email = "tbister3@so-net.ne.jp", Phone = "+7 (528) 881-6250" },
                    new Client { Id = 10005, FullName = "Nikaniki Boulder", Email = "nboulder4@cisco.com", Phone = "+93 (657) 895-3488" },
                    new Client { Id = 10006, FullName = "Ariana Plaide", Email = "aplaide5@smh.com.au", Phone = "+57 (863) 320-2637" },
                    new Client { Id = 10007, FullName = "Burr Livzey", Email = "blivzey6@businessweek.com", Phone = "+675 (218) 591-6032" },
                    new Client { Id = 10008, FullName = "Waring Barrow", Email = "wbarrow7@arstechnica.com", Phone = "+86 (398) 693-2908" },
                    new Client { Id = 10009, FullName = "Brade Brymham", Email = "bbrymham8@usgs.gov", Phone = "+55 (979) 581-5768" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
