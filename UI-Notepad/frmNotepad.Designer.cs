namespace UI_Notepad
{
    partial class frmNotepad
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picIcone = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picIcone);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "UI - Notepad";
            // 
            // picIcone
            // 
            this.picIcone.Image = global::UI_Notepad.Properties.Resources.notepad;
            this.picIcone.Location = new System.Drawing.Point(15, 3);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(40, 40);
            this.picIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcone.TabIndex = 2;
            this.picIcone.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(873, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(919, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(62, 443);
            this.panel2.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(56, 55);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConteudo.ForeColor = System.Drawing.Color.White;
            this.txtConteudo.Location = new System.Drawing.Point(68, 50);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(891, 443);
            this.txtConteudo.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialog.FileName = "Sem Titulo";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text (*.txt)|*.txt";
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(962, 496);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcone)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picIcone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

