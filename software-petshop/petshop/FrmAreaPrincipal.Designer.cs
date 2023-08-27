namespace petshop
{
    partial class FrmAreaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAreaPrincipal));
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCadastrarPet = new Guna.UI2.WinForms.Guna2Button();
            this.btnCadastrarCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgendamentos = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.AutoRoundedCorners = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BorderRadius = 19;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.Maroon;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(338, 417);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 41);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseTransparentBackground = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(251, 69);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(300, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(516, 43);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnCadastrarPet
            // 
            this.btnCadastrarPet.BorderRadius = 20;
            this.btnCadastrarPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarPet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarPet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarPet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrarPet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrarPet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnCadastrarPet.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCadastrarPet.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPet.Location = new System.Drawing.Point(417, 160);
            this.btnCadastrarPet.Name = "btnCadastrarPet";
            this.btnCadastrarPet.Size = new System.Drawing.Size(226, 45);
            this.btnCadastrarPet.TabIndex = 12;
            this.btnCadastrarPet.Text = "Cadastrar pet";
            this.btnCadastrarPet.Click += new System.EventHandler(this.btnCadastrarPet_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BorderRadius = 20;
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrarCliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(172, 160);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(226, 45);
            this.btnCadastrarCliente.TabIndex = 13;
            this.btnCadastrarCliente.Text = "Cadastrar tutor";
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.BorderRadius = 20;
            this.btnAgendamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendamentos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendamentos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendamentos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendamentos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendamentos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(136)))), ((int)(((byte)(189)))));
            this.btnAgendamentos.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnAgendamentos.ForeColor = System.Drawing.Color.White;
            this.btnAgendamentos.Location = new System.Drawing.Point(417, 225);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(226, 45);
            this.btnAgendamentos.TabIndex = 14;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(124)))), ((int)(((byte)(29)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(262, 296);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(298, 45);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Visualizar cadastros";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BorderRadius = 20;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(136)))), ((int)(((byte)(189)))));
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(172, 225);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(226, 45);
            this.btnAgendar.TabIndex = 16;
            this.btnAgendar.Text = "Agendar serviço";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // FrmAreaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(815, 494);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnAgendamentos);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnCadastrarPet);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "FrmAreaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAreaPrincipal";
            this.Load += new System.EventHandler(this.FrmAreaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCadastrarPet;
        private Guna.UI2.WinForms.Guna2Button btnCadastrarCliente;
        private Guna.UI2.WinForms.Guna2Button btnAgendamentos;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
    }
}