using asp_servicios.Controllers;
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lid_repositorios.Interfaces;
using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace asp_servicios
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static IConfiguration? Configuration { set; get; }

        public void ConfigureServices(WebApplicationBuilder builder, IServiceCollection services)
        {
            services.Configure<KestrelServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.Configure<IISServerOptions>(x => { x.AllowSynchronousIO = true; });
            services.AddControllers();
            services.AddEndpointsApiExplorer();

            //services.AddSwaggerGen();
            services.AddScoped<Conexion, Conexion>();
            // Repositorios
            services.AddScoped<IMascotasRepositorio, MascotasRepositorio>();
            services.AddScoped<IClientesRepositorio, ClientesRepositorio>();
            services.AddScoped<ITipos_MascotasRepositorio, Tipos_MascotasRepositorio>();
            services.AddScoped<IAuditoriasRepositorio, AuditoriasRepositorio>();
            services.AddScoped<IServiciosRepositorio, ServiciosRepositorio>();
            services.AddScoped<ITipos_serviciosRepositorio, Tipos_serviciosRepositorio>();
            services.AddScoped<IFacturasRepositorio, FacturasRepositorio>();
            services.AddScoped<IUsuariosRepositorio, UsuariosRepositorio>();

            // Aplicaciones
            services.AddScoped<IMascotasAplicacion, MascotasAplicacion>();
            services.AddScoped<IClientesAplicacion, ClientesAplicacion>();
            services.AddScoped<ITipos_MascotasAplicacion, Tipos_MascotasAplicacion>();
            services.AddScoped<IServiciosAplicacion, ServiciosAplicacion>();
            services.AddScoped<ITipos_serviciosAplicacion, Tipos_serviciosAplicacion>();
            services.AddScoped<IFacturasAplicacion, FacturasAplicacion>();
            services.AddScoped<IUsuariosRepositorio, UsuariosRepositorio>();

            // Controladores
            services.AddScoped<TokenController, TokenController>();

            services.AddCors(o => o.AddDefaultPolicy(b => b.AllowAnyOrigin()));
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
            
            app.UseCors();
        }
    }
}