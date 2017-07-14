using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        public bool CompruebaPeso(float peso1, float peso2)
        {
            Receta receta = new Receta();
            return peso1 > receta.PesoAlimento1 && peso2 > receta.PesoAlimento2;                
        }

    }
}
