using lib_entidades.Modelos;

namespace lib_repositorios.Interfaces
{
    public interface ITipos_serviciosRepositorio
    {
        List<Tipos_servicios> Listar();
        Tipos_servicios Guardar(Tipos_servicios entidad);
        Tipos_servicios Modificar(Tipos_servicios entidad);
        Tipos_servicios Borrar(Tipos_servicios entidad);
    }
}