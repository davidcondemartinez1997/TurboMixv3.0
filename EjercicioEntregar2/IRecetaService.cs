namespace EjercicioEntregar2
{
    public interface IRecetaService
    {
        void Delete(string Nombre);
        void Guardar(Receta receta);
        void Lee(string Nombre);
        void Lista();
        void Update(Receta receta);
    }
}