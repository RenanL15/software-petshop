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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtPassSign_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUserSign_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserLogin.Text;
            string password = txtPassLogin.Text;
            MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
            string sql = $"SELECT * FROM TB_USUARIOS WHERE SENHA = '{password}' AND NM_USUARIO = '{user}'";
            MySqlCommand command = new MySqlCommand(sql, bdConn);
            bdConn.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                Form area = new FrmAreaPrincipal();
                area.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha ou usuário incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bdConn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new FrmCadastro();
            form.Show();
            this.Hide();
        }
    }
}
