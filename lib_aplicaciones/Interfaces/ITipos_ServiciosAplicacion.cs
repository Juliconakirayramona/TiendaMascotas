using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ITipos_serviciosAplicacion
    {
        void Configurar(string string_conexion);
        List<Tipos_servicios> Buscar(Tipos_servicios entidad, string tipo);
        List<Tipos_servicios> Listar();
        Tipos_servicios Guardar(Tipos_servicios entidad);
        Tipos_servicios Modificar(Tipos_servicios entidad);
        Tipos_servicios Borrar(Tipos_servicios entidad);
    }
}