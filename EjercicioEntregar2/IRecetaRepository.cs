using System.Collections.Generic;

namespace EjercicioEntregar2
{
    public interface IRecetaRepository
    {
        void Add(Receta receta);
        void Delete(string Nombre);
        IList<Receta> Lee();
        Receta Lee(string Nombre);
        void Update(Receta receta);
    }
}