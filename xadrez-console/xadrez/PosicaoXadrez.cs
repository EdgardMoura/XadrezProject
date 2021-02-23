using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        //construtor padrao
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        //metodo para converter a posiçao do xadrez para uma posiçao interna da matriz
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }


        //metodo override
        public override string ToString()
        {
            return "" + coluna + linha;
        }


    }
}
