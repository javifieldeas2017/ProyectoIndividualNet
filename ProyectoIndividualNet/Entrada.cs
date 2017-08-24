using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoIndividualNet
{
    public class Entrada
    {
        public long Id { get; set; }
        public string Pelicula { get; set; }
        public short Fila { get; set; }
        public short Butaca { get; set; }
        public double Precio { get; set; }
        public bool Online { get; set; }
    }
}