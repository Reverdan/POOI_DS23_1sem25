﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimoNoite.modelo
{
    public class Primo
    {
		private String mensagem;
		private int num;

        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }

        private void Verificar()
        {
            this.mensagem = "É primo";
            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                {
                    this.mensagem = "Não é primo";
                    break;
                }
            }
        }

        public String Mensagem
		{
			get { return mensagem; }
		}

	}
}
