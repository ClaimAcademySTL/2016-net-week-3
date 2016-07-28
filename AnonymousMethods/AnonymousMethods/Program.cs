using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    delegate void NumberChanger(int n);

    class Program
    {
        static int num = 10;

        static void AddNum(int x)
        {
            num += x;
            Console.WriteLine("Named Method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }

        static void Main(string[] args)
        {
            //create delegate instances using anonymous method
            NumberChanger nc1 = delegate (int x)
            {
                Console.WriteLine("Anonymous Method: {0}", x);
            };

            //instantiating the delegate using the named methods 
            var nc2 = new NumberChanger(AddNum);


            //instantiating the delegate using another named methods 
            var nc3 = new NumberChanger(MultNum);

            NumberChanger nc4 = x => { Console.WriteLine("Lambda Method: {0}", x); };

            var nc = nc1 += nc2 += nc3 += nc4;

            nc(10);

            Console.ReadKey();
        }
    }
}
