using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimateSystem
{
    public class Måling
    {
        public int id { get; private set; }
        private static int nextId = 1;
        private DateTime tidspunkt { get; set; }
        private double temperatur { get; set; }
        private double co2 { get; set; }
        private int antalPersoner { get; set; } 

        public Lokale Lokale { get; }

        public Måling(Lokale lokale, int id, DateTime tidspunkt, double temperatur, double co2, int antalPersoner)
        {
            this.id = id;
            nextId++;
            this.tidspunkt = tidspunkt;
            this.temperatur = temperatur;
            this.co2 = co2;
            this.antalPersoner = antalPersoner;
        }
        public void ToString()
        {
            Console.WriteLine($"Måling ID: {id}, Tidspunkt: {tidspunkt}, Temperatur: {temperatur}, CO2: {co2}, Antal Personer: {antalPersoner}");
        }   

    }

}
