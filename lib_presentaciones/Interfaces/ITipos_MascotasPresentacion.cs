using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IClientes_mascotaspresentacion
    {
        Task<List<Clientes_mascotas>> Listar();
        Task<List<Clientes_mascotas>> Buscar(Clientes_mascotas entidad, string tipo);
        Task<Clientes_mascotas> Guardar(Clientes_mascotas entidad);
        Task<Clientes_mascotas> Modificar(Clientes_mascotas entidad);
        Task<Clientes_mascotas> Borrar(Clientes_mascotas entidad);
    }
}
