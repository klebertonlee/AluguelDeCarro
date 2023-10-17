using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio11
{

    public static class Taxas
    {
        static public double ValorVeiculo { get; set; }
        static public double SeguroVeiculo { get; set; }
        static public double SeguroTerceiro { get; set; }

        public static double ValorDoVeiculo(double valorVeiculo)
        {
            return ValorVeiculo = valorVeiculo;
        }
        public static double SeguroDoVeiculo(double veiculoSeguro)
        {
            return SeguroVeiculo = veiculoSeguro;

        }
        public static double SeguroDoTerceiro(double terceiroSeguro)
        {
            return SeguroTerceiro = terceiroSeguro;
        }


    }

}
