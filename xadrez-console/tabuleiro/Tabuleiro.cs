

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;//nao pode ser acessada por fora

        //construtor da classe
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //metodo que retorna uma peça
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //sobrecarga do metodo peca recebendo pos em vez de linha e coluna separadamente
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        //metodo para colocar pecas, reforça o teste da existencia de peça e dispara a exceçao
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (exitePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        //metodo que verifica a existencia de peça, se houver erro de validaçao de 
        //posiçao o metodo é cortado e fornce uma exceçao
        public bool exitePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //verificando se a posiçao do tabuleiro é valida
        public bool posicaValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        
        //metodo que lança exceçao caso posiçao nao seja valida
            public void validarPosicao(Posicao pos) {
            if (!posicaValida(pos))
            {
                throw new TabuleiroException("Posiçao invalida!");
            }
            }
        }
    }
}
