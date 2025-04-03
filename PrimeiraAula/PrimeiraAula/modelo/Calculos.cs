using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Calculos
    {
        private Double n1;
        private Double n2;
        private String op;
        private Double resultado;

        public Calculos(Double n1, Double n2, String op) // +, -, *, /
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
            this.calcular();
        }

        private void calcular()
        {
            if (op.Equals("+")) this.resultado = this.n1 + this.n2;
            if (op.Equals("-")) this.resultado = this.n1 - this.n2;
            if (op.Equals("*")) this.resultado = this.n1 * this.n2;
            if (op.Equals("/")) this.resultado = this.n1 / this.n2;
        }

        public Double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
