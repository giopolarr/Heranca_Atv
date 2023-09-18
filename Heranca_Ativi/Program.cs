using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Ativi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(11, "120", "Giovanna", 150);


            Console.WriteLine("Digite o valor do saque: ");
            double valorSaquee = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(valorSaquee);
            

            Console.WriteLine("Digite o valor do deposito: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(valorDeposito);
           Console.WriteLine(valorDeposito);



            Console.ReadKey();
        }
    }
}
