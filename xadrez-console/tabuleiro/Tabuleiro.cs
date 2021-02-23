

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
    }
}
