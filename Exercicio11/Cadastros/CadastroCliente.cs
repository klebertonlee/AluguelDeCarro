using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Cadastros
{
    internal sealed class CadastroCliente : Cadastro
    {
        public decimal Habilitacao {protected get; set; }
        public string TipoCartao { get; set; }
        public CadastroCliente(string nameCompleto, decimal cpf, DateTime dataNascimento, decimal numeroCelular, string email, decimal habilitacao, string tipocartao) 
            : base(nameCompleto, cpf, dataNascimento, numeroCelular, email)
        {
            Habilitacao = habilitacao;
            TipoCartao = tipocartao;

        }

        
       

    }
}
