using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Ativi
{
    internal class Estudante : Conta
    {
        public double LimiteChequeEspecial { get; set; }
        public string Cpf { get; set; }
        public string NomeInstituicao { get; set; }

        public Estudante(double limiteChequeEspecial, string cpf, string nomeInstiuicao, int numConta, string NumAgencia, string TitularConta, double SaldoConta)
            : base(numConta, NumAgencia, TitularConta, SaldoConta)
        {
            this.LimiteChequeEspecial = limiteChequeEspecial;
            this.Cpf = cpf;
            this.NomeInstituicao = nomeInstiuicao;
        }
        public override void Sacar(double valor)
        {
            if (valor <= SaldoConta + LimiteChequeEspecial)
            {
                Console.WriteLine("Seu saque foi realizado  total: " + valor);
                SaldoConta = (SaldoConta + LimiteChequeEspecial) - valor;
            }
            else { Console.WriteLine("Voce nao tem saldo o suficiente para esse saque"); }

        }

    }
}
