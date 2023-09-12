using Exercicio11.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Exercicio11.Cadastros{
   
    
    internal sealed class CadastroCarro : Cadastro
    {
        static double Seguro = 50.00;

        public double ValorDia { get; set; }
        public CadastroCarro(string modelo, string marcaCarro, int anoCarro, double valorDia) 
            : base(modelo, marcaCarro, anoCarro)
        {
            ValorDia = valorDia;

        }

        public double DiasUsados(int dias, double valorDia)
        {
            return ValorDia * dias;
           if(dias <= 0)
            {
                throw new DomainException("A quantidade de dias está abaixo do permitido");
            }
        }

        //Taxa de Seguro
        
    }
}
