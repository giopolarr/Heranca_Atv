using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Ativi
{
    internal class Conta
    {

        public int NumConta { get; set; }
        public string NumAgencia { get; set; }
        public string TitularConta { get; set; }
        public double SaldoConta { get; set; }

        public Conta(int NumConta, string NumAgencia, string TitularConta, double SaldoConta)
        {
            this.NumConta = NumConta;
            this.NumAgencia = NumAgencia;
            this.TitularConta = TitularConta;
            this.SaldoConta = SaldoConta;
        }

        public virtual void Sacar(double ValorSaque)
        {

            if (ValorSaque <= SaldoConta)
            {
                SaldoConta = SaldoConta - ValorSaque;
                Console.WriteLine("O saque foi realizado \nO saldo atual da sua conta é: " + SaldoConta);
            }

            else { Console.WriteLine("Você não tem saldo o suficiente \n Seu saldo atual é: " + SaldoConta); }
        }
        public virtual void Depositar(double ValorDeposito)

        {
            SaldoConta = SaldoConta + ValorDeposito;
            Console.WriteLine("Deposito realizado com sucesso  \nO saldo atual da sua conta é: " + SaldoConta);
        }

    }
}
