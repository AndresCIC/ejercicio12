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
        private ICategoriaService CategoriaService;

        public RecetaService(IRecetaRepository _RecetaRepo, ICategoriaService _CategoriaService)
        {
            this.RecetaRepo = _RecetaRepo;
            this.CategoriaService = _CategoriaService;

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
            if(CategoriaService.ExisteCategoriaYNoNula(receta.categoria)){
                 RecetaRepo.Add(receta);
            }
            else
            {
                throw new Exception("La categoria debe existir y no ser nula!!");
            }         
             
        }

    }
}
