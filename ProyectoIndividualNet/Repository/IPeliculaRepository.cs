using System.Linq;

namespace ProyectoIndividualNet.Repository
{
    public interface IPeliculaRepository
    {
        Pelicula Create(Pelicula pelicula);
        Pelicula Delete(long id);
        IQueryable<Pelicula> Get();
        Pelicula Get(long id);
        void Put(Pelicula pelicula);
    }
}