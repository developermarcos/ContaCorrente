using System;

namespace Funcionarios.ConsoleApp
{
    public enum Departamentos
    {
        Administrativo,
        Operacional
    }
    public class Funcionario
    {
        public static int id = 0;
        private int _identificador;
        public string nome;
        public Departamentos Departamento;
        private decimal _salario;
        public DateTime dataCadastro;
        public string rg;
        public bool ehFuncionario;

        public Funcionario() 
        {
            this._identificador = ++id;
        }

        public Funcionario(string nome)
        {
            this.nome = nome;
            this._identificador = ++id;
        }
        
        public int Identificador
        {
            get { return this._identificador; }
        }

        public decimal Salario
        {
            get { return this._salario; }
            set { this._salario = value; }
        }

        public void Bonificar(decimal valor)
        {
            this.Salario += valor;
        }
        public void Demitir()
        {
            this.ehFuncionario = false;
        }
        public void Mostrar()
        {
            Console.WriteLine("Funcionario: {0}", this.nome);
            Console.WriteLine("Departamento: {0}", this.Departamento);
            Console.WriteLine("Salário: {0}", this.Salario.ToString("N2"));
            Console.WriteLine("Data de cadastrar: {0}", this.dataCadastro);
            Console.WriteLine("RG: {0}", this.rg);
            Console.WriteLine("É funcionario: {0}", this.ehFuncionario == true ? "Sim" : "Não");
        }
    }
}
