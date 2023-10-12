using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio11.Aluguel
{
   
    static public class Taxas
    {
        static public double ValorVeiculo { get; set; }
        static public double SeguroVeiculo { get; set; }
        static public double SeguroTerceiro { get; set; }

        static double ValorDoVeiculo()
        {
            return ValorVeiculo;
        }
        static void SeguroDoVeiculo(double veiculoSeguro)
        {
            SeguroVeiculo = veiculoSeguro;
        }
        static void SeguroDoTerceiro(double terceiroSeguro)
        {
            SeguroTerceiro = terceiroSeguro;
        }
    }
}
