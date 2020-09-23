using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootTheAlien
{
    public partial class frmJogo : Form
    {
        Jogo game;
        Jogador player;
        int seg;
        int seg2;
        int dif;
 


        //-------------------------------------Funções-----------------------------------//
        void Atirar(int dif, Control pb)
        {
            //quantidade de vezes de cada imagem //0 - alien   1 - alf   2 - nada
            int[] marc = new int[3];
            if (dif == 1)
            {
                marc[0] = 2;
                marc[1] = 1;
                marc[2] = 2;
            }
            if (dif == 2)
            {
                marc[0] = 1;
                marc[1] = 1;
                marc[2] = 3;
            }
            if (dif == 3)
            {
                marc[0] = 1;
                marc[1] = 2;
                marc[2] = 2;
            }

            IniciarJogo(marc, pb);
        }

        void IniciarJogo(int[] vet, Control pb)
        {
            seg = 0;
            Image[] images = new Image[3] { Properties.Resources.alien, Properties.Resources.alf, Properties.Resources.nada };
            Random rand;
            string[] tag = new string[3] { "Alien", "Alf", "Nada" };

            rand = new Random();
            int y;

            //inicio da troca de imagens
            foreach (Control item in pnFacil.Controls)
            {

                y = rand.Next(3);
                while (vet[y] == 0)
                    y = rand.Next(3);

                item.BackgroundImage = images[y];
                item.Tag = tag[y];
                vet[y]--;
            }

            Comparar(pb);

            //fim da troca, inicio do temporizador
            timerSel.Enabled = true;
            timerSel.Start();
        }

        //Comparação de imagens
        void Comparar(Control pb)
        {

            if (pb.Tag.ToString() == "Alien")
            {
                prbNivel.Value++;
                game.Pontos++;
                lblAcerto.ForeColor = Color.Green;
                lblAcerto.Text = "Bom tiro!";
            }
            if (pb.Tag.ToString() == "Alf")
            {
                if(prbNivel.Value!=0)
                {
                    prbNivel.Value--;
                    game.Pontos--;
                }
                lblAcerto.ForeColor = Color.Red;
                lblAcerto.Text = "Você acertou o Alf!";
            }
            if (pb.Tag.ToString() == "Nada")
            {
                lblAcerto.ForeColor = Color.White;
                lblAcerto.Text = "Errou!";
            }
        }

        //Voltar ao original
        void Reset()
        {
            foreach(Control item in pnFacil.Controls)
            {
                item.BackgroundImage = Properties.Resources.top;
                item.Tag = "";
            }
        }

        //Termino do jogo
        void Terminar()
        {
            pnFacil.Enabled = false;
            MessageBox.Show("Jogo Terminado");
            frmFim frm = new frmFim(player.Nome,game.Pontos);
            player.Pontos = game.Pontos;
            frm.Show();
        }

        //-----------------------------------------------------Form-------------------------------------------//
        public frmJogo(int dif, int tempo, Jogador player)
        {
            game = new Jogo(dif, tempo);
            this.player = player;
            InitializeComponent();

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            pnFacil.Visible = true;
            dif = game.Dificuldade;
            seg2 = game.Tempo*60;
            prbTempo.Maximum = game.Tempo * 60;
            prbNivel.Value = player.Pontos % 10;
            timerTempo.Start();

        }

        private void timerSel_Tick(object sender, EventArgs e)
        {
            //temporizador
            seg++;
            if (seg == 10)
            {
                timerSel.Stop();
                timerSel.Enabled = false;
                Reset();
            }
        }

        private void timerTempo_Tick(object sender, EventArgs e)
        {
            //tempo de jogo
            if (prbTempo.Value == prbTempo.Maximum)
            {
                timerTempo.Stop();
                Terminar();
            }
            else
                prbTempo.Value++;
            if (prbNivel.Value == 10) 
            {
                prbNivel.Value = 0;
            }
            lblNivel.Text = "Nível: " + ((game.Pontos/10)+1);
            seg2--;
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Atirar(dif,pb1);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            Atirar(dif,pb2);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            Atirar(dif,pb3);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            Atirar(dif,pb4);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            Atirar(dif,pb5);
        }
    }
}
