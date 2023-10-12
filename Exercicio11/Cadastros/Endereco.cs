using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Cadastros
{
    abstract class Endereco
    {
        public string Rua { get; set; }
        public int NumeroCasa { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Endereco(string rua, int numeroCasa, int cep, string cidade, string bairro, string estado, string pais)
        {
            Rua = rua;
            NumeroCasa = numeroCasa;
            Cep = cep;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Pais = pais;
        }
    }
}
