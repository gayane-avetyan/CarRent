using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent3
{
    class Cars
    {
        public string CarNumber { get; set; }
        public string CarModel { get; set; }
        public int ProductionYear { get; set; }
        public int SeatsNumber { get; set; }
        public decimal Price { get; set; }
        public string CarImage { get; set; }

        public Cars(string carNumber, string carModel, int productionYear, int seatsNumber, decimal price, string carImage)
        {
            CarNumber = carNumber;
            CarModel = carModel;
            ProductionYear = productionYear;
            SeatsNumber = seatsNumber;
            Price = price;
            CarImage = carImage;
        }
    }
}
