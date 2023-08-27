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
    public partial class FrmAreaPrincipal : Form
    {
        public FrmAreaPrincipal()
        {
            InitializeComponent();
        }

        private void FrmAreaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPet_Click(object sender, EventArgs e)
        {
            Form area_pet = new FrmCadastrarPet();
            area_pet.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form form = new FrmCadastrarTutor();
            form.Show();
            this.Hide();
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            Form form = new FrmAgendamentos();
            form.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form form = new FrmAreaCadastrados();
            form.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form login = Application.OpenForms["FrmLogin"];
            login.Show();
            this.Hide();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Form form = new FrmAgendar();
            form.Show();
            this.Hide();
        }
    }
}
