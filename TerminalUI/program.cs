using System;
using System.Text;
using System.Threading;

namespace AulaHeranca
{
    internal static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ContaEspecial conta = new ContaEspecial("222245", "Nezuko", 1000.00m, 3000.00m);
            int opcao = 0;

            while (opcao != 6)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("1. Mostrar conta.\t4. Aumentar limite.\n2. Depositar.\t\t5. Diminuir limite.\n3. Sacar.\t\t6. Sair");
                    Console.WriteLine("Escolha uma opção: ");
                    opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine($"Nome: {conta.TitularConta}\nSaldo: {conta.mostrarSaldo()}\nLimite disponível: {conta.ConsultaLimite()}");
                            Console.WriteLine("Aperte enter para continuar");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Valor para depósito: ");
                            decimal valor = decimal.Parse(Console.ReadLine());

                            if (valor < 0){
                                throw new ArgumentException("O valor do depósito deve ser positivo!");
                            }
                            conta.depositarSaldo(valor);
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Valor para saque: ");
                            decimal valor2 = decimal.Parse(Console.ReadLine());
                            if (conta.mostrarSaldo() < valor2){
                                throw new ArgumentException("Saldo insuficiente.");
                            }

                            conta.sacarSaldo(valor2);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Valor para aumento: ");
                            decimal valor3 = decimal.Parse(Console.ReadLine());
                            if (valor3 < 0 ){
                                throw new ArgumentException("O valor deve ser positivo!");
                            }

                            conta.AumentaLimite(valor3);
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Valor para diminuir: ");
                            decimal valor4 = decimal.Parse(Console.ReadLine());
                            if (valor4 < 0){
                                throw new ArgumentException("O valor deve ser positivo!");
                            }

                            if (conta.ConsultaLimite() < valor4){
                                throw new ArgumentException("Limite insuficiente.");
                            }
                            conta.DiminuiLimite(valor4);
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Saindo...");
                            Thread.Sleep(1500);
                            break;
                        default:
                            Console.Clear();
                            throw new ArgumentException("Opção invalida!");
                            break;
                    }
                } catch (ArgumentException e)
                {
                    Console.Clear();
                    Console.WriteLine($"Erro: {e.Message}");
                    Console.WriteLine("Aperte enter para continuar");
                    Console.ReadLine();
                }
                }
            }
        }
    }