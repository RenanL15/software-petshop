using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petshop
{
    public partial class FrmCadastrarTutor : Form
    {
        public FrmCadastrarTutor()
        {
            InitializeComponent();
        }

        private void btnCadastrarTutor_Click(object sender, EventArgs e)
        {
            MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
            string ownerName = txtNomeTutor.Text;
            string cpf = txtCPF.Text;
            string sql = $"INSERT INTO TB_TUTORES(NM_TUTOR, CPF) VALUES ('{ownerName}', '{cpf}')";
            MySqlCommand execute = new MySqlCommand(sql, bdConn);
            bdConn.Open();
            execute.ExecuteReader();
            bdConn.Close();
            Form form = new FrmAreaPrincipal();
            form.Show();
            this.Hide();
        }

        private void FrmCadastrarTutor_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FrmAreaPrincipal"];
            form.Show();
            this.Hide();
        }
    }
}
