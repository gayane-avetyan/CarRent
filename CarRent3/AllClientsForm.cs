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
    public partial class AllClientsForm : Form
    {
        public AllClientsForm()
        {
            InitializeComponent();
        }

        private void AllClientsForm_Load(object sender, EventArgs e)
        {
            dgvAllClients.DataSource = CommonData.allClients2;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
