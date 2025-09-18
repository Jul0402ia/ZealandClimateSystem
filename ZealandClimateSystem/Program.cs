using System.ComponentModel;

namespace ZealandClimateSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var målingregister = new MålingRegister();

            var lokale1 = new Lokale(1, "A101", 30);
            var lokale2 = new Lokale(2, "B202", 25);
            var lokale3 = new Lokale(2, "B203", 20);

            var m1 = new Måling(lokale1, 1, DateTime.Today.AddHours(11).AddMinutes(22), 21.4, 650, 12);
            var m2 = new Måling(lokale2, 2, DateTime.Today.AddHours(11).AddMinutes(27), 21.6, 670, 14);
            var m3 = new Måling(lokale3, 3, DateTime.Today.AddHours(11).AddMinutes(27), 27.9, 1100, 20);

            målingregister.OpretMåling(m1);
            målingregister.OpretMåling(m2);
            målingregister.OpretMåling(m3);

            målingregister.PrintAlleMålinger();

            Console.ReadLine();

            målingregister.AntalUlovligeCo2Målinger();
            Console.ReadLine();
            
        }
    }
}



