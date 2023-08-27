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
    public partial class FrmAreaCadastrados : Form
    {
        MySqlConnection bdConn = new MySqlConnection("server=localhost; port=3306; database=CAOAMIGO; uid=root; pwd=root");
        public FrmAreaCadastrados()
        {
            InitializeComponent();
        }

        private void FrmAreaCadastrados_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TB_PETS";
            MySqlCommand exeTutor = new MySqlCommand(sql, bdConn);
            bdConn.Open();
            MySqlDataReader readerTutor = exeTutor.ExecuteReader();
            while(readerTutor.Read())
            {
                ListViewItem item = new ListViewItem($"{readerTutor["NM_TUTOR"]}");
                lstCadastrados.Items.Add(item);
                item.SubItems.Add($"{readerTutor["NM_PET"]}");
            }
            bdConn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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
