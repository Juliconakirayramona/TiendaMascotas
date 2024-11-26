using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lid_repositorios.Interfaces
{
    public interface IModuloRolRepositorio
    {
        void Configurar(string string_conexion);
        List<ModuloRol> Listar();
        List<ModuloRol> Buscar(Expression<Func<ModuloRol, bool>> condiciones);
        ModuloRol Guardar(ModuloRol entidad);
        ModuloRol Modificar(ModuloRol entidad);
        ModuloRol Borrar(ModuloRol entidad);
    }



}