using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            NCRJob ncrJob = new NCRJob(".NET FULL STACK DEVELOPER\n", "SOFFWARE ENGINNER-II\n", "No Vacancies.\n");

            Console.WriteLine("Current Job Status : " + ncrJob.getAvailability());

            JobSeeker user1 = new JobSeeker("Anurag", ncrJob);
            JobSeeker user2 = new JobSeeker("Pranaya", ncrJob);
            JobSeeker user3 = new JobSeeker("Priyanka", ncrJob);

            Console.WriteLine();
            ncrJob.setAvailability("available");
            Console.ReadLine();
        }
    }
}
