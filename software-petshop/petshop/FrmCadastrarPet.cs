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
    public partial class FrmCadastrarPet : Form
    {

        MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
        public FrmCadastrarPet()
        {
            InitializeComponent();
        }

        private void FrmCadastrarPet_Load(object sender, EventArgs e)
        {
            string sql = "SELECT NM_TUTOR FROM TB_TUTORES";
            MySqlCommand execute = new MySqlCommand(sql, bdConn);
            bdConn.Open();
            MySqlDataReader reader = execute.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmbTutores.Items.Add(reader.GetString(0));
                }
            }
            else
            {
                cmbTutores.Items.Clear();
                cmbTutores.Items.Add("Nenhum tutor cadastrado");
            }
            bdConn.Close();
        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            string petName = txtNomePet.Text;
            string petAge = txtIdadePet.Text;
            string petBreed = txtRacaPet.Text;
            object petOwner = cmbTutores.SelectedItem;
            if (petName == "" || petAge == "" || petBreed == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else if (petOwner == "Nenhum tutor cadastrado" || petOwner == null || petOwner == "")
            {
                MessageBox.Show("Por favor, cadastre um tutor");
            }
            else
            {
                string sql = $"INSERT INTO TB_PETS(NM_PET, IDADE, RACA, NM_TUTOR) VALUES ('{petName}', '{petAge}','{petBreed}', '{petOwner}')";
                bdConn.Open();
                MySqlCommand execute = new MySqlCommand(sql, bdConn);
                execute.ExecuteReader();
                bdConn.Close();
                Form form = new FrmAreaPrincipal();
                form.Show();
                this.Hide();
            }
        }

        private void cmbTutores_SelectedIndexChanged(object sender, EventArgs e)
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
