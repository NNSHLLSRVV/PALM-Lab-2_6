using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_6
{
    static class IO
    {
        public static void Input(ref List<Airline> list)
        {
            Console.WriteLine("Введіть дані про рейс в такому форматі:\nМісце_призначення|номер_рейсу|модель_літака");
            string[] str = Console.ReadLine().Split('|');
            string destination = str[0].Trim();
            int flight = int.Parse(str[1].Trim());
            string aircraft = str[2].Trim();
            while(true)
            {
                if(list.Contains(new Airline { flightNumber = flight}))
                {
                    Console.WriteLine("Запис з таким номером рейсу існує, Будь-ласка введіть інший номер");
                    flight = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            list.Add(new Airline(destination, flight, aircraft));
        }

        public static void PrintList(List<Airline> list)
        {
            foreach(Airline airline in list)
            {
                Console.WriteLine($"{airline.destination} | {airline.flightNumber} | {airline.aircraft}");
            }
            Console.WriteLine();
        }
    }
}
