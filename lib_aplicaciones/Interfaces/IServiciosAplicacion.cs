using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IServiciosAplicacion
    {
        void Configurar(string string_conexion);
        List<Servicios> Listar();
        Servicios Guardar(Servicios entidad);
        Servicios Modificar(Servicios entidad);
        Servicios Borrar(Servicios entidad);
    }
}