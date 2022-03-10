using System;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMarcos = new ContaCorrente();
            contaMarcos.numero = 12;
            contaMarcos.limite = 0;
            contaMarcos.saldo = 1000;
            contaMarcos.ehEspecial = true;
            contaMarcos.movimentacoes = new Movimentacao[10];

            contaMarcos.Sacar(200);
            contaMarcos.Depositar(300);
            contaMarcos.Depositar(500);
            contaMarcos.Sacar(200);

            ContaCorrente contaJoao = new ContaCorrente();
            contaJoao.numero = 13;
            contaJoao.limite = 0;
            contaJoao.saldo = 300;
            contaJoao.ehEspecial = true;
            contaJoao.movimentacoes = new Movimentacao[10];

            contaJoao.Sacar(200);
            contaJoao.Depositar(300);
            contaJoao.Depositar(500);
            contaJoao.Sacar(200);
            
            contaMarcos.TransferirPara(contaJoao, 400);
            contaMarcos.Extrato();
            contaMarcos.Saldo();
            
            Console.WriteLine("");
            contaJoao.Extrato();
            contaJoao.Saldo();

            Console.ReadKey();
        }
    }
}
