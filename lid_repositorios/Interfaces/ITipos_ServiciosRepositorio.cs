using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IClientes_serviciosRepositorio
    {
        void Configurar(string string_conexion);
        List<Clientes_servicios> Listar();
        Clientes_servicios Guardar(Clientes_servicios entidad);
        Clientes_servicios Modificar(Clientes_servicios entidad);
        Clientes_servicios Borrar(Clientes_servicios entidad);
    }
}