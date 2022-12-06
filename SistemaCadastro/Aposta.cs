using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Aposta

    {
        string formaPagamento, nomeCliente, valor;
        int jogos_codJogo;
    

        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public string Valor { get => valor; set => valor = value; }
        public int Jogos_codJogo { get => jogos_codJogo; set => jogos_codJogo = value; }
    }
}
