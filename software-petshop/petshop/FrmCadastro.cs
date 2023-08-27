using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace petshop
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if(txtPassRepeat.Text == txtPassSign.Text)
            {
                MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
                string user = txtUserSign.Text;
                string pass = txtPassSign.Text;
                string sql = $"INSERT INTO TB_USUARIOS(NM_USUARIO, SENHA) VALUES ('{user}', '{pass}')";
                bdConn.Open();
                MySqlCommand signup = new MySqlCommand(sql, bdConn);
                signup.ExecuteReader();
                bdConn.Close();
                Form form = new FrmLogin();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("As senhas não se concidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
