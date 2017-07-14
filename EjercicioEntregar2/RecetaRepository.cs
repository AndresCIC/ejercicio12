using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        public static List<Receta> ListaRecetas { get; set; }

        public RecetaRepository()
        {
            ListaRecetas = new List<Receta>();
        }

        public void AddRecipe(Receta receta)
        {
            ListaRecetas.Add(receta);
        }

    }
}
