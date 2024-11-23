using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ITipos_mascotaspresentacion
    {
        Task<List<Tipos_mascotas>> Listar();
        Task<List<Tipos_mascotas>> Buscar(Tipos_mascotas entidad, string tipo);
        Task<Tipos_mascotas> Guardar(Tipos_mascotas entidad);
        Task<Tipos_mascotas> Modificar(Tipos_mascotas entidad);
        Task<Tipos_mascotas> Borrar(Tipos_mascotas entidad);
    }
}
