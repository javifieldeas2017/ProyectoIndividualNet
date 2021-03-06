﻿using ProyectoIndividualNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoIndividualNet.Service
{
    public class PeliculaService : IPeliculaService
    {
        private IPeliculaRepository peliculaRepository;
        public PeliculaService(IPeliculaRepository _peliculaRepository)
        {
            this.peliculaRepository = _peliculaRepository;
        }

        public Pelicula Get(long id)
        {
            return peliculaRepository.Get(id);
        }

        public IQueryable<Pelicula> Get()
        {
            return peliculaRepository.Get();
        }

        public Pelicula Create(Pelicula pelicula)
        {
            return peliculaRepository.Create(pelicula);
        }

        public void Put(Pelicula pelicula)
        {
            peliculaRepository.Put(pelicula);
        }

        public Pelicula Delete(long id)
        {
            return peliculaRepository.Delete(id);
        }
    }
}