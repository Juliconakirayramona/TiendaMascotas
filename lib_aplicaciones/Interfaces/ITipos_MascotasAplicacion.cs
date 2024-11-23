using lib_entidades;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ITipos_MascotasAplicacion
    {
        void Configurar(string string_conexion);
        List<Tipo_Mascotas> Buscar(Tipo_Mascotas entidad, string tipo);
        List<Tipo_Mascotas> Listar();
        Tipo_Mascotas Guardar(Tipo_Mascotas entidad);
        Tipo_Mascotas Modificar(Tipo_Mascotas entidad);
        Tipo_Mascotas Borrar(Tipo_Mascotas entidad);
    }
}