using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lid_repositorios.Interfaces;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class Metodo_pagoPruebaUnitaria
    {
        private IMetodo_pagoRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Metodo_pago? entidad = null;
        private List<Metodo_pago>? lista = null;

        public Metodo_pagoPruebaUnitaria()
        {
            conexion = new Conexion();
            conexion.StringConnection = "server=localhost;database=TiendaDeMascotas;Integrated Security=True;TrustServerCertificate=true;";
            iRepositorio = new Metodo_pagoRepositorio(conexion);
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
            entidad = new Metodo_pago()
            {
                
                Tipo_Pago = "Efectivo"

            };
            entidad = iRepositorio!.Guardar(entidad!);
            Assert.IsTrue(entidad.ID_Pago != 0);
        }

        public void Modificar()
        {
            entidad!.Tipo_Pago = entidad.Tipo_Pago + "123";
            entidad = iRepositorio!.Modificar(entidad!);

            Assert.IsTrue(entidad.ID_Pago != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            Assert.IsTrue(entidad.ID_Pago != 0);
        }
    }
}
