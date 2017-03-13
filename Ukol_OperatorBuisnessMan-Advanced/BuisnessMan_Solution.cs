using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukol_OperatorBuisnessMan_Advanced
{
    //Content
    class BuisnessMan : IComparable<BuisnessMan>
    {
        public string Name { get; set; }
        public decimal ValueOfCar { get; set; }
        public decimal ValueOfHouse { get; set; }
        public decimal ValueOfBuisness { get; set; }

        public int CompareTo(BuisnessMan other)
        {
            decimal thisValue = ValueOfCar + ValueOfHouse + ValueOfBuisness;
            decimal otherValue = other.ValueOfCar + other.ValueOfHouse + other.ValueOfBuisness;
            return thisValue.CompareTo(otherValue);
        }

        public static bool operator >(BuisnessMan bman1, BuisnessMan bman2)
        {
            return bman1.CompareTo(bman2) > 0;
        }

        public static bool operator <(BuisnessMan bman1, BuisnessMan bman2)
        {
            return bman1.CompareTo(bman2) < 0;
        }

        public static bool operator <=(BuisnessMan bman1, BuisnessMan bman2)
        {
            return !(bman1 > bman2);
        }

        public static bool operator >=(BuisnessMan bman1, BuisnessMan bman2)
        {
            return !(bman1 < bman2);
        }
    }
}
