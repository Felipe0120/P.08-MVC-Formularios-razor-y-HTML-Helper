using Microsoft.EntityFrameworkCore;
using DawActivy.Models;
namespace DawActivy.Models
{
    public class equipoDbContext : DbContext
    {
        public equipoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<carreras> carreras{ get; set; }
        public DbSet<equipos> equipoos { get; set; }
        public DbSet<estados_equipo> estados_equipos { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<reservas> reservas { get; set; }
        public DbSet<tipo_equipo> tipo_equipo { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<DawActivy.Models.estados_reserva>? estados_reserva { get; set; }

    }
}
