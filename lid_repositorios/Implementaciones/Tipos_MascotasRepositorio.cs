using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Tipos_mascotasRepositorio : ITipos_mascotasRepositorio
    {
        private Conexion? conexion = null;

        public Tipos_mascotasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Tipos_mascotas> Listar()
        {
            return conexion!.Listar<Tipos_mascotas>();
        }
        public Tipos_mascotas Guardar(Tipos_mascotas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos_mascotas Modificar(Tipos_mascotas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Tipos_mascotas Borrar(Tipos_mascotas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}