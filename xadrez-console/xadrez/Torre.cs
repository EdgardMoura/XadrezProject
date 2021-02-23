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
            return "T";
        }
    }
}