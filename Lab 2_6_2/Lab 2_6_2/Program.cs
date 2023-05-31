using Lab_2_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab_2_6_2
{
    internal class Program
    {
        static void Main()
        {
            List<Airline> list = new List<Airline>();
            string filenametxt = "";
            string filenamexml = "";
            while (true)
            {
                Console.WriteLine("1: Вивести дані про рейси\n2: Додати новий рейс\n3: Прочитати файли\n4: Записати у файл\n5: Змінити розташування файлів\n6: Знайти рейси з певним пунктом призначення");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            for(int i = 0; i < list.Count -1; i++)
                            {
                                for(int j = 0; j < list.Count - i - 1; j++)
                                {
                                    if (list[j].CompareTo(list[j+1]) == 1)
                                    {
                                        Airline temp = list[j+1];
                                        list[j+1] = list[j];
                                        list[j] = temp;
                                    }
                                }
                            }
                            IO.PrintList(list);
                            break;
                        }
                    case 2:
                        {
                            IO.Input(ref list);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("1: XML 2: TXT");
                            choice = int.Parse(Console.ReadLine());
                            switch(choice)

                            {
                                case 1:
                                    {
                                        if (filenamexml != null)
                                        {
                                            list = XMLSerializer.Deserialize(filenamexml + ".xml");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Не встановлене розташування файлу");
                                            break;
                                        }
                                    }
                                case 2:
                                    {
                                        if (filenametxt != null)
                                        {
                                            list = TXTSerializer.ReadData(filenametxt + ".txt");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Не встановлене розташування файлу");
                                            break;
                                        }
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("1: XML 2: TXT");
                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    {
                                        if (filenamexml != null)
                                        {
                                            XMLSerializer.Serialize(filenamexml + ".xml", list);
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Не встановлене розташування файлу");
                                            break;
                                        }
                                    }
                                case 2:
                                    {
                                        if (filenametxt != null)
                                        {
                                            TXTSerializer.WriteData(list ,filenametxt + ".txt");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Не встановлене розташування файлу");
                                            break;
                                        }
                                    }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("1: XML 2: TXT");
                            choice = int.Parse(Console.ReadLine());
                            switch(choice)
                            {
                                case 1:
                                    {
                                        filenamexml = Console.ReadLine();
                                        break;
                                    }
                                case 2:
                                    {
                                        filenametxt = Console.ReadLine();
                                        break;
                                    }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введіть потрібний пункт призначення");
                            string dest = Console.ReadLine();
                            foreach(Airline a in list)
                            {
                                if(a.destination == dest)
                                { 
                                    Console.WriteLine(a.ToString());
                                }
                            }
                            break;
                        } 
                    case 0:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            break;
                        }

                }
            }
        }
    }
}
