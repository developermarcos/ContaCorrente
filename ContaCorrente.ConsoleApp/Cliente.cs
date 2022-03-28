using System;

namespace ContaCorrente.ConsoleApp
{
    public class Cliente
    {
        private String nome;
        private String endereco;
        private String cpf;
        private int idade;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string Endereco
        {
            get { return this.endereco; }
            set { this.endereco = value; }
        }
        public string Cpf
        {
            get { return this.cpf; }
        }

        private Cliente() { }
        public Cliente(string nome, string endereco, string cpf, int idade)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
            this.idade = idade;
        }
        public void MudaCPF(String cpf)
        {
            ValidaCPF(cpf);
            this.cpf = cpf;
        }
        private void ValidaCPF(String cpf)
        {
            
        }
        
    }
}
