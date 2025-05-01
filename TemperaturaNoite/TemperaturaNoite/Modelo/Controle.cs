using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaNoite.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(string tipo, string temp) : base(tipo, temp)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.temp);
            if (validacao.mensagem.Equals(""))
            {
                Conversao conversao = new Conversao(this.tipo,
                    validacao.temperatura);
                this.resposta = conversao.resposta;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
