using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tallersumativo
{
    public class Eliminador
    {
        private string id;
        private string tipo;
        private string objetivo;
        private int prioridadBase;
        private Int32 anio;

        public string ID { get => id; set => id = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public int PrioridadBase { get => prioridadBase; set => prioridadBase = value; }
        public int Anio { get => anio; set => anio = value; }
    }
}
