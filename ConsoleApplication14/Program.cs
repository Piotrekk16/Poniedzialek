using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car(4.8, "Ford");

            Car car3 = Car.Create();
            Console.WriteLine("jakiś lancuch");
            Console.ReadKey();
            
        }
    }
}
