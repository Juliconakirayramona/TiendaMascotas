using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IClientes_mascotasRepositorio
    {
        void Configurar(string string_conexion);
        List<Clientes_mascotas> Listar();
        Clientes_mascotas Guardar(Clientes_mascotas entidad);
        Clientes_mascotas Modificar(Clientes_mascotas entidad);
        Clientes_mascotas Borrar(Clientes_mascotas entidad);
    }
}