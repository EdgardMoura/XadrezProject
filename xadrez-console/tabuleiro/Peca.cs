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

        public abstract bool[,] movimentosPossiveis();
        
        }
    }

