using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Lab_2_6
{
    static class XMLSerializer
    {
        public static void Serialize(string filename, List<Airline> list)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Airline>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, list);
            }
        }

        public static List<Airline> Deserialize(string filename)
        {
            List<Airline> list = new List<Airline>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Airline>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                list = xmlSerializer.Deserialize(fs) as List<Airline>;
            }
            return list;
        }
    }

}
