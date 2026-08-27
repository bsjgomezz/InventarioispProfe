using Backend.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Register InventarioContext for dependency injection using PostgreSQL provider.
        // Note: connection string mirrors the one set in InventarioContext.OnConfiguring.
        builder.Services.AddDbContext<Backend.Data.InventarioContext>(options =>
            options.UseNpgsql("Host=up-de-fra1-postgresql-3.db.run-on-seenode.com;Port=11550;Database=db_4r596rgwatp9;Username=db_4r596rgwatp9;Password=B1nUrwPXoV9GGckCPYPIFPr5 ")
        );
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        //string cadenaConexion = configuration.GetConnectionString("mysqlRemote");
        var cadenaConexion = configuration.GetConnectionString("postgresRemote");
        //string cadenaConexion="Host=up-de-fra1-postgresql-3.db.run-on-seenode.com;Port=11550;Database=db_4r596rgwatp9;Username=db_4r596rgwatp9;Password=B1nUrwPXoV9GGckCPYPIFPr5"; 
        builder.Services.AddDbContext<InventarioContext>(
        options => options.UseNpgsql(cadenaConexion));
        
        

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}