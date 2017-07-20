using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class CategoriaService : ICategoriaService
    {
        public ICategoriaRepository CaterogoriaRepository { get; set; }
        public CategoriaService(ICategoriaRepository _CategoriaRepository)
        {
            this.CaterogoriaRepository = _CategoriaRepository;
        }
        public bool ExisteCategoriaYNoNula(Categoria categoria)
        {
            bool encontrado = false;
            if (categoria != null && CaterogoriaRepository.Read(categoria.Nombre) != null)
            {
                encontrado = true;
                return encontrado;
            }
            return encontrado;
        }



    }
}
