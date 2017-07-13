using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaRepositorio
    {
        private static List<Receta> repositorio;

        public void addReceta(Alimento mAlimento1, Alimento mAlimento2)
        {
            Receta receta = new Receta(mAlimento1.Nombre, mAlimento2.Nombre, mAlimento1.Peso, mAlimento2.Peso);
            repositorio.Add(receta);
        }
    }
}
