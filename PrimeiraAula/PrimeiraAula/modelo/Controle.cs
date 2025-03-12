using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraAula.modelo
{
    public class Controle
    {
        public string numero1;
        public string numero2;
        public string mensagem;
        public string resultado;

        public void executar()
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.numero1 = numero1;
            validacao.numero2 = numero2;
            validacao.validarDoisNumeros();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.n1 = validacao.n1;
                calculos.n2 = validacao.n2;
                calculos.somar();
                resultado = calculos.res.ToString();
            }
            else
            {
                mensagem = validacao.mensagem;
            }
        }
    }
}
