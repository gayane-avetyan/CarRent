using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent3
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClients.Rows[dgvClients.CurrentRow.Index].Selected = true;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            dgvClients.DataSource = CommonData.allClients2;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CommonData.ClientId = Int32.Parse(dgvClients.CurrentRow.Cells[0].Value.ToString());
            MakeAgreementForm makeAgreementForm = new MakeAgreementForm();
            Hide();
            Close();
            makeAgreementForm.ShowDialog();           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
