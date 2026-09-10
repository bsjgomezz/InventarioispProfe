using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Backend.Data
{
    public class InventarioContext: DbContext
    {
        public InventarioContext()
        {
            
        }
        public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }

        //creamos el método OnConfiguring para configurar la cadena de conexión de datos PostgreSQL

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();

                //string cadenaConexion = configuration.GetConnectionString("mysqlRemote");
                var cadenaConexion = configuration.GetConnectionString("postgresRemote");
                optionsBuilder.UseNpgsql(cadenaConexion); 
            }
        }
        
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Localidad> Localidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Firstname = "Juan", Lastname = "Pérez", Dni = "12345678", Address = "Calle Falsa 123", LocalidadId = 1 },
                new Cliente { Id = 2, Firstname = "María", Lastname = "González", Dni = "87654321", Address = "Avenida Siempre Viva 456", LocalidadId = 1 },
                new Cliente { Id = 3, Firstname = "Pedro", Lastname = "López", Dni = "11223344", Address = "Callejón del Beso 789", LocalidadId = 2 }
            );

            // configuramos la propiedad Created_at para que tenga un valor por defecto de la fecha y hora actual.

            modelBuilder.Entity<Cliente>()
                .Property(c => c.Created_at)
                .HasDefaultValueSql("NOW()");

            //configuramos los queries filters para que no se muestren los clientes eliminados
            modelBuilder.Entity<Cliente>()
                .HasQueryFilter(c => !c.IsDeleted);

            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1, Name = "Buenos Aires", ProvinciaId = 1 },
                new Localidad { Id = 2, Name = "Santa Fe", ProvinciaId = 2 },
                new Localidad { Id = 3, Name = "Vera y Pintado", ProvinciaId = 2 }
            );

                //Desactivamos la eliminacion en cascada para la relacion entre localidad y provincias usando Fluent API
            modelBuilder.Entity<Provincia>().HasData(
                new Provincia { Id = 1, Name = "Buenos Aires", PaisId = 1 },
                new Provincia { Id = 2, Name = "Santa Fe", PaisId = 1 },
                new Provincia { Id = 3, Name = "Chaco", PaisId = 1 }
            );
             modelBuilder.Entity<Provincia>()
                .HasOne(p => p.Pais)
                .WithMany()
                .HasForeignKey(p => p.PaisId)
                .OnDelete(DeleteBehavior.Restrict);


             modelBuilder.Entity<Localidad>()
                .HasOne(l => l.Provincia)
                .WithMany()
                .HasForeignKey(l => l.ProvinciaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, Name = "Argentina" },
                new Pais { Id = 2, Name = "Brasil" },
                new Pais { Id = 3, Name = "Uruguay" }
            );

             modelBuilder.Entity<Provincia>()
                .HasQueryFilter(p => !p.IsDeleted);

            modelBuilder.Entity<Pais>()
                .HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
