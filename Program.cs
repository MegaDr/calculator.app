using System;

namespace praktikum3
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.name = "bejo";
            taxi.OnDuty = true;
            taxi.NumPassenger = 02;

            taxi.TaxiInfo();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
        public class Taxi
        {
            public string name { get; set; }
            public bool OnDuty { get; set; }
            public int NumPassenger { get; set; }

            public void TaxiInfo()
            {
                Console.WriteLine("Drive Name : {0}", name);
                if (OnDuty)
                    Console.WriteLine("On Duty : YES");
                else
                    Console.WriteLine("On Duty : NO");
                Console.WriteLine("Number of Passenger {0}", NumPassenger);
            }
            public void PickupPassenger()
            {
                if (OnDuty)
                    Console.WriteLine("{0} sedang menjemput penumpang", name);
                else 
                        Console.WriteLine("{0} tidak sedang menjemput penumpang", name);
            }
            
            public void DropOffPassenger()
            {
                if (OnDuty)
                    Console.WriteLine("{0} selesai mengantar penumpang", name);
                else 
                        Console.WriteLine("{0} belum selesai mngantar penumpang", name);
            }
        }
    }
}
