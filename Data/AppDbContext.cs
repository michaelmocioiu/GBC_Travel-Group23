using Microsoft.EntityFrameworkCore;
using GBC_Travel_Group23.Models;

namespace GBC_Travel_Group23.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<tempfolder> RoomBookings { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        // Define other DbSet properties for your models here

    }
}
