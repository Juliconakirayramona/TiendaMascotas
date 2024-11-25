using lib_entidades;
using lib_aplicaciones.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class Tipos_MascotasAplicacion : ITipos_MascotasAplicacion
    {
        private ITipos_MascotasRepositorio? iRepositorio = null;

        public Tipos_MascotasAplicacion(ITipos_MascotasRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Tipo_Mascotas Borrar(Tipo_Mascotas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_TipoMascota == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Tipo_Mascotas Guardar(Tipo_Mascotas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_TipoMascota != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Tipo_Mascotas> Listar()
        {
            return iRepositorio!.Listar();
        }
        public List<Tipo_Mascotas> Buscar(Tipo_Mascotas entidad, string tipo)
        {
            Expression<Func<Tipo_Mascotas, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "CODIGO FACTURA": condiciones = x => x.TipoDeMascota!.Contains(entidad.TipoDeMascota!); break;
                case "COMPLEJA":
                    condiciones =
                        x => x.TipoDeMascota!.Contains(entidad.TipoDeMascota!); break;
                default: condiciones = x => x.ID_TipoMascota == entidad.ID_TipoMascota; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Tipo_Mascotas Modificar(Tipo_Mascotas entidad)
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