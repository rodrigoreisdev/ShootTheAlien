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
    public partial class frmPrincipal : Form
    {
        List<Jogador> listaJogador = new List<Jogador>();
        bool x = false;
        bool notify = true;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cmdRegras_Click(object sender, EventArgs e)
        {
            if(x==false)
            {
                panel1.Visible = true;
                x = true;
            }
            else
            {
                panel1.Visible = false;
                x = false;
            }
        }

        private void cmdCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro(listaJogador);
            cad.Show();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            if (listaJogador.Count == 0)
                MessageBox.Show("Cadastre um jogador!");
            else
            {
                frmSelecao sel = new frmSelecao(listaJogador);
                sel.Show();
            }
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRanking frm = new frmRanking(listaJogador);
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por Jogar!");
            this.Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shoot the Alien!\nVersão 1.0.0\nDesenvolvido por Rodrigo Reis.\n");
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoria frm = new frmHistoria();
            frm.Show();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
                notify = false;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
