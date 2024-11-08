using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class CuentaCorriente
    {
        private int nroCuenta;
        private Cliente titular;
        private double saldo;

        public CuentaCorriente(int nro, Cliente titular)
        {
            this.nroCuenta = nro;
            this.titular = titular;
        }

        public Cliente VerTitular()
        {
            return titular;
        }

        public int VerNroCuenta()
        {
            return nroCuenta;
        }

        public void RegistrarPago(double monto)
        {
            this.saldo = saldo - monto;
        }

        public void RegistraVenta(double monto)
        {
            if (saldo >= monto)
            {

            }
        }
    }
}
