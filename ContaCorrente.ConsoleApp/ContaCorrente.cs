using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente.ConsoleApp
{
    
    internal class ContaCorrente
    {
        public int numero;
        public bool ehEspecial;
        public decimal limite;
        public decimal saldo;
        public Movimentacao[] movimentacoes;
        
        
        public bool Sacar(decimal valor)
        {
            bool saqueRealizado = false;
            decimal valorSaque = valor;

            if (valorSaque < (limite + saldo))
            {
                int posicao = PosicaoParaInserirMovimentacao();
                if (posicao != -1)
                {
                    saldo -= valor;
                    Movimentacao movimentacao = new Movimentacao();
                    movimentacao.tipos = Tipos.Débito;
                    movimentacao.valores = valorSaque;
                    movimentacoes[posicao] = movimentacao;
                    saqueRealizado = true;
                }
            }
            else
                Console.WriteLine("Não foi possível realizar esta transação");

            return saqueRealizado;
        }
        public void Depositar(decimal valorDeposito)
        {
            int posicao = PosicaoParaInserirMovimentacao();
            if (posicao != -1)
            {
                saldo += valorDeposito;
                Movimentacao movimentacao = new Movimentacao();
                movimentacao.tipos = Tipos.Crédito;
                movimentacao.valores = valorDeposito;
                movimentacoes[posicao] = movimentacao;
            }
            else
                Console.WriteLine("Não foi possível realizar esta transação");
        }
        public bool TransferirPara(ContaCorrente contaFinal, decimal valor)
        {
            bool saqueRealizado = false;
            
            if(Sacar(valor) == true)
            {
                contaFinal.Depositar(valor);
                saqueRealizado = true;
            }
            else
                Console.WriteLine("Não foi possível realizar esta transação");

            return saqueRealizado;
        }
        private int PosicaoParaInserirMovimentacao()
        {
            int posicao = -1;// -1 não há posições para registrar movimentacoes
            if (movimentacoes[0] == null)
                posicao = 0;
            else
            {
                for (int i = 0; i < movimentacoes.Length; i++)
                {
                    if (movimentacoes[i] == null)
                    {
                        posicao = i;
                        break;
                    }
                }
            }
            return posicao;
        }
        public void Saldo()
        {
            Console.WriteLine("O saldo da conta {0} é de {1}", numero.ToString(), saldo.ToString());
        }
        public void Extrato()
        {
            Console.WriteLine("---------------Segue extrato da conta---------------");
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] != null)
                    Console.WriteLine("Movimentação de "+ movimentacoes[i].tipos +" com o valor de "+ movimentacoes[i].valores);
                else
                    break;
            }
        }
    }
}
