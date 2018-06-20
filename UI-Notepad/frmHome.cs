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
                txtNomeProjeto.BackColor = Color.Red;
            }
        }
    }
}
