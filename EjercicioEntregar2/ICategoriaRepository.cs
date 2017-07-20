using System.Collections.Generic;

namespace EjercicioEntregar2
{
    public interface ICategoriaRepository
    {
        void Add(Categoria categoria);
        bool Delete(string nombre);
        List<Categoria> List();
        Categoria Read(string nombre);
        Categoria Update(Categoria Categoria);
    }
}