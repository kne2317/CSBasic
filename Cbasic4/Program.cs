using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbasic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cars = new Car();
            cars.SetInTime();
            cars.SetOutTime();

            Random r = new Random();
            Console.WriteLine(r.NextDouble());
            Console.WriteLine(r.NextDouble());


        }
    }
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;

        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

}
