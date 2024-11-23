using lib_entidades;
using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class Tipos_mascotasAplicacion : ITipos_mascotasAplicacion
    {
        private ITipos_mascotasRepositorio? iRepositorio = null;

        public Tipos_mascotasAplicacion(ITipos_mascotasRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Tipos_mascotas Borrar(Tipos_mascotas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_TipoMascota == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Tipos_mascotas Guardar(Tipos_mascotas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_TipoMascota != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Tipos_mascotas> Listar()
        {
            return iRepositorio!.Listar();
        }

        public Tipos_mascotas Modificar(Tipos_mascotas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_TipoMascota == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}