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
        public void HentMåling(int id)
        {
            foreach (var måling in målinger)
            {
                if (måling.id == id)
                {
                    måling.ToString();
                }
            }
        }
        public void PrintAllMålinger()
        {
            foreach (var måling in målinger)
            {
                måling.ToString();
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
    }
}
