using lib_entidades.Modelos;

namespace lib_repositorios.Interfaces
{
    public interface IMetodo_pagoRepositorio
    {
        List<Metodo_pago> Listar();
        Metodo_pago Guardar(Metodo_pago entidad);
        Metodo_pago Modificar(Metodo_pago entidad);
        Metodo_pago Borrar(Metodo_pago entidad);
    }
}

