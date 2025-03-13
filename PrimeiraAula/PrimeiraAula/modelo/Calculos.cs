using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Calculos
    {
        public Double res;

        public Calculos()
        {
        }

        public Calculos(Double n1, Double n2)
        {
            somar(n1, n2);
        }

        public Double somar(Double n1, Double n2)
        {
            res = n1 + n2;
            return res;
        }
    }
}
