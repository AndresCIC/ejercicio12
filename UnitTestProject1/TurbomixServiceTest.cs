using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;

namespace TurboMixTest
{
    [TestClass]
    public class TurbomixServiceIntegracionTest
    {
        [TestMethod]
        public void TestPrepararPlato()
        {
            
            var mockBasculaService = new Mock<IBascula>();
            var mockCocinaService = new Mock<ICocina>();

            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.Peso);
            mockBasculaService.Setup(bascula => bascula.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.Peso);

            mockCocinaService.Setup(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()))
                .Callback(
                    (Alimento p1, Alimento p2)
                    =>
                    {
                        p1.Calentado = true;
                        p2.Calentado = true;
                    }

                );

            IBascula basculaService = mockBasculaService.Object;
            ICocina cocinaService = mockCocinaService.Object;

            TurbomixService sut = new TurbomixService(basculaService, cocinaService);
            Alimento mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Curry";
            mAlimento1.Peso = 1.5F;
            Alimento mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Queso";
            mAlimento1.Peso = 5F;

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2);

            //Verificaciones
            mockBasculaService.Verify(bascula => bascula.Pesar(It.IsAny<Alimento>()), Times.AtLeast(2));
            mockCocinaService.Verify(cocina => cocina.Calentar(It.IsAny<Alimento>(), It.IsAny<Alimento>()), Times.Once());
            


            Plato mPlato = new Plato(mAlimento1, mAlimento2);
            Assert.AreEqual(mPlato, resultado);
        }
    }
}
