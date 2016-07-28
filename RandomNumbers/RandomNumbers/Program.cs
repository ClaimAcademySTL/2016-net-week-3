using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for(int i =0; i < 5; i++)
            {
                Console.WriteLine(r.Next(9999)  + r.NextDouble());
            }

            Console.ReadKey();
        }
    }
}
