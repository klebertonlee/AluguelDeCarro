
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11.Cadastros
{
    internal sealed class CadastroFuncionario : Cadastro
    {
        public string Funcionario { get; set; }
        public CadastroFuncionario(string nameCompleto, int matricula, decimal cpf, DateTime dataNascimento, decimal numeroCelular, string email, string funcionario) 
                            : base(nameCompleto, matricula, cpf, dataNascimento, numeroCelular, email)
        {
            Funcionario = funcionario;
        }
            

        
    }
}
