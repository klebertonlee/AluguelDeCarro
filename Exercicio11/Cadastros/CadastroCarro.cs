using Exercicio11.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Exercicio11.Cadastros
{


    internal sealed class CadastroCarro : Cadastro
    {
        //static double Seguro = 50.00;

        public double ValorDia { get; set; }
       
        public CadastroCarro(string modelo, string marcaCarro, int anoCarro, double valorDia)
            : base(modelo, marcaCarro, anoCarro)
        {
            ValorDia = valorDia;

        }       

    }
}
