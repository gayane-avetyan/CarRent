using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent3
{
    class UsingData
    {
        public List<Cars> allCars = new List<Cars>();

        public UsingData()
        {
            allCars.Add(new Cars("78SV887", "Bmw 520i", 2004, 5, 13300, "//CarImg//Bmw_520i.jpg"));
            allCars.Add(new Cars("55AG001", "Ford Transit", 2006, 9, 25000, "//CarImg//Ford_Transit.jpg"));
            allCars.Add(new Cars("41SX041", "VW Polo", 2010, 5, 22000, "//CarImg//VW_Polo.jpg"));
            allCars.Add(new Cars("88QQ880", "Lada Niva", 2012, 4, 19000, "//CarImg//Lada_Niva.jpg"));
            allCars.Add(new Cars("59KA559", "Ford Tourneo", 2008, 8, 35000, "//CarImg//Ford_Tourneo.jpg"));
            allCars.Add(new Cars("99AL888", "Toyota Prado", 2014, 5, 32000, "//CarImg///Toyota_Prado.jpg"));
            allCars.Add(new Cars("34PK120", "Hyundai Tucson", 2010, 5, 20000, "//CarImg//Hyundai_Tucson.jpg"));
            allCars.Add(new Cars("45KP433", "Renault Duster", 2013, 5, 24000, "//CarImg//Renault_Duster.jpg"));
            allCars.Add(new Cars("82KP289", "Suzuki Vitara", 2010, 5, 21000, "//CarImg//Suzuki_Vitara.jpg"));
            allCars.Add(new Cars("55KP651", "Toyota Corolla", 2009, 5, 19000, "//CarImg//Toyota_Corolla.jpg"));
         
        }
    }
}
