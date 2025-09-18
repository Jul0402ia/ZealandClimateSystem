using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimateSystem
{
    public class Lokale
    {
        public int id { get; private set; }
        private static int nextId = 1; 
        private string lokaleNumer { get; set; }
        private int maxAntalPladser;
        public int MaxAntalPladser
        {
            get { return maxAntalPladser; }
            set
            {
                if (value > 36)
                {
                    maxAntalPladser = 36;
                }
                else if (value < 0)
                {
                    maxAntalPladser = 0;
                }
                else
                {
                    maxAntalPladser = value;
                }
            }
        }

        

        public Lokale(int id, string lokaleNumer, int maxAntalPladser)
        {
            this.id = id;
            nextId++;
            this.lokaleNumer = lokaleNumer;
            this.maxAntalPladser = maxAntalPladser;
        }

        
        
        public void ToString()
        {
            Console.WriteLine($"Lokale ID: {id}, Lokale Nummer: {lokaleNumer}, Max Antal Pladser: {maxAntalPladser}");
        }   

    }
}
