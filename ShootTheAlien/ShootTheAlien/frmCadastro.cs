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
    public partial class frmCadastro : Form
    {
        List<Jogador> listaJogadores;
        Jogador jog;
        public frmCadastro(List<Jogador> LJ)
        {
            listaJogadores = LJ;
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txtNome.Text;
            jog = new Jogador(nome);
            listaJogadores.Add(jog);
            MessageBox.Show("Cadastro Efetuado com sucesso!");
            txtNome.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
