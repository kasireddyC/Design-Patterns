using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClient hondaClient;
            CarClient toyotaClient;
            Console.WriteLine("\r\n------------This is HONDA Car Factory----------------");
            hondaClient = new CarClient(new HondaFactory(), "compact");
            Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSedanName() + " as compact Sedan");
            Console.WriteLine("\r\n Manufactureing " + hondaClient.GetManufacturedSuvName() + " as compact SUV");

            Console.WriteLine("\r\n\r\n------------This is TOYOTA Car Factory----------------");
            toyotaClient = new CarClient(new ToyotaFactory(), "compact");
            Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSedanName() + " as compact Sedan");
            Console.WriteLine("\r\n Manufactureing " + toyotaClient.GetManufacturedSuvName() + " as compact SUV");

            Console.ReadLine();
        }
    }
}
