using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface ITipos_serviciospresentacion
    {
        Task<List<Tipos_servicios>> Listar();
        Task<List<Tipos_servicios>> Buscar(Tipos_servicios entidad, string tipo);
        Task<Tipos_servicios> Guardar(Tipos_servicios entidad);
        Task<Tipos_servicios> Modificar(Tipos_servicios entidad);
        Task<Tipos_servicios> Borrar(Tipos_servicios entidad);
    }
}
