using lib_entidades;
using lib_entidades.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace lib_repositorios
{
    public class Conexion : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected DbSet<Clientes>? Clientes { get; set; }
        protected DbSet<Servicios> Servicios { get; set; }
        protected DbSet<Mascotas>? Mascotas { get; set; }
        protected DbSet<Tipo_Mascotas> Tipo_Mascotas { get; set; }
        protected DbSet<Tipos_servicios> Tipo_Servicios { get; set; }
        protected DbSet<Facturas> Facturas { get; set; }

        public virtual DbSet<T> ObtenerSet<T>() where T : class, new()
        {
            return this.Set<T>();
        }

        public virtual List<T> Listar<T>() where T : class, new()
        {
            return this.Set<T>().ToList();
        }

        public virtual List<T> Buscar<T>(Expression<Func<T, bool>> condiciones) where T : class, new()
        {
            return this.Set<T>().Where(condiciones).ToList();
        }
        public virtual List<Mascotas> Buscar(Expression<Func<Mascotas, bool>> condiciones)
        {
            return this.Set<Mascotas>()
                .Include(x => x._Dueño)
                .Where(condiciones)
                .ToList();
        }
        public virtual List<Tipo_Mascotas> Buscar(Expression<Func<Tipo_Mascotas, bool>> condiciones)
        {
            return this.Set<Tipo_Mascotas>()
                .Include(x => x._Mascota)
                .Where(condiciones)
                .ToList();
        }
        public virtual List<Servicios> Buscar(Expression<Func<Servicios, bool>> condiciones)
        {
            return this.Set<Servicios>()
                .Include(x => x._Mascota)
                .Where(condiciones)
                .ToList();
        }
        public virtual List<Tipos_servicios> Buscar(Expression<Func<Tipos_servicios, bool>> condiciones)
        {
            return this.Set<Tipos_servicios>()
                .Include(x => x._Servicio)
                .Where(condiciones)
                .ToList();
        }
        public virtual List<Facturas> Buscar(Expression<Func<Facturas, bool>> condiciones)
        {
            return this.Set<Facturas>()
                .Include(x => x._Cliente)
                .Include(x => x._Mascota)
                .Include(x => x._Servicio)
                .Include(x => x._Pago)
                .Where(condiciones)
                .ToList();

        }

        public virtual bool Existe<T>(Expression<Func<T, bool>> condiciones) where T : class, new()
        {
            return this.Set<T>().Any(condiciones);
        }

        public virtual void Guardar<T>(T entidad) where T : class, new()
        {
            this.Set<T>().Add(entidad);
        }

        public virtual void Modificar<T>(T entidad) where T : class
        {
            var entry = this.Entry(entidad);
            entry.State = EntityState.Modified;
        }

        public virtual void Borrar<T>(T entidad) where T : class, new()
        {
            this.Set<T>().Remove(entidad);
        }

        public virtual void Separar<T>(T entidad) where T : class, new()
        {
            this.Entry(entidad).State = EntityState.Detached;
        }

        public virtual void GuardarCambios()
        {
            this.SaveChanges();
        }
    }
}
