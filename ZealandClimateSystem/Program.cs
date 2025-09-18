using System.ComponentModel;

namespace ZealandClimateSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            var register = new MålingRegister();
            var lokale1 = new Lokale(1, "A101", 30);    
            var lokale2 = new Lokale(2, "B202", 25);

            var m1 = new Måling(lokale1, 1, DateTime.Today.AddHours(11).AddMinutes(22), 21.4, 650, 12);
            var m2 = new Måling(lokale1, 2, DateTime.Today.AddHours(11).AddMinutes(27), 21.6, 670, 14);


            register.OpretMåling(m1);
            register.OpretMåling(m2);

            //Console.WriteLine($"Antal målinger i registret: {register.målinger.Count}");

            //foreach (var m in register.målinger)
            //{
            //    Console.WriteLine(m);   
            //}



            public void PrintAlleMålinger()
        {
            foreach (var m in register.målinger)
            {
                Console.WriteLine($"Id: {m.Id}, Værdi: {m.Værdi}, Tid: {m.Tidspunkt}");
            }
        }

    }
}
}


