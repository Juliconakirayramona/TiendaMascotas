using lib_entidades;
using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IMascotasRepositorio
    {
        void Configurar(string string_conexion);
        List<Mascotas> Listar();
        Mascotas Guardar(Mascotas entidad);
        Mascotas Modificar(Mascotas entidad);
        Mascotas Borrar(Mascotas entidad);
    }
}