using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent3
{
    public static class CommonData
    {
        public static int ClientId { get; set; } = 1;
        public static string CarNumber { get; set; }
        public static DateTime StartDate { get; set; }
        public static DateTime EndDate { get; set; }
        public static int AgreementId { get; set; } = 1;
        public static string AgreementNumber { get; set; }

        public static List<Reservation> reservations2 = new List<Reservation>();
        public static List<Client> allClients2 = new List<Client>();


        static CommonData()
        {
            reservations2.Add(new Reservation(AgreementId++, "82KP289", 4, new DateTime(2018, 11, 18, 1, 0, 0), new DateTime(2018, 11, 28, 1, 0, 0)));
            reservations2.Add(new Reservation(AgreementId++, "41SX041", 2, new DateTime(2018, 11, 21, 1, 0, 0), new DateTime(2018, 11, 25, 1, 0, 0)));


            allClients2.Add(new Client(ClientId++, "Aram", "Margaryan", 32, "Arzumanyan bldg 16/2 apt 20", "AK0490760", "UB512077", new DateTime(2010, 12, 04)));
            allClients2.Add(new Client(ClientId++, "David", "Sargsyan", 24, "Arcaxi bldg 14/1 apt 24", "AP0367588", "UB776102", new DateTime(2015, 03, 16)));
            allClients2.Add(new Client(ClientId++, "Ruben", "Poghasyan", 50, "Tigran Mec bldg 32 apt 3", "AE0202868", "UA776102", new DateTime(2004, 09, 24)));
            allClients2.Add(new Client(ClientId++, "Armen", "Arakelyan", 45, "Tumanyan bldg 10 apt 15", "AP0335724", "UB831992", new DateTime(2008, 11, 05)));
            allClients2.Add(new Client(ClientId++, "Ashot", "Hakobjanyan", 29, "Mashtoci bldg 8/1 apt 2", "AP0244319", "UB313341", new DateTime(2011, 03, 11)));
            allClients2.Add(new Client(ClientId++, "Levon", "Kalashyan", 35, "Arshakunyac bldg 15/2 apt 14", "AK0580411", "UB881843", new DateTime(2009, 10, 10)));
            allClients2.Add(new Client(ClientId++, "Erik", "Grigoryan", 46, "Andraniki bldg 1 apt 20", "AK0565734", "UA719992", new DateTime(2015, 05, 21)));
            allClients2.Add(new Client(ClientId++, "Karen", "Kachatryan", 60, "Nalbandyzn bldg 33 apt 2", "AK0371232", "UB441239", new DateTime(2010, 03, 01)));
        }

    }
}
