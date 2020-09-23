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
    public partial class frmFim : Form
    {
        int pts;
        string player;
        public frmFim(string player, int pts)
        {
            this.player = player;
            this.pts = pts;
            InitializeComponent();
        }

        private void frmFim_Load(object sender, EventArgs e)
        {
            lblPts.Text = "Você fez " + pts + " nesse jogo!";

        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmSelecao"].Close();
            Application.OpenForms["frmJogo"].Close();
            this.Close();
        }

        private void cmdJogar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["frmSelecao"].Close();
        }
    }
}
