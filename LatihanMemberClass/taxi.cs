using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass {
    class taxi {
        public string Drivename { get; set; }
        public bool Onduty { get; set; }
        public int NumberofPassenger { get; set; }

        public void registrasi() {
            Console.WriteLine("Drive name : {0}", Drivename);
            Console.WriteLine("Onduty Duty:{0}", Onduty ? "yes" : "No");
            Console.WriteLine("Number of passenger: {0}", NumberofPassenger);


        }
        public void req() {
            Console.WriteLine("{0} sedang menjemput penumpang ", Drivename);


        }
    }
}
