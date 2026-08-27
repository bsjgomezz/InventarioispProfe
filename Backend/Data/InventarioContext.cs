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
        

        public DbSet<Localidad> Localidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Firstname = "Juan", Lastname = "Pérez", Dni = "12345678", Address = "Calle Falsa 123" },
                new Cliente { Id = 2, Firstname = "María", Lastname = "González", Dni = "87654321", Address = "Avenida Siempre Viva 456" },
                new Cliente { Id = 3, Firstname = "Pedro", Lastname = "López", Dni = "11223344", Address = "Callejón del Beso 789" }
            );

            // configuramos la propiedad Created_at para que tenga un valor por defecto de la fecha y hora actual.

            modelBuilder.Entity<Cliente>()
                .Property(c => c.Created_at)
                .HasDefaultValueSql("NOW()");

            //configuramos los queries filters para que no se muestren los clientes eliminados
            modelBuilder.Entity<Cliente>()
                .HasQueryFilter(c => !c.IsDeleted);

            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1, Name = "Buenos Aires" },
                new Localidad { Id = 2, Name = "Santa Fe" },
                new Localidad { Id = 3, Name = "Vera y Pintado" }
         );


            modelBuilder.Entity<Localidad>()
                .HasQueryFilter(l => !l.IsDeleted);    
        }
    }
}
