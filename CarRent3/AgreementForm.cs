using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent3
{
    public partial class AgreementForm : Form
    {
        public AgreementForm()
        {
            InitializeComponent();
        }

        private void AgreementForm_Load(object sender, EventArgs e)
        {
            UsingData usingData = new UsingData();

            textBoxAgreement.Text = $"\t\t\t Car Rental Agreement N{CommonData.AgreementNumber}";
            textBoxAgreement.Text += $"\r\n\r\n   The parties to this Agreement are:";
            textBoxAgreement.Text += $"\r\n\r\n   1) The Owner:";
            textBoxAgreement.Text += $"\r\n   First Name: Armen";
            textBoxAgreement.Text += $"\r\n   Last Name: Hakobyan";
            textBoxAgreement.Text += $"\r\n   Phisical Address: Arami 82";
            textBoxAgreement.Text += $"\r\n\r\n   2) The Renter:";
            foreach (Reservation item in CommonData.reservations2)
            {
                if (item.AgreementId == Int32.Parse(CommonData.AgreementNumber))
                {
                    foreach (Client item2 in CommonData.allClients2)
                    {
                        if (item2.Id == item.ClientId)
                        {
                            textBoxAgreement.Text += $"\r\n   First Name: {item2.FirstName}";
                            textBoxAgreement.Text += $"\r\n   Last Name: {item2.LastName}";
                            textBoxAgreement.Text += $"\r\n   Age: {item2.Age}";
                            textBoxAgreement.Text += $"\r\n   Address: {item2.Address}";
                            textBoxAgreement.Text += $"\r\n   Passport Number: {item2.PassportNumber}";
                            textBoxAgreement.Text += $"\r\n   Licence Number: {item2.LicenceNumber}";
                            textBoxAgreement.Text += $"\r\n   Licence Year: {item2.LicenceYear}";
                        }
                    }
                    foreach (Cars item3 in usingData.allCars)
                    {
                        if (item3.CarNumber == item.CarNumber)
                        {
                            textBoxAgreement.Text += $"\r\n\r\n   The vehichal information:";
                            textBoxAgreement.Text += $"\r\n   Car Number: {item3.CarNumber}";
                            textBoxAgreement.Text += $"\r\n   Production Year: {item3.ProductionYear}";
                            textBoxAgreement.Text += $"\r\n   Car Model: {item3.CarModel}";
                            textBoxAgreement.Text += $"\r\n   Price: {item3.Price} per day";
                            textBoxAgreement.Text += $"\r\n   Start Date: {item.StartDate}";
                            textBoxAgreement.Text += $"\r\n   End Date: {item.EndDate}";

                            double totalDays = (item.EndDate - item.StartDate).TotalDays;
                            decimal totalPrice = Convert.ToDecimal(totalDays) * item3.Price;
                            textBoxAgreement.Text += $"\r\n\r\n   Total Price: {totalPrice}";
                        }
                    }
                }
            }
            textBoxAgreement.Text += $"\r\n\r\n  \t\t Your Signature   ________________";
            textBoxAgreement.Text += $"\r\n\r\n  \t\t Signature Date   ___ /___ /_______";
            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.textBoxAgreement.Text, this.textBoxAgreement.Font, Brushes.Black, 10, 25);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
