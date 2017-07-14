using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{

    [TestClass]
    public class RecetaServiceTest
    {

        [TestMethod]
        public void TestGuardarReceta()
        {
            Alimento alimento1 = new Alimento("Queso", 1F, false);
            Alimento alimento2 = new Alimento("Chocolate", 3F, false);
            IRecetaService sut = new RecetaService();
            sut.GuardarReceta(alimento1, alimento2);
        }
    }
}
