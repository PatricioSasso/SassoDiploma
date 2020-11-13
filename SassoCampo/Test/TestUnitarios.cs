using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Sql;
using Service;
using BLL;
using GUI;
using System.Data.SqlClient;

namespace Test
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void Login_Usuario_Pato_Contra_xAgunimon_ResultadoEsperado_True()
        {
            ControlDeAccesoGestor control = new ControlDeAccesoGestor();
            var userName = "Pato";
            var password = control.GetHash("xAgunimon");
            var result = control.LogIn(userName, password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Login_UsuarioYContraVacios_ResultadoEsperado_False()
        {
            ControlDeAccesoGestor control = new ControlDeAccesoGestor();
            var userName = string.Empty;
            string password = string.Empty;
            var result = control.LogIn(userName, password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void BuscarFecha_FiltroVacio_ReultadoEsperado_EqualToGetAll()
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            var expectedResult = bitacoraGestor.GetAll();
            var result = bitacoraGestor.BuscarFecha(string.Empty);
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AltaProducto_ProductoNull_ExpectedException_SqlException()
        {
            ProductoGestor productoGestor = new ProductoGestor();
            Producto productoEsperado = new Producto();
            productoGestor.Alta(productoEsperado);
        }

        [TestMethod]
        public void BuscarFecha_Filtro_X_ResultadoEsperado_EmptyList()
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            int expectedResult = 0;
            var result = bitacoraGestor.BuscarFecha("x");
            Assert.AreEqual(expectedResult, result);
        }
    }
}
