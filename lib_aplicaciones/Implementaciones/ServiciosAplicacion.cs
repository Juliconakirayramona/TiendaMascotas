using lib_entidades;
using lib_aplicaciones.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class ServiciosAplicacion : IServiciosAplicacion
    {
        private IServiciosRepositorio? iRepositorio = null;

        public ServiciosAplicacion(IServiciosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Servicios Borrar(Servicios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Servicio == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Servicios Guardar(Servicios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Servicio != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Servicios> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Servicios> Buscar(Servicios entidad, string tipo)
        {
            Expression<Func<Servicios, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                default: condiciones = x => x.ID_Servicio == entidad.ID_Servicio; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }
        public Servicios Modificar(Servicios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Servicio == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}