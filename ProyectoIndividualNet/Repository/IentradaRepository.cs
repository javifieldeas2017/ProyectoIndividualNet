using System.Linq;

namespace ProyectoIndividualNet.Repository
{
    public interface IentradaRepository
    {
        Entrada Create(Entrada entrada);
        Entrada Delete(long id);
        IQueryable<Entrada> Get();
        Entrada Get(long id);
        void Put(Entrada entrada);
    }
}