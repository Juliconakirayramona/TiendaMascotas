using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IClientes_mascotasAplicacion
    {
        void Configurar(string string_conexion);
        List<Clientes_mascotas> Listar();
        Clientes_mascotas Guardar(Clientes_mascotas entidad);
        Clientes_mascotas Modificar(Clientes_mascotas entidad);
        Clientes_mascotas Borrar(Clientes_mascotas entidad);
    }
}