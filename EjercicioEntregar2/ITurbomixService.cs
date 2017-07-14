namespace EjercicioEntregar2
{
    public interface ITurbomixService
    {
        Plato PrepararPlato(Alimento Alimento1, Alimento Alimento2);
        Plato PrepararPlato(Alimento Alimento1, Alimento Alimento2, Receta receta);
    }
}