using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.EscolherVeiculo
{
    internal class DuracaoAluguel
    {
        public DateTime DiaRetirada { get; set; }
       
        public DateTime DiaEntrega { get; set; }

        public DuracaoAluguel(DateTime diaRetirada, DateTime diaEntrega)
        {
            DiaRetirada = diaRetirada;
            DiaEntrega = diaEntrega;
        }

        public TimeSpan aluguel()
        {
            return DiaEntrega - DiaRetirada;
        }
    }
}
