using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Ativi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(11, "120", "Giovanna", 150);
           
            while (true) 
            
            {
                Console.WriteLine("Qual conta você quer: " +
                    "\n para estudantil digite 1" +
                    " \n para empresarial digite 2 " +
                    "\n Apenas abrir conta digite 3");
                int tipoConta = Convert.ToInt32(Console.ReadLine());

                try
                {
                    if (tipoConta == 1)
                    {
                        Estudante estudante = new Estudante(100, "01010101", "Ifro", 1010101, "01010", "Giovanna", 150);
                        Console.WriteLine("Para sacar digite: 3 \n Para depositar digite: 4");
                        int escolha = Convert.ToInt32(Console.ReadLine());
                        if (escolha == 3)
                        {
                            Console.WriteLine("Digite o valor do saque: ");
                            double valorSaquee = Convert.ToDouble(Console.ReadLine());
                            estudante.Sacar(valorSaquee);
                        }
                        else { Console.WriteLine("Erro"); }
                    }
                    if(tipoConta == 2)
                    {
                        Empresarial b = new Empresarial(1000, 500, 0, 100, "10101", "Giovanna", 1000);

                        Console.WriteLine("Para sacar digite: 1 \n Para fazer emprestimo digite:2");
                        int escolha = Convert.ToInt32((Console.ReadLine()));
                        if (escolha == 1)
                        {
                            Console.WriteLine("Digite o valor do saque: ");
                            double valorSaquee = Convert.ToDouble(Console.ReadLine());
                            b.Sacar(valorSaquee);

                        } else { Console.WriteLine("erro"); }
                        if(escolha == 2)
                        {
                            Console.WriteLine("Digite o valor do Emprestimo ");
                            double valorEmprestimo = Convert.ToDouble(Console.ReadLine());
                            b.Emprestimo(valorEmprestimo);
                        }
                    }
                    if(tipoConta == 3)
                    {
                        Console.WriteLine("Para sacar digite: 1 \n Para fazer um deposito digite:2");
                        int escolha = Convert.ToInt32((Console.ReadLine()));
                        if(escolha == 1)
                        {
                            Console.WriteLine("Digite o valor do saque: ");
                            double valorSaquee = Convert.ToDouble(Console.ReadLine());
                            conta.Sacar(valorSaquee);

                        }
                        if(escolha == 2)
                        {
                            Console.WriteLine("Digite o valor do deposito: ");
                            double valorDeposito = Convert.ToDouble(Console.ReadLine());
                            conta.Depositar(valorDeposito);
                            Console.WriteLine(valorDeposito);
                        }
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Erro");
                }
            }
            Console.ReadKey();
        }
    }
}
