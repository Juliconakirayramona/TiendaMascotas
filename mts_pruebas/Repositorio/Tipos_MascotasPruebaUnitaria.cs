using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class Clientes_mascotasPruebaUnitaria
    {
        private IClientes_mascotasRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Clientes_mascotas? entidad = null;
        private List<Clientes_mascotas>? lista = null;

        public Clientes_mascotasPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new Clientes_mascotasRepositorio(conexion);
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
            entidad = new Clientes_mascotas()
            {
                TipoDeMascota = "TEST1",
                Mascota = 3

            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_TipoMascota != 0);
        }

        public void Modificar()
        {
            entidad!.TipoDeMascota = entidad.TipoDeMascota + "123";
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_TipoMascota != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_TipoMascota != 0);
        }
    }
}