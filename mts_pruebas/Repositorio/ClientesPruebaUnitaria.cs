using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lid_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class ClientesPruebaUnitaria
    {
        private IClientesRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Clientes? entidad = null;
        private List<Clientes>? lista = null;

        public ClientesPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost\\SQLEXPRESS;database=TiendaDeMascotas;User Id=miUsuario;Password=miContraseña;TrustServerCertificate=true;"; 
;
            iRepositorio = new ClientesRepositorio(conexion);   
        }

        [TestMethod]
        public void Executar()
        {
            Guardar();
            Listar();
            Modificar();
            Borrar();
        }

        private void Listar()
        {
            lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            entidad = new Clientes()
            {
                Nombre = "TEST1",
                Cedula = "123"
            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_Persona != 0);
        }

        public void Modificar()
        {
            entidad!.Nombre = entidad.Nombre + "123";
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_Persona != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_Persona != 0);
        }
    }
}
