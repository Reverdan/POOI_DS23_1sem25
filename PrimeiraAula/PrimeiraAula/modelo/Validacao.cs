using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Validacao
    {
        public string numero1;
        public string numero2;
        public Double n1;
        public Double n2;
        public string mensagem;

        public void validarDoisNumeros()
        {
            mensagem = "";
            try
            {
                n1 = Convert.ToDouble(numero1);
                n2 = Convert.ToDouble(numero2);
            }
            catch
            {
                mensagem = "Números inválidos";
            }
        }


    }
}
