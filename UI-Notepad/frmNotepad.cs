using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI_Notepad
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }
        MessageBox MessageBox = new MessageBox();

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtConteudo.Text))
            {
                MessageBox.lblTitulo.Text = "Alterações não salvas";
                MessageBox.lblDescricao.Text = "Você realmente deseja sair sem salvar as alterações?";
                MessageBox.ShowDialog();

                if (MessageBox.Sim != 1)
                {
                    saveFileDialog.Title = "UINotepad - BETA";
                    saveFileDialog.Filter = "Text File|.txt";
                    saveFileDialog.FilterIndex = 0;
                    saveFileDialog.FileName = frmHome.nomeProjeto;
                    saveFileDialog.DefaultExt = ".txt";
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    saveFileDialog.InitialDirectory = desktopPath;
                    saveFileDialog.RestoreDirectory = true;
                    DialogResult resultado = saveFileDialog.ShowDialog();
                    FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.Write(txtConteudo.Text);
                    txtConteudo.Text = "";
                    writer.Close();
                }
                else
                {
                    txtConteudo.Text = "";
                }
            }
        }
    }
}
