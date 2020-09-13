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
            frmSelecao sel = new frmSelecao(listaJogador);
            sel.Show();
        }
    }
}
