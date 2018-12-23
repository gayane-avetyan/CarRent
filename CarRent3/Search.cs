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
      
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value.AddDays(1);
            UsingData cars = new UsingData();

            int minYears = cars.allCars[0].ProductionYear;
            int maxYears = cars.allCars[0].ProductionYear;

            int minSeats = cars.allCars[0].SeatsNumber;
            int maxSeats = cars.allCars[0].SeatsNumber;

            decimal minPrice = cars.allCars[0].Price;
            decimal maxPrice = cars.allCars[0].Price;

            cmbCarModel.Items.Add("");
            cmbYear.Items.Add("");
            cmbSeats.Items.Add("");
            cmbPrice.Items.Add("");

            for (int i = 0; i < (cars.allCars).Count; i++)
            {
                cmbCarModel.Items.Add(cars.allCars[i].CarModel);

                if (minYears > cars.allCars[i].ProductionYear)
                {
                    minYears = cars.allCars[i].ProductionYear;
                }
                if (maxYears < cars.allCars[i].ProductionYear)
                {
                    maxYears = cars.allCars[i].ProductionYear;
                }

                if (minSeats > cars.allCars[i].SeatsNumber)
                {
                    minSeats = cars.allCars[i].SeatsNumber;
                }
                if (maxSeats < cars.allCars[i].SeatsNumber)
                {
                    maxSeats = cars.allCars[i].SeatsNumber;
                }

                if (minPrice > cars.allCars[i].Price)
                {
                    minPrice = cars.allCars[i].Price;
                }
                if (maxPrice < cars.allCars[i].Price)
                {
                    maxPrice = cars.allCars[i].Price;
                }
            }

            int years = maxYears - minYears;
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear - maxYears; i <= years; i++)
            {
                cmbYear.Items.Add(i);
            }

            int seats = maxSeats - minSeats;
            for (int i = minSeats; i <= maxSeats; i++)
            {
                cmbSeats.Items.Add(i);
            }

            decimal price = maxPrice - minPrice;
            for (decimal i = minPrice; i < maxPrice; i += 5000)
            {
                cmbPrice.Items.Add(i);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UsingData usingData = new UsingData();
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "CarImage";

            dgvSearch.Columns.Clear();            
            dgvSearch.Columns.Add("CarNumber", "CarNumber");
            dgvSearch.Columns.Add("CarModel", "CarModel");
            dgvSearch.Columns.Add("ProductionYear", "ProductionYear");
            dgvSearch.Columns.Add("SeatsNumber", "SeatsNumber");
            dgvSearch.Columns.Add("Price", "Price");
            dgvSearch.Columns.Add(imgCol);

            for (int i = 0; i < usingData.allCars.Count; i++)
            {
                if (Result(usingData.allCars[i]))
                {
                    Image carImg = Image.FromFile(Environment.CurrentDirectory + usingData.allCars[i].CarImage);
                    dgvSearch.Rows.Add(usingData.allCars[i].CarNumber, usingData.allCars[i].CarModel, usingData.allCars[i].ProductionYear, usingData.allCars[i].SeatsNumber, usingData.allCars[i].Price, carImg);
                }
            }
        }
        
        private bool Result(Cars c)
        {
            UsingData usingData = new UsingData();
            for (int i = 0; i < CommonData.reservations2.Count; i++)
            {
                if (c.CarNumber == CommonData.reservations2[i].CarNumber)
                {
                    if (dtpStartDate.Value >= CommonData.reservations2[i].StartDate && dtpStartDate.Value <= CommonData.reservations2[i].EndDate)
                    {
                        return false;
                    }
                    if (dtpEndDate.Value >= CommonData.reservations2[i].StartDate && dtpEndDate.Value <= CommonData.reservations2[i].EndDate)
                    {
                        return false;
                    }
                }

            }

            if (cmbCarModel.Text != "Car Model" && cmbCarModel.Text.Length != 0)
            {
                if (c.CarModel != cmbCarModel.Text)
                {
                    return false;
                }
            }

            if (cmbYear.Text != "Year" && cmbYear.Text.Length != 0)
            {
                if (c.ProductionYear > (DateTime.Now.Year - Int32.Parse(cmbYear.Text)))
                {
                    return false;
                }
            }

            if (cmbSeats.Text != "Seats" && cmbSeats.Text.Length != 0)
            {
                if (c.SeatsNumber > Int32.Parse(cmbSeats.Text))
                {
                    return false;
                }
            }

            if (cmbPrice.Text != "Price" && cmbPrice.Text.Length != 0)
            {
                if (c.Price > Decimal.Parse(cmbPrice.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvSearch.Columns.Count < 1)
            {
                MessageBox.Show("No Car Selected");
            }
            else
            {
                CommonData.CarNumber =  dgvSearch.CurrentRow.Cells[0].Value.ToString();
                CommonData.StartDate = dtpStartDate.Value;
                CommonData.EndDate = dtpEndDate.Value;
                ClientsForm clientsForm = new ClientsForm();
                clientsForm.ShowDialog();
            }
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            AddNewClientForm addNewClientForm = new AddNewClientForm();
            addNewClientForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AllAgreementsForm allAgreementsForm = new AllAgreementsForm();
            allAgreementsForm.ShowDialog();
        }
    }
}
