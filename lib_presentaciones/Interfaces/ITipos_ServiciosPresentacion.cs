using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IClientes_serviciospresentacion
    {
        Task<List<Clientes_servicios>> Listar();
        Task<List<Clientes_servicios>> Buscar(Clientes_servicios entidad, string tipo);
        Task<Clientes_servicios> Guardar(Clientes_servicios entidad);
        Task<Clientes_servicios> Modificar(Clientes_servicios entidad);
        Task<Clientes_servicios> Borrar(Clientes_servicios entidad);
    }
}
