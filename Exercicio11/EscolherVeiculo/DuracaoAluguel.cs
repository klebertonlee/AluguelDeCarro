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

        //---fazer o calculo dos dias que o cliente está com o veiculo pelo valor por dia.
        //como vou fazer para trasformar data em int ou double?

        public double valorAluguel()
        {
            return aluguel() * 50;
        }

    }
}
