using System.Collections.Generic;

namespace EjercicioEntregar2
{
    public interface IRecetaRepository
    {
        void Add(Receta receta);
        bool Delete(string nombre);
        List<Receta> List();
        Receta Read(string nombre);
        void Update(Receta receta);
    }
}