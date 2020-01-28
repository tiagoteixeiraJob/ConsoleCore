using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador1 : iJogador
    {
        public string Chutar()
        {
            return "Ronaldo está chutando";
        }

        public string Correr()
        {
            return "Ronaldo está correndo";
        }

        public string Passar()
        {
            return "Ronaldo está passando";
        }
    }
}