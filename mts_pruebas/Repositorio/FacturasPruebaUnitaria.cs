using lib_entidades;
using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lid_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class FacturasPruebaUnitaria
    {
        private IFacturasRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Facturas? entidad = null;
        private List<Facturas>? lista = null;

        public FacturasPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new FacturasRepositorio(conexion);
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
            entidad = new Facturas()
            {
                Codigo_Factura = "TEST1",
               Fecha = DateTime.Now,
               IVA = 300m,
               TOTAL = 4300m,
               Cliente = 2,
               Mascota = 2,
               Servicio=2,
               Pago = 2,

            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_Factura != 0);
        }

        public void Modificar()
        {
            entidad!.TOTAL = entidad.TOTAL + 250m;
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_Factura != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_Factura != 0);
        }
    }
}