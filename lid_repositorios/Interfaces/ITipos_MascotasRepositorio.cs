using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ITipos_MascotasRepositorio
    {
        void Configurar(string string_conexion);
        List<Tipo_Mascotas> Listar();
        List<Tipo_Mascotas> Buscar(Expression<Func<Tipo_Mascotas, bool>> condiciones);
        Tipo_Mascotas Guardar(Tipo_Mascotas entidad);
        Tipo_Mascotas Modificar(Tipo_Mascotas entidad);
        Tipo_Mascotas Borrar(Tipo_Mascotas entidad);
    }
}