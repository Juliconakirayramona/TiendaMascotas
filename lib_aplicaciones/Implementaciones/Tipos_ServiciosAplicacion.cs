using lib_entidades;
using lib_aplicaciones.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class Tipos_serviciosAplicacion : ITipos_serviciosAplicacion
    {
        private ITipos_serviciosRepositorio? iRepositorio = null;

        public Tipos_serviciosAplicacion(ITipos_serviciosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Tipos_servicios Borrar(Tipos_servicios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Tiposervicio == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Tipos_servicios Guardar(Tipos_servicios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Tiposervicio != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Tipos_servicios> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Tipos_servicios> Buscar(Tipos_servicios entidad, string tipo)
        {
            Expression<Func<Tipos_servicios, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "NOMBRE": condiciones = x => x.Tipo_Servicio!.Contains(entidad.Tipo_Servicio!); break;
                default: condiciones = x => x.ID_Tiposervicio == entidad.ID_Tiposervicio; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }
        public Tipos_servicios Modificar(Tipos_servicios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Tiposervicio == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}