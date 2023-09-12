using Exercicio11.Cadastros;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Exercicio11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Menu();

        }
        public static void Menu()
        {


            Console.WriteLine("KSistem Aluguel de carro ");

            Console.WriteLine();
            Console.WriteLine("Cadastro");

            Console.WriteLine();
            Console.WriteLine("Para Cadastra Veiculo Digite 1");
            Console.WriteLine("Para Cadastrar Cliente Digite 2");
            Console.WriteLine("Para Cadastrar Funcionario Digite 3");
            Console.Write("Digite A Opção Desejada: ");
            int opcao = int.Parse(Console.ReadLine());

            try
            {
                switch (opcao)
                {

                    case 1:
                        {
                            List<CadastroCarro> CarroCadastro = new List<CadastroCarro>();
                            Console.WriteLine("Cadastro de Veiculo:");
                            Console.WriteLine();

                            Console.Write("Fabricante: ");
                            string MarcaCarro = Console.ReadLine();
                            Console.Write("Modelo:");
                            string ModeloCarro = Console.ReadLine();
                            Console.Write("Ano: ");
                            int AnoCarro = int.Parse(Console.ReadLine());
                            double ValorDia = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            CarroCadastro.Add(new CadastroCarro(ModeloCarro, MarcaCarro, AnoCarro, ValorDia));
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            List<CadastroCliente> ClienteCadastro = new List<CadastroCliente>();
                            Console.WriteLine("Cadastro de Cliente");
                            Console.WriteLine();

                            //Coloca habilitação, Categoria, data de vencimento, do cliente.
                            Console.Write("Nome do Cliente: ");
                            string NomeCliente = Console.ReadLine();
                            Console.WriteLine("Número de Habilitação");
                            decimal Habilitacao = decimal.Parse(Console.ReadLine());
                            Console.Write("Data Nascimento: ");
                            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
                            Console.Write("CPF do Cliente: ");
                            decimal CpfCliente = decimal.Parse(Console.ReadLine());
                            Console.Write("Celular do Cliente: ");
                            decimal CelularCliente = decimal.Parse(Console.ReadLine());
                            Console.Write("Email do Cliente: ");
                            string EmailCliente = Console.ReadLine();
                            Console.Write("Cartão do Cliente: ");
                            string CartaoCliente = Console.ReadLine();

                            ClienteCadastro.Add(new CadastroCliente
                                (
                                 NomeCliente, CpfCliente, DataNascimento,
                                 CelularCliente, EmailCliente, Habilitacao, CartaoCliente
                                ));
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        {
                            List<CadastroFuncionario> FuncionarioCadastro = new List<CadastroFuncionario>();
                            Console.WriteLine("Cadastro do Funcionario");
                            Console.WriteLine();

                            Console.Write("Nome do Funcionario: ");
                            string NomeFuncionario = Console.ReadLine();
                            Console.Write("Matricula Funcionario: ");
                            int MatriculaFuncionario = int.Parse(Console.ReadLine());
                            Console.Write("Data do Nascimento ");
                            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
                            Console.Write("CPF do Funcionario: ");
                            decimal CpfFuncionario = decimal.Parse(Console.ReadLine());
                            Console.Write("Celular Funcionario: ");
                            decimal CelularFuncionario = decimal.Parse(Console.ReadLine());
                            Console.Write("Email Funcionario: ");
                            string EmailFuncionario = Console.ReadLine();
                            Console.Write("Cargo Funcionario: ");
                            string tipoFuncionario = Console.ReadLine();

                            FuncionarioCadastro.Add(new CadastroFuncionario
                                (
                                 NomeFuncionario, MatriculaFuncionario, CpfFuncionario,
                                 DataNascimento, CelularFuncionario, EmailFuncionario, tipoFuncionario
                                ));
                            Console.WriteLine();
                        }
                        break;

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Código Invalido");
                            Console.WriteLine("Digite o Código Referente ao Cadastro Desejado: ");
                            Console.WriteLine();
                            Menu();
                        }
                        break;
                }
            }
            catch (Exception k)
            {
                Console.WriteLine();
                Console.WriteLine("Erro de Digitação" + k.Message);
            }
            Console.WriteLine();
        }
    }
}