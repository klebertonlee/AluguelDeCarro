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
       public CadastroCarro Carro { get; set; }

        
       
        public CadastroCarro(string modelo, string marcaCarro, int anoCarro)
            : base(modelo, marcaCarro, anoCarro)
        {

        }   
        
        public CadastroCarro(CadastroCarro carro)
        {
            Carro = carro;
        }


        public CadastroCarro VetorCarro(CadastroCarro carro)
        {
            return VetorCarro();
        }


    }
}
