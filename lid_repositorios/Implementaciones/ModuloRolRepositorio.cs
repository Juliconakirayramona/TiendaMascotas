using lib_entidades;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class ModuloRolRepositorio : IModuloRolRepositorio
    {
        private Conexion? conexion = null;

        public ModuloRolRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<ModuloRol> Listar()
        {
            return conexion!.Listar<ModuloRol>();
        }

        public List<ModuloRol> Buscar(Expression<Func<ModuloRol, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public ModuloRol Guardar(ModuloRol entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public ModuloRol Modificar(ModuloRol entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public ModuloRol Borrar(ModuloRol entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}