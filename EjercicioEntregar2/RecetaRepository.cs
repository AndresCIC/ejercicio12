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

        public void Add(Receta receta)
        {
            ListaRecetas.Add(receta);
        }

        public Receta Read(String nombre)
        {
            return ListaRecetas.Find(x => x.nombre == nombre);
        }

        public List<Receta> List()
        {
            return ListaRecetas;
        }

        public void Update(Receta receta)
        {

        }

        public bool Delete(string nombre)
        {
            return ListaRecetas.Remove(ListaRecetas.Find(x => x.nombre == nombre));
        }


    }
}
