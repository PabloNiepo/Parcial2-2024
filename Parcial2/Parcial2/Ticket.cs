using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    abstract class Ticket
    {
        protected int NroOrden;
        private DateTime fechaHora;

        public int VerNumero()
        {
            return NroOrden;
        }

        public DateTime VerFecha()
        {
            return fechaHora;
        }

    }
}
