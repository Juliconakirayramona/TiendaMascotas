using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lid_repositorios.Interfaces
{
    public interface IMetodo_pagoRepositorio
    {
        void Configurar(string string_conexion);
        List<Metodo_pago> Listar();
        Metodo_pago Guardar(Metodo_pago entidad);
        Metodo_pago Modificar(Metodo_pago entidad);
        Metodo_pago Borrar(Metodo_pago entidad);
    }
}