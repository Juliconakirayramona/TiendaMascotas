using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class MascotasPruebaUnitaria
    {
        private IMascotasRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Mascotas? entidad = null;
        private List<Mascotas>? lista = null;

        public MascotasPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new MascotasRepositorio(conexion);
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
            entidad = new Mascotas()
            {
                Cod_Mascota = "test7",
                Nombre = "test",
                Genero = "m",
                Edad = "3",
                Dueño = 1
            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_Mascota != 0);
        }

        public void Modificar()
        {
            entidad!.Nombre = entidad.Nombre + "123";
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_Mascota != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_Mascota != 0);
        }
    }
} 
