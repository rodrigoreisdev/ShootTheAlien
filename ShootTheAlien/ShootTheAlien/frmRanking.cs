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
    public partial class frmRanking : Form
    {
        List<Jogador> listaJogadores;
        public frmRanking(List<Jogador> listaJogadores)
        {
            this.listaJogadores = listaJogadores;
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            foreach(Jogador item in listaJogadores)
            {
                lsbJogadores.Items.Add(item.Mostra());
            }
        }
    }
}
