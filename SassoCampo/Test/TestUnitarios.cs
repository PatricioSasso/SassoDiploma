using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using BLL;
using GUI;
using DAL;
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
        public void BuscarNombreUsuario_FiltroVacio_ReultadoEsperado_EqualToGetAll()
        {
            DALBitacora dalBitacora = new DALBitacora();
            var expectedResult = dalBitacora.GetAll();
            var result = dalBitacora.BuscarNombreUsuario(string.Empty);
            Assert.AreEqual(expectedResult.Count, result.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AltaProducto_ProductoNull_ExpectedException_SqlException()
        {
            DALProducto dalProducto = new DALProducto();
            Producto productoVacio = new Producto();
            dalProducto.Alta(productoVacio);
        }

        [TestMethod]
        public void BuscarFecha_Filtro_Hola_ResultadoEsperado_EmptyList()
        {
            DALBitacora bitacoraGestor = new DALBitacora();
            int expectedResult = 0;
            var result = bitacoraGestor.BuscarFecha("Hola");
            Assert.AreEqual(expectedResult, result.Count);
        }
    }
}
