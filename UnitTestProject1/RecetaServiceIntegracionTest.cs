using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;
using Moq;
using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace TurboMixTest
{
    [TestClass]
    public class RecetaServiceTest
    {
        IUnityContainer container;
        IRecetaRepository sut;

        [TestInitialize]
        public void init()
        {
            container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();
            container.RegisterType<ITurbomixService, TurbomixService>();
            container.RegisterType<IBasculaService, BasculaService>();
            container.RegisterType<ICocinaService, CocinaService>();
            sut = container.Resolve<IRecetaRepository>();

        }

        [TestMethod]
        public void TestAdd()
        {
            
            Receta receta = new Receta();           
            sut.Add(receta);

            //var mockRecetaRepository = new Mock<IRecetaRepository>();
            ////No hace falta programar el mock ya que el metodo es tonto, solo llama y no devuelve nada
            //Receta receta = new Receta();
            ////Sometemos a test la clase de verdad
            //IRecetaService sut = new RecetaService(mockRecetaRepository.Object);
            //sut.Add(receta);

            //mockRecetaRepository.Verify(RecetaRepository => RecetaRepository.Add(It.IsAny<Receta>()), Times.Once);

            /*
             * Test de integracion
             * 
             *  Receta receta = new Receta();
             *  IRecetaRepository recetaRepository = new RecetaRepository();
             *  IRecetaService sut = new RecetaService(recetaRepository);
             *  
             *  sut.Add(receta);
             *              
             */
        }
        [TestMethod]
        public void TestRead()
        {
            //IRecetaRepository recetaRepository = new RecetaRepository();
            //IRecetaService sut = new RecetaService(recetaRepository);
            sut.Read("Pollo al Curry");
        }

        [TestMethod]
        public void TestList()
        {
            //IRecetaRepository recetaRepository = new RecetaRepository();
            //IRecetaService sut = new RecetaService(recetaRepository);

            IList<Receta> lista = sut.List();
            Assert.IsNotNull(lista);

        }

        [TestMethod]
        public void TestUpdate()
        {
            Receta receta = new Receta();
            //IRecetaRepository recetaRepository = new RecetaRepository();
            // IRecetaService sut = new RecetaService(recetaRepository);
            sut.Update(receta);


        }

        [TestMethod]
        public void TestDelete()
        {
            //IRecetaRepository recetaRepository = new RecetaRepository();
            //IRecetaService sut = new RecetaService(recetaRepository);

            sut.Delete("Pollo al curry");
        }


    }
}
