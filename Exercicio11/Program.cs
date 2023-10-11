using Exercicio11.Aluguel;
using Exercicio11.Cadastros;
using Exercicio11.EscolherVeiculo;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;



namespace Exercicio11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o meu desejado");
            Console.WriteLine();
            Console.WriteLine("Cadastro Opção 1: ");
            Console.WriteLine("Escolha do Veiculo opção 2: ");
            int Menu = int.Parse(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    {
                        MenuCadastro();
                    }
                    break;
                case 2:
                    {
                        MenuCarro();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Escolha incorreta");
                    }
                    break;

            }

        }
        public static void MenuCadastro()
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
                            //Cadastro do veiculo
                            List<CadastroCarro> CarroCadastro = new List<CadastroCarro>();
                            Console.WriteLine("Cadastro de Veiculo:");
                            Console.WriteLine();

                            Console.Write("Fabricante: ");
                            string MarcaCarro = Console.ReadLine();
                            Console.Write("Modelo:");
                            string ModeloCarro = Console.ReadLine();
                            Console.Write("Ano: ");
                            int AnoCarro = int.Parse(Console.ReadLine());
                            Console.Write("Valor da diaria: ");
                            double ValorDia = double.Parse(Console.ReadLine());
                            //Colocar Kilometragem inicial e final

                            CarroCadastro.Add(new CadastroCarro
                                (
                                ModeloCarro, MarcaCarro, AnoCarro, ValorDia));
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            //cadastro do cliente
                            List<CadastroCliente> ClienteCadastro = new List<CadastroCliente>();
                            Console.WriteLine("Cadastro de Cliente");
                            Console.WriteLine();

                            //Coloca habilitação, Categoria, data de vencimento da habilitação cliente.
                            Console.Write("Nome do Cliente: ");
                            string NomeCliente = Console.ReadLine();
                            Console.Write("Número de Habilitação: ");
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
                            //cadastro do funcionario
                            List<CadastroFuncionario> FuncionarioCadastro = new List<CadastroFuncionario>();
                            Console.WriteLine("Cadastro do Funcionario");


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
                            //Caso seja inserido um codigo errado
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Código Invalido");
                            Console.WriteLine("Digite o Código Referente ao Cadastro Desejado: ");
                            Console.WriteLine();
                            MenuCadastro();
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

        /*---Menu da escolha do Veículo
        ------------------------------------------------------------------*/
        public static void MenuCarro()
        {

            Console.WriteLine("Qual Veículo Desejado");
            Console.WriteLine();

            Console.Write(" O veículo escolhido é: ");
            string Carro = Console.ReadLine();


            //Aqui poderia ter uma data e hora especifica mais quis usar o DataTime.now para usar o horario atual da retirada.
            Console.WriteLine();
            Console.Write("Retirada do carro: ");
            DateTime DiaRetirada = DateTime.Now;
            double DiaHoraRetirada = (double)DiaRetirada.Day;
            Console.WriteLine(DiaHoraRetirada);
            Console.WriteLine();

            //Aqui entraria o DateTime.Now também, mais ai não conseguiria ter um calculo de dia e horas 
            Console.Write("Dia da Entrega: ");

            DateTime DiaEntrega = DateTime.Parse(Console.ReadLine());
            double DiaHoraEntrega = (double)DiaEntrega.Day;
            Console.WriteLine(DiaHoraEntrega);
            Console.WriteLine();

            DuracaoAluguel duracaoAluguel = new DuracaoAluguel(DiaHoraRetirada, DiaHoraEntrega);
            Console.WriteLine(duracaoAluguel.aluguel());
            Console.WriteLine(duracaoAluguel.valorAluguel());
        }


    }
}