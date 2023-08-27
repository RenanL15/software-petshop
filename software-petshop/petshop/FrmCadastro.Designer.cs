namespace petshop
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtUserSign = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassSign = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSign = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassRepeat = new Guna.UI2.WinForms.Guna2TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(503, 30);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(238, 56);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(300, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // txtUserSign
            // 
            this.txtUserSign.Animated = true;
            this.txtUserSign.BorderRadius = 20;
            this.txtUserSign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserSign.DefaultText = "";
            this.txtUserSign.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserSign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserSign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserSign.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserSign.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserSign.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtUserSign.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserSign.Location = new System.Drawing.Point(238, 138);
            this.txtUserSign.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUserSign.Name = "txtUserSign";
            this.txtUserSign.PasswordChar = '\0';
            this.txtUserSign.PlaceholderText = "Usuário";
            this.txtUserSign.SelectedText = "";
            this.txtUserSign.Size = new System.Drawing.Size(307, 55);
            this.txtUserSign.TabIndex = 2;
            // 
            // txtPassSign
            // 
            this.txtPassSign.Animated = true;
            this.txtPassSign.BorderRadius = 20;
            this.txtPassSign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassSign.DefaultText = "";
            this.txtPassSign.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassSign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassSign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassSign.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassSign.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassSign.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPassSign.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassSign.Location = new System.Drawing.Point(238, 203);
            this.txtPassSign.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassSign.Name = "txtPassSign";
            this.txtPassSign.PasswordChar = '●';
            this.txtPassSign.PlaceholderText = "Senha";
            this.txtPassSign.SelectedText = "";
            this.txtPassSign.Size = new System.Drawing.Size(307, 55);
            this.txtPassSign.TabIndex = 3;
            // 
            // btnSign
            // 
            this.btnSign.BorderRadius = 20;
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSign.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnSign.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSign.ForeColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(299, 348);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(180, 45);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "Cadastrar";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtPassRepeat
            // 
            this.txtPassRepeat.Animated = true;
            this.txtPassRepeat.BorderRadius = 20;
            this.txtPassRepeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassRepeat.DefaultText = "";
            this.txtPassRepeat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassRepeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassRepeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassRepeat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassRepeat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassRepeat.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPassRepeat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassRepeat.Location = new System.Drawing.Point(238, 268);
            this.txtPassRepeat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassRepeat.Name = "txtPassRepeat";
            this.txtPassRepeat.PasswordChar = '●';
            this.txtPassRepeat.PlaceholderText = "Repita a senha";
            this.txtPassRepeat.SelectedText = "";
            this.txtPassRepeat.Size = new System.Drawing.Size(307, 55);
            this.txtPassRepeat.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(282, 402);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Já tem uma conta? Entre aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 490);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtPassRepeat);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.txtPassSign);
            this.Controls.Add(this.txtUserSign);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtUserSign;
        private Guna.UI2.WinForms.Guna2TextBox txtPassSign;
        private Guna.UI2.WinForms.Guna2Button btnSign;
        private Guna.UI2.WinForms.Guna2TextBox txtPassRepeat;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

