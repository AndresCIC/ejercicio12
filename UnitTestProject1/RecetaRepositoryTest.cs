using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class RecetaRepositoryTest
    {
        [TestMethod]
        public void AddRecipeTest()
        {
            IRecetaRepository repository = new IRecetaRepository();
            Receta receta = new Receta();
            repository.AddRecipe(receta);
            Assert.IsTrue();

        }
    }
}
