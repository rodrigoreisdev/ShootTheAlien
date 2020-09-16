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
        public frmJogo(int dif, int tempo)
        {
            game = new Jogo(dif, tempo);
            InitializeComponent();
            IniciarJogo(1);
        }

        public Jogo Game { get => game; set => game = value; }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            

        }

        private void pnFacil_Paint(object sender, PaintEventArgs e)
        {
            
        }

        void IniciarJogo(int x)
        {
            pnFacil.Visible = true;
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
                    pb1.Image = images[y];
                }
            }
        }
    }
}
