namespace UI_Notepad
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(258, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(85, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Novo Projeto";
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtNomeProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProjeto.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProjeto.ForeColor = System.Drawing.Color.White;
            this.txtNomeProjeto.Location = new System.Drawing.Point(12, 78);
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(234, 14);
            this.txtNomeProjeto.TabIndex = 1;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.White;
            this.lblAviso.Location = new System.Drawing.Point(38, 60);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(174, 15);
            this.lblAviso.TabIndex = 3;
            this.lblAviso.Text = "Digite um nome para o projeto";
            // 
            // btnCriar
            // 
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(93, 97);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(258, 129);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtNomeProjeto);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Projeto";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnCriar;
    }
}