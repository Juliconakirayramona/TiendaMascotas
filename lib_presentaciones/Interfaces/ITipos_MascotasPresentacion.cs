using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ITipos_Mascotaspresentacion
    {
        Task<List<Tipo_Mascotas>> Listar();
        Task<List<Tipo_Mascotas>> Buscar(Tipo_Mascotas entidad, string tipo);
        Task<Tipo_Mascotas> Guardar(Tipo_Mascotas entidad);
        Task<Tipo_Mascotas> Modificar(Tipo_Mascotas entidad);
        Task<Tipo_Mascotas> Borrar(Tipo_Mascotas entidad);
    }
}
