using lib_entidades.Modelos;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class Tipos_serviciosRepositorio : ITipos_serviciosRepositorio
    {
        private Conexion? conexion = null;

        public Tipos_serviciosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Tipos_servicios> Listar()
        {
            return conexion!.Listar<Tipos_servicios>();
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