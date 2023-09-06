
using System;


namespace Exercicio11.Cadastros
{
    internal class Cadastro
    {
        //veiculo       
        public string Modelo { get; protected set; }
        public string MarcaCarro { get; protected set; }
        public int AnoCarro { get; protected set; }
       

        //Cliente e funcionario
        public string NameCompleto { get; protected set; }
        public int Matricula { get; protected set; }
        public decimal Cpf { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public decimal NumeroCelular { get; protected set; }
        public string Email { get; protected set; }
       

        public Cadastro()
        {
        }

        //Costrutor para cadastro dos Veiculos
        public Cadastro(string modelo, string marcaCarro, int anoCarro)
        {
            Modelo = modelo;
            MarcaCarro = marcaCarro;
            AnoCarro = anoCarro;
        }

        //Costrutor para cadastro dos Clientes
        public Cadastro(string nameCompleto, decimal cpf, DateTime dataNascimento, decimal numeroCelular, string email)
        {
            
            NameCompleto = nameCompleto;            
            Cpf = cpf;
            DataNascimento = dataNascimento;
            NumeroCelular = numeroCelular;
            Email = email;
        }

        //construtor para cadastro dos Funcionarios
        public Cadastro(string nameCompleto, int matricula, decimal cpf, DateTime dataNascimento, decimal numeroCelular, string email)
            :this (nameCompleto, cpf, dataNascimento, numeroCelular,email)
        {           
            Matricula = matricula;           
        }


       




    }
}
