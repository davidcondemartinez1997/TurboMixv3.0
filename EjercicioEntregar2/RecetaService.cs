using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class RecetaService : IRecetaService
    {
        private IRecetaRepository recetaRepository;


        public RecetaService(IRecetaRepository _recetaRepository)
        {
            this.recetaRepository = _recetaRepository;
        }

        public void Guardar(Receta receta) 
        {
            recetaRepository.Add(receta);
        }

        public void Lee(string Nombre)
        {
            recetaRepository.Lee(Nombre);
        }

        public void Lista()
        {
            recetaRepository.Lee();
        }

        public void Update(Receta receta)
        {
            //TODO
        }

        public void Delete(string Nombre)
        {

        }
    }
}
