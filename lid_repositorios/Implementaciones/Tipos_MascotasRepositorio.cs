using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class Clientes_mascotasRepositorio : IClientes_mascotasRepositorio
    {
        private Conexion? conexion = null;

        public Clientes_mascotasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Clientes_mascotas> Listar()
        {
            return conexion!.Listar<Clientes_mascotas>();
        }
        public Clientes_mascotas Guardar(Clientes_mascotas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Clientes_mascotas Modificar(Clientes_mascotas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Clientes_mascotas Borrar(Clientes_mascotas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}