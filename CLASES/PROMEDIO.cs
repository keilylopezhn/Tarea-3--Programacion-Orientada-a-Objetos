using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Orientada_a_Objetos.CLASES
{
    class PROMEDIO
    {
        public double promedio(double c1, double c2, double c3, double c4)
        {
            double res = (c1 + c2 + c3 + c4) / 4;
            return res;
        }
    }
}
 