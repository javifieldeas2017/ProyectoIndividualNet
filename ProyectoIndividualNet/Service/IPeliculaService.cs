using System.Linq;

namespace ProyectoIndividualNet.Service
{
    public interface IPeliculaService
    {
        Pelicula Create(Pelicula pelicula);
        Pelicula Delete(long id);
        IQueryable<Pelicula> Get();
        Pelicula Get(long id);
        void Put(Pelicula pelicula);
    }
}