using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootTheAlien
{
    public class Jogo
    {
        private int dificuldade;
        private int tempo;
        private int pontos;
        

        public Jogo(int dificuldade, int tempo)
        {
            this.dificuldade = dificuldade;
            this.tempo = tempo;
        }

        public int Dificuldade { get => dificuldade;  }
        public int Tempo { get => tempo; }
        public int Pontos { get => pontos; set => pontos = value; }
    }
}
