using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Controle
    {
        private string resultado;

        public void executar(string numero1, string numero2, string op)
        {
            Validacao validacao = new Validacao();
            validacao.validarDoisNumeros(numero1, numero2, op);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1,
                    validacao.N2, op);
                resultado = calculos.Resultado.ToString();
            }
            else
            {
                resultado = validacao.Mensagem;
            }
        }

        public string Resultado { get => resultado; }
    }
}
