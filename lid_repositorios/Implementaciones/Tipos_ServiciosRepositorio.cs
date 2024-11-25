using lib_entidades.Modelos;
using lid_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Tipos_serviciosRepositorio : ITipos_serviciosRepositorio
    {
        private Conexion? conexion = null;

        public Tipos_serviciosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Tipos_servicios> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Tipos_servicios> Buscar(Expression<Func<Tipos_servicios, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Tipos_servicios Guardar(Tipos_servicios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos_servicios Modificar(Tipos_servicios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos_servicios Borrar(Tipos_servicios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}