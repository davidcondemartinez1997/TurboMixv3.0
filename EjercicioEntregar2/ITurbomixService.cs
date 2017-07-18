namespace EjercicioEntregar2
{
    public interface ITurbomixService
    {
        IBasculaService basculaService { get; set; }
        ICocinaService cocinaService { get; set; }

        Plato PrepararPlato(Alimento mAlimento1, Alimento mAlimento2);
    }
}