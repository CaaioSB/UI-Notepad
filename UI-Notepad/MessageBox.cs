using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Notepad
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
            btnFocus.Focus();
        }

        public int Sim = -1;
        public int Nao = -1;

        private void btnSim_Click(object sender, EventArgs e)
        {
            Sim = 1;
            Nao = -1;
            Close();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            Sim = -1;
            Nao = 1;
            Close();
        }
        public void Default()
        {
            lblTitulo.Text = "Titulo";
            lblDescricao.Text = "Descrição";
            btnSim.Text = "Sim";
            btnNao.Text = "Não";
            btnFocus.Focus();
            btnSim.Visible = true;
            btnNao.Visible = true;
            picImagem.Image = Properties.Resources.info;
        }

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
