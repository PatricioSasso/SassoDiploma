using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ControlDeAcceso_LogIn_Test
    {
        [TestMethod]
        public void UserPatoAndPassxAgunimon_ShouldReturnTrue()
        {
            ControlDeAccesoGestor control = new ControlDeAccesoGestor();
            var userName = "Pato";
            var password = control.GetHash("xAgunimon");
            var result = control.LogIn(userName, password);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestExecption()
        {
            ControlDeAccesoGestor control = new ControlDeAccesoGestor();
            var userName = "Pato";
            string password = null;
            var result = control.LogIn(userName, password);
        }
    }
}
