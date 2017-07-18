using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Microsoft.Practices.Unity;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceIntegracionTest
    {
        [TestMethod]
        public void TestPrepararPlato()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBasculaService, BasculaService>();
            container.RegisterType<ICocinaService, CocinaService>();
            container.RegisterType<ITurbomixService, TurbomixService>();

            IBasculaService basculaService = container.Resolve<IBasculaService>();
            ICocinaService cocinaService = container.Resolve<ICocinaService>();
            ITurbomixService sut = container.Resolve<ITurbomixService>();

            Alimento mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Curry";
            mAlimento1.Peso = 1.5F;
            Alimento mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Queso";
            mAlimento1.Peso = 5F;

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2);

            Plato mPlato = new Plato(mAlimento1, mAlimento2);
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
