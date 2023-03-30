using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    internal class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("Driver Status : YES ", OnDuty);
            }
            else
            {
                Console.WriteLine("Driver Status : NO ", OnDuty);
            }
            Console.WriteLine("Number of Passenger : {0}\n", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }   
            public void DropOffPassenger()
            {
                Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
            }
    }
}
