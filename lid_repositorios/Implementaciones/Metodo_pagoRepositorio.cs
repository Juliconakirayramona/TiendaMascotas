using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Metodo_pagoRepositorio : IMetodo_pagoRepositorio
    {
        private Conexion? conexion = null;

        public Metodo_pagoRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Metodo_pago> Listar()
        {
            return conexion!.Listar<Metodo_pago>();
        }


        public Metodo_pago Guardar(Metodo_pago entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Metodo_pago Modificar(Metodo_pago entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Metodo_pago Borrar(Metodo_pago entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}