using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace UnitTestProject1
{

    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        private IRecetaRepository recetaRepository;
        private IRecetaService sut;

        [TestInitialize]
        public void Init()
        {
            recetaRepository = new RecetaRepository();
            sut = new RecetaService(recetaRepository);
        }
        [TestMethod]
        public void TestGuardar()
        {
            Receta receta = new Receta();

            sut.Guardar(receta);
        }

        [TestMethod]
        public void TestLeer()
        {
            sut.Lee("Chocolate con pan");
        }

        [TestMethod]
        public void TestListar()
        {
            sut.Lista();
        }

        [TestMethod]
        public void TestUpdate()
        {
            Receta receta = new Receta();

            sut.Guardar(receta);
        }

        [TestMethod]
        public void TestDelete()
        {
            sut.Delete("Chocolate con pan");
        }
    }
}
