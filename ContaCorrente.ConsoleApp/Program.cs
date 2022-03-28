using System;
using Funcionarios.ConsoleApp;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente marcos = new Cliente("Marcos", "Rua 1", "123465", 26);
            ContaCorrente contaMarcos = new ContaCorrente(12, true, 0, 1000, marcos, new Movimentacao[10]);

            contaMarcos.Sacar(200);
            contaMarcos.Depositar(300);
            contaMarcos.Depositar(500);
            contaMarcos.Sacar(200);
            Console.WriteLine(contaMarcos.cliente.Nome);

            Cliente cliente = new Cliente("Mulher", "Rua 2", "007", 20);
            ContaCorrente contaJoao = new ContaCorrente(13, true, 0, 300, cliente, new Movimentacao[10]);

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



            Console.WriteLine("\n\nHello World!");
            Funcionario marcos2 = new Funcionario();
            marcos2.nome = "Marcos";
            marcos2.Salario = 5000.00m;
            marcos2.rg = "623.111.111";
            marcos2.ehFuncionario = true;
            DateTime dataCadastro = new DateTime(2022, 08, 01);
            marcos2.dataCadastro = dataCadastro;
            marcos2.Departamento = Departamentos.Administrativo;
            marcos2.Bonificar(1000);
            marcos2.Mostrar();


            Funcionario f1 = new Funcionario();
            f1.nome = "Fiodor";
            f1.Salario = 100;
            Funcionario f2 = new Funcionario();
            f2.nome = "Fiodor";
            f2.Salario = 100;
            
            Console.WriteLine(f1.Identificador);
            Console.WriteLine(f2.Identificador);

            Console.ReadKey();
        }
    }
}
