using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using prueba.Data;
using prueba.Models;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // Configuración de la cadena de conexión a la base de datos
        var connectionString = Configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<TrabajadoresContext>(options =>
            options.UseSqlServer(connectionString));

        // Otras configuraciones
        // ...
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Otras configuraciones
        // ...
    }
}
