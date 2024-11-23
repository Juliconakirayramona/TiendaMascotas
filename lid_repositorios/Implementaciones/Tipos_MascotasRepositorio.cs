using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Tipos_MascotasRepositorio : ITipos_MascotasRepositorio
    {
        private Conexion? conexion = null;

        public Tipos_MascotasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }
        public List<Tipo_Mascotas> Listar()
        {
            return Buscar(x => x != null);
        }
        public List<Tipo_Mascotas> Buscar(Expression<Func<Tipo_Mascotas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Tipo_Mascotas Guardar(Tipo_Mascotas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipo_Mascotas Modificar(Tipo_Mascotas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipo_Mascotas Borrar(Tipo_Mascotas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}