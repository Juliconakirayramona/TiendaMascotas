using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ITipos_serviciosRepositorio
    {
        void Configurar(string string_conexion);
        List<Tipos_servicios> Listar();
        Tipos_servicios Guardar(Tipos_servicios entidad);
        Tipos_servicios Modificar(Tipos_servicios entidad);
        Tipos_servicios Borrar(Tipos_servicios entidad);
    }
}