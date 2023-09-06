using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio11.Cadastros
{
    internal sealed class CadastroCarro : Cadastro
    {
        public CadastroCarro(string modelo, string marcaCarro, int anoCarro) 
            : base(modelo, marcaCarro, anoCarro)
        {
        }
    }
}
