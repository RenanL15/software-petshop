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
using System.Xml.Linq;

namespace petshop
{
    public partial class FrmAgendamentos : Form
    {
        public FrmAgendamentos()
        {
            InitializeComponent();
        }

        private void lstAgendamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAgendamentos_Load(object sender, EventArgs e)
        {
            MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
            bdConn.Open();
            string sql = "SELECT * FROM TB_AGENDAMENTOS";
            MySqlCommand execute = new MySqlCommand(sql, bdConn);
            MySqlDataReader reader = execute.ExecuteReader();
            while(reader.Read())
            {
               ListViewItem item = new ListViewItem($"{reader["NM_PET"]}");
               lstCadastrados.Items.Add(item);
               item.SubItems.Add($"{reader["NM_PET"]}");
                item.SubItems.Add($"{reader["NM_TIPO"]}");
                item.SubItems.Add($"{reader["DT_AGENDAMENTO"]}");

            }
            bdConn.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FrmAreaPrincipal"];
            form.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
