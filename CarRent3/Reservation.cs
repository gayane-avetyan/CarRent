using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent3
{
    public class Reservation
    {
        public int AgreementId{ get; set; }
        public string CarNumber { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        public Reservation(int agreementId, string carNumber, int clientId, DateTime startDate, DateTime endDate)
        {
            AgreementId = agreementId;
            CarNumber = carNumber;
            ClientId = clientId;
            StartDate = startDate;
            EndDate = endDate;            
        }
    }
}
