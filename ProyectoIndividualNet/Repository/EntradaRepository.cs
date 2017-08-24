using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoIndividualNet.Repository
{
    public class entradaRepository : IentradaRepository
        public Entrada Create(Entrada entrada)
        {
            return ApplicationDbContext.applicationDbContext.entrada.Add(entrada);
        }

        public Entrada Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.entrada.Find(id);
        }

        public IQueryable<Entrada> Get()
        {
            IList<Entrada> lista = new List<Entrada>(ApplicationDbContext.applicationDbContext.entrada);

            return lista.AsQueryable();
        }


        public void Put(Entrada entrada)
        {
            if (ApplicationDbContext.applicationDbContext.entrada.Count(e => e.Id == entrada.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(entrada).State = EntityState.Modified;
        }

        public Entrada Delete(long id)
        {
            Entrada entrada = ApplicationDbContext.applicationDbContext.entrada.Find(id);
            if (entrada == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.entrada.Remove(entrada);
            return entrada;
        }
    }
}