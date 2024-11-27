using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;

using lid_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class Tipos_serviciosPruebaUnitaria
    {
        private ITipos_serviciosRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Tipos_servicios? entidad = null;
        private List<Tipos_servicios>? lista = null;

        public Tipos_serviciosPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new Tipos_serviciosRepositorio(conexion);
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
            entidad = new Tipos_servicios()
            {
                Tipo_Servicio = "TEST1",
                Servicio = 2

            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_Tiposervicio != 0);
        }

        public void Modificar()
        {
            entidad!.Tipo_Servicio = entidad.Tipo_Servicio + "123";
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_Tiposervicio != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_Tiposervicio != 0);
        }
    }
}