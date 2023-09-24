using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Aluguel
{
   
    internal class CalculoAluguel
    {
        public DateTime DataRetirada { get;  set; }
        public DateTime DataEntrega { get; set; }

        public CalculoAluguel(DateTime dataRetirada, DateTime dataEntrega)
        {
            DataRetirada = dataRetirada;
            DataEntrega = dataEntrega;
        }

        public DateTime CarroEmUso(DateTime dataRetirada, DateTime dataEntrega)
        {
            return dataEntrega - dataRetirada;
        }
    }
}
