using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            taxi taxi = new taxi();

            //pengesetan nilai properties
            taxi.Drivename = "jono";
            taxi.Onduty = true;
            taxi.NumberofPassenger = 10;

            //pemangilan method
            taxi.registrasi();
            taxi.req();

            Console.ReadKey();
        }
    }
}
