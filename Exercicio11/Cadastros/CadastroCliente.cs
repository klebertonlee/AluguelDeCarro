using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Cadastros
{
    internal sealed class CadastroCliente : Cadastro
    {
        public string TipoCartao { get; set; }
        public CadastroCliente(string nameCompleto, decimal cpf, DateTime dataNascimento, decimal numeroCelular, string email, string tipocartao) 
            : base(nameCompleto, cpf, dataNascimento, numeroCelular, email)
        {
            TipoCartao = tipocartao;
        }

        
       

    }
}
