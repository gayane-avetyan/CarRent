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
    public partial class AddNewClientForm : Form
    {
        public AddNewClientForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           bool result = Int32.TryParse(textBoxAge.Text, out int age);

            if (textBoxFirstName.Text.Count() == 0 || textBoxLastName.Text.Count() == 0 || textBoxAge.Text.Count() == 0 || textBoxAddress.Text.Count() == 0 || textBoxPassportNumber.Text.Count() == 0 || textBoxLicenceNumber.Text.Count() == 0)
            {
                MessageBox.Show("All field required");
            }
            else if (!result)
            {
                MessageBox.Show("Age must be a number");
            }
            else
            {              
                CommonData.allClients2.Add(new Client(CommonData.ClientId++, textBoxFirstName.Text, textBoxLastName.Text, age, textBoxAddress.Text, textBoxPassportNumber.Text, textBoxLicenceNumber.Text, dtpLicenceYear.Value));
                MessageBox.Show("New client added");
                Hide();
                Close();
                AllClientsForm allClientsForm = new AllClientsForm();
                allClientsForm.ShowDialog();
            }
        }

    }
}
