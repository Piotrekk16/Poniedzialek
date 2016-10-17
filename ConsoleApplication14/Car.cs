using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;
        
        public Car()
        {
            this.marka = "Skoda";
            this.pojemnoscSilnika = 5.1;
        }
        public Car (double pojemnoscSilnika, string marka)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
        }
        static public Car Create()
        {
            return new Car();
        }
        static int iloscKol;
        static Car()
        {
            iloscKol = 4;
        }
        
        
    }
}
