using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class Cliente : Ticket
    {
        private static int nroinicio;
        private long dni;

        public Cliente (string DNI)
        {
            
           for (int i = 0; i < DNI.Length; i++)
                {
                    if (!char.IsNumber(DNI[i])) throw new ExcepcionDNI("Hay caracteres no numericos ") ;
                }

                dni = Convert.ToInt64(DNI);

                if (dni < 30000000 && dni > 45000000)
                {
                    throw new ExcepcionDNI("Numero de documento fuera de rango");
                }            
           
        }
    }
}
