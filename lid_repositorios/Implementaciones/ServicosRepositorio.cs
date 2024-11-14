using lib_entidades.Modelos;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class ServiciosRepositorio : IServiciosRepositorio
    {
        private Conexion? conexion = null;

        public ServiciosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Servicios> Listar()
        {
            return conexion!.Listar<Servicios>();
        }

        public Servicios Guardar(Servicios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Servicios Modificar(Servicios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Servicios Borrar(Servicios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}