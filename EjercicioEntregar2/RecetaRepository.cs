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

        public void Add(Receta receta)
        {
            repositorio.Add(receta);
        }

        public IList<Receta> Lee()
        {
            return repositorio;
        }

        public Receta Lee(string Nombre)
        {
            return new Receta();
        }

        public void Update(Receta receta)
        {

        }

        public void Delete(string Nombre)
        {

        }
    }
}
