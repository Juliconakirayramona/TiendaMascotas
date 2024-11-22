using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IClientes_serviciosAplicacion
    {
        void Configurar(string string_conexion);
        List<Clientes_servicios> Listar();
        Clientes_servicios Guardar(Clientes_servicios entidad);
        Clientes_servicios Modificar(Clientes_servicios entidad);
        Clientes_servicios Borrar(Clientes_servicios entidad);
    }
}