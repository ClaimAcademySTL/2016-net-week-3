using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int NumberChanger(int n);

    class Program
    {
        static int num = 10;
        static NumberChanger nc;


        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Add or Multiply?");
            var answer = Console.ReadLine();

            if (answer.ToLower() == "add")
            {
                nc = new NumberChanger(AddNum);
            }
            else
            {
                nc = new NumberChanger(MultNum);
            }

            //calling the methods using the delegate objects
            PrintIt();
            Console.ReadKey();
        }

        static void PrintIt()
        {
            Console.WriteLine(nc(num));
        }

        void PrintNumber(int val)
        {
            Console.WriteLine(val);
        }


        void DelegateLoop()
        {
            List<int> someInts = new List<int> { 5, 42, 3, 8, 19, 23 };

            someInts.ForEach(PrintNumber);

            someInts.ForEach(delegate (int val)
            {
                Console.WriteLine(val);
            });

            someInts.ForEach(x => { Console.WriteLine(x); });
        }
    }
}
