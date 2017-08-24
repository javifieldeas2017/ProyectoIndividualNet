using System.Linq;

namespace ProyectoIndividualNet.Service
{
    public interface IEntradaService
    {
        Entrada Create(Entrada entrada);
        Entrada Delete(long id);
        IQueryable<Entrada> Get();
        Entrada Get(long id);
        void Put(Entrada entrada);
    }
}