using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Posicao
    {
        //encapsulamento, permite acesso e alteraçao por outras classes
        public int linha { get; set; }
        public int coluna { get; set; }

        //criaçao de construtor para classe Posicao que atribui diretamente
        //os valores para um novo objeto que venha a ser instanciado
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        //to string da classe Posicao
        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
