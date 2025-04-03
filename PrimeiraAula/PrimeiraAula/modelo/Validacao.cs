using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Validacao
    {
        private Double n1;
        private Double n2;
        private string mensagem;

        public void validarDoisNumeros(string numero1, string numero2, string op)
        {
            mensagem = "";
            try
            {
                n1 = Convert.ToDouble(numero1);
                n2 = Convert.ToDouble(numero2);
                if (op.Equals("/") && n2.Equals(0))
                    mensagem = "Divisão por zero";
            }
            catch
            {
                mensagem = "Números inválidos";
            }

        }

        public double N1 { get => n1;}
        public double N2 { get => n2;}
        public string Mensagem { get => mensagem;}

    }
}
