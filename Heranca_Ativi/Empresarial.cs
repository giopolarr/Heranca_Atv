using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Ativi
{
    internal class Empresarial : Conta
    {
        public double Anuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public Empresarial(double Anuidade, double LimiteEmprestimo, double TotalEmprestimo, int numConta, string NumAgencia, string TitularConta, double SaldoConta)
            : base(numConta, NumAgencia, TitularConta, SaldoConta)
        {
            this.Anuidade = Anuidade;
            this.LimiteEmprestimo = LimiteEmprestimo;
            this.TotalEmprestimo = TotalEmprestimo;
        }

        public override void Sacar(double ValorSaque)
        {   if (ValorSaque > 5000)
            {
                ValorSaque = ValorSaque + 5;
                Console.WriteLine("O saque foi realizado \n O saldo atual da sua conta é:" + SaldoConta);
                if (ValorSaque <= SaldoConta)
                {
                    SaldoConta = SaldoConta - ValorSaque;
                    Console.WriteLine("O saque foi realizado \n O saldo atual da sua conta é: " + SaldoConta);
                }

                else
                {
                    Console.WriteLine("Você não tem saldo o suficiente \n Seu saldo atual é: " + SaldoConta);

                }
            } 
            
        }

        public virtual void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)

            { 
                LimiteEmprestimo -= valor;
                SaldoConta += valor;
                TotalEmprestimo += valor;
                Console.WriteLine("Seu Emprestimo foi realizado O saldo atual da sua conta é: " + SaldoConta); }
            else { Console.WriteLine("Voce nao pode realizar este Emprestimo "); }
        }
    }
    
}
