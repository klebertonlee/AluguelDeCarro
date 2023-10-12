﻿using Exercicio11.Aluguel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.EscolherVeiculo
{

    class DuracaoAluguel
    {
        public double DiaRetirada { get; set; }

        public double DiaEntrega { get; set; }

        public DuracaoAluguel(double diaRetirada, double diaEntrega)
        {
            DiaRetirada = diaRetirada;
            DiaEntrega = diaEntrega;
        }

        public double aluguel()
        {
            return DiaEntrega - DiaRetirada;
        }

        public double valorAluguel()
        {
           double calc1 =  CalculoAluguel.ValorVeiculo + aluguel() +CalculoAluguel.ValorVeiculo;

            return valorAluguel();

        }

    }
}
