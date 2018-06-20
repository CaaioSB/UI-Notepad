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
    }
}
