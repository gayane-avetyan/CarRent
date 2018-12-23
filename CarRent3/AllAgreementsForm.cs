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
    public partial class AllAgreementsForm : Form
    {
        public AllAgreementsForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllAgreementsForm_Load(object sender, EventArgs e)
        {            
            dgvAllAgreements.DataSource = CommonData.reservations2;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            CommonData.AgreementNumber = dgvAllAgreements.CurrentRow.Cells[0].Value.ToString();
            AgreementForm agreementForm = new AgreementForm();
            agreementForm.ShowDialog();
        }

        private void dgvAllAgreements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
