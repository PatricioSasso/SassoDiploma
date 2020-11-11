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
    public class ControlDeAcceso_LogIn_Test
    {
        [TestMethod]
        public void BaseLogin()
        {
            ControlDeAccesoGestor control = new ControlDeAccesoGestor();
            var userName = "Pato";
            var password = control.GetHash("xAgunimon");
            var result = control.LogIn(userName, password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EmptyUser()
        {
            ControlDeAccesoGestor control = new ControlDeAccesoGestor();
            var userName = string.Empty;
            string password = string.Empty;
            var result = control.LogIn(userName, password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FilterTest()
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            var expectedResult = bitacoraGestor.GetAll();
            var result = bitacoraGestor.BuscarFecha(string.Empty);
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void ProductoTest()
        {
            ProductoGestor productoGestor = new ProductoGestor();
            Producto productoEsperado = new Producto();
            productoGestor.Alta(productoEsperado);
        }

        [TestMethod]
        public void UserFilterTest()
        {
            BitacoraGestor bitacoraGestor = new BitacoraGestor();
            int expectedResult = 0;
            var result = bitacoraGestor.BuscarFecha("x");
            Assert.AreEqual(expectedResult, result);
        }
    }
}
