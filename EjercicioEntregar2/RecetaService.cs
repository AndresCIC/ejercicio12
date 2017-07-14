using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository RecetaRepo;

        public RecetaService(IRecetaRepository _RecetaRepo)
        {
            this.RecetaRepo = _RecetaRepo;
        }
        public bool CompruebaPeso(float peso1, float peso2)
        {
            Receta receta = new Receta();
            bool pesoSuficiente = false;
            if(peso1 > receta.PesoAlimento1 && peso2 > receta.PesoAlimento2)
            {
                peso1 -= receta.PesoAlimento1;
                peso2 -= receta.PesoAlimento2;
                pesoSuficiente = true;
            
            }
            return pesoSuficiente;

        }
        /// <summary>
        /// Now we add the recipe from here
        /// </summary>
        /// <param name="receta"></param>
        public void Add(Receta receta)
        {
            RecetaRepo.Add(receta);
        }

    }
}
