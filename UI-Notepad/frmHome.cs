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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        public static string nomeProjeto;
        MessageBox MessageBox = new MessageBox();
        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNomeProjeto.Text.Length != 0)
            {
                nomeProjeto = txtNomeProjeto.Text;
                frmNotepad objNotepad = new frmNotepad();
                this.Hide();
                objNotepad.Show();
            }
            else
            {
                MessageBox.lblTitulo.Text = "Ops... algo não deu certo";
                MessageBox.lblDescricao.Text = "Você precisa digitar um nome válido para o projeto.";
                MessageBox.btnSim.Visible = false;
                MessageBox.btnNao.Text = "Ok";
                MessageBox.btnFocus.Focus();
                MessageBox.ShowDialog();
                txtNomeProjeto.BackColor = Color.Red;
                MessageBox.Default();
            }
        }

        private void txtNomeProjeto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCriar_Click(sender, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
