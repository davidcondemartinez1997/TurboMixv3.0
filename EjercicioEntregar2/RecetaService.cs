using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        public void GuardarReceta(Alimento mAlimento1, Alimento mAlimento2)
        {
            IRecetaRepository recetaRepository = new RecetaRepository();
            Receta receta = new Receta(mAlimento1.Nombre, mAlimento2.Nombre, mAlimento1.Peso, mAlimento2.Peso);
            recetaRepository.addReceta(receta);

        }
    }
}
