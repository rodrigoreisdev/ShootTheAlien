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
        int seg = 0;
        public frmJogo(int dif, int tempo)
        {
            game = new Jogo(dif, tempo);
            InitializeComponent();
            
        }

        public Jogo Game { get => game; set => game = value; }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            pnFacil.Visible = true;

        }

        void IniciarJogo(int x)
        {
            Control[] control= { pb1, pb2, pb3, pb4, pb5 };
            
            int[] marc = new int[3];
            Image[] images = new Image[3];
            images[0] = Properties.Resources.alien; //0- alien
            images[1] = Properties.Resources.alf;   //1- alf
            images[2] = Properties.Resources.nada;  //2- nada
            for (int i=0; i < marc.Length; i++)
                marc[i]= 0;

            Random rand;
            if (x==1)
            {
                rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    int y= rand.Next(3);
                    control[i].BackgroundImage = images[y];
                }
            }
            timerSel.Enabled = true;
            timerSel.Start();
        }

        void Reset()
        {
            Control[] control = { pb1, pb2, pb3, pb4, pb5 };
            for (int i = 0; i < 5; i++)
            {
                control[i].BackgroundImage = Properties.Resources.top;
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            IniciarJogo(1);
        }

        private void timerSel_Tick(object sender, EventArgs e)
        {
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
