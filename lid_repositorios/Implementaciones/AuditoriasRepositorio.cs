using lib_entidades;
using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class AuditoriasRepositorio : IAuditoriasRepositorio
    {
        private Conexion? conexion = null;
        private IAuditoriasRepositorio? IAuditoriasRepositorio = null;

        public AuditoriasRepositorio(Conexion conexion, IAuditoriasRepositorio IAuditoriasRepositorio)
        {
            this.conexion = conexion;
            this.IAuditoriasRepositorio = IAuditoriasRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Auditorias> Listar()
        {

            
            return conexion!.Listar<Auditorias>();
        }

        public List<Auditorias> Buscar(Expression<Func<Auditorias, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Auditorias Guardar(Auditorias entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();

            IAuditoriasRepositorio.Guardar(new Auditorias()
            {
                Tabla = "FActuras",
                Referencia = entidad.ID_Auditoria,
                Accion = "Guardar"
            });

            return entidad;
        }

        public Auditorias Modificar(Auditorias entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Auditorias Borrar(Auditorias entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();


            return entidad;
        }
    }
}