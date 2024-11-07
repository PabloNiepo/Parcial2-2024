using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Pago : Ticket
    {
        private static int nroinicio;
        private CuentaCorriente ficha;

        public Pago(int nroCuenta)
            {
            nroinicio++;
            }

        public void MontoPago(double monto)
        {
        }
    }
}
