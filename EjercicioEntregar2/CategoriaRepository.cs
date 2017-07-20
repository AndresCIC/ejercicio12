using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public List<Categoria> ListaDeCategorias = new List<Categoria>();

        public void Add(Categoria categoria)
        {
            ListaDeCategorias.Add(categoria);
        }

        public Categoria Read(String nombre)
        {
            return ListaDeCategorias.Find(x => x.Nombre == nombre);
        }

        public List<Categoria> List()
        {
            return ListaDeCategorias;
        }

        public Categoria Update(Categoria Categoria)
        {
            Categoria CategoriaAnterior = ListaDeCategorias.Find(x => x.Nombre == Categoria.Nombre);
            CategoriaAnterior.Descripcion = Categoria.Descripcion;
            return CategoriaAnterior;
        }
        public bool Delete(string nombre)
        {
            return ListaDeCategorias.Remove(ListaDeCategorias.Find(x => x.Nombre == nombre));
        }

    }
}
