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
        }

        public Jogo Game { get => game; set => game = value; }

        private void frmJogo_Load(object sender, EventArgs e)
        {

        }
    }
}
