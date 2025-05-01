using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaNoite.Modelo
{
    public class Conversao : absPropriedades
    {
        public Conversao(string tipo, double temperatura) : base(tipo, temperatura)
        {
        }

        public override void Executar()
        {
            Double valor = 0.0;
            if (tipo.Equals("CF"))
            {
                valor = (temperatura - 32) / 1.8;
            }
            else
            {
                valor = temperatura * 1.8 + 32;
            }

            this.resposta = valor.ToString();
        }
    }
}
