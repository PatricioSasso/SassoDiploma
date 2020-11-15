using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;
using BLL;
using GUI;
using DAL;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestIntegracion
    {

        [TestMethod]
        public void TestTejido()
        {
            Controller controller = new Controller();
            TejidoGestor tejidoGestor = new TejidoGestor();
            bool condicion1 = false;
            bool condicion2 = false;
            bool condicion3 = false;
            int cantUtilizada = 1200;
            int areaTela = 40;
            controller.AltaHilado("PRUEBA", "HILADO DE PRUEBA", "3000", "4");
            Hilado hilado = controller.GetListHilado().Find(h => h.Codigo == "PRUEBA");
            string codigoTela = "TELA PRUEBA";
            controller.Tejer(cantUtilizada, areaTela, hilado, codigoTela);
            if (hilado.Cantidad == 3000 - cantUtilizada)
            {
                condicion1 = true;
            }
            List<Tejido> tejidos = tejidoGestor.GetList();
            Tejido tejidoResultante = tejidos.Find(t => t.CantidadUtilizada == cantUtilizada && t.AreaTela == areaTela && t.Hilado.Codigo == hilado.Codigo);
            if (tejidoResultante != null)
            {
                condicion2 = true;
            }
            Tela telaResultante = controller.GetListTela().Find(t => t.Codigo == codigoTela);
            if (telaResultante != null)
            {
                condicion3 = true;
            }
            Cleaner cleaner = new Cleaner();
            cleaner.Clean("Tejido", "Id = " + tejidoResultante.Id);
            cleaner.Clean("Hilado", "Id = " + hilado.Id);
            cleaner.Clean("Tela", "Id = " + telaResultante.Id);
            Assert.IsTrue(condicion1 && condicion2 && condicion3);
        }

        [TestMethod]
        public void TestTenido()
        {
            Controller controller = new Controller();
            TenidoGestor tenidoGestor = new TenidoGestor();
            bool condicion1 = false;
            bool condicion2 = false;
            bool condicion3 = false;
            TelaGestor telaGestor = new TelaGestor();
            telaGestor.Alta(new Tela("TELA PRUEBA", "TELA DE PRUEBA", 5000, "", false));
            Tela tela = controller.GetListTela().Find(t => t.Codigo == "TELA PRUEBA");
            int cantUtilizada = 2000;
            controller.AltaTinte("TINTE PRUEBA", "TINTE DE PRUEBA", 3000, "CELESTE");
            Tinte tinte = controller.GetListTinte().Find(t => t.Codigo == "TINTE PRUEBA");
            int cantTinteUtilizado = 1000;
            string codigoTelaTenida = "TELA TEÑIDA PRUEBA";
            controller.Teñir(tela, cantUtilizada, tinte, cantTinteUtilizado, codigoTelaTenida);
            if (tela.Cantidad == 5000 - cantUtilizada && tinte.Cantidad == 3000 - cantTinteUtilizado )
            {
                condicion1 = true;
            }
            List<Tenido> tenidos = tenidoGestor.GetList();
            Tenido tenidoResultante = tenidos.Find(t => t.CantidadTelaUtilizada == cantUtilizada && t.CantidadTinteUtilizada == cantTinteUtilizado && t.Tela.Codigo == tela.Codigo && t.Tinte.Codigo == tinte.Codigo);
            if (tenidoResultante != null)
            {
                condicion2 = true;
            }
            Tela telaResultante = controller.GetListTela().Find(t => t.Codigo == codigoTelaTenida && t.Teñido == true && t.Color == tinte.Color);
            if (telaResultante != null)
            {
                condicion3 = true;
            }
            Cleaner cleaner = new Cleaner();
            cleaner.Clean("Teñido", "Id = " + tenidoResultante.Id);
            cleaner.Clean("Tela", "Id = " + tela.Id);
            cleaner.Clean("Tinte", "Id = " + tinte.Id);
            cleaner.Clean("Tela", "Id = " + telaResultante.Id);
            Assert.IsTrue(condicion1 && condicion2 && condicion3);
        }

        [TestMethod]
        public void TestModificarPrenda()
        {
            Controller controller = new Controller();
            controller.AltaPrenda("PRUEBA", "PRENDA DE PRUEBA", 6000, "M");
            Prenda prendaOriginal = controller.GetListPrenda().Find(p => p.Codigo == "PRUEBA");
            prendaOriginal.Descripcion = "PRUEBA DE PRENDA";
            prendaOriginal.Cantidad = 3000;
            prendaOriginal.Talle = "S";
            controller.ModificarPrenda(prendaOriginal);
            Prenda prendaModificada = controller.GetListPrenda().Find(p => p.Id == prendaOriginal.Id && p.Descripcion == prendaOriginal.Descripcion && p.Cantidad == prendaOriginal.Cantidad && p.Talle == prendaOriginal.Talle );
            Cleaner cleaner = new Cleaner();
            cleaner.Clean("Prenda","Id = " + prendaOriginal.Id);
            Assert.IsTrue(prendaModificada != null);
        }

        [TestMethod]
        public void TestConfeccion()
        {
            Controller controller = new Controller();
            ConfeccionGestor confeccionGestor = new ConfeccionGestor();
            bool condicion1 = false;
            bool condicion2 = false;
            bool condicion3 = false;
            controller.AltaPrenda("PRUEBA", "PRENDA DE PRUEBA", 1500, "L");
            Prenda prenda = controller.GetListPrenda().Find(p => p.Codigo == "PRUEBA");
            int cantidadPrenda = 400;
            string codigoPrenda = "PRENDA CONFECCIONADA PRUEBA";
            controller.Confeccionar(prenda, cantidadPrenda, codigoPrenda);
            if(prenda.Cantidad == 1500 - cantidadPrenda)
            {
                condicion1 = true;
            }
            Confeccion confeccion = confeccionGestor.GetList().Find(c => c.Cantidad == cantidadPrenda && c.Prenda.Codigo == prenda.Codigo);
            if(confeccion != null)
            {
                condicion2 = true;
            }
            Prenda prendaConfeccionada = controller.GetListPrenda().Find(p => p.Codigo == codigoPrenda && p.Confeccionada == true);
            if(prendaConfeccionada != null)
            {
                condicion3 = true;
            }
            Cleaner cleaner = new Cleaner();
            cleaner.Clean("Confeccion", "Id = " + confeccion.Id);
            cleaner.Clean("Prenda", "Id = " + prendaConfeccionada.Id);
            cleaner.Clean("Prenda", "Id = " + prenda.Id);
            Assert.IsTrue(condicion1 && condicion2 && condicion3);
        }
    }

    public class Cleaner : DAL.DAL
    {
        public Cleaner()
        {
        }

        public void Clean(string table, string condition)
        {
            conexion.Open();
            query = new SqlCommand("DELETE FROM " + table + " WHERE " + condition, conexion);
            query.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
