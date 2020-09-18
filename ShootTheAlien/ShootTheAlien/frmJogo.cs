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
        int seg;
        int dif;
        public Jogo Game { get => game; set => game = value; }

        //-------------------------------------Funções-----------------------------------//
        void IniciarJogo(int[] vet)
        {
            seg = 0;
            Control[] control = { pb1, pb2, pb3, pb4, pb5 };
            Image[] images = new Image[3] { Properties.Resources.alien, Properties.Resources.alf, Properties.Resources.nada };
            Random rand;

            rand = new Random();
            int y;
            //inicio da troca de imagens
            foreach (Control item in pnFacil.Controls)
            {

                y = rand.Next(3);
                while (vet[y] == 0)
                    y = rand.Next(3);

                item.BackgroundImage = images[y];
                vet[y]--;
            }
            //fim da troca, inicio do temporizador
            timerSel.Enabled = true;
            timerSel.Start();
        }

        void Atirar(int dif)
        {
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

            IniciarJogo(marc);
        }

        void Reset()
        {
            Control[] control = { pb1, pb2, pb3, pb4, pb5 };
            for (int i = 0; i < 5; i++)
            {
                control[i].BackgroundImage = Properties.Resources.top;
            }
        }
        //-----------------------------------------------------Form-------------------------------------------//
        public frmJogo(int dif, int tempo)
        {
            game = new Jogo(dif, tempo);
            InitializeComponent();

        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            pnFacil.Visible = true;
            dif = game.Dificuldade;

        }

        private void pb1_Click(object sender, EventArgs e)
        {
            Atirar(dif);
        }

        private void timerSel_Tick(object sender, EventArgs e)
        {
            //temporizador
            seg++;
            if (seg == 3)
            {
                timerSel.Stop();
                timerSel.Enabled = false;
                Reset();
            }
        }
    }
}
