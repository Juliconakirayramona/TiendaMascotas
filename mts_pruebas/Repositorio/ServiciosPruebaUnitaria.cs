using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lid_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class ServiciosPruebaUnitaria
    {
        private IServiciosRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Servicios? entidad = null;
        private List<Servicios>? lista = null;

        public ServiciosPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new ServiciosRepositorio(conexion);
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
            entidad = new Servicios()
            {
                Precio = 3000m,
                Estado = true,
                Mascota = 4,

            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_Servicio != 0);
        }

        public void Modificar()
        {
            entidad!.Precio = entidad.Precio + 123m;
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_Servicio != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_Servicio != 0);
        }
    }
}