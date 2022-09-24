using Microsoft.EntityFrameworkCore;
using CCM.App.Dominio;

namespace CCM.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Persona> personas { get; set; }
        public DbSet<Registro> registros { get; set; }
        public DbSet<RegistroParqueadero> registrosParqueadero { get; set; }
        public DbSet<Residente> residentes{ get; set; }
        public DbSet<ResidenteCorrespondencia> residentesCorrespondecia { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<UsuarioHistorial> usuariosHistorial { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CCM_Data");
            }
        }
    }
}