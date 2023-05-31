using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_6
{
    [Serializable]
    public struct Airline : IComparable<Airline>, IComparer<Airline>
    {
        public string destination = string.Empty;
        public int flightNumber = int.MinValue;
        public string aircraft = string.Empty;

        public Airline(string d, int f, string a)
        {
            this.destination = d;
            this.flightNumber = f;
            this.aircraft = a;
        }

        public Airline()
        {

        }
        public int CompareTo(Airline a)
        {
            if (this.flightNumber > a.flightNumber)
            {
                return 1;
            }
            else if (a.flightNumber > this.flightNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public int Compare(Airline a1, Airline a2)
        {
            if (a1.flightNumber > a2.flightNumber)
            {
                return 1;
            }
            else if (a2.flightNumber > a1.flightNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{this.destination} | {this.flightNumber} | {this.aircraft}";
        }
    }
}
