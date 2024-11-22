using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Clientes_serviciosRepositorio : IClientes_serviciosRepositorio
    {
        private Conexion? conexion = null;

        public Clientes_serviciosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Clientes_servicios> Listar()
        {
            return conexion!.Listar<Clientes_servicios>();
        }
        public Clientes_servicios Guardar(Clientes_servicios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Clientes_servicios Modificar(Clientes_servicios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Clientes_servicios Borrar(Clientes_servicios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}