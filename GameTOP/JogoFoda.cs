using GameTOP.Interface;

namespace GameTOP
{
    public  class JogoFODA
    {
        private readonly iJogador _jogadorA;

        private readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogadorA = jogador1;
            _jogadorB = jogador2;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogadorA.Correr());
            System.Console.WriteLine(_jogadorA.Chutar());
            System.Console.WriteLine(_jogadorA.Passar());  
            //
            System.Console.WriteLine("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.WriteLine(_jogadorB.Correr());
            System.Console.WriteLine(_jogadorB.Chutar());
            System.Console.WriteLine(_jogadorB.Passar());           
        }
    }
}