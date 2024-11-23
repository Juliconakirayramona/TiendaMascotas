using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface ITipos_mascotasAplicacion
    {
        void Configurar(string string_conexion);
        List<Tipos_mascotas> Listar();
        Tipos_mascotas Guardar(Tipos_mascotas entidad);
        Tipos_mascotas Modificar(Tipos_mascotas entidad);
        Tipos_mascotas Borrar(Tipos_mascotas entidad);
    }
}