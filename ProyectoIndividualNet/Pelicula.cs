using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoIndividualNet
{
    public class Pelicula
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Pais { get; set; }
        public short Duracion { get; set; }
        public string Director { get; set; }
    }
}