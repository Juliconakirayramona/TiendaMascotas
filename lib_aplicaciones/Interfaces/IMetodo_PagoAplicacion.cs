using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IMetodo_pagoAplicacion
    {
        void Configurar(string string_conexion);
        List<Metodo_pago> Listar();
        Metodo_pago Guardar(Metodo_pago entidad);
        Metodo_pago Modificar(Metodo_pago entidad);
        Metodo_pago Borrar(Metodo_pago entidad);
    }
}