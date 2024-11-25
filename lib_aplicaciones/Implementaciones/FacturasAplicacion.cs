using lib_entidades;
using lib_aplicaciones.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class FacturasAplicacion : IFacturasAplicacion
    {
        private IFacturasRepositorio? iRepositorio = null;

        public FacturasAplicacion(IFacturasRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Facturas Borrar(Facturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Factura == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Facturas Guardar(Facturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Factura != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Facturas> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Facturas> Buscar(Facturas entidad, string tipo)
        {
            Expression<Func<Facturas, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "CODIGO FACTURA": condiciones = x => x.Codigo_Factura!.Contains(entidad.Codigo_Factura!); break;
                case "COMPLEJA":
                    condiciones =
                        x => x.Codigo_Factura!.Contains(entidad.Codigo_Factura!); break;
                default: condiciones = x => x.ID_Factura == entidad.ID_Factura; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Facturas Modificar(Facturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Factura == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}