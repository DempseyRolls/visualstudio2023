using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Lectura
    {
        private Medidor medidorLectura;
        private DateTime fechaLectura;
        private DateTime horaLectura;
        private double valorConsumo;

        public Medidor MedidorLectura { get => medidorLectura; set => medidorLectura = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public DateTime HoraLectura { get => horaLectura; set => horaLectura = value; }
        public double ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
    }
}
