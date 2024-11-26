using lib_comunicaciones.Implementaciones;
using lib_comunicaciones.Interfaces;
using lib_presentaciones.Implementaciones;
using lib_presentaciones.Interfaces;

namespace asp_presentacion
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
            // Comunicaciones
            services.AddScoped<IClientesComunicacion, ClientesComunicacion>();

            services.AddScoped<IServiciosComunicacion, ServiciosComunicacion>();

            services.AddScoped<IMascotasComunicacion, MascotasComunicacion>();

            services.AddScoped<ITipo_MascotasComunicacion, Tipo_MascotaComunicacion>();



            // Presentaciones
            services.AddScoped<IClientespresentacion, Clientespresentacion>();

            services.AddScoped<IServiciospresentacion, Serviciospresentacion>();


            services.AddScoped<IMascotaspresentacion, Mascotaspresentacion>();

            services.AddScoped<ITipos_Mascotaspresentacion, Tipos_Mascotaspresentacion>();

            
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddRazorPages();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseAuthorization();
            app.MapRazorPages();
            app.UseRouting();
            app.UseSession();
            app.Run();
        }
    }
}