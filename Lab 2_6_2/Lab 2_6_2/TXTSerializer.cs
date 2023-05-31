using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_6
{
    static class TXTSerializer
    {
        public static List<Airline> ReadData(string filename)
        {
            List<Airline> list = new List<Airline>();
            StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8);
            if (sr.Peek() == -1)
            {
                return list;
            }
           
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split('|');
                list.Add(new Airline(str[0].Trim(), int.Parse(str[1].Trim()), str[2].Trim()));
            }

            return list;
        }

        public static void WriteData(List<Airline> list, string filename)
        {
            StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            foreach (Airline a in list)
            {
                sw.WriteLine(a.ToString());
            }
            sw.Flush();
            sw.Close();
        }
    }
}
