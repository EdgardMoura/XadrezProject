namespace tabuleiro
{
    abstract class Peca
    {
        //associaçao de classes
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }//encapsulamento, alterada por ela e subclasses apenas
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //construtor da classe
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;            
        }

        //metodo para contar os movimentos realizados
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        //metodo verifica se a peça nao esta bloqueada
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i < tab.linhas; i++)
            {
                for(int j=0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //metodo verifica se a peça pode mover para uma dada posiçao
        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
        
        }
    }

