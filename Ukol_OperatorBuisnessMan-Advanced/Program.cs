using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_OperatorBuisnessMan_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var BuisnessMen = new List<BuisnessMan>
            {
                new BuisnessMan { Name = "Arnold", ValueOfBuisness = 8000, ValueOfCar = 200, ValueOfHouse = 3000 },
                new BuisnessMan { Name = "Brandor", ValueOfBuisness = 3000, ValueOfCar = 0, ValueOfHouse = 5000 },
                new BuisnessMan { Name = "Cyrill", ValueOfBuisness = 6000, ValueOfCar = 40, ValueOfHouse = 50 },
                new BuisnessMan { Name = "Dean", ValueOfBuisness = 13, ValueOfCar = 444, ValueOfHouse = 10000 },
                new BuisnessMan { Name = "Ester", ValueOfBuisness = 0, ValueOfCar = 0, ValueOfHouse = 10 },
                new BuisnessMan { Name = "Franky", ValueOfBuisness = 5000, ValueOfCar = 5000, ValueOfHouse = 5000 }
            };


            if (BuisnessMen[0] < BuisnessMen[1]
                || BuisnessMen[2] > BuisnessMen[3]
                || BuisnessMen[3] <= BuisnessMen[4]
                || BuisnessMen[4] >= BuisnessMen[5]
                )
            {
                Console.WriteLine("Neporovnáva niečo naopak?");
            }
            else if (BuisnessMen[0] > BuisnessMen[0]
              || BuisnessMen[0] < BuisnessMen[0]
              || !(BuisnessMen[0] >= BuisnessMen[0])
              || !(BuisnessMen[0] <= BuisnessMen[0])
              )
            {
                Console.WriteLine("Funguje správne porovnávanie dvoch rovnakých objektov?");
            }
            else
            {
                Console.WriteLine("Správne!");
            }

            Console.ReadLine();


        }
    }
}
