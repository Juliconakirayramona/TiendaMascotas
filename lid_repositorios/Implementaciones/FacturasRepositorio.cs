using lib_entidades.Modelos;
using lib_repositorios.Interfaces;

namespace lib_repositorios.Implementaciones
{
    public class FacturasRepositorio : IFacturasRepositorio
    {
        private Conexion? conexion = null;

        public FacturasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Facturas> Listar()
        {
            return conexion!.Listar<Facturas>();
        }

        public Facturas Guardar(Facturas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Facturas Modificar(Facturas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Facturas Borrar(Facturas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}