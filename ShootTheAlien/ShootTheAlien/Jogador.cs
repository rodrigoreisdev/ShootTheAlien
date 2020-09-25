using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootTheAlien
{
    public class Jogador
    {
        private string nome;
        private int pontos;

        public Jogador(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; }
        public int Pontos { get => pontos; set => pontos = value; }
        public int Nivel { get => (pontos / 10) + 1; }

        public string Mostra()
        {
            string aux="";
            aux = nome + "\t\t" + pontos + " pontos" + "\t\t" + "Nível: " + Nivel;
            return aux;
        }
    }
}
