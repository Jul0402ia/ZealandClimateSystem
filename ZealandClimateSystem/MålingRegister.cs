using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZealandClimateSystem
{
    public class MålingRegister
    {
        
            public readonly List<Måling> målinger;

            public MålingRegister()
            {
                målinger = new List<Måling>();
            }
            public void OpretMåling(Måling måling)
        {
            if (måling == null)
            {
                throw new ArgumentNullException(nameof(måling), "Måling cannot be null");
            }
            målinger.Add(måling);

        }
        public Måling HentMåling(int id)
        {
            foreach (var måling in målinger)
            {
                if (måling.id == id)
                {
                    return måling;
                }
            }
            return null;
        }
        public void PrintAlleMålinger()
        {
            foreach (var måling in målinger)
            {
                Console.WriteLine(måling);
            }
        }
        public void SletMåling(int id)
        {
            Måling målingToRemove = null;
            foreach (var måling in målinger)
            {
                if (måling.id == id)
                {
                    målingToRemove = måling;
                    break;
                }
            }
            if (målingToRemove != null)
            {
                målinger.Remove(målingToRemove);
            }
        }


        //Dont funktion yet:
        public int AntalUlovligeCo2Målinger()
        {
            int antalUlovligeCo2Målinger = 0;

            foreach (Måling måling in målinger)
            {
                if (måling.id > 1000) // or måling.id if it's a field
                {
                    
                   
                }
                return antalUlovligeCo2Målinger;
                else
                {
                 
                    Console.WriteLine("Ingen ulovlige CO2 målinger fundet.");
                }
            
         
        }

    }
    
      
