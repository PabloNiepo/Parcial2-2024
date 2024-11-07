using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2
{
    class ExcepcionDNI : ApplicationException
    {
       public ExcepcionDNI() { }

        public ExcepcionDNI(string mensaje) : base(mensaje) { }
    }


}
