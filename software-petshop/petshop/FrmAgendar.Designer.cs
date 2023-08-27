namespace petshop
{
    partial class FrmAgendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgendar));
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAgendar = new Guna.UI2.WinForms.Guna2Button();
            this.dtpAgenda = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnBack = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmbPets = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rdbBanho = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbForm = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(234, 40);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(300, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 12;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(499, 14);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BorderRadius = 20;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgendar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgendar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgendar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(145)))), ((int)(((byte)(144)))));
            this.btnAgendar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnAgendar.ForeColor = System.Drawing.Color.White;
            this.btnAgendar.Location = new System.Drawing.Point(310, 373);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(180, 45);
            this.btnAgendar.TabIndex = 24;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // dtpAgenda
            // 
            this.dtpAgenda.AutoRoundedCorners = true;
            this.dtpAgenda.BackColor = System.Drawing.Color.Transparent;
            this.dtpAgenda.BorderRadius = 24;
            this.dtpAgenda.Checked = true;
            this.dtpAgenda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpAgenda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAgenda.Location = new System.Drawing.Point(257, 289);
            this.dtpAgenda.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAgenda.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAgenda.Name = "dtpAgenda";
            this.dtpAgenda.Size = new System.Drawing.Size(300, 51);
            this.dtpAgenda.TabIndex = 25;
            this.dtpAgenda.Value = new System.DateTime(2023, 6, 19, 1, 16, 48, 17);
            this.dtpAgenda.ValueChanged += new System.EventHandler(this.dtpAgenda_ValueChanged);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageRotate = 0F;
            this.btnBack.Location = new System.Drawing.Point(25, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 43);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 26;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbPets
            // 
            this.cmbPets.BackColor = System.Drawing.Color.Transparent;
            this.cmbPets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPets.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPets.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPets.ItemHeight = 30;
            this.cmbPets.Location = new System.Drawing.Point(257, 226);
            this.cmbPets.Name = "cmbPets";
            this.cmbPets.Size = new System.Drawing.Size(300, 36);
            this.cmbPets.TabIndex = 27;
            this.cmbPets.Tag = "";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(257, 205);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 15);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "Selecione o pet:";
            // 
            // rdbBanho
            // 
            this.rdbBanho.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.rdbBanho.CheckedState.BorderThickness = 0;
            this.rdbBanho.CheckedState.FillColor = System.Drawing.Color.Green;
            this.rdbBanho.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbBanho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbBanho.Location = new System.Drawing.Point(297, 136);
            this.rdbBanho.Name = "rdbBanho";
            this.rdbBanho.Size = new System.Drawing.Size(20, 20);
            this.rdbBanho.TabIndex = 29;
            this.rdbBanho.Text = "guna2CustomRadioButton1";
            this.rdbBanho.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbBanho.UncheckedState.BorderThickness = 2;
            this.rdbBanho.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbBanho.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbBanho.CheckedChanged += new System.EventHandler(this.rdbBanho_CheckedChanged);
            // 
            // rdbForm
            // 
            this.rdbForm.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.rdbForm.CheckedState.BorderThickness = 0;
            this.rdbForm.CheckedState.FillColor = System.Drawing.Color.Green;
            this.rdbForm.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbForm.Location = new System.Drawing.Point(420, 135);
            this.rdbForm.Name = "rdbForm";
            this.rdbForm.Size = new System.Drawing.Size(20, 20);
            this.rdbForm.TabIndex = 30;
            this.rdbForm.Text = "guna2CustomRadioButton2";
            this.rdbForm.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbForm.UncheckedState.BorderThickness = 2;
            this.rdbForm.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbForm.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(323, 131);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(63, 26);
            this.guna2HtmlLabel2.TabIndex = 31;
            this.guna2HtmlLabel2.Text = "Banho";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(451, 133);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(49, 26);
            this.guna2HtmlLabel3.TabIndex = 32;
            this.guna2HtmlLabel3.Text = "Tosa";
            // 
            // FrmAgendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(815, 494);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.rdbForm);
            this.Controls.Add(this.rdbBanho);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cmbPets);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpAgenda);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "FrmAgendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgendar";
            this.Load += new System.EventHandler(this.FrmAgendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAgendar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAgenda;
        private Guna.UI2.WinForms.Guna2PictureBox btnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPets;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbBanho;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbForm;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}