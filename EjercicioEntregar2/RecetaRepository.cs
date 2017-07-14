using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepository : IRecetaRepository
    {
        private static IList<Receta> repositorio = new List<Receta>();

        public void addReceta(Receta receta)
        {
            repositorio.Add(receta);
        }
    }
}
