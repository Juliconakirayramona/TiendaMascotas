using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class Tipos_mascotasPruebaUnitaria
    {
        private ITipos_mascotasRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Tipos_mascotas? entidad = null;
        private List<Tipos_mascotas>? lista = null;

        public Tipos_mascotasPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new Tipos_mascotasRepositorio(conexion);
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
            entidad = new Tipos_mascotas()
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