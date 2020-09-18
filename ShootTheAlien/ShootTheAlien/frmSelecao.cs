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
    public partial class frmSelecao : Form
    {
        List<Jogador> listaJogadores;
        int dif;
        int tempo;

        public frmSelecao(List<Jogador> LJ)
        {
            listaJogadores = LJ;
            InitializeComponent();
        }

        private void frmSelecao_Load(object sender, EventArgs e)
        {
            foreach(Jogador item in listaJogadores)
            {
                lbNomes.Items.Add(item.Nome + "\t" + item.Nivel);

            }
        }

        private void lbNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbNivel.Visible = true;
        }

        private void gbNivel_Enter(object sender, EventArgs e)
        {
            
            gbTempo.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempo = int.Parse(cbTempo.SelectedItem.ToString());
            cmdOk.Visible = true;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            dif = 0;
            if (rbFacil.Checked)
                dif = 1;
            if (rbMedio.Checked)
                dif = 2;
            if (rbDificil.Checked)
                dif = 3;
            frmJogo jog = new frmJogo(dif,tempo);
            jog.Show();
        }
    }
}
