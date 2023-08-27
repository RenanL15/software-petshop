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
    public partial class FrmAgendar : Form
    {
        MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
        public FrmAgendar()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            string tipo;
            string nome = cmbPets.SelectedItem.ToString();
            string data = dtpAgenda.Value.ToString();
            if(rdbBanho.Checked)
            {
                tipo = "Banho";
            }
            else
            {
                tipo = "Tosa";
            }
            string sql = $"INSERT INTO TB_AGENDAMENTOS(NM_TIPO, NM_PET, DT_AGENDAMENTO) VALUES ('{tipo}', '{nome}', '{data}')";
            bdConn.Open();
            MySqlCommand execute = new MySqlCommand(sql, bdConn);
            execute.ExecuteReader();
            bdConn.Close();
            Form form = Application.OpenForms["FrmAreaPrincipal"];
            form.Show();
            this.Hide();
        }

        private void dtpAgenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FrmAreaPrincipal"];
            form.Show();
            this.Hide();
        }

        private void FrmAgendar_Load(object sender, EventArgs e)
        {
            string sql = "SELECT NM_PET FROM TB_PETS";
            MySqlCommand execute = new MySqlCommand(sql, bdConn);
            bdConn.Open();
            MySqlDataReader reader = execute.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbPets.Items.Add(reader.GetString(0));
                }
            }
            else
            {
                cmbPets.Items.Clear();
                cmbPets.Items.Add("Nenhum pet cadastrado");
            }
            bdConn.Close();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void rdbBanho_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
