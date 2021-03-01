using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        //construtor utilizando herança
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        //metodo to string
        public override string ToString()
        {
            return "t";
        }
        //metodo verifica se é nula a posiçao ou cor diferente da peça em movimento
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos)!=null&& tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }
            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }

            //direita
            pos.definirValores(posicao.linha, posicao.coluna +1);
            while (tab.posicaValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna -1);
            while (tab.posicaValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna - 1;
            }


            return mat;
        }
    }
}