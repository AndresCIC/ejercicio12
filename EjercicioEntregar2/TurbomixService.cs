using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class TurbomixService : ITurbomixService
    {
        public IBascula Bascula { get; set; }
        public ICocina Cocina { get; set; }
        public IRecetaService Receta { get; set; }
        /*
         * 30"
         * Version 3.1 En lugar de llamar a recetaRepository, esta vez entra por receta Service, recetaService llama a repository
         */

        public TurbomixService(IBascula _Bascula, ICocina _Cocina, IRecetaRepository _RecetaReposity)
        {
            this.Bascula = _Bascula;
            this.Cocina = _Cocina;
        }

        public Plato PrepararPlato(Alimento Alimento1, Alimento Alimento2, Receta receta)
        {
            float Peso1 = Bascula.Pesar(Alimento1);
            float Peso2 = Bascula.Pesar(Alimento2);
            if (Receta.CompruebaPeso(Peso1, Peso2))
            {
                //Comprobar el peso de los alimentos, si no hay suficiente no cocina
                Cocina.Calentar(Alimento1, Alimento2);
                return new Plato(Alimento1, Alimento2);
            }
            throw new Exception("Peso insuficiente");
        }

        public Plato PrepararPlato(Alimento Alimento1, Alimento Alimento2)
        {
            float Peso1 = Bascula.Pesar(Alimento1);
            float Peso2 = Bascula.Pesar(Alimento2);

            Cocina.Calentar(Alimento1, Alimento2);

            return new Plato(Alimento1, Alimento2);
        }

    }
}
