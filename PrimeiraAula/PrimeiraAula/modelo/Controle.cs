using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Controle
    {
        public string mensagem;

        public string executar(string numero1, string numero2)
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.validarDoisNumeros(numero1, numero2);
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.n1, validacao.n2);
                mensagem = calculos.res.ToString();
            }
            else
            {
                mensagem = validacao.mensagem;
            }
            return mensagem;
        }
    }
}
