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
    public partial class MakeAgreementForm : Form
    {
        public MakeAgreementForm()
        {
            InitializeComponent();
        }


        private void MakeAgreementForm_Load(object sender, EventArgs e)
        {
            textBoxCarNumber.Text = CommonData.CarNumber;
            textBoxClientId.Text = CommonData.ClientId.ToString();
            textBoxStartDate.Text = CommonData.StartDate.ToString();
            textBoxEndDate.Text = CommonData.EndDate.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CommonData.reservations2.Add(new Reservation(++CommonData.AgreementId, textBoxCarNumber.Text, Int32.Parse(textBoxClientId.Text), DateTime.Parse(textBoxStartDate.Text), DateTime.Parse(textBoxEndDate.Text)));
            Hide();
            Close();
            MessageBox.Show("Agreement Concluded");
        }
    }
}
